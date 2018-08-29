using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioClase04
{
    class Cosa
    {
        public string cadena;
        public double numero;
        public DateTime fecha;

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
