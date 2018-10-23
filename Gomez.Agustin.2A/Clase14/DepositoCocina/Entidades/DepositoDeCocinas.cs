using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Entidades
{
    public class DepositoDeCocinas
    {
        #region Atributos
        private int _capacidadMaxima;
        private List<Cocina> _lista;
        #endregion

        #region Constructor
        public DepositoDeCocinas(int capacidad)
        {
            this._lista = new List<Cocina>();
            this._capacidadMaxima = capacidad;
        }
        #endregion

        #region Metodos
        private int GetIndice(Cocina c)
        {
            int indice = -1;
            int i;
            for(i = 0; i<this._lista.Count ;i++)
            {
                if(this._lista[i] == c)
                {
                    indice = i;
                    break;
                }
            }
            return indice;
        }

        public bool Agregar(Cocina c)
        {
            return this + c;
        }

        public bool Remover(Cocina c)
        {
            return this - c;
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendFormat("Capacidad máxima: {0}",this._capacidadMaxima);
            sb.AppendLine("\nListado de Cocinas:");
            foreach (Cocina item in this._lista)
            {
                sb.AppendLine(item.ToString());
            }
            return sb.ToString();
        }

        public bool Guardar(string cadena) //Guardo en un archivo lo que devuelve ToString. Devuelve true si pudo, false si no.
        {
            bool retorno = false;
            try
            {
                using (StreamWriter streamWriter = new StreamWriter(cadena, false))
                {
                    streamWriter.Write(this.ToString());
                }
                retorno = true;
            }
            catch(Exception e)
            {
                retorno = false;
            }
            return retorno;
        }

        public bool Recuperar(string path)
        {
            bool retorno = false;
            try
            {
                 using (StreamReader sr = new StreamReader(path))
                 {
                    Console.WriteLine(sr.ReadToEnd());
                    retorno = true;
                 }
            }
            catch(Exception e)
            {
                retorno = false;
            }
            return retorno;
        }
        #endregion

        #region Operadores
        public static bool operator +(DepositoDeCocinas d, Cocina c)
        {
            bool retorno = false;
            if(d._lista.Count < d._capacidadMaxima)
            {
                d._lista.Add(c);
                retorno = true;
            }
            return retorno;
        }

        public static bool operator -(DepositoDeCocinas d, Cocina c)
        {
            bool retorno = false;
            int indice = d.GetIndice(c);
            if(indice!=-1)
            {
                d._lista.RemoveAt(indice);
                retorno = true;
            }
            return retorno;
        }
        #endregion
    }
}
