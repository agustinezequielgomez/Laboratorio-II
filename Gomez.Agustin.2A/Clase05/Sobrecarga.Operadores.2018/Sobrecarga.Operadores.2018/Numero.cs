using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sobrecarga.Operadores._2018
{
    class Numero
    {
        private double valor;

        private Numero(double valor)
        {
            this.valor = valor;
        }

        public static Numero operator +(Numero op1, Numero op2)
        {
            Numero retorno = new Numero( op1.valor + op2.valor);
            return retorno;
        }

        public static Numero operator +(Numero op1, int op2)
        {
            Numero retorno = new Numero(op1.valor + op2);
            return retorno;
        }

        public static Numero operator ++(Numero op1)
        {
            op1.valor++;
            return op1;
        }

        public static implicit operator Numero(int valor)
        {

            Numero retorno = new Numero(valor);
            return retorno;

        }

        public static explicit operator double(Numero n)
        {

            
            return n.valor;

        }


        public static bool operator ==(Numero n1, Numero n2)
        {

            return n1.valor == n2.valor;
        }

        public static bool operator !=(Numero n1, Numero n2)
        {

            return !(n1 == n2);
        }



    }
}
