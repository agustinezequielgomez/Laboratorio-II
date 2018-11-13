using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Alumno
    {
        private string _apellido;
        private int _dni;
        private string _fotoAlumno;
        private string _nombre;

        public string Nombre { get => _nombre; set => _nombre = value; }
        public string FotoAlumno { get => _fotoAlumno; set => _fotoAlumno = value; }
        public int Dni { get => _dni; set => _dni = value; }
        public string Apellido { get => _apellido; set => _apellido = value; }

        public Alumno(string apellido, int dni, string ruta, string nombre)
        {
            Apellido = apellido;
            Dni = dni;
            FotoAlumno = ruta;
            Nombre = nombre;
        }
    }
}
