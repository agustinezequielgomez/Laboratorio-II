using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_14
{
    class CalculoDeArea
    {
        public static double CalcularCuadrado(double x)
        {
            return x * x;
        }
        public static double CalcularTriangulo(double x,double y)
        {
            return (x * y)/2;
        }
        public static double CalcularCirculo(double x)
        {
            return x * Math.PI;
        }
    }
}
