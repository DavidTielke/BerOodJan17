using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _7Vererbung
{
    public class Fahrzeug
    {
        protected List<Schaden> _schäden;
        protected Reifen[] _reifen;
        protected Motor _motor;

        public double Tankstand { get; protected set; }
        protected double Verbrauch { get; set; }
        public Person Fahrzeugführer { get; set; }

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
    }
}