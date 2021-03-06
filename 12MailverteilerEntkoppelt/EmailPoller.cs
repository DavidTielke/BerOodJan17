﻿using System;

namespace _12MailverteilerEntkoppelt
{
    class EmailPoller : IPoller
    {
        public IMailErkanntVerarbeiter Verarbeiter { get; set; }

        public void Start()
        {
            Console.WriteLine("Polling gestartet");
            NeueMailErkannt();
        }

        private void NeueMailErkannt()
        {
            Console.WriteLine("Neue Email erkannt");
            Verarbeiter.NeueMailErkannt();
        }
    }
}