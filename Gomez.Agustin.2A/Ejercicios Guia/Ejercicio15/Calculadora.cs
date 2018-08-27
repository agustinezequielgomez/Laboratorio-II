using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio15
{
    class Calculadora
    {
        public static float Calcular(float numeroUno, float numeroDos, char signo)
        {
            float operacion = 0;
            switch(signo)
            {
                case '+':
                    operacion = numeroUno + numeroDos;
                    break;
                case '-':
                    operacion = numeroUno - numeroDos;
                    break;
                case '*':
                    operacion = numeroUno * numeroDos;
                    break;
                    case '/':
                    if(Calculadora.Validar(numeroDos))
                    {
                        operacion = numeroUno / numeroDos;
                    }
                    else
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("No es posible dividir ya que el 2do numero es 0");
                        Console.ResetColor();
                    }
                    break;
                default:
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.Write("La operacion matematica ingresada no es valida!");
                    Console.ReadLine();
                    Console.ResetColor();
                    break;
            }
            return operacion;
        }

        private static bool Validar(float numeroDos)
        {
            if(numeroDos!=0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static void Mostrar(float resultado)
        {
            Console.WriteLine("El resultado de la operacion es {0}", resultado);
        }
    }
}
