using System;

namespace LoggingConsole.Test
{
     static class CodepageTest
    {
        internal static void NewConsoleAndNewCodepage ()
        {
            Console.WriteLine($"OutputEncoding.CodePage: {Console.OutputEncoding.CodePage}");
            Program.FreeConsole();
            Program.AllocConsole();
            Program.SetConsoleOutputCP(1251);
            Console.WriteLine($"OutputEncoding.CodePage after trying to change to 1251 : {Console.OutputEncoding.CodePage}");
            Console.ReadKey();
        }
        internal static void CodepageCheckRus(string codepagenum)
        {
            uint result = uint.Parse(codepagenum);
            Program.SetConsoleOutputCP(result);
            Console.WriteLine($"New CodePageNum {result}: русский текст");
        }
        internal static void TryChandeCodePage(string codepagenum)
        {
            Program.SetConsoleOutputCP(uint.Parse(codepagenum));
            Console.WriteLine($"StartedCodepage: {Program.GetConsoleOutputCP()}");
            uint[] encodes = new uint[] { 437, 866, 1251, 1252, 65001 };
            foreach (uint encode in encodes)
            {
            Program.SetConsoleOutputCP(encode);
            Console.WriteLine($"New CodePageNum {encode}: русский текст");
            } 
        }
    }
}
