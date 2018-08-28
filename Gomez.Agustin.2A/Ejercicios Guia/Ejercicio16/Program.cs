using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio16
{
    class Ejercicio_16
    {
        static void Main(string[] args)
        {
            Console.Title = "Ejercicio 16";
            Alumno primerAlumno = new Alumno("Juan", "Perez", 1534);
            Alumno segundoAlumno = new Alumno("Pedro", "Soliz", 2045);
            Alumno tercerAlumno = new Alumno("Maria", "Siedlar", 8875);
            primerAlumno.Estudiar(1, 2);
            segundoAlumno.Estudiar(4, 5);
            tercerAlumno.Estudiar(10, 10);
            primerAlumno.CalcularFinal();
            segundoAlumno.CalcularFinal();
            tercerAlumno.CalcularFinal();
            primerAlumno.Mostrar();
            segundoAlumno.Mostrar();
            tercerAlumno.Mostrar();
            Console.ReadLine();
        }
    }
}
