﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Billetes
{
    class Program
    {
        static void Main(string[] args)
        {
            Dolar d1 = new Dolar(1);
            Pesos p1 = new Pesos(17.55d);

            Console.WriteLine(d1 == p1);
            Console.ReadLine();
        }
    }
}
