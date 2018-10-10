using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrestamosPersonales
{
    public class PrestamoPesos : Prestamo
    {
        #region Atributos
        private float porcentajeInteres;
        #endregion

        #region
        public float Interes
        {
            get
            {
                return this.CalcularInteres();
            }
        }
        #endregion

        #region Constructores
        public PrestamoPesos(float monto, DateTime vencimiento, float interes) : base(monto,vencimiento)
        {
            this.porcentajeInteres = interes;
        }

        public PrestamoPesos(Prestamo prestamo, float porcentajeInteres) : this(prestamo.Monto,prestamo.Vencimiento,porcentajeInteres)
        {

        }
        #endregion

        #region Metodos
        private float CalcularInteres()
        {
            return (this.Monto * this.porcentajeInteres) / 100;
        }

        public override void ExtenderPlazo(DateTime nuevoVencimiento)
        {
            float dias = (float)(this.Vencimiento - nuevoVencimiento).TotalDays;
            this.porcentajeInteres += (int) 0.25 * dias;
            this.Vencimiento = nuevoVencimiento;
        }

        public override string Mostrar()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine(base.Mostrar());
            sb.AppendFormat("\nPorcentaje de Interes {0}\nInteres ${1}\n", this.porcentajeInteres, this.Interes);
            return sb.ToString();
        }
        #endregion
    }
}
