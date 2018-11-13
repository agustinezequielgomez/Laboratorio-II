using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using Interfaces;

namespace Entidades
{
    class InfoHilo
    {
        int _id;
        IRespuesta<int> _callback;
        Thread _hilo;
        Random _randomizes;

        InfoHilo()
        {
            this._randomizes = new Random();
        }

        public InfoHilo(int id, IRespuesta<int> callback)
            : this()
        {
            this._id = id;
            this._callback = callback;
            this._hilo = new Thread(Ejecutar);
            this._hilo.Start();
        }

        public int ID
        {
            get { return this._id; }
        }


        void Ejecutar()
        {
            int sleep_amount = (this._randomizes.Next(1, 5)) * 1000;
            Thread.Sleep(sleep_amount);
            this._callback.RespuestaHilo(this._id);
        }
    }
}
