using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Perro : Mascota
    {
        #region Atributos
        private int edad;
        private bool esAlfa;
        #endregion

        #region Propiedades
        public int Edad
        {
            get
            {
                return this.edad;
            }
            set
            {
                this.edad = value;
            }
        }

        public bool EsAlfa
        {
            get
            {
                return this.esAlfa;
            }
            set
            {
                this.esAlfa = value;
            }
        }
        #endregion

        #region Constructores
        public Perro(string nombre, string raza) : this(nombre, raza,0,false)
        {
        }

        public Perro(string nombre, string raza, int edad, bool esAlfa) : base(nombre, raza)
        {
            this.edad = edad;
            this.esAlfa = esAlfa;
        }
        #endregion

        #region Metodos
        protected override string Ficha()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append(base.DatosCompletos());
            if (this.EsAlfa == true)
            {
                sb.AppendFormat("{0}", this.Nombre);
                sb.AppendFormat(", alfa de la manada, edad {0}", this.Edad);
            }
            else
            {
                sb.AppendFormat("{0}, edad {1}", this.Nombre, this.Edad);
            }
            return sb.ToString();
        }

        public override string ToString()
        {
            return this.Ficha();
        }

        public override bool Equals(object obj)
        {
            return (this == (Perro)obj);
        }
        #endregion

        #region Operadores
        public static bool operator ==(Perro j1, Perro j2)
        {
            return (j1.Raza == j2.Raza && j1.Edad == j2.Edad);
        }

        public static bool operator !=(Perro j1, Perro j2)
        {
            return !(j1 == j2);
        }

        public static explicit operator int(Perro Perro)
        {
            return Perro.Edad;
        }
        #endregion
    }
}
