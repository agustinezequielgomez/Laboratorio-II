using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Lavadero
    {
        #region Atributos
        private List<Vehiculo> _vehiculos;
        private static float _precioAuto;
        private static float _precioCamion;
        private static float _precioMoto;
        private string _razonSocial;
        #endregion

        #region Constructores
        private Lavadero()
        {
            this._vehiculos = new List<Vehiculo>();
        }

        static Lavadero()
        {
            Random random = new Random();
            Lavadero._precioAuto = random.Next(150, 565);
            do
            {
                Lavadero._precioCamion = random.Next(150, 565);
                Lavadero._precioMoto = random.Next(150, 565);
            } while (Lavadero._precioAuto == Lavadero._precioCamion || Lavadero._precioAuto == Lavadero._precioMoto || Lavadero._precioCamion == Lavadero._precioMoto);
        }

        public Lavadero(string razonSocial) : this()
        {
            this._razonSocial = razonSocial;
        }
        #endregion

        #region Propiedades
        public string LavaderoToString
        {
            get
            {
                StringBuilder sb = new StringBuilder();
                sb.AppendFormat("\nRazon Social: {0}", this._razonSocial);
                sb.AppendFormat("\nPrecios\nPrecios Autos ${0}\nPrecios Motos ${1}\nPrecios Camiones ${2}\n", Lavadero._precioAuto, Lavadero._precioMoto, Lavadero._precioCamion);
                sb.AppendLine("\nVehiculos:\n");
                foreach (Vehiculo vehiculo in this._vehiculos)
                {
                    sb.AppendLine(vehiculo.ToString());
                }
                return sb.ToString();
            }
        }

        public List<Vehiculo> Vehiculos
        {
            get
            {
                return this._vehiculos;
            }
                
        }
        #endregion

        #region Metodos
        public double MostrarTotalFacturado()
        {
            double total = 0;
            total += MostrarTotalFacturado(EVehiculos.Auto);
            total += MostrarTotalFacturado(EVehiculos.Camion);
            total += MostrarTotalFacturado(EVehiculos.Moto);
            return total;
        }

        public double MostrarTotalFacturado(EVehiculos vehiculos)
        {
            double total = 0;
            foreach(Vehiculo vehiculo in this._vehiculos)
            {
                switch (vehiculos)
                {
                    case EVehiculos.Auto:
                        if(vehiculo is Auto)
                        {
                            total += Lavadero._precioAuto;
                        }
                        break;
                    case EVehiculos.Moto:
                        if(vehiculo is Moto)
                        {
                            total += Lavadero._precioMoto;
                        }
                        break;
                    case EVehiculos.Camion:
                        if (vehiculo is Camion)
                        {
                            total += Lavadero._precioCamion;
                        }
                        break;
                    default:
                        break;
                }
            }
            return total;
        }
        #endregion

        #region Operadores
        public static bool operator ==(Lavadero lavadero, Vehiculo vehiculo)
        {
            bool retorno = false;
            foreach(Vehiculo vehiculos in lavadero._vehiculos)
            {
                if(vehiculo == vehiculos)
                {
                    retorno = true;
                    break;
                }
            }
            return retorno;
        }

        public static bool operator !=(Lavadero lavadero, Vehiculo vehiculo)
        {
            return !(lavadero == vehiculo);
        }

        public static int operator ==(Vehiculo vehiculo, Lavadero lavadero)
        {
            int retorno = -1;
            int i;
            for(i = 0; i<lavadero._vehiculos.Count;i++)
            {
                if(vehiculo == lavadero._vehiculos[i])
                {
                    retorno = i;
                }
            }
            return retorno;
        }

        public static int operator !=(Vehiculo vehiculo, Lavadero lavadero)
        {
            return vehiculo == lavadero;
        }

        public static Lavadero operator +(Lavadero lavadero, Vehiculo vehiculo)
        {
            if(lavadero!=vehiculo)
            {
                lavadero._vehiculos.Add(vehiculo);
            }
            return lavadero;
        }

        public static Lavadero operator -(Lavadero lavadero, Vehiculo vehiculo)
        {
            int indice = (vehiculo == lavadero);
            if(indice != -1)
            {
                lavadero._vehiculos.RemoveAt(indice);
            }
            return lavadero;
        }

        public static int OrdenarVehiculosPorPatente(Vehiculo vehiculo1, Vehiculo vehiculo2)
        {
            return string.Compare(vehiculo1.Patente, vehiculo2.Patente);
        }

        public int OrdenarVehiculosPorMarca(Vehiculo vehiculo1, Vehiculo vehiculo2)
        {
            return string.Compare(Enum.GetName(typeof(EMarcas), vehiculo1.Marcas), Enum.GetName(typeof(EMarcas), vehiculo2.Marcas));
        }
        #endregion
    }
}
