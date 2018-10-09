using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    class Carrera
    {
        #region Atributos
        private List<Animal> _animales;
        private int _corredoresMax;
        #endregion

        #region Constructores
        private Carrera()
        {
            this._animales = new List<Animal>();
        }

        public Carrera(int corredoresMax) : this()
        {
            this._corredoresMax = corredoresMax;
        }
        #endregion

        #region Operadores
        public static bool operator ==(Carrera c, Animal a)
        {
            bool retorno = false;
            foreach(Animal animal in c._animales)
            {
                if(animal is Humano && ((Humano)animal) == (Humano)a)
                {
                    retorno = true;
                }
                else if(animal is Perro && ((Perro)animal) == (Perro)a)
                {
                    retorno = true;
                }
                else if(animal is Caballo && ((Caballo)animal) == (Caballo)a)
                {
                    retorno = true;
                }
            }
            return retorno;
        }

        public static bool operator !=(Carrera c, Animal a)
        {
            return !(c == a);
        }

        public static Carrera operator +(Carrera c, Animal a)
        {
            if(c!=a && c._animales.Count <= c._corredoresMax)
            {
                c._animales.Add(a);
            }
            return c;
        }
        #endregion
    }
}
