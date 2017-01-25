using System;

namespace _12MailverteilerEntkoppelt
{
    class Program
    {
        static void Main(string[] args)
        {
            var repository = new EmpfängerRepository();

            var verteiler = new Mailverteiler();
            verteiler.Start();

            Console.ReadKey();
        }
    }
}
