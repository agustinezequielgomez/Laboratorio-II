using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Grupo
    {
        #region Atributos
        private List<Mascota> manada;
        private string nombre;
        private TipoManada tipo;

        public enum TipoManada
        {
            Unica,
            Mixta
        }
        #endregion

        #region Propiedades
        public TipoManada Tipo
        {
            set
            {
                this.tipo = value;
            }
        }
        #endregion

        #region Constructores
        private Grupo()
        {
            this.Tipo = TipoManada.Unica;
            manada = new List<Mascota>();

        }

        public Grupo(string nombre) : this()
        {
            this.nombre = nombre;
            this.tipo = TipoManada.Unica;
        }

        public Grupo(string nombre, TipoManada tipo) : this(nombre)
        {
            this.Tipo = tipo;
        }
        #endregion

        #region Operadores
        public static implicit operator string(Grupo e)
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendFormat("{0} {1}\n",e.nombre,e.tipo);
            sb.AppendLine("Integrantes: ");
            foreach(Mascota mascota in e.manada)
            {
                sb.AppendLine(mascota.ToString());
            }
            return sb.ToString();
        }

        public static bool operator ==(Grupo e, Mascota j)
        {
            foreach(Mascota mascotas in e.manada)
            {
                if(mascotas is Perro && j is Perro)
                {
                    if((Perro)mascotas == (Perro)j)
                    {
                        return true;
                    }
                }
                else if(mascotas is Gato && j is Gato)
                {
                    if ((Gato)mascotas == (Gato)j)
                    {
                        return true;
                    }
                }
            }
            return false;
        }

        public static bool operator !=(Grupo e, Mascota j)
        {
            return !(e == j);
        }

        public static Grupo operator +(Grupo e, Mascota j)
        {
            if((e != j))
            {
                e.manada.Add(j);
            }
            return e;
        }

        public static Grupo operator -(Grupo e, Mascota j)
        {
            if(e == j)
            {
                e.manada.Remove(j);
            }
            return e;
        }
        #endregion

    }
}
