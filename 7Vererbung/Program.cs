using System;

namespace _7Vererbung
{
    class Program
    {
        static void Main(string[] args)
        {
            // ### Basisklassenreferenzen

            // Impliziter Cast
            Fahrzeug f1 = new Auto();
            Fahrzeug f2 = new Flugzeug();

            // Expliziter Cast
            Auto a1 = (Auto)f1;

            // Basisklassenarrays
            Fahrzeug[] fahrzeuge = new Fahrzeug[2];
            fahrzeuge[0] = new Auto();
            fahrzeuge[1] = new Flugzeug();

            foreach (var fahrzeug in fahrzeuge)
            {
                fahrzeug.Reise(300);
                Console.WriteLine(fahrzeug.GetKennung());

                if (fahrzeug is Auto)
                {
                    var auto = (Auto) fahrzeug;
                    Console.WriteLine(auto.KmStand);
                }

                fahrzeug.Tanke(20);
            }



            Console.ReadKey();
        }
    }
}
