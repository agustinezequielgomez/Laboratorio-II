using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Indexadores._2017
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Arrays

            LibroArray miLibrito = new LibroArray("C# al descubierto", "Joe Mayo");

            miLibrito[0] = "Fundamentos Básicos de C#";

            miLibrito[1] = "Titulo que se va a modificar";
            miLibrito[1] = "Cómo comenzar con C#";
            
            miLibrito[2] = "Cómo escribir expresiones con C#";

            miLibrito[-1] = "Genero un índice erroneo";


            Console.WriteLine("Titulo: {0}", miLibrito.Titulo);
            Console.WriteLine("Autor: {0}", miLibrito.Autor);

            for (int i = 0; i < miLibrito.CantidadDeCapitulos; i++)
                Console.WriteLine("Capitulo {0}: {1}", miLibrito[i].Numero, miLibrito[i].Titulo);


            Console.ReadLine();
            #endregion

            #region Colecciones

            Libro miLibro = new Libro("C# al descubierto", "Joe Mayo");

            miLibro[0] = "Fundamentos Básicos de C#";
            miLibro[1] = "Cómo comenzar con C#";;
            miLibro[2] = "Cómo escribir expresiones con C#"; 

            miLibro[-1] = "Genero un índice erroneo";


            Console.WriteLine("Titulo: {0}", miLibro.Titulo);
            Console.WriteLine("Autor: {0}", miLibro.Autor);

            for (int i = 0; i < miLibro.CantidadDeCapitulos; i++)
                Console.WriteLine("Capitulo {0}: {1}", miLibro[i].Numero, miLibro[i].Titulo);


            Console.ReadLine();
            #endregion 
        }
    }
}
