﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio51
{
    class Centralita : IGuardar<string>
    {
        #region Atributos
        private List<Llamada> listaDeLlamadas;
        protected string razonSocial;
        #endregion

        #region Propiedades
        public float GananciasPorLocal
        {
            get
            {
                return this.CalcularGanancias(TipoLlamada.Local);
            }
        }

        public float GananciasPorProvincial
        {
            get
            {
                return this.CalcularGanancias(TipoLlamada.Provinicial);
            }
        }

        public float GananciasPorTotal
        {
            get
            {
                return this.CalcularGanancias(TipoLlamada.Todas);
            }
        }

        public List<Llamada> Llamadas
        {
            get
            {
                return this.listaDeLlamadas;
            }
        }

        public bool RutaDeArchivo { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        #endregion

        #region Constructores
        public Centralita()
        {
            this.listaDeLlamadas = new List<Llamada>();
        }

        public Centralita(string nombreEmpresa) : this()
        {
            this.razonSocial = nombreEmpresa;
        }
        #endregion

        #region Metodos
        private float CalcularGanancias(TipoLlamada tipo)
        {
            float retorno = 0;
            float retornoTodos = 0;
            float retornoProvincial = 0;
            float retornoLocal = 0;
            foreach (Llamada item in this.Llamadas)
            {
                if(item is Local)
                {
                    retornoTodos += retornoLocal += item.CostoLlamada;
                }
                else if(item is Provincial)
                {
                    retornoTodos += retornoProvincial += item.CostoLlamada;
                }
            }
            switch (tipo)
            {
                case TipoLlamada.Local:
                    retorno = retornoLocal;
                    break;
                case TipoLlamada.Provinicial:
                    retorno = retornoProvincial;
                    break;
                case TipoLlamada.Todas:
                    retorno = retornoTodos;
                    break;
                default:
                    break;
            }
            return retorno;
        }

        protected string Mostrar()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendFormat("\nRazon social: {0}", this.razonSocial);
            sb.AppendFormat("\nGanancia total: {0}", this.GananciasPorTotal);
            sb.AppendFormat("\nGanancia por provincia: {0}", this.GananciasPorProvincial);
            sb.AppendFormat("\nGanancia por local: {0}", this.GananciasPorLocal);
            sb.AppendLine("\nDetalle de las llamadas: ");
            foreach (Llamada item in this.Llamadas)
            {
                sb.AppendLine(item.ToString());
            }
            return sb.ToString();
        }

        private void AgregarLlamada(Llamada nuevaLlamada)
        {
            this.Llamadas.Add(nuevaLlamada);
        }

        public override string ToString()
        {
            return this.Mostrar();
        }

        public void OrdenarLlamadas()
        {
            this.Llamadas.Sort(Llamada.OrdenarPorDuracion);
        }

        public bool Guardar()
        {
            return true;
        }

        public string Leer()
        {
            throw new NotImplementedException();
        }

        #endregion

        #region Operadores
        public static bool operator ==(Centralita c, Llamada llamada)
        {
            bool retorno = false;
            foreach (Llamada item in c.Llamadas)
            {
                if(item == llamada)
                {
                    retorno = true;
                    break;
                }
            }
            return retorno;
        }

        public static bool operator !=(Centralita c, Llamada llamada)
        {
            return !(c == llamada);
        }

        public static Centralita operator +(Centralita c, Llamada llamada)
        {
            try
            {
                if (c != llamada)
                {
                    c.AgregarLlamada(llamada);
                }
                else
                {
                    throw new CentralitaException("\nLlamada ya existente", "\nClase llamada", "\nMetodo operador +");
                }
            }
            catch (CentralitaException e)
            {
                Console.Write(e.Message);
                Console.Write(e.NombreClase);
                Console.WriteLine(e.NombreMetodo);
            }
            return c;
        }
        #endregion
    }
}