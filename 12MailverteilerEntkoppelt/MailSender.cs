using System;

namespace _12MailverteilerEntkoppelt
{
    class MailSender
    {
        private readonly Mailverteiler _mailverteiler;

        public MailSender(Mailverteiler mailverteiler)
        {
            _mailverteiler = mailverteiler;
        }

        public void Versende()
        {
            Console.WriteLine("Email wird versendet");
            _mailverteiler.EmailVersendet();
        }
    }
}