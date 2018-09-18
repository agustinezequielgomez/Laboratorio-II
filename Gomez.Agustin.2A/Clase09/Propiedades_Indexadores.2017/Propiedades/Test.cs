using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Propiedades
{
    class Test
    {
        private string _cadena;
        private Int32 _entero;
        private Single _decimal;

        #region Métodos Getters y Setters

        #region Getters

        public String GetCadena() { return this._cadena; }
        public Int32 GetEntero() { return this._entero; }
        public Single GetDecimal() { return this._decimal; }

        #endregion

        #region Setters

        public void SetCadena(String cadena) { this._cadena = cadena; }
        public void SetEntero(Int32 nroEntero) { this._entero = nroEntero; }
        public void SetDecimal(Single nroDecimal) { this._decimal = nroDecimal; }

        #endregion

        #endregion

        #region Método

        public string TestToString()
        {
            String retorno = "";

            retorno = "Cadena: " + this._cadena + "\n" + "Entero: " + this._entero + "\n" + "Decimal: " + this._decimal + "\n";

            return retorno;
        }

        #endregion

        #region Mejoras

        #region Propiedades

        public String Cadena
        {
            get { return this._cadena; }
            set { this._cadena = value; }
        }
        public Int32 Entero
        {
            get { return this._entero; }
            set { this._entero = value; }
        }
        public Single Decimal
        {
            get { return this._decimal; }
            set { this._decimal = value; }
        }

        #endregion

        #region Método con StringBuilder

        public string TestToStringBuilder()
        {
            StringBuilder sb = new StringBuilder();

            sb.Append("Cadena: ");
            sb.AppendLine(this._cadena);
            
            sb.Append("Entero: ");
            sb.AppendLine(this._entero.ToString());

            sb.Append("Decimal: ");
            sb.AppendLine(this._decimal.ToString());

            return sb.ToString();
        }
        #endregion

        #region Más Propiedades

        #region Propiedad Sólo Lectura

        public string PropiedadSoloLectura
        {
            get { return this.TestToStringBuilder(); }
        }
        #endregion

        #region Propiedad Sólo Escritura

        public Int32 PropiedadSoloEscritura
        {
            set
            {
                if (value != this._entero)
                {
                    this._entero = value;
                }
                else
                {
                    Console.WriteLine("Es el mismo valor!!!");
                }
            }
        }

        #endregion

        #region Propiedad Auto-Contenida

        public DateTime PropiedadAutoContenida { get; set; }

        #endregion

        #endregion

        #region Enumerados
        public void Enums(EColor miColor)
        {

            Console.WriteLine(miColor);
        }
        #endregion

        #endregion


    }
}
