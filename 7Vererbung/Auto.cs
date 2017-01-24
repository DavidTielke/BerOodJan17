using System;
using System.Collections.Generic;

namespace _7Vererbung
{
    public sealed class Auto : Fahrzeug
    {
        public double KmStand { get; private set; }

        public Auto()
            : base()
        {
            _motoren = new Motor[]
            {
                new Motor(3000, 258) 
            };

            _reifen = new Reifen[]{
                new Reifen(),
                new Reifen(),
                new Reifen(),
                new Reifen()
            };
        }

        public override void Reise(double strecke)
        {
            base.Reise(strecke);
            KmStand += strecke;
        }

    }
}