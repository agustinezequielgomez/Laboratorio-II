using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_7
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Ejercicio Nro 07";
            int dia;
            int mes;
            int anio;
            int contador;
            int diasDeVida=0;
            DateTime fechaActual;
            fechaActual = DateTime.Now;
            Console.Write("Ingrese dia: ");
            while (!int.TryParse(Console.ReadLine(), out dia) || dia < 1 || dia>31)
            {
                Console.Write("Error, reingrese: ");
            }
            Console.Write("Ingrese mes: ");
            while (!int.TryParse(Console.ReadLine(), out mes) || mes < 1 || mes > 12)
            {
                Console.Write("Error, reingrese: ");
            }
            Console.Write("Ingrese año: ");
            while (!int.TryParse(Console.ReadLine(), out anio) || anio < 1900 || anio > fechaActual.Year)
            {
                Console.Write("Error, reingrese: ");
            }

            for (contador=anio+1;contador<fechaActual.Year;contador++)
            {
                if (contador % 4 == 0 && contador % 100 != 0 || contador % 100 == 0 && contador % 400 == 0)
                {
                    diasDeVida += 366;
                }
                else
                {
                    diasDeVida += 365;
                }
            }
            for (contador = mes;contador<=12;contador++)
            {
                switch(contador)
                {
                    case 2:
                        diasDeVida += 28;
                        break;
                    case 4:
                    case 6:
                    case 9:
                    case 11:
                        diasDeVida += 30;
                        break;
                    case 1:
                    case 3:
                    case 5:                   
                    case 7:
                    case 8:                    
                    case 10:                   
                    case 12:
                        diasDeVida += 31;
                        break;
                }
            }
            if (mes<=2 && (anio % 4 == 0 && anio % 100 != 0 || anio % 100 == 0 && anio % 400 == 0))
            {
                diasDeVida += 1;
            }
            diasDeVida -= dia;

            for (contador = fechaActual.Month; contador > 0; contador--)
            {
                switch (contador)
                {
                    case 2:
                        diasDeVida += 28;
                        if (contador == fechaActual.Month)
                        {
                            diasDeVida = diasDeVida - (28 - fechaActual.Day);
                        }
                        break;
                    case 4:
                    case 6:
                    case 9:
                    case 11:
                        diasDeVida += 30;
                        if (contador == fechaActual.Month)
                        {
                            diasDeVida = diasDeVida - (30 - fechaActual.Day);
                        }
                        break;
                    case 1:
                    case 3:
                    case 5:
                    case 7:
                    case 8:
                    case 10:
                    case 12:
                        diasDeVida += 31;
                        if (contador == fechaActual.Month)
                        {
                            diasDeVida = diasDeVida - (31 - fechaActual.Day);
                        }
                        break;
                }
            }
            if (mes > 2 && (fechaActual.Year % 4 == 0 && fechaActual.Year % 100 != 0 || fechaActual.Year % 100 == 0 && fechaActual.Year % 400 == 0))
            {
                diasDeVida += 1;
            }
            Console.WriteLine("Usted vivio {0} dias",diasDeVida);
            Console.Read();


            Console.Read();
        }
    }
}
