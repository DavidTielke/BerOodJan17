using System;

namespace _10MailVerteiler
{
    class MailPoller
    {
        private readonly Mailverteiler _mailverteiler;

        public MailPoller(Mailverteiler mailverteiler)
        {
            _mailverteiler = mailverteiler;
        }

        public void StartPoller()
        {
            Console.WriteLine("Polling gestartet");
            NeueMailErkannt();
        }

        private void NeueMailErkannt()
        {
            Console.WriteLine("Neue Email erkannt");
            _mailverteiler.Verteile();
        }
    }
}