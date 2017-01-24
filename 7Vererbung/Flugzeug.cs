using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _7Vererbung
{
    public sealed class Flugzeug : Fahrzeug
    {
        public double Flughöhe { get; private set; }

        public Flugzeug()
            : base()
        {
            _reifen = new Reifen[]
            {
                new Reifen(), 
                new Reifen(), 
                new Reifen(),
            };

            _motoren = new Motor[]
            {
                new Motor(2000, 180), 
                new Motor(2000, 180),
            };
        }

        public void Steigen(double höhe)
        {
            Flughöhe += höhe;
        }

        public void Sinken(double höhe)
        {
            Flughöhe -= höhe;
        }

        public void Fliege(double strecke)
        {
            Tankstand -= Verbrauch/100*strecke;
        }

        public override string GetKennung()
        {
            return "D-4711";
        }
    }
}