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
        private  static TipoManada tipo;

        public enum TipoManada
        {
            Unica,
            Mixta
        }
        #endregion

        #region Propiedades
        public static TipoManada Tipo
        {
            set
            {
                Grupo.tipo = value;
            }
        }
        #endregion

        #region Constructores
        static Grupo()
        {
            Grupo.tipo = TipoManada.Unica;
        }

        private Grupo()
        {
            manada = new List<Mascota>();
        }

        public Grupo(string nombre) : this()
        {
            this.nombre = nombre;
        }

        public Grupo(string nombre, TipoManada tipo) : this(nombre)
        {
            Grupo.Tipo = tipo;
        }
        #endregion

        #region Operadores
        public static implicit operator string(Grupo e)
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendFormat("{0} {1}\n",e.nombre,Grupo.tipo);
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
