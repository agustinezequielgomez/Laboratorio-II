using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public delegate void DelPar(object sender, EventArgs args);

    public class Galpon<T>
    {
        private List<T> _elementos;
        private int _capacidad;
        public event DelPar ElementosParesEvent;

        private Galpon()
        {
            this._elementos = new List<T>();
        }
        public Galpon(int capacidad):this()
        {
            this._capacidad = capacidad;
        }

        public void Add(T elemento)
        {
            if(this._elementos.Count<this._capacidad)
            {
                this._elementos.Add(elemento);
                if(this._elementos.Count%2==0)
                {
                    this.ElementosParesEvent(elemento, EventArgs.Empty);
                } 
            }
        }
    }
}
