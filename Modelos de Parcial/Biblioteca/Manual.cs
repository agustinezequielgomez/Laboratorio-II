using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticaParcial
{
    public class Manual : Libro
    {
        public ETipo tipo;
 #region Constructores
        public Manual(string titulo, float precio, string nombre, string apellido,ETipo tipoR)
            :base(precio,titulo,nombre,apellido)
        {
            this.tipo=tipoR;
        }
#endregion
 #region Metodos
        public string Mostrar()
        {
            StringBuilder stringBuild = new StringBuilder();
            stringBuild.AppendLine(((string)this));
            stringBuild.AppendFormat("Tipo: {0}", this.tipo);

            return stringBuild.ToString();
        }
        public static implicit operator double(Manual manual)
        {
            return manual._precio;
        }
        public static bool operator ==(Manual manualA, Manual manualB)
        {
            bool retorno = false;
            if (((Libro)manualA) == ((Libro)manualB) && manualA.tipo == manualB.tipo)
            {
                retorno = true;
            }
            return retorno;
        }
        public static bool operator !=(Manual manualA, Manual manualB)
        {
            return !(manualA == manualB);
        }
        #endregion
    }
}
public enum ETipo
    {
        Tecnico,
        Escolar,
        Finanzas,
    }