using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Ejercicio31
{
    class PuestoAtencion
    {
        private static int numeroActual;
        private Puesto puesto;

        public enum Puesto
        {
            Caja1,
            Caja2
        }

        public static int NumeroActual
        {
            get
            {
                return PuestoAtencion.numeroActual += 1;
            }
        }

        static PuestoAtencion()
        {
            PuestoAtencion.numeroActual = 0;
        }

        public PuestoAtencion(Puesto puesto)
        {
            this.puesto = puesto;
        }

        public bool Atender(Cliente cli)
        {
            Thread.Sleep(1500);
            return true;   
        }
    }
}
