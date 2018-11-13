using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Data;
using System.Threading.Tasks;

namespace Entidades {

    public class Producto {

        private string _nombre;
        private int _stock;
        static SqlConnection conexion;
        static SqlCommand sqlCom;

        public string nombre {

            get { return this._nombre; }
            set { this._nombre = value; }

        }

        public int stock {

            get { return this._stock; }
            set { this._stock = value; }

        }

        static Producto() {

            conexion = new SqlConnection(Properties.Settings.Default.conexion);
            sqlCom = new SqlCommand();

        }

        public Producto () { }

        public Producto(string nombre, int stock) {

            this._nombre = nombre;
            this._stock = stock;

        }

        public bool AgregarBD() {

            try {

                sqlCom.Connection = conexion;
                sqlCom.CommandType = CommandType.Text;
                sqlCom.CommandText = "INSERT INTO productosBD (nombre,stock) VALUES ('"+this.nombre+"',"+this.stock+")";
                conexion.Open();
                sqlCom.ExecuteNonQuery();
                conexion.Close();
                return true;

            } catch (Exception) {

                conexion.Close();
                return false;

            }

        }

        public static bool operator ==(Producto a, Producto b) {

            bool retorno = false;

            try {

                if (a.nombre == b.nombre) {

                    retorno = true;

                }

            } catch (NullReferenceException) {

                retorno = false;

            }

            return retorno;

        }

        public static bool operator !=(Producto a, Producto b) {

            return !(a == b);

        }

        public static int operator ==(Producto[] d, Producto p) {

            int retorno = -1;

            for (int i = 0; i < d.Length; i++) {

                if (d[i] == p) {

                    retorno = i;
                    break;

                }

            }

            return retorno;

        }

        public static int operator !=(Producto[] d, Producto p) {

            return -1;

        }

        public override string ToString() {

            StringBuilder sb = new StringBuilder();

            sb.AppendFormat("Nombre: {0}\n", this.nombre);
            sb.AppendFormat("Stock: {0}\n", this.stock);

            return sb.ToString();

        }

    }

}
