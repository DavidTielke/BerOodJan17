namespace _12MailverteilerEntkoppelt
{
    interface IMailErkanntVerarbeiter
    {
        void NeueMailErkannt();
    }

    interface IMailVersendetVerarbeiter
    {
        void MailVersendet();
    }
}