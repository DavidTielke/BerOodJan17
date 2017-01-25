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
            var zeit = new TimeSpan(0,0,30);
            Tankstand -= new VerbrauchsRechner().BeiVerbrauchVon(23).BerechneFürZeit(zeit);
            // var verb = new VerbrauchsRechner().BeiVerbrauchVon(8.5).BerechneFürStrecke(546);
        }


        public override string GetKennung()
        {
            return "D-4711";
        }
    }

    class VerbrauchsRechner
    {
        private double _verbrauch;

        public VerbrauchsRechner BeiVerbrauchVon(double verbrauch)
        {
            _verbrauch = verbrauch;
            return this;
        }

        public double BerechneFürStrecke(double strecke)
        {
            return _verbrauch / 100 * strecke;
        }

        public double BerechneFürZeit(TimeSpan zeit)
        {
            return zeit.Hours*_verbrauch;
        }
    }
}