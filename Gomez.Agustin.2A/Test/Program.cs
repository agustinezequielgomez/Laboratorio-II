using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EntidadesAbstractas;
using EntidadesInstanciables;
using Archivos;


namespace Test
{
    class Program
    {
        static void Main(string[] args)
        {
            Alumno a1 = new Alumno(10, "A", "A", "10", Persona.ENacionalidad.Argentino, Universidad.EClases.Laboratorio, Alumno.EEstadoCuenta.AlDia);
            Alumno a2 = new Alumno(25, "B", "B", "9000090", Persona.ENacionalidad.Extranjero, Universidad.EClases.Legislacion, Alumno.EEstadoCuenta.Deudor);
            Profesor p1 = new Profesor(50, "P", "P", "3", Persona.ENacionalidad.Extranjero);
            Jornada j1 = new Jornada(Universidad.EClases.Legislacion, p1);
            Universidad u1 = new Universidad();
            j1 += a1;
            j1 += a2;
            u1 += p1;
            u1 += a1;
            u1 += Universidad.EClases.Laboratorio;
            Console.WriteLine(Jornada.Leer());
            Console.ReadKey();

        }
    }
}
