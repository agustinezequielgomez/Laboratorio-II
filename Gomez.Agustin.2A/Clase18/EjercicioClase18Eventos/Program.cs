using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;

namespace EjercicioClase18Eventos
{
    class Program
    {
        static void Main(string[] args)
        {
            Program program = new Program();
            Televisor televisor1 = new Televisor(3472, "Bangho", 15475, 32, "Argentina");
            televisor1.MiEvento += new MiDelegado(PruebaEvento);
            televisor1.MiEvento += new MiDelegado(program.PruebaEvento2);
            televisor1.MiEvento += new MiDelegado(PruebaEvento);
            televisor1.MiEvento += new MiDelegado(program.PruebaEvento2);
            televisor1.MiEvento += new MiDelegado(PruebaEvento);
            televisor1.MiEvento += new MiDelegado(program.PruebaEvento2);
            televisor1.MiEvento += new MiDelegado(PruebaEvento);
            televisor1.MiEvento += new MiDelegado(program.PruebaEvento2);
            televisor1.EventoTV += new DelegadoTV(Program.MuestroTVAgregado);
            televisor1.Insertar();
            Console.ReadKey();
        }

        public static void PruebaEvento()
        {
            Console.WriteLine("\nSe inserto un registro en la base de datos.");
        }

        public void PruebaEvento2()
        {
            Console.WriteLine("\nEstoy en el 2do de los metodos del delegado.");
        }

        public static void MuestroTVAgregado(Televisor televisor, TVEventArgs args)
        {
            Console.WriteLine("\nID: {0}\nMarca: {1}\nPrecio: {2}\nPulgadas: {3}\nPais: {4}\nFecha: {5}", televisor.id, televisor.marca, televisor.precio, televisor.pulgadas, televisor.pais,args.Fecha);
        }
    }
}