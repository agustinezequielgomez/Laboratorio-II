using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Ejercicio Nro 03";
            int entradaUsuario;
            int incremento;
            int verificador;
            int contadorPrimos=0;
            Console.Write("Ingrese un numero: ");
            while(!int.TryParse(Console.ReadLine(),out entradaUsuario) || entradaUsuario<0)
            {
                Console.WriteLine("Error, reingrese");
            }
            for(incremento=2;incremento<=entradaUsuario;incremento++)
            {
                for(verificador=1;verificador<=incremento/2+1;verificador++)
                {
                    if(incremento%verificador==0 && verificador!=incremento && verificador!=1)
                    {
                        break;
                    }
                    else
                    {
                        if (verificador == incremento/2+1)
                        {
                            contadorPrimos += 1;
                        }
                    }
                }
            }
            Console.WriteLine("Hay {0} numeros primos",contadorPrimos);
            Console.Read();
        }
    }
}
