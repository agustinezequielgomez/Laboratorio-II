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
