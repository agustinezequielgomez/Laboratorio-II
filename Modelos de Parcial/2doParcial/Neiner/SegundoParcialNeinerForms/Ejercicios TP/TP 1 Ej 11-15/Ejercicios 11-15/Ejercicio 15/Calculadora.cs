using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_15
{
    class Calculadora
    {
        public static double Calcular(double x, double y, string z)
        {
            double returnAux =0;
            switch (z)
            {
                case "+":
                    returnAux = x + y;
                    break;
                case "-":
                    returnAux = x - y;
                    break;
                case "*":
                    returnAux = x * y;
                    break;
                case "/":
                    if(Validar(y))
                    {
                        returnAux = x / y;
                    }
                    else
                    {
                        Console.WriteLine("Syntax Error");
                    }
                    break;
            }
            return returnAux;
        }
        private static bool Validar(double x)
        {
            bool auxReturn = false;
            if(x!=0)
            {
                auxReturn = true;
            }
            return auxReturn;
        }
        public static void Mostrar(double x)
        {
            Console.WriteLine("{0:N2}", x);
            Console.Read();
        }

    }
}
