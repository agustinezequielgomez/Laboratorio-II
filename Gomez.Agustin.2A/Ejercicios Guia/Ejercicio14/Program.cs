using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio14
{
    class Ejercicio_14
    {
        static void Main(string[] args)
        {
            Console.Title = "Ejercicio 14";
            int opcion = 4;
            double datoUno;
            double datoDos;
            Console.Write("1- Calcular el area de un cuadrado\n2- Calcular el area de un triangulo\n3- Calcular el area de un circulo\n4- Salir\nIngrese una opcion ");
            opcion = int.Parse(Console.ReadLine());
            switch (opcion)
            {
                case 1:
                    Console.Write("Ingrese la longitud de un lado del cuadrado ");
                    datoUno = double.Parse(Console.ReadLine());
                    Console.WriteLine("El area del cuadrado es de {0} m²", CalculoDeArea.CalcularCuadrado(datoUno));
                    Console.ReadLine();
                    break;
                case 2:
                    Console.Write("Ingrese la base del triangulo ");
                    datoUno = double.Parse(Console.ReadLine());
                    Console.Write("Ingrese la altura del triangulo ");
                    datoDos = double.Parse(Console.ReadLine());
                    Console.WriteLine("El area del triangulo es de {0} m²", CalculoDeArea.CalcularTriangulo(datoUno, datoDos));
                    Console.ReadLine();
                    break;
                case 3:
                    Console.Write("Ingrese el radio del circulo ");
                    datoUno = double.Parse(Console.ReadLine());
                    Console.WriteLine("El area del circulo es de {0:#.##} m²", CalculoDeArea.CalcularCirculo(datoUno));
                    Console.ReadLine();
                    break;
                case 4:
                    break;
                default:
                    Console.Write("Opcion invalida. Saliendo del programa... ");
                    Console.ReadLine();
                    break;
            }
        }
    }
}
