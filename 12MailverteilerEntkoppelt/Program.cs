using System;

namespace _12MailverteilerEntkoppelt
{
    class Program
    {
        static void Main(string[] args)
        {
            var repository = new EmpfängerRepository();
            var sender = new TwitterSender();
            var poller = new FacebookPoller();

            var verteiler = new Mailverteiler(repository,sender,poller);
            verteiler.Start();

            Console.ReadKey();
        }
    }
}
