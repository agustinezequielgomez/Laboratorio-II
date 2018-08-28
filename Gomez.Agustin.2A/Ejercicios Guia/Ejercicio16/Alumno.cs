using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio16
{
    class Alumno
    {
        private byte _nota1;
        private byte _nota2;
        private float _notaFinal;
        public string apellido;
        public string nombre;
        public int legajo;

        public void Estudiar(byte notaUno, byte notaDos)
        {
            this._nota1 = notaUno;
            this._nota2 = notaDos;         
        }

        public void CalcularFinal()
        {
            if(this._nota1 >= 4 && this._nota2 >= 4)
            {
                Random aleatorio = new Random();
                this._notaFinal = aleatorio.Next();
            }
            else
            {
                this._notaFinal = -1;
            }
        }

        public void Mostrar()
        {
            Console.WriteLine("{0,-8}{1,-10}{2,-15}{3,-10}{4,-10}{5,-10}", "Legajo", "Nombre", "Apellido", "1º Nota", "2ª Nota", "Nota Final");
            if(this._notaFinal==-1)
            {
                Console.WriteLine("{0,-8}{1,-10}{2,-15}{3,-10}{4,-10}{5,-10}", this.legajo, this.nombre, this.apellido, this._nota1, this._nota2, "Alumno desaprobado");
            }
            else
            {
                Console.WriteLine("{0,-8}{1,-10}{2,-15}{3,-10}{4,-10}{5,-10}", this.legajo, this.nombre, this.apellido, this._nota1, this._nota2,this._notaFinal);

            }
        }


        public Alumno(string nombre, string apellido, int legajo)
        {
            this.nombre = nombre;
            this.apellido = apellido;
            this.legajo = legajo;
        }
    }
}
