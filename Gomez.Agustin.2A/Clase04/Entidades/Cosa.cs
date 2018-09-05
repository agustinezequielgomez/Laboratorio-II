using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Cosa
    {
        public string cadena;
        public double numero;
        public DateTime fecha;

        public void EstablecerValor(string cadena)
        {
            this.cadena = cadena;
        }

        public void EstablecerValor(string cadena, double numero)
        {
            this.EstablecerValor(cadena, numero);
            this.numero = numero;
        }

        public void EstablecerValor(string cadena, double numero, DateTime fecha)
        {
            this.EstablecerValor(cadena, numero);
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

        public Cosa()
        {
            this.cadena = "Sin valor";
            this.numero = 1.9;
            this.fecha = DateTime.Now;
        }

        public Cosa(string c)
        {
            this.cadena = c;
            this.numero = 1.9;
            this.fecha = DateTime.Now;
        }
    }
}
