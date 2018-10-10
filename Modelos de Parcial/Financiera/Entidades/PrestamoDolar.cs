using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrestamosPersonales
{
    public class PrestamoDolar : Prestamo
    {
        #region Atributos
        private PeriodicidadDePagos periodicidad;
        #endregion

        #region Propiedades
        public float Interes
        {
            get
            {
                return this.CalcularInteres();
            }
                
        }

        public PeriodicidadDePagos Periodicidad
        {
            get
            {
                return this.periodicidad;
            }
        }
        #endregion

        #region Constructor
        public PrestamoDolar(float monto, DateTime vencimiento, PeriodicidadDePagos periodicidad) : base(monto,vencimiento)
        {
            this.periodicidad = periodicidad;
        }

        public PrestamoDolar(Prestamo prestamo, PeriodicidadDePagos periodicidad) : this(prestamo.Monto, prestamo.Vencimiento, periodicidad)
        {

        }
        #endregion

        #region Metodos
        private float CalcularInteres()
        {
            float retorno = 0;
            switch (this.periodicidad)
            {
                case PeriodicidadDePagos.Mensual:
                    retorno = 25;
                    break;
                case PeriodicidadDePagos.Bimestral:
                    retorno = 35;
                    break;
                case PeriodicidadDePagos.Trimestral:
                    retorno = 40;
                    break;
                default:
                    break;
            }
            return retorno;
        }

        public override void ExtenderPlazo(DateTime nuevoVencimiento)
        {
            double dias = (nuevoVencimiento - (this.Vencimiento)).TotalDays;
            this.monto += (float) (dias * 2.5);
            this.Vencimiento = nuevoVencimiento;
        }

        public override string Mostrar()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine(base.Mostrar());
            sb.AppendFormat("\nPeriodicidad de pagos {0}\nInteres ${1}\n", this.Periodicidad, this.Interes);
            return sb.ToString();
        }
        #endregion
    }
}
