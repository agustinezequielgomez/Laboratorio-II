using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
namespace Entidades
{
    [XmlInclude(typeof(DepositoHeredado))]
    public class Deposito
    {
        public string nombre;
        public Producto[] productos;
        public int cantidad;

        public string Nombre { get { return this.nombre; } }
        public Deposito()
        {

            this.cantidad = 3;
            this.productos = new Producto[this.cantidad];
        }
        public Deposito(int cant)
        {
            this.cantidad = cant;
            this.productos = new Producto[this.cantidad];

        }

        public static Producto[] operator +(Deposito d1, Deposito d2)
        {
            Producto[] returnAux = new Producto[3];
        
            returnAux[0] = new Producto("tomate", 0);
            returnAux[1] = new Producto("azucar", 0);
            returnAux[2] = new Producto("yerba", 0);

            for (int i = 0; i < d1.cantidad; i++)
            {
                for (int j = 0; j < returnAux.Count(); j++)
                {
                    if (d1.productos[i].Nombre == returnAux[j].Nombre)
                        returnAux[j].Stock += d1.productos[i].Stock;
                }
            }
            for (int i = 0; i < d2.cantidad; i++)
            {
                for (int j = 0; j < returnAux.Count(); j++)
                {
                    if (d2.productos[i].Nombre == returnAux[j].Nombre)
                        returnAux[j].Stock += d2.productos[i].Stock;
                }
            }

            return returnAux;
        }

        
    }
}
