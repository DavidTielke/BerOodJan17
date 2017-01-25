namespace _12MailverteilerEntkoppelt
{
    internal interface IPoller
    {
        void Start();
        IMailErkanntVerarbeiter Verarbeiter { get; set; }
    }
}