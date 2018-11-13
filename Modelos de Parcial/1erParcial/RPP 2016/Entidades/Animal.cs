using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public abstract class Animal
    {
        #region Atributos
        protected static Random _distanciaRecorrida;
        protected int _cantidadPatas;
        protected int _velocidadMaxima;
        #endregion

        #region Constructores
        static Animal()
        {
            Animal._distanciaRecorrida = new Random();
        }
        
        public Animal(int cantidadPatas, int velocidadMaxima)
        {
            this.CantidadPatas = cantidadPatas;
            this.VelocidadMaxima = velocidadMaxima;
        }

        #endregion

        #region Propiedades
        public int CantidadPatas
        {
            get
            {
                return this._cantidadPatas;
            }

            set
            {
                if(value <= 4)
                {
                    this._cantidadPatas = value;
                }
                else
                {
                    this._cantidadPatas = 4;
                }
            }
        }

        private int DistanciaRecorrida
        {
            get
            {
                return Animal._distanciaRecorrida.Next(10, this.VelocidadMaxima);
            }
        }

        public int VelocidadMaxima
        {
            get
            {
                return this._velocidadMaxima;
            }

            set
            {
                if(value <=60)
                {
                    this._velocidadMaxima = value;
                }
                else
                {
                    this._velocidadMaxima = 60;
                }
            }
        }
        #endregion

        #region Metodos
        public string MostrarDatos()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendFormat("Cantidad de patas {0}\n", this.CantidadPatas);
            sb.AppendFormat("Velocidad maxima {0}", this.VelocidadMaxima);
            sb.AppendFormat("Distancia recorrida {0}", this.DistanciaRecorrida);
            return sb.ToString();
        }
        #endregion
    }
}
