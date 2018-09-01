using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Sobrecargas_2010
{
    class Calculadora
    {
        public int Sumar(int primerNumero, int segundoNumero)
        {
            Console.WriteLine("Realizo la suma de 2 números enteros.");

            return primerNumero + segundoNumero;        
        }

//        ERROR, LAS FIRMAS SON IGUALES.
//        public float Sumar(int n1, int n2)
//        {
//            return primerNumero + segundoNumero;
//        }
        public int Sumar(int primerNumero, int segundoNumero, int tercerNumero)
        {
            Console.WriteLine("Realizo la suma de 3 números enteros.");

            return primerNumero + segundoNumero + tercerNumero;
        }

        public double Sumar(double primerNumero, double segundoNumero)
        {
            Console.WriteLine("Realizo la suma de 2 números dobles.");

            return primerNumero + segundoNumero;
        }

    }
}
