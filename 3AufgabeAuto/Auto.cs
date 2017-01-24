using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _3AufgabeAuto
{
    // PascalCase: MeineVariable, VerbindeDatenbank
    // camelCase: meineVariable, verbindeDatenbank

    // Klassen: Nomen, PascalCase
    public class Auto
    {
        // Felder: camelCase, _ davor
        public double _kmStand = 0;
        public double _tankstand = 50;
        public double _verbrauch = 8.5;

        // Methoden: Verben, PascalCase
        // Parameter: camelCase, OHNE _
        public void Tanke(double menge)
        {
            _tankstand = _tankstand + menge;
            Console.WriteLine("Tanke "+menge+" L. Neuer Tankstand "+_tankstand+" L");
        }

        public void Fahre(double strecke)
        {
            // Lokale Variablen: camelCase, OHNE _
            double verbrauch = strecke/100*_verbrauch;
            _tankstand = _tankstand - verbrauch;
            Console.WriteLine("Fahre "+strecke+" km und verbauche "+verbrauch+" L. Neuer Tankstand ist "+_tankstand+" L");
        }
    }
}