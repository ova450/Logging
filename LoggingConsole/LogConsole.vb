Imports System.Runtime.CompilerServices
Imports Microsoft.Extensions.Logging
Imports ova.common.logging.Console.Colors
Imports ova.сommon
Imports ova.сommon.UnixTime

Public Module LogConsole


    Public Separator As String = " "
    Public TimestampKind As TimeKind = TimeKind.Utc

    <Extension>
    Private Sub SetSeparator(text As String)
        System.Console.ForegroundColor = ConsoleColor.Gray
        System.Console.Write(text)
    End Sub

    <Extension>
    Private Sub Message(level As LogLevel, text As String)
        System.Console.ForegroundColor = levelcolors(level)
        System.Console.WriteLine(text)
    End Sub

    <Extension>
    Private Function Label(level As LogLevel) As String
        Dim back As ConsoleColor = System.Console.BackgroundColor
        System.Console.ForegroundColor = back
        System.Console.BackgroundColor = levelcolors(level)

        Select Case level
            Case LogLevel.Trace : System.Console.Write("TRCE")
            Case LogLevel.Debug : System.Console.Write("DBUG")
            Case LogLevel.Information : System.Console.Write("INFO")
            Case LogLevel.Warning : System.Console.Write("WARN")
            Case LogLevel.Error : System.Console.Write("ERRR")
            Case LogLevel.Critical : System.Console.Write("CRIT")
            Case LogLevel.None : System.Console.Write("NONE")
        End Select
        System.Console.BackgroundColor = back
        Return Separator
    End Function

    Private Function Timestamp() As String
        System.Console.ForegroundColor = ConsoleColor.Gray
        Select Case TimestampKind
            Case TimeKind.Local : System.Console.Write(Now().ToString("yyyy.MM.dd hh:mm:ss.ff (loc)"))
            Case TimeKind.Utc : System.Console.Write(Now().ToUniversalTime.ToString("yyyy.MM.dd hh:mm:ss.ff") & "(utc)")
            Case TimeKind.Unix : System.Console.Write(UnixTime.Timestamp)
        End Select
        Return Separator
    End Function

    Public Sub Write(messagetext As String, Optional level As LogLevel = LogLevel.Information)
        If level = LogLevel.None Then Exit Sub
        Timestamp.SetSeparator
        level.Label.SetSeparator
        level.Message(messagetext)
    End Sub

End Module
