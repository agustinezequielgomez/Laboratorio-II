using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication6
{
    public class Cosa
    {
        #region Atributos

        public string cadena;
        public int entero;
        public DateTime fecha;
        
        #endregion

        #region Metodos

        public string Mostrar()
        {
            return this.cadena + " - " + this.entero.ToString() + " - " + this.fecha.ToLongDateString();
        }

        public void EstablecerValor(string valor) 
        {
            this.cadena = valor;
        }
        public void EstablecerValor(int valor)
        {
            this.entero = valor;
        }
        public void EstablecerValor(DateTime valor)
        {
            this.fecha = valor;
        }
        #endregion

        #region Constructor

        public Cosa() 
        {
            this.cadena = "sin valor";
            this.entero = 10;
            this.fecha = DateTime.Now;
        }

        public Cosa(string a) :this()
        {
            this.cadena = a;
            //this.entero = 10;
            //this.fecha = DateTime.Now;
        }

        public Cosa(string a, DateTime b):this(a)
        {
            //this.cadena = a;
            //this.entero = 10;
            this.fecha = b;
        }

        public Cosa(string a, DateTime b, int c)
        {
            this.cadena = a;
            this.entero = c;
            this.fecha = b;
        }
        #endregion
    }
}
