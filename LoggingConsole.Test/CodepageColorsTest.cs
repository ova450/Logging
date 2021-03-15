using Microsoft.Extensions.Logging;
using ova.common.logging.Console;
using ova.common.Console;
using System;

namespace LoggingConsole.Test
{
    class CodepageColorsTest
    {
        //static ConsoleColor Background = Console.BackgroundColor;
        //static ConsoleColor Foreground = Console.ForegroundColor;

        internal static void Main2( ConsoleColor? @background, ConsoleColor? @foreground)
        {
            //Factory.ChangeImageConsole(ConsoleColor.Green, ConsoleColor.DarkGreen);
            //Factory.ChangeCodepage(65001);

            LogConsole.Write($"CurrentCodePageInput: {Console.InputEncoding.CodePage}", LogLevel.Warning);
            LogConsole.Write($"CurrentCodePageOutput: {Console.OutputEncoding.CodePage}", LogLevel.Warning);

            Factory.ChangeCodepage(28591);
            LogConsole.Write($"CurrentCodePageInput: {Console.InputEncoding.CodePage}", LogLevel.Warning);
            LogConsole.Write($"CurrentCodePageOutput: {Console.OutputEncoding.CodePage}", LogLevel.Warning);


            LogConsole.Write("Hello World! Привет, мир!");     //вывод строки приветствия на двух языках
            LogConsole.Write($"Уровень {LogLevel.Trace} - трассировка", LogLevel.Trace);
            LogConsole.Write($"Уровень {LogLevel.Debug} - отладка", LogLevel.Debug);
            LogConsole.Write($"Уровень {LogLevel.Information} - информация");
            LogConsole.Write($"Уровень {LogLevel.Warning} - предупреждение", LogLevel.Warning);
            Factory.ChangeCodepage(65001);
            LogConsole.Write($"CurrentCodePageInput: {Console.InputEncoding.CodePage}", LogLevel.Warning);
            LogConsole.Write($"CurrentCodePageOutput: {Console.OutputEncoding.CodePage}", LogLevel.Warning);

             LogConsole.Write($"Уровень {LogLevel.Error} - ошибка", LogLevel.Error);
            LogConsole.Write($"Уровень {LogLevel.Critical} - критическая ошибка", LogLevel.Critical);
            LogConsole.Write($"Уровень {LogLevel.None} - без логирования", LogLevel.None);
        }
    }
}
