using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Threading;

namespace Hilos
{
    class Mensajes
    {
        public void Mostrar1()
        {
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("Escribiendo desde ==> 1");
                Thread.Sleep(1000);
            }
            Console.WriteLine("Fin Hilo 1");
        }

        public void Mostrar2()
        {
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("Escribiendo desde ==> 2");
                Thread.Sleep(1200);
            }
            Console.WriteLine("Fin Hilo 2");
        }

        public void MostrarConParametros(object p)
        {
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("Escribiendo desde ==> {0}",p);
                Thread.Sleep(1500);
            }
            Console.WriteLine("Fin Hilo con parámetros");
        }
    }
}
