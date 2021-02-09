using ova.common.logging.EventProvider.Data;
using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            using Context db = new Context();
            db.SaveChanges();

        }
    }
}
