using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3AufgabeAuto
{
    class Program
    {
        static void Main(string[] args)
        {
            Auto bmw = new Auto();
            
            bmw.Fahre(467.8);
            bmw.Tanke(20);

            Console.ReadKey();
        }
    }
}
