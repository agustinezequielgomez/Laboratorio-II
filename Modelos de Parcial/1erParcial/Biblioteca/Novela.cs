using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticaParcial
{
    public class Novela : Libro
    {
        public EGenero genero;
 #region Constructores
        public Novela(string titulo,float precio, Autor autor,EGenero generoR)
            :base(titulo,autor,precio)
        {
            this.genero = generoR;
        }
#endregion
 #region Metodos
        public string Mostrar()
        {
            StringBuilder stringBuild = new StringBuilder();
            stringBuild.AppendLine(((string)this));
            stringBuild.AppendFormat("Tipo: {0}", this.genero);

            return stringBuild.ToString();
        }
        public static implicit operator double(Novela novela)
        {
            return novela._precio;
        }
        public static bool operator ==(Novela novelaA, Novela novelaB)
        {
            bool retorno = false;
            if (((Libro)novelaA) == ((Libro)novelaB) && novelaA.genero == novelaB.genero)
            {
                retorno = true;
            }
            return retorno;
        }
        public static bool operator !=(Novela novelaA, Novela novelaB)
        {
            return !(novelaA == novelaB);
        }
#endregion
    }
}
public enum EGenero
{
    Accion,
    Romantica,
    CienciaFiccion,
}
