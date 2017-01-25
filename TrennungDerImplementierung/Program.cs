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
            var b = new B2();
            var a = new A(b);

            Console.WriteLine(a.DoA());

            Console.ReadKey();
        }
    }

    class A
    {
        private IB _ib;

        public A(IB ib)
        {
            _ib = ib;
        }

        public string DoA()
        {
            var input = _ib.DoB();
            var result = input.ToUpper();
            return result;
        }
    }

    interface IB
    {
        string DoB();
    }

    class B2 : IB
    {
        public string DoB()
        {
            return "Berlin";
        }
    }


    // ---

    class BNew : IB
    {
        public string DoB()
        {
            return "Lena";
        }
    }

    class B : IB
    {
        public string DoB()
        {
            return "David";
        }
    }
}
