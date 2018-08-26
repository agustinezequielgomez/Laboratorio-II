using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio08
{
    class Ejercicio_08
    {
        static void Main(string[] args)
        {
            Console.Title = "Ejercicio Nro 08";
            int horas;
            int antiguedad;
            int valor;
            int cantidadEmpleados;
            int i;
            int total=0;
            string nombre;
            Console.Write("Ingrese la cantidad de empleados ");
            cantidadEmpleados=int.Parse(Console.ReadLine());
            for (i = 0; i < cantidadEmpleados; i++)
            {
                Console.Write("Ingrese el valor hora ");
                valor = int.Parse(Console.ReadLine());
                Console.Write("Ingrese el nombre ");
                nombre = Console.ReadLine();
                Console.Write("Ingrese la antiguedad ");
                antiguedad = int.Parse(Console.ReadLine());
                Console.Write("Ingrese la cantidad de horas trabajadas \a");
                horas = int.Parse(Console.ReadLine());
                total += Prueba.Salario.CalcularSalario(antiguedad, horas, valor, nombre);
            }
            Console.WriteLine("Valor total a pagar por {0} empleados: {1:c}", cantidadEmpleados, total);
            Console.ReadLine();
        }
    }
}
