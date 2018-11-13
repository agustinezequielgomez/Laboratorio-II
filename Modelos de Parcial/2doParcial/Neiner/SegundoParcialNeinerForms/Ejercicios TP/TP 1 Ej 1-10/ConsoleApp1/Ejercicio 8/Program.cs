using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_8
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Ejercicio Nro 08";
            int valorHora;
            string nombre;
            int antiguedad;
            int horasTrabajadas;
            float importeACobrar;
            float descuentos;
            char seguir = 's';
            while(seguir!='n')
            {
                Console.Write("Ingrese valor por hora: ");
                while (!int.TryParse(Console.ReadLine(), out valorHora) || valorHora < 1)
                {
                    Console.Write("Error, reingrese: ");
                }
                Console.Write("Ingrese nombre: ");
                nombre = Console.ReadLine();
                Console.Write("Ingrese antiguedad: ");
                while (!int.TryParse(Console.ReadLine(), out antiguedad) || antiguedad < 0)
                {
                    Console.Write("Error, reingrese: ");
                }
                Console.Write("Ingrese horas trabajadas: ");
                while (!int.TryParse(Console.ReadLine(), out horasTrabajadas) || horasTrabajadas < 1)
                {
                    Console.Write("Error, reingrese: ");
                }
                importeACobrar = (valorHora * horasTrabajadas + antiguedad * 150);
                descuentos = importeACobrar * (float)0.87;
                Console.Clear();
                Console.WriteLine("Resumen: ");
                Console.WriteLine("Nombre: {0}", nombre);
                Console.WriteLine("Antiguedad: {0} años",antiguedad);
                Console.WriteLine("Pago por hora: ${0}", valorHora);
                Console.WriteLine("Total a cobrar en bruto: ${0:N2}", importeACobrar);
                Console.WriteLine("Total de descuentos: ${0:N2}", descuentos);
                Console.WriteLine("Neto a cobrar: ${0:N2}", importeACobrar - descuentos);
                do
                {
                    Console.Write("\nDesea ingresar otro empleado? (s/n): ");
                    seguir = char.Parse(Console.ReadLine());
                } while (seguir != 's' && seguir != 'n');
                Console.Clear();
            }
        }
    }
}
