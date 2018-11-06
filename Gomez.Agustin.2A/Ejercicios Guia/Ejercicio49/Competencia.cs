using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio49
{
    class Competencia<T> where T : VehiculoDeCarrera
    {
        private short cantidadCompetidores;
        private short cantidadVuelas;
        private List<T> competidores;
        private TipoCompetencia tipo;

        public enum TipoCompetencia
        {
            F1,
            MotoCross
        }

        public List<T> Competidores
        {
            get
            {
                return this.competidores;
            }
        }

        public short CantidadCompetidores
        {
            get
            {
                return this.cantidadCompetidores;
            }
            set
            {
                this.cantidadCompetidores = value;
            }
        }

        public short CantidadVueltas
        {
            get
            {
                return this.cantidadVuelas;
            }
            set
            {
                this.cantidadVuelas = value;
            }
        }

        public VehiculoDeCarrera this[int i]
        {
            get
            {
                return this.competidores[i];
            }
        }

        public TipoCompetencia Tipo
        {
            get
            {
                return this.tipo;
            }
            set
            {
                this.tipo = value;
            }
        }

        private Competencia()
        {
            this.competidores = new List<T>();
        }

        public Competencia(short cantidadvueltas, short cantidadCompetidores,TipoCompetencia tipo) : this()
        {
            this.cantidadVuelas = cantidadvueltas;
            this.cantidadCompetidores = cantidadCompetidores;
            this.Tipo = tipo;
        }

        public static bool operator ==(Competencia<T> c, VehiculoDeCarrera a)
        {
            bool retorno = false;
            try
            {
                if (c.Tipo == TipoCompetencia.F1 && a is AutoF1)
                {
                    foreach (T item in c.competidores)
                    {
                        if (item == ((AutoF1)a))
                        {
                            retorno = true;
                            break;
                        }
                    }
                }
                else if (c.Tipo == TipoCompetencia.MotoCross && a is MotoCross)
                {
                    foreach (T item in c.competidores)
                    {
                        if (item == ((MotoCross)a))
                        {
                            retorno = true;
                            break;
                        }
                    }
                }
                else
                {
                    throw new CompetenciaNoDisponibleException("\nEl vehiculo no corresponde a la competencia", "Clase Competencia", "Metodo ==");
                }
            }catch(CompetenciaNoDisponibleException e)
            {
                throw e;
            }


            return retorno;
        }

        public static bool operator !=(Competencia<T> c, VehiculoDeCarrera a)
        {
            return !(c == a);
        }

        public string MostrarDatos()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendFormat("\nCantidad de competidores: {0}\nCantidad de vueltas: {1}\nCompetidores: ", this.cantidadCompetidores, this.cantidadVuelas);
            foreach (T item in this.competidores)
            {
                sb.AppendFormat(item.MostrarDatos());
            }
            return sb.ToString();
        }

        public static bool operator +(Competencia<T> c, T a)
        {
            Random random = new Random();
            bool retorno = false;
            if(c.competidores.Count < c.cantidadCompetidores)
            {
                try
                {
                    if (!(c == a))
                    {
                        a.EnCompetencia = true;
                        a.VueltasRestantes = c.cantidadVuelas;
                        a.CantidadCombustible = (short)random.Next(15, 100);
                        retorno = true;
                        c.competidores.Add(a);
                    }
                }
                catch(CompetenciaNoDisponibleException e)
                {
                    throw new CompetenciaNoDisponibleException("\nCompetencia incorrecta", "Clase competencia", "Metodo operador +", e);
                }

            }
            return retorno;
        }

        public static bool operator -(Competencia<T> c, T a)
        {
            bool retorno = false;
            if(c == a)
            {
                c.Competidores.Remove(a);
                retorno = true;
            }
            return retorno;
        }
    }
}
