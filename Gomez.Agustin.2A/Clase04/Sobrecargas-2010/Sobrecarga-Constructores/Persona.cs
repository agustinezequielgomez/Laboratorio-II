using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Sobrecarga_Constructores
{
    class Persona
    {
        #region Atributos

        public string apellido;
        public string nombre;
        public int dni;

        #endregion

        #region Constructores

        /// <summary>
        /// Constructor por defecto.
        /// Cantidad de parámetros 0.
        /// </summary>
        public Persona()
        {
            Console.WriteLine("Constructor por defecto. Sin parámetros.");
            Console.ReadLine();

            this.apellido = "Sin Apellido";
            this.nombre = "Sin Nombre";
            this.dni = 0;
        }

        /// <summary>
        /// Constructor con 1 parámetro de tipo String.
        /// </summary>
        /// <param name="apellido">Apellido de la persona.</param>
        public Persona(string apellido)
        {
            Console.WriteLine("Constructor con 1 parámetro. String.");
            Console.ReadLine();

            this.apellido = apellido;
            this.nombre = "Sin Nombre";
            this.dni = 0;
        }

        //ERROR, MISMA FIRMA
        //public Persona(string nombre)
        //{ 
        //}

        /// <summary>
        /// Constructor con 2 parámetros de tipo String.
        /// </summary>
        /// <param name="apellido">Apellido de la persona.</param>
        /// <param name="nombre">Nombre de la persona.</param>
        public Persona(string apellido, string nombre)
        {
            Console.WriteLine("Constructor con 2 parámetros. String - String.");
            Console.ReadLine();
         
            this.apellido = apellido;
            this.nombre = nombre;
            this.dni = 0;
        }

        /// <summary>
        /// Constructor con 3 parámetros. String - String - Int
        /// </summary>
        /// <param name="apellido">Apellido de la persona.</param>
        /// <param name="nombre">Nombre de la persona.</param>
        /// <param name="dni">DNI de la persona.</param>
        public Persona(string apellido, string nombre, int dni)
        {
            Console.WriteLine("Constructor con 3 parámetros. String - String - Int.");
            Console.ReadLine();

            this.apellido = apellido;
            this.nombre = nombre;
            this.dni = dni;
        }

        /// <summary>
        /// Constructor con 3 parámetros. Int - String - String
        /// </summary>
        /// <param name="dni">DNI de la persona.</param>
        /// <param name="nombre">Nombre de la persona.</param>
        /// <param name="apellido">Apellido de la persona.</param>
        public Persona(int dni, string nombre, string apellido)
        {
            Console.WriteLine("Constructor con 3 parámetros. Int - String - String.");
            Console.ReadLine();

            this.apellido = apellido;
            this.nombre = nombre;
            this.dni = dni;            
        }

        #endregion

        #region "Métodos"

        public void MostrarPersona()
        {
            Console.WriteLine("Apellido: {0}", this.apellido);
            Console.WriteLine("Nombre: {0}", this.nombre);
            Console.WriteLine("DNI: {0}",this.dni);

            Console.ReadLine();
        }

        #endregion
    }
}
