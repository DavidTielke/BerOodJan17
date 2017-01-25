using System;

namespace _12MailverteilerEntkoppelt
{
    class Mailverteiler : IMailErkanntVerarbeiter, IMailVersendetVerarbeiter
    {
        private readonly IPoller _poller;
        private readonly IEmpfängerRepository _empfängerRepository;
        private readonly ISender _sender;

        public Mailverteiler(IEmpfängerRepository repository, ISender sender, IPoller poller)
        {
            _empfängerRepository = repository;
            _sender = sender;
            _sender.Verarbeiter = this;
            _poller = poller;
            _poller.Verarbeiter = this;
        }

        public void Start()
        {
            Console.WriteLine("Mailverteiler gestartet");
            _poller.Start();
        }

        public void Verteile()
        {
            Console.WriteLine("Email wird verteilt");
            _empfängerRepository.Lade();
            _sender.Versende();
        }

        public void NeueMailErkannt()
        {
            Verteile();
        }

        public void MailVersendet()
        { 
            Console.WriteLine("Email wurde versenden");
        }
    }
}