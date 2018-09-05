using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sobrecarga.Operadores._2018
{
    class Program
    {
        static void Main(string[] args)
        {

            Numero n1 = 5;
            Numero n2 = 8;

            Console.Beep();

            Numero resultado = n1 + n2;

            resultado += n2; // resultado = resultado + 12 / + n1


            resultado = resultado + 12;

            Console.Write((Numero)resultado++);

            Numero n3 = 6;

            double valor = (double)n3;

            Console.Write(valor);







        }
    }
}
