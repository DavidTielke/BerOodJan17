using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _5Tagesaufgabe
{
    public class Auto
    {
        private readonly List<Schaden> _schäden;
        private readonly Reifen[] _reifen;
        private readonly Motor _motor;

        public double KmStand { get; private set; }

        public double Tankstand { get; private set; }

        private double Verbrauch { get; set; }

        public Person Fahrer { get; set; }

        public Auto()
        {
            _motor = new Motor(3000, 258);
            _schäden = new List<Schaden>();
            _reifen = new Reifen[]{
                new Reifen(),
                new Reifen(),
                new Reifen(),
                new Reifen()
            };
        }

        public void AddSchaden(Schaden schaden)
        {
            _schäden.Add(schaden);
        }

        public IReadOnlyCollection<Schaden> GetSchäden()
        {
            return _schäden.AsReadOnly();
        }


        public void Fahre(double strecke)
        {
            if (Fahrer != null)
            {
                Console.WriteLine("Kann nicht ohne Fahrer fahren.");
                return;
            }

            var verbrauch = Verbrauch / 100 * strecke;
            Tankstand -= verbrauch;
            KmStand += strecke;

            for (int index = 0; index < _reifen.Length; index++)
            {
                _reifen[index].Abnutzen(strecke);
            }

            //_reifen.ToList().ForEach(r => r.Abnutzen(strecke));

            Console.WriteLine("Fahre " + strecke + " km und verbrauche " + verbrauch + " L");
        }

        public void Tanke(double menge)
        {
            Tankstand += menge;
            Console.WriteLine("Tanke " + menge + " L");
        }
    }
}