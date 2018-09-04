using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioClase04
{
    class Cosa
    {
        #region Atributos
        public string cadena;
        public double numero;
        public DateTime fecha;
        #endregion

        #region Metodos
        public void EstablecerValor(string cadena)
        {
            this.cadena = cadena;
        }

        public void EstablecerValor(double numero)
        {
            this.numero = numero;
        }

        public void EstablecerValor(DateTime fecha)
        {
            this.fecha = fecha;
        }

        public static string Mostrar(Cosa objeto)
        {
            return objeto.Mostrar();
        }

        private string Mostrar()
        {
            string retorno = "";
            retorno += this.cadena + "  " +this.numero.ToString() + "  " + this.fecha.ToString();
            return retorno;
        }

        #endregion


        #region Constructores
        //si accedo al constructor por defecto , la cadena = "sin valor" , numero = 1.9  , fecha=DateTime.now;
        public Cosa()
        {
            this.cadena = "Sin valor";
            this.numero = 1.9;
            this.fecha = DateTime.Now;
        }

        public Cosa(String c) : this()
        {
            this.cadena = c;
            // this.numero = 1.9;
            //this.fecha = DateTime.Now;
        }

        public Cosa(string c, Int32 n) : this(c)
        {
            //this.cadena = c;
            this.numero = n;
            //this.fecha = DateTime.Now;
        }

        public Cosa(string c, Int32 n, DateTime d) : this(c, n)
        {
            //this.cadena = c;
            // this.numero = n;
            this.fecha = DateTime.Now;
        }
        #endregion


        //public Cosa()
        //{
        //    this.cadena = "Sin valor";
        //    this.numero = 1.9;
        //    this.fecha = DateTime.Now;
        //}

        //public Cosa(string c)
        //{
        //    this.cadena = c;
        //    this.numero = 1.9;
        //    this.fecha = DateTime.Now;
        //}
    }
}
