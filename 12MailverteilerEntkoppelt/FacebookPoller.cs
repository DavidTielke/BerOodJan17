using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _12MailverteilerEntkoppelt
{
    class FacebookPoller : IPoller
    {
        public void Start()
        {
            Console.WriteLine("Polle Facebook");

            // ...

            Console.WriteLine("Neue Nachricht auf Facebook erkannt");
            Verarbeiter.NeueMailErkannt();
        }

        public IMailErkanntVerarbeiter Verarbeiter { get; set; }
    }
}