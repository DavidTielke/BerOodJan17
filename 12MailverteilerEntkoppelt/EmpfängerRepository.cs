using System;

namespace _12MailverteilerEntkoppelt
{
    class EmpfängerRepository : IEmpfängerRepository
    {
        public EmpfängerRepository()
        {
        }

        public void Lade()
        {
            Console.WriteLine("Empfänger werden geladen");
        }
    }
}