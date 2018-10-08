using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class DirectorTecnico : Persona
    {
        #region Constructores
        public DirectorTecnico(string nombre, string apellido) : base(nombre,apellido)
        {
        }
        #endregion

        #region Metodos
        protected override string FichaTecnica()
        {
            return this.NombreCompleto();
        }

        public override string ToString()
        {
            return this.FichaTecnica();
        }
        #endregion
    }
}
