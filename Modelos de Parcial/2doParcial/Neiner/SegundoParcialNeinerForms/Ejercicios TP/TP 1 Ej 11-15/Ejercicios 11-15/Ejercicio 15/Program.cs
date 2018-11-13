using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_15
{
    class Program
    {
        static void Main(string[] args)
        {
            double numeroUno = 0;
            double numeroDos = 0;
            string opcion;
            char seguir = 's';
            while (seguir == 's')
            {
                Console.WriteLine("Numero 1: {0} -- Numero 2: {1}", numeroUno, numeroDos);
                Console.Write("1-Ingrese numero 1\n2-Ingrese numero 2\n3-Salir\n(+,-,*,/) elija operacion\n");
                Console.Write("Su opcion: ");

                opcion = Console.ReadLine();
                switch (opcion)
                {
                    case "1":
                        Console.Write("Ingrese numero 1: ");
                        while (!double.TryParse(Console.ReadLine(), out numeroUno))
                        {
                            Console.Write("Error, reingrese: ");
                        }
                        break;
                    case "2":
                        Console.Write("Ingrese numero 2: ");
                        while (!double.TryParse(Console.ReadLine(), out numeroDos))
                        {
                            Console.Write("Error, reingrese: ");
                        }
                        break;
                    case "3":
                        seguir = 'n';
                        break;
                    case "/":
                    case "*":
                    case "+":
                    case "-":
                        Calculadora.Mostrar(Calculadora.Calcular(numeroUno, numeroDos, opcion));
                        break;
                    default:
                        Console.WriteLine("No se ingreso una opcion valida");
                        Console.Read();
                        break;
                }
                Console.Clear();
                
            }

        }
    }
}
