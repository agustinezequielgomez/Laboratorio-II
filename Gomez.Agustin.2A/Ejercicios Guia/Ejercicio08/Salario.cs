using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prueba
{
    class Salario
    {
        public static int CalcularSalario(int antiguedad, int horas, int valor, string nombre)
        {
            int resultado;
            int aux;
            int descuento;
            aux = valor * horas;
            aux += antiguedad * 150;
            descuento = (aux * 13 / 100);
            resultado = aux - descuento;
            Console.WriteLine("----------------------Informe de recibo----------------------");
            Console.WriteLine("{0,-10}{1,-20}{2,-20}{3,-15}{4,-15}{5,-15}","Nombre","Valor por hora","Horas trabajadas","Antiguedad","Total a cobrar","Descuentos totales");
            Console.WriteLine("{0,-10}{1,-20:c}{2}{3,-19}{4}{5,-14}{6,-15:c}{7,-15:c}", nombre,valor,horas," Horas",antiguedad," Años",resultado,descuento);
            return resultado;
        }
    }
}
