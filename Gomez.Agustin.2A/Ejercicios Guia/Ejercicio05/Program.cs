using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio05
{
    class Ejercicio_05
    {
        static void Main(string[] args)
        {
            Console.Title = "Ejercicio Nro 05";
            int numero;
            int i;
            int j;
            int acumuladorI = 0;
            int acumuladorJ = 0;
            Console.WriteLine("Ingrese un numero ");
            numero = int.Parse(Console.ReadLine());
            for(i=1;i<=numero;i++) //Se recorren todos los numeros dese el 1 hasta el numero ingresado por el usuario
            {
                acumuladorI += i; //Cada vez que se recorre un numero, se va sumando en el acumulador
                for (j=i+2;j<=numero;j++) //Se recorren los numeros comenzando 2 numeros mas adelante que I. Dejando un lugar libre en el medio de I y J (El centro numerico)
                {
                    acumuladorJ += j; //Cada vez que se recorre un numero, se suma en el acumulador
                    if(acumuladorI==acumuladorJ) //Se checkea si la suma del acumulador I y J es igual. Si esto es asi, se encontro un centro numerico.
                    {
                        Console.WriteLine("El numero {0} es un centro numerico, separando los numeros del 1 al {1} y los numeros del {2} al {3}, dando una suma de {4}", i+1,i,i+2,j,acumuladorI); //El centro numerico encontrado esta un lugar sobre el valor de I (o uno bajo el valor de J)
                    }
                }
                acumuladorJ = 0; //Si no se encuentra un centro numerico, se reinicia el contador y se continua la busqueda.
            }
            Console.ReadLine();
        }
    }
}