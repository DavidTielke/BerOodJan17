using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2ErsteDemo
{
    class Program
    {
        // Daten
        public int _counter = 0;

        // Methoden
        public void AddAndPrint()
        {
            _counter++;
            Console.WriteLine(_counter);
        }

        // Methode
        static void Main(string[] args)
        {
            int zahl;
            zahl = 5;

            Counter counter;
            counter = new Counter();
            counter.AddAndPrint();
            counter.AddAndPrint();
            counter.AddAndPrint();

            Counter counter2 = new Counter();
            counter2.AddAndPrint();

            Console.ReadKey();
        }
    }

    // Klasse Auto
    // Fahre(strecke)   -> "Fahre 50km, neuer KMStand ist 230km. Tankstand ist 34L"
    // Tanke(menge)     -> "Tanke 34L, neuer Tankstand 55L"

    // Klassen
    class Counter
    {
        // Daten
        public int _counter2 = 0;

        // Verhalten
        public void AddAndPrint()
        {
            _counter2++;
            Console.WriteLine(_counter2);
        }
    }
}
