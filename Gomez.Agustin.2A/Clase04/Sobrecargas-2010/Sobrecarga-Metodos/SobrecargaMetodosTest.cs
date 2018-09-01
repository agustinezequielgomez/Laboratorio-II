using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Sobrecargas_2010
{
    class SobrecargaMetodosTest
    {
        static void Main(string[] args)
        {
            //INSTANCIO LA CLASE CALCULADORA
            Calculadora miCalculadora = new Calculadora();

            int resultadoInt;
            double resultadoDouble;

            //REALIZO LAS OPERACIONES CON LAS SOBRECARGAS
            //DEL METODO SUMAR.
            resultadoInt = miCalculadora.Sumar(1, 9);
            Console.WriteLine(resultadoInt);
            Console.ReadLine();

            resultadoInt = miCalculadora.Sumar(3, 7, 10);
            Console.WriteLine(resultadoInt);
            Console.ReadLine();

            resultadoDouble = miCalculadora.Sumar(3d, 9.0);
            Console.WriteLine(resultadoDouble);
            Console.ReadLine();
           
        }
    }
}
