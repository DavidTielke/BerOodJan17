using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _7Vererbung
{
    class Motorrad : Fahrzeug
    {
        public override string GetKennung()
        {
            return "BRUM BRUM";
        }
    }
}