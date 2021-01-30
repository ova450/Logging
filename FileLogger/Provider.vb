Imports System.Collections.Concurrent
Imports System.IO
Imports System.Text
Imports Microsoft.Extensions.Logging
Imports Microsoft.Extensions.Options
Imports ova.Common.Logging.Shared

Public Class Provider : Inherits LoggerProvider

    Private Terminated As Boolean
    Private Counter As Integer = 0
    Private FilePath As String
    Private Lengths As Dictionary(Of String, Integer) = New Dictionary(Of String, Integer)()
    Private InfoQueue As ConcurrentQueue(Of LogEntry) = New ConcurrentQueue(Of LogEntry)()

    Public Sub New(ByVal Settings As IOptionsMonitor(Of Options))
        Me.New(Settings.CurrentValue)
        SettingsChangeToken = Settings.OnChange(Sub(s) _settings = s)
    End Sub

    Public Sub New(ByVal Settings As Options)
        PrepareLengths()
        _settings = Settings
        BeginFile()
        ThreadProc()
    End Sub

    Private Sub ApplyRetainPolicy()
        Dim FI As FileInfo

        Try
            Dim FileList As List(Of FileInfo)
            FileList = New DirectoryInfo(Settings.Folder).GetFiles("*.log", SearchOption.TopDirectoryOnly).OrderBy(Function(info) info.CreationTime).ToList()

            While FileList.Count >= Settings.RetainPolicyFileCount
                FI = FileList.First()
                FI.Delete()
                FileList.Remove(FI)
            End While

        Catch
        End Try
    End Sub

    Private Sub WriteLine(ByVal Text As String)

        '// check the file size after any 100 writes
        Counter += 1

        If Counter Mod 100 = 0 Then
            Dim FI As FileInfo = New FileInfo(FilePath)
            If FI.Length > (1024 * 1024 * Settings.MaxFileSizeInMB) Then BeginFile()
        End If

        File.AppendAllText(FilePath, Text)

    End Sub

    Private Function Pad(ByVal Text As String, ByVal MaxLength As Integer) As String
        If String.IsNullOrWhiteSpace(Text) Then Return "" '.PadRight(MaxLength)
        If Text.Length > MaxLength Then Return Text.Substring(0, MaxLength)
        Return Text.PadRight(MaxLength)
    End Function

    Private Sub PrepareLengths()
        Lengths("Time") = 24
        Lengths("Host") = 16
        Lengths("User") = 16
        Lengths("Level") = 14
        Lengths("EventId") = 32
        Lengths("Category") = 92
        Lengths("Scope") = 64
    End Sub

    Private Sub BeginFile()
        Directory.CreateDirectory(Settings.Folder)
        FilePath = Path.Combine(Settings.Folder, $"{LogEntry.StaticHostName}-{DateTime.Now.ToString("yyyyMMdd-HHmm")}.log")
        Dim SB As StringBuilder = New StringBuilder()
        SB.Append(Pad("Time", Lengths("Time")))
        SB.Append(Pad("Host", Lengths("Host")))
        SB.Append(Pad("User", Lengths("User")))
        SB.Append(Pad("Level", Lengths("Level")))
        SB.Append(Pad("EventId", Lengths("EventId")))
        SB.Append(Pad("Category", Lengths("Category")))
        SB.Append(Pad("Scope", Lengths("Scope")))
        SB.AppendLine("Text")
        File.WriteAllText(FilePath, SB.ToString())
        ApplyRetainPolicy()
    End Sub

    Private Sub WriteLogLine()

        Dim Info As LogEntry = Nothing

        If InfoQueue.TryDequeue(Info) Then
            Dim S As String
            Dim SB As StringBuilder = New StringBuilder()
            SB.Append(Pad(DateTime.UtcNow.ToString("yyyy-MM-dd HH:mm:ss.ff"), Lengths("Time")))
            SB.Append(Pad(Info.HostName, Lengths("Host")))
            SB.Append(Pad(Info.UserName, Lengths("User")))
            SB.Append(Pad(Info.Level.ToString(), Lengths("Level")))
            SB.Append(Pad(If(Not Info.EventId = Nothing, Info.EventId.ToString(), ""), Lengths("EventId")))
            SB.Append(Pad(Info.Category, Lengths("Category")))
            S = ""

            If Info.Scopes IsNot Nothing AndAlso Info.Scopes.Count > 0 Then
                Dim SI As LogScopeInfo = Info.Scopes.Last()
                If Not String.IsNullOrWhiteSpace(SI.Text) Then S = SI.Text
            End If

            SB.Append(Pad(S, Lengths("Scope")))
            Dim Text As String = Info.Message

            '/* writing properties Is too much for a text file logger
            'If (Info.StateProperties IsNot Nothing AndAlso Info.StateProperties.Count > 0) Then Text = Text + " Properties = " + Newtonsoft.Json.JsonConvert.SerializeObject(Info.StateProperties);

            If Not String.IsNullOrWhiteSpace(Text) Then SB.Append(Text.Replace(vbCrLf, " ").Replace(vbCr, " ").Replace(vbLf, " "))

            SB.AppendLine()
            WriteLine(SB.ToString())

        End If
    End Sub

    Private Sub ThreadProc()
        Task.Run(Sub()
                     While Not Terminated
                         Try : WriteLogLine() : Threading.Thread.Sleep(100)
                         Catch
                         End Try
                     End While
                 End Sub)
    End Sub

    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Terminated = True
        MyBase.Dispose(disposing)
    End Sub

    Public Overrides Function IsEnabled(ByVal logLevel As LogLevel) As Boolean
        Dim Result As Boolean = logLevel <> LogLevel.None AndAlso Me.Settings.LogLevel <> LogLevel.None AndAlso Convert.ToInt32(logLevel) >= Convert.ToInt32(Me.Settings.LogLevel)
        Return Result
    End Function

    Dim _settings As Options
    Friend ReadOnly Property Settings As Options
        Get
            Return _settings
        End Get
    End Property

End Class
