using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PruebaGeometria
{
    class Ejercicio_18
    {
        static void Main(string[] args)
        {
            Console.Title = "Ejercicio 18";

        }
    }
}

namespace Geometria
{
    class Punto
    {
        private int x;
        private int y;

        public int GetX()
        {
            return this.x;
        }

        public int GetY()
        {
            return this.y;
        }
    }

    class Rectangulo
    {
        private float area;
        private float perimetro;
        private Punto vertice1;
        private Punto vertice2;
        private Punto vertice3;
        private Punto vertice4;

        public Rectangulo(Punto vertice1, Punto vertice3)
        {
            Math.Abs()
        }
    }
}