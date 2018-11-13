using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using System.Threading.Tasks;

namespace Entidades {

    public delegate void ElementoAgregado(object o, CartucheraEventArgs e);

    public class Cartuchera<T> {

        protected string _marca;
        protected int _capacidad;
        protected List<T> lista;
        public event ElementoAgregado ElementoAgregadoEvent;

        static SqlConnection conexion;
        static SqlCommand sqlCom;

        private Cartuchera() {
            
            this.lista = new List<T>();
            conexion = new SqlConnection(Properties.Settings.Default.Conexion);

        }

        public Cartuchera(string marca, int capacidad) : this() {

            this._marca = marca;
            this._capacidad = capacidad;

        }

        public void Agregar(T obj) {

            try {

                if (this.lista.Count < this._capacidad) {

                    lista.Add(obj);
                    this.ElementoAgregadoEvent(this, new CartucheraEventArgs(obj.ToString()));

                }
                else {

                    throw new CartucheraLlenaException("Se alcanzo la capacidad maxima de la cartuchera ("+this._capacidad+"), no se podra agregar el item solicitado");

                }

            } catch (CartucheraLlenaException e) {

                Console.WriteLine(e.Message);

            }
            

        }

        public string ObtenerUtilesBD() {

            List<Utiles> lista = new List<Utiles>();

            SqlDataReader sqlRead;

            sqlCom = new SqlCommand();

            sqlCom.Connection = conexion;

            sqlCom.CommandType = CommandType.Text;

            sqlCom.CommandText = "SELECT * FROM elementos";

            conexion.Open();

            sqlRead = sqlCom.ExecuteReader();

            while (sqlRead.Read()) {

                Console.WriteLine(sqlRead["id"].ToString() + " " + sqlRead["marca"].ToString() + " " + sqlRead["precio"].ToString() + " " + sqlRead["color"].ToString() + " " + sqlRead["trazo"].ToString() + " " + sqlRead["soloLapiz"].ToString() + " " + sqlRead["tipo"].ToString());
                //lista.Add(new Goma((bool)sqlRead[0], (string)sqlRead[1], (float)sqlRead[2]));

            }



            sqlRead.Close();
            conexion.Close();

            StringBuilder sb = new StringBuilder();

            foreach (Goma i in lista) {
                sb.AppendLine(i.ToString());
            }

            return sb.ToString();

        }

        public override string ToString() {

            StringBuilder sb = new StringBuilder();

            sb.AppendLine("Marca: " + this._marca);
            sb.AppendLine("Capacidad: " + this._capacidad);
            sb.AppendLine("Lista:");

            foreach (T i in this.lista) {

                sb.AppendLine(i.ToString());
                sb.AppendLine();

            }

            return sb.ToString();
        
        }

    }

}
