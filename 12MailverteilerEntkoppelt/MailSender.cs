using System;

namespace _12MailverteilerEntkoppelt
{
    class MailSender : ISender
    {
        public IMailVersendetVerarbeiter Verarbeiter { get; set; }

        public void Versende()
        {
            Console.WriteLine("Email wird versendet");
            Verarbeiter.MailVersendet();
        }
    }
}