using System;
using System.Runtime.InteropServices;

namespace LoggingConsole.Test
{
    class Program
    {
        [DllImport("kernel32.dll")] public static extern uint GetConsoleCP();
        [DllImport("kernel32.dll")] public static extern bool SetConsoleCP(uint pagenum);
        [DllImport("kernel32.dll")] public static extern uint GetConsoleOutputCP();
        [DllImport("kernel32.dll")] public static extern bool SetConsoleOutputCP(uint pagenum);
        [DllImport("kernel32.dll")] public static extern bool FreeConsole();
        [DllImport("kernel32.dll")] public static extern bool AllocConsole();

        static void Main(string[] args)
        {
            //switch (args[0])
            //{
            //    case "help":
            //        {
            //            Console.WriteLine("TryChandeCodePage: logggingconsole.test 0 <codepagenum>");
            //            Console.WriteLine("NewConsoleAndNewCodepage: logggingconsole.test 1");
            //            Console.WriteLine("CodepageCheckRus: logggingconsole.test 2 <codepagenum>");
            //            Console.WriteLine("CodepageColorsTest: logggingconsole.test 3 <backcodepagenum> <forecodepagenum>");
            //            break;
            //        }
            //    case "0": { CodepageTest.TryChandeCodePage(args[1]); break; }
            //    case "1": { CodepageTest.NewConsoleAndNewCodepage(); break; }
            //    case "2": { CodepageTest.CodepageCheckRus(args[1]); break; }
            //    case "3": { CodepageColorsTest.Main2((ConsoleColor)int.Parse(args[1]), (ConsoleColor)int.Parse(args[2])); break; }
            //}
            CodepageColorsTest.Main2(null, null);
        }

    }
    }

