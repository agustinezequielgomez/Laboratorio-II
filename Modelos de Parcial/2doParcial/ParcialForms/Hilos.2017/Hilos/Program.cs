using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.IO;
using System.Threading;

namespace Hilos
{
    class Program
    {
        static void Main(string[] args)
        {
            Mensajes mensaje = new Mensajes();
 
            //INVOCO EXPLICITAMENTE AL DELEGADO
            Thread hilo1 = new Thread(new ThreadStart(mensaje.Mostrar1));
            
            //INVOCO IMPLICITAMENTE AL DELEGADO
            Thread hilo2 = new Thread(mensaje.Mostrar2);

            //INVOCO A DELEGADO QUE ADMITE UN PARAMETRO (OBJECT)
            Thread hilo3 = new Thread(new ParameterizedThreadStart(mensaje.MostrarConParametros));

            //INICIO LOS HILOS (INVOCANDO AL DELEGADO)
            hilo1.Start();
            hilo2.Start();
            hilo3.Start();


            Console.ReadLine();

        }
    }
}