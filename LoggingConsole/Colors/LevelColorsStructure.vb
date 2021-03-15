Imports System.Text.Json.Serialization
Imports Microsoft.Extensions.Logging

Namespace Colors
    Friend Structure LevelColorsStructure
        <JsonInclude> Public Trace As ConsoleColor
        <JsonInclude> Public Debug As ConsoleColor
        <JsonInclude> Public Information As ConsoleColor
        <JsonInclude> Public Warning As ConsoleColor
        <JsonInclude> Public [Error] As ConsoleColor
        <JsonInclude> Public Critical As ConsoleColor
        <JsonInclude> Public None As ConsoleColor

        Default Public ReadOnly Property GetColor(key As LogLevel)
            Get
                Select Case key
                    Case LogLevel.Trace : Return Trace
                    Case LogLevel.Debug : Return Debug
                    Case LogLevel.Information : Return Information
                    Case LogLevel.Warning : Return Warning
                    Case LogLevel.Error : Return [Error]
                    Case LogLevel.Critical : Return Critical
                    Case LogLevel.None : Return None
                    Case Else : Return Nothing
                End Select
            End Get
        End Property

    End Structure

End Namespace