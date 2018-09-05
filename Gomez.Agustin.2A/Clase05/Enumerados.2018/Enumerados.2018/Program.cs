using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Enumerados._2018
{
    class Program
    {
        static void Main(string[] args)
        {

            ConsoleColor a;
            a = ConsoleColor.Blue;

            int c;
            string d = "Enum5";

            c = -99;


            MiEnumerado b = MiEnumerado.Enum2;


            b = (MiEnumerado) Enum.Parse(typeof(MiEnumerado),"asdfasdfasdfasdfasdfasdfasdf");

            //como asignarlo


            //como parametros
            Console.WriteLine(Program.MetodoEstatico(b));

            //como retorno


            //como recorrerlo
            foreach (String item in Enum.GetNames(typeof(MiEnumerado))) {

                Console.WriteLine(item);
            }

            foreach (MiEnumerado item in Enum.GetValues (typeof(MiEnumerado)))
            {

                Console.WriteLine((int)item);
            }

            Console.ReadLine();
            //switch
            switch (b)
            {
                case MiEnumerado.Enum1:
                    break;
                case MiEnumerado.Enum2:
                    break;
                case MiEnumerado.Enum3:
                    break;
                case MiEnumerado.Enum4:
                    break;
                case MiEnumerado.Enum5:
                    break;
                case MiEnumerado.Enum6:
                    break;
                case MiEnumerado.Enum7:
                    break;
                case MiEnumerado.Enum8:
                    break;
                default:
                    break;
            }

            ConsoleColor z;

            switch (z)
            {
                case ConsoleColor.Black:
                    break;
                case ConsoleColor.DarkBlue:
                    break;
                case ConsoleColor.DarkGreen:
                    break;
                case ConsoleColor.DarkCyan:
                    break;
                case ConsoleColor.DarkRed:
                    break;
                case ConsoleColor.DarkMagenta:
                    break;
                case ConsoleColor.DarkYellow:
                    break;
                case ConsoleColor.Gray:
                    break;
                case ConsoleColor.DarkGray:
                    break;
                case ConsoleColor.Blue:
                    break;
                case ConsoleColor.Green:
                    break;
                case ConsoleColor.Cyan:
                    break;
                case ConsoleColor.Red:
                    break;
                case ConsoleColor.Magenta:
                    break;
                case ConsoleColor.Yellow:
                    break;
                case ConsoleColor.White:
                    break;
                default:
                    break;
            }



            Clase obj = new Clase(5, MiEnumerado.Enum3);

            obj.MetodoInstancia((MiEnumerado)3);


        }




        private static MiEnumerado MetodoEstatico(MiEnumerado param)
        {
            Console.WriteLine(param);
            return MiEnumerado.Enum7;
        }

    }
}
