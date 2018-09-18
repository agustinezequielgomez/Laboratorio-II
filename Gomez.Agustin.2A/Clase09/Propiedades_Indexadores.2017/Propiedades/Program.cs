using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Propiedades
{
    class Program
    {
        static void Main(string[] args)
        {
            Test prueba = new Test();

            prueba.SetCadena("valor STRING");
            prueba.SetEntero(22);
            prueba.SetDecimal(44.56f);

            Console.WriteLine(prueba.GetCadena());
            Console.WriteLine(prueba.GetEntero());
            Console.WriteLine(prueba.GetDecimal());

            Console.ReadLine();

            Console.WriteLine(prueba.TestToString());
            Console.ReadLine();

            #region Mejoras...

            prueba.Cadena = "otro valor STRING";
            prueba.Entero = 88;
            prueba.Decimal = 125.33f;

            Console.WriteLine(prueba.Cadena);
            Console.WriteLine(prueba.Entero);
            Console.WriteLine(prueba.Decimal);

            Console.ReadLine();

            Console.WriteLine(prueba.TestToStringBuilder());
            Console.ReadLine();

            #region Más Mejoras...

            Console.WriteLine(prueba.PropiedadSoloLectura);

            prueba.PropiedadSoloEscritura = 88;
            prueba.PropiedadSoloEscritura = 52;

            prueba.PropiedadAutoContenida = DateTime.Now;

            Console.WriteLine(prueba.PropiedadAutoContenida.ToLongDateString());

            #endregion

            #endregion

            Console.ReadLine();

        

            #region Enumerados

            //Defino una variable de tipo enumerado EColor
            EColor unColor;

            #region Recorrer un Enumerado

            /// recorrer un enumerado con ForEach
            ///**********************************
            ///**********************************


            /// sacar los nombres de los items del enumerado con el metodo 
            /// estatico "GetNames" de la clase "Enum"
            foreach (String NombresDelEnumerado in Enum.GetNames(typeof(EColor)))
            {
                Console.WriteLine(NombresDelEnumerado);
            }

            /// sacar  los items del enumerado con el metodo 
            /// estatico "GetValues" de la clase "Enum"
            foreach (EColor ValoresDelEnumerado in Enum.GetValues(typeof(EColor)))
            {
                Console.WriteLine(ValoresDelEnumerado);
            }

            /// sacar  los items del enumerado con el metodo 
            /// estatico "GetValues" de la clase "Enum" , luego de
            /// extraerlos los casteo a enterro para obtener su valor numerico 
            foreach (EColor ValoresDelEnumerado in Enum.GetValues(typeof(EColor)))
            {
                Console.WriteLine((int)ValoresDelEnumerado);
            }

            /// recorrer un enumerado con For
            ///******************************
            ///******************************

            int Cantidad = Enum.GetValues(typeof(EColor)).GetLength(0);

            // esto solo se puede hacer si el enumerado  comienza 
            // en 0 e incrementa de una unidad sus valores
            for (int i = 0; i < Cantidad; i++)
            {
                unColor = (EColor)i;

                Console.WriteLine((int)unColor);
            }

            #endregion


            #region Asignacion de valores


            ///DESDE UN "STRING"
            ///*****************
            ///Asignacion de valores a un enumerado
            ///desde un  "STRING", con el metodo estatico "Parse" de la clase "Enum" y 
            ///luego aplicando el casteo explicito.
            ///Recordar que debemos manejar los posibles errores de casteo que ocurran
            ///try - Catch

            String nombreDeColor = "rojo";
            unColor = (EColor)Enum.Parse(typeof(EColor), nombreDeColor, true);
            nombreDeColor = "verde";
            unColor = (EColor)Enum.Parse(typeof(EColor), nombreDeColor, true);

            nombreDeColor = "amardfasdfasf";
            unColor = (EColor)Enum.Parse(typeof(EColor), nombreDeColor, true);


            ///DESDE UN "INTEGER"
            ///*****************
            ///Asignacion de valores a un enumerado
            ///desde un  "INTEGER", el casteo explicito  "(Color)"
            ///Recordar que debemos manejar losposibles errores de casteo que ocurran
            ///try - Catch

            int numeroDeColor = 3;
            unColor = (EColor)numeroDeColor;

            numeroDeColor = 0;
            unColor = (EColor)numeroDeColor;


            numeroDeColor = 100;
            unColor = (EColor)numeroDeColor;


            #endregion


            #region Utilizacion del Switch

            ///facilita el uso de todas sus items en una estrutura "swicht",
            ///colocando dentro del parametro un objeto de tipo enumerado y 
            ///generando los casos automaticamente gracias a su codeSnippet


            switch (unColor)
            {
                case EColor.Rojo:
                    break;
                case EColor.Azul:
                    break;
                case EColor.Verde:
                    break;
                case EColor.Negro:
                    break;
                default:
                    break;
            }

            #endregion


            #region Recorrer enumarado de Dias

            /// sacar los nombres de los items del enumerado con el metodo 
            /// estatico "GetNames" de la clase "Enum"
            foreach (String NombresDelEnumerado in Enum.GetNames(typeof(EDiaDeLaSemana)))
            {
                Console.WriteLine(NombresDelEnumerado);
            }

            /// sacar  los items del enumerado con el metodo 
            /// estatico "GetValues" de la clase "Enum"
            foreach (EDiaDeLaSemana ValoresDelEnumerado in Enum.GetValues(typeof(EDiaDeLaSemana)))
            {
                Console.WriteLine(ValoresDelEnumerado);
            }

            /// sacar  los items del enumerado con el metodo 
            /// estatico "GetValues" de la clase "Enum" , luego de
            /// extraerlos los casteo a enterro para obtener su valor numerico 
            foreach (EDiaDeLaSemana ValoresDelEnumerado in Enum.GetValues(typeof(EDiaDeLaSemana)))
            {
                Console.WriteLine((int)ValoresDelEnumerado);
            }

            #endregion


            #region Pasaje de Datos

            /// PASEJE DE DATOS
            /// 
            /// Valores literales:
            prueba.Enums(EColor.Rojo);

            /// con una variable del tipo enumerado
            prueba.Enums(unColor);

            /// parseando un string
            prueba.Enums((EColor)Enum.Parse(typeof(EColor), "azul", true));

            /// casteando un entero 
            prueba.Enums((EColor)2);

            #endregion


            #region Posibles errores en tiempo de compilación

            ///MAL

            //prueba.Enums((EColor)"AZul");


            //prueba.Enums((Color)Enum.Parse(Color, "azul", true));


            //prueba.Enums((Color)Enum.Parse(typeof(Color), "azul", true));

            //foreach (EColor ValoresDelEnumerado in Enum.GetValues(EColor))
            //{
            //    Console.WriteLine((int)ValoresDelEnumerado);
            //}


            #endregion

            #endregion

            Console.ReadLine();

        }
    }
}
