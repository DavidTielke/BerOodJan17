using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrennungDerImplementierung
{
    class Program
    {
        static void Main(string[] args)
        {
            var b = new BStub();
            var a = new A(b);

            if (a.DoA() == "TEST")
            {
                Console.WriteLine("OK");
            }

            Console.ReadKey();
        }
    }


    // ---
}
