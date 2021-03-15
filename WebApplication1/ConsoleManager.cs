using System;
//using System.IO;
using System.IO;
using System.Runtime.InteropServices;
using System.Text;
//using System.Text;

namespace WebApplication1
{
  static public class ConsoleManager
    {
        [DllImport("kernel32.dll")]
        static extern bool AllocConsole();

        [STAThread]
        public static void InitializeConsoleManager()


        {
            //#if CONSOLE
            try
            {
             bool ok = AllocConsole();
                TextWriter newOut;
                //newOut = TextWriter.Null;
                StreamWriter sw = new StreamWriter(Console.OpenStandardOutput(), Encoding.Default, 100);
                newOut = new LoggingTextWriter(sw);
                Console.SetOut(newOut);


                //Console.SetOut(new TextWriter(new StreamWriter(Console.OpenStandardOutput(), Encoding.Default, 100)));
                ////LoggingTextWriter tw = new LoggingTextWriter<StreamWriter>;
                //Console.SetOut(tw);
                Console.Clear();
            }
            catch (Exception) { }
            //    #endif
            //}
        }
    }
    public class LoggingTextWriter: TextWriter
    {
        public  LoggingTextWriter(StreamWriter streamWriter) {}
        public override Encoding Encoding => throw new NotImplementedException();
    }
}
    
