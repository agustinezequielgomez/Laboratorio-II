using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrestamosPersonales
{
    public enum PeriodicidadDePagos
    {
        Mensual,
        Bimestral,
        Trimestral
    }

    public enum TipoDePrestamo
    {
        Pesos,
        Dolares,
        Todos
    }
    abstract public class Prestamo
    {
        #region Atributos
        protected float monto;
        protected DateTime vencimiento;
        #endregion

        #region Propiedades
        public float Monto
        {
            get
            {
                return this.monto;
            }
        }

        public DateTime Vencimiento
        {
            get
            {
                return this.vencimiento;
            }
            set
            {
                if(value > DateTime.Now)
                {
                    this.vencimiento = value;
                }
                else
                {
                    this.vencimiento = DateTime.Now;
                }
            }
        }
        #endregion

        #region Constructores
        public Prestamo(float monto, DateTime vencimiento)
        {
            this.monto = monto;
            this.vencimiento = vencimiento;
        }
        #endregion

        #region Metodos
        public static int OrdenarPorFecha(Prestamo p1, Prestamo p2)
        {
            return DateTime.Compare(p1.Vencimiento, p2.Vencimiento);
        }

        public abstract void ExtenderPlazo(DateTime nuevoVencimiento);

        public virtual string Mostrar()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendFormat("\nPrestamo:\nMonto: ${0}\nVencimiento: {1}\n", this.Monto, this.Vencimiento);
            return sb.ToString();
        }
        #endregion
    }
}
