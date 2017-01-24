using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datenkapselung
{
    class Program
    {
        static void Main(string[] args)
        {
            Frau meine = new Frau("Lena", 30);
            meine.AddKosename("Maria");
            meine.AddKosename("Magdalena");

            var kosenamen = meine.GetKosenamen();

            foreach (var kosename in meine.GetKosenamen())
            {
                Console.WriteLine(kosename);
            }

            Console.WriteLine(meine.Alter);

            Console.ReadKey();
        }
    }

    class Frau
    {
        // Feld
        private int _alter;
        private string _name;
        private bool _verheiratet;
        private List<string> _kosenamen;

        public Frau()
        {
            Name = "Angela";
            Alter = 63;
           _verheiratet = true;
            _kosenamen = new List<string>();
        }

        public Frau(string name, int alter)
            : this()
        {
            Name = name;
            Alter = alter;
        }


        private List<string> Kosenamen
        {
            get { return _kosenamen; }
            set { _kosenamen = value; }
        }


        // Automatische Eigenschaft
        public string Name
        {
            get { return _name; }
            private set
            {
                if (value == "Eva") return;
                _name = value;
            }
        }

        public string Haarfarbe { set; get; }

        public IReadOnlyCollection<string> GetKosenamen()
        {
            return Kosenamen.AsReadOnly();
        }

        public void AddKosename(string kosename)
        {
            Kosenamen.Add(kosename);
        }

        // Explizite Eigenschaft (Property)
        // PascalCase
        public int Alter
        {
            get { return _alter; }
            private set
            {
                if (value <= _alter)
                {
                    return;
                }
                _alter = value;
            }
        }
    }
}
