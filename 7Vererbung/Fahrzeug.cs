using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _7Vererbung
{
    public abstract class Fahrzeug
    {
        protected List<Schaden> _schäden;
        protected Reifen[] _reifen;
        protected Motor[] _motoren;

        public double Tankstand { get; protected set; }
        protected double Verbrauch { get; set; }
        public Person Fahrzeugführer { get; set; }

        public Fahrzeug()
        { 
            _schäden = new List<Schaden>();
        }

        public void AddSchaden(Schaden schaden)
        {
            _schäden.Add(schaden);
        }

        public IReadOnlyCollection<Schaden> GetSchäden()
        {
            return _schäden.AsReadOnly();
        }

        public void Tanke(double menge)
        {
            Tankstand += menge;
            Console.WriteLine("Tanke " + menge + " L");
        }

        public abstract string GetKennung();

        public virtual void Reise(double strecke)
        {
            if (Fahrzeugführer != null)
            {
                Console.WriteLine("Kann nicht ohne Fahrzeugführer fahren.");
                return;
            }

            var verbrauch = Verbrauch / 100 * strecke;
            Tankstand -= verbrauch;

            for (int index = 0; index < _reifen.Length; index++)
            {
                _reifen[index].Abnutzen(strecke);
            }
            Console.WriteLine("Reise " + strecke + " km und verbrauche " + verbrauch + " L");
        }
    }
}