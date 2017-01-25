namespace _12MailverteilerEntkoppelt
{
    internal interface ISender
    {
        void Versende();
        IMailVersendetVerarbeiter Verarbeiter { get; set; }
    }
}