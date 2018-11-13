using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_14
{
    class Program
    {
        static void Main(string[] args)
        {
            int respuesta;
            double numero;
            double altura;
            Console.WriteLine("1-Area del cuadrado");
            Console.WriteLine("2-Area del triangulo");
            Console.WriteLine("3-Area del circulo");
            Console.Write("Que desea calcular? ");
            while(!(int.TryParse(Console.ReadLine(),out respuesta)) || (respuesta!=1 && respuesta!=2 && respuesta!=3))
            {
                Console.WriteLine("Error, reingrese: ");
            }
            switch (respuesta)
            {
                case 1:
                    Console.Write("Ingrese base del cuadrado: ");
                    while(!double.TryParse(Console.ReadLine(),out numero) || numero<1)
                    {
                        Console.WriteLine("Error, reingrese: ");
                    }
                    Console.Write("Area del cuadrado: {0}", CalculoDeArea.CalcularCuadrado(numero));
                    break;
                case 2:
                    Console.Write("Ingrese base del triangulo: ");
                    while (!double.TryParse(Console.ReadLine(), out numero) || numero < 1)
                    {
                        Console.WriteLine("Error, reingrese: ");
                    }
                    Console.Write("Ingrese altura del triangulo: ");
                    while (!double.TryParse(Console.ReadLine(), out altura) || altura < 1)
                    {
                        Console.WriteLine("Error, reingrese: ");
                    }
                    Console.Write("Area del triangulo: {0}", CalculoDeArea.CalcularTriangulo(numero,altura));
                    break;
                case 3:
                    Console.Write("Ingrese radio del circulo: ");
                    while (!double.TryParse(Console.ReadLine(), out numero) || numero < 1)
                    {
                        Console.WriteLine("Error, reingrese: ");
                    }
                    Console.Write("Area del circulo: {0:N2}",CalculoDeArea.CalcularCirculo(numero));
                    break;
            }
            Console.Read();
        }
    }
}
