using System;

namespace _12MailverteilerEntkoppelt
{
    class Mailverteiler
    {
        private readonly MailPoller _poller;
        private readonly EmpfängerRepository _empfängerRepository;
        private readonly MailSender _mailSender;

        public Mailverteiler()
        {
            _poller = new MailPoller(this);
            _empfängerRepository = new EmpfängerRepository();
            _mailSender = new MailSender(this);
        }

        public void Start()
        {
            Console.WriteLine("Mailverteiler gestartet");
            _poller.StartPoller();
        }

        public void Verteile()
        {
            Console.WriteLine("Email wird verteilt");
            _empfängerRepository.Lade();
            _mailSender.Versende();
        }

        public void EmailVersendet()
        {
            Console.WriteLine("Email wurde versenden");
        }
    }
}