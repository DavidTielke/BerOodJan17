﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10MailVerteiler
{
    class Program
    {
        static void Main(string[] args)
        {
            var verteiler = new Mailverteiler();
            verteiler.Start();

            Console.ReadKey();
        }
    }
}
