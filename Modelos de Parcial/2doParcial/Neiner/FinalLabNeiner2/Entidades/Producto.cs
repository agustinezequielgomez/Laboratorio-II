using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
namespace Entidades
{

    public class Producto
    {
        private string _nombre;
        private int _stock;
        public Producto()
        {

        }
        public string Nombre { get { return this._nombre; } }
        public int Stock { get { return this._stock; } set { this._stock = value; } }
        public Producto(string nombre,int stock)
        {
            this._nombre = nombre;
            this._stock = stock;
        }

        public override string ToString()
        {
            return "Nombre: " + this.Nombre + " Stock: " + this.Stock;
        }
    }
}
