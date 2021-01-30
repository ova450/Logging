Imports Microsoft.Extensions.Logging
Imports ova.Common.Logging.Shared

Partial Public Class Provider : Inherits LoggerProvider

    Public Overrides Sub WriteLog(ByVal Info As LogEntry)
        InfoQueue.Enqueue(Info)
    End Sub

    Private Sub WriteLogLevel(category As String, text As String, level As LogLevel)
        Dim info As New LogEntry
        With info
            .Level = level
            .Category = category
            .Message = text
        End With
        WriteLog(info)
    End Sub

    Public Sub LogInfo(category As String, text As String)
        WriteLogLevel(category, text, LogLevel.Information)
    End Sub

    Public Sub LogTrace(category As String, text As String)
        WriteLogLevel(category, text, LogLevel.Trace)
    End Sub

    Public Sub LogDebug(category As String, text As String)
        WriteLogLevel(category, text, LogLevel.Debug)
    End Sub

    Public Sub LogError(category As String, text As String)
        WriteLogLevel(category, text, LogLevel.Error)
    End Sub

    Public Sub LogWarning(category As String, text As String)
        WriteLogLevel(category, text, LogLevel.Warning)
    End Sub

    Public Sub LogCritical(category As String, text As String)
        WriteLogLevel(category, text, LogLevel.Critical)
    End Sub

    Public Sub LogNone(category As String, text As String)
        WriteLogLevel(category, text, LogLevel.None)
    End Sub

End Class
