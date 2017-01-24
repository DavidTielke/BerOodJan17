using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _5Tagesaufgabe
{
    public class Reifen
    {
        public double Luftdruck { get; private set; }

        public double Profiltiefe { get; private set; }

        public void Aufpumpen(double menge)
        {
            Luftdruck += menge;
        }

        public void Abnutzen(double strecke)
        {
            Profiltiefe -= strecke/1000;
        }
    }
}