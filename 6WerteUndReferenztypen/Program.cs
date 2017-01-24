using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6WerteUndReferenztypen
{
    class Program
    {
        static void Main(string[] args)
        {
            Foo foo;
            foo = new Foo();
            foo.Value = 5;

            AddTwo(ref foo);

            Console.WriteLine(foo.Value);

            Console.ReadKey();
        }

        static void AddTwo(ref Foo foo)
        {
            foo = new Foo();
            foo.Value += 2;
        }

        static void AddTwo(ref int zahl2)
        {
            zahl2 = zahl2 + 2;
        }
    }

    class Foo
    {
        public int Value { get; set; }
    }
}
