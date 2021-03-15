Imports System.IO
Imports System.Text.Json
Imports Microsoft.Extensions.Logging

Namespace Colors
    Public Module LogLevelColors

        Private options As JsonSerializerOptions = New JsonSerializerOptions With {.IncludeFields = True}
        Friend levelcolors As LevelColorsStructure

        Sub New()
            Read()
        End Sub
        Public Sub SetColorsDictionary(Optional TraceColor As ConsoleColor? = Nothing,
                                        Optional DebugColor As ConsoleColor? = Nothing,
                                        Optional InformationColor As ConsoleColor? = Nothing,
                                        Optional WarningColor As ConsoleColor? = Nothing,
                                        Optional ErrorColor As ConsoleColor? = Nothing,
                                        Optional CriticalColor As ConsoleColor? = Nothing,
                                        Optional NoneColor As ConsoleColor? = Nothing)
            levelcolors.Trace = If(TraceColor, ConsoleColor.Gray)
            levelcolors.Debug = If(DebugColor, ConsoleColor.Cyan)
            levelcolors.Information = If(InformationColor, ConsoleColor.White)
            levelcolors.Warning = If(WarningColor, ConsoleColor.Blue)
            levelcolors.Error = If(ErrorColor, ConsoleColor.Yellow)
            levelcolors.Critical = If(CriticalColor, ConsoleColor.Red)
            levelcolors.None = If(NoneColor, ConsoleColor.Gray)

            Write()

        End Sub

        Public Sub Write()
            Try
                Using sw As StreamWriter = New StreamWriter("ConsoleColorsSetting.json")
                    sw.WriteLine(JsonSerializer.Serialize(Of LevelColorsStructure)(levelcolors, options))
                    sw.Close()
                End Using
            Catch ex As Exception
                LogConsole.Write($"Write: {ex.Message}", LogLevel.Error)
            End Try
        End Sub

        Public Sub Read()
            Try
                Using sr As StreamReader = New StreamReader("ConsoleColorsSetting.json")
                    levelcolors = JsonSerializer.Deserialize(Of LevelColorsStructure)(sr.ReadLine, options)
                    sr.Close()
                End Using
            Catch ex As FieldAccessException
                SetColorsDictionary()
                LogConsole.Write($"Read, FieldAccessException: {ex.Message}", LogLevel.Error)
            Catch ex As FileNotFoundException
                SetColorsDictionary()
                LogConsole.Write($"Read, FileNotFoundException: {ex.Message}", LogLevel.Error)
                LogConsole.Write($"Read, FileNotFoundException: LevelColors loaded by default", LogLevel.Warning)
            Catch ex As Exception
                SetColorsDictionary()
                LogConsole.Write($"Read: {ex.Message}", LogLevel.Error)
            End Try
        End Sub

    End Module

End Namespace