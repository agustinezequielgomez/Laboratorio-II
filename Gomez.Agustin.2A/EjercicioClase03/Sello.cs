using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioClase03
{
    class Sello
    {
        public static string mensaje;
        public static ConsoleColor color;

        public static string Imprimir()
        {
            return Sello.ArmarFormatoMensaje();
        }

        public static void Borrar()
        {
            Sello.mensaje = "";
        }

        public static void ImprimirEncolor()
        {
            Console.BackgroundColor = Sello.color;
            Console.WriteLine(Sello.Imprimir()); //Encapsulamiento
        }

        private static string ArmarFormatoMensaje()
        {
            string mensaje = Sello.mensaje;
            string cadenaReturn="";
            string asteriscos = "";
            string middleLine = "";
            int largo = mensaje.Length;
            int i;
            for (i=0;i<largo+2;i++)
            {
                asteriscos += "*";
            }
            middleLine +="\n*";
            middleLine += mensaje;
            middleLine += "*\n";
            cadenaReturn += asteriscos;
            cadenaReturn += middleLine;
            cadenaReturn += asteriscos;
            return cadenaReturn;
        }
    }
}