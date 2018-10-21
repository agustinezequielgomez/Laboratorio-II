using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio42
{
    class Program
    {
        //DATAZO AMIGO: SIEMPRE ARMA PRIMERO EL CALL STACK (EMPEZANDO POR EL FINAL DEL ENUNCIADO) HASTA LA PRIMERA EXCEPCION QUE TE PIEN.
        //DESPUES VAS CAPTURANDO LAS EXCEPCIONES SUBIENDO POR ESE MISMO CALL STACK HASTA LLEGAR AL MAIN.
        static void Main(string[] args)
        {
            try
            {
                //LLamo al metodo de instancia de la Class6
                Class6 obj = new Class6();
                obj.MetodoInsatncia();
            }
            catch(Exception e)//Capturo MiExcepcion lanzada por MetodoInstancia 
            {
                Console.WriteLine("Errores:\n{0}", e.Message);//Muestro todos los datos de MiException, que incluyen los datos de todas las excepciones anteriores.
            }
            finally
            {
                Console.ReadKey();
            }
        }
    }
}
