using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _12MailverteilerEntkoppelt
{
    class TwitterSender : ISender
    {
        public void Versende()
        {
            Console.WriteLine("Versende auf Twitter");
            // ...

            Verarbeiter.MailVersendet();
        }

        public IMailVersendetVerarbeiter Verarbeiter { get; set; }
    }
}