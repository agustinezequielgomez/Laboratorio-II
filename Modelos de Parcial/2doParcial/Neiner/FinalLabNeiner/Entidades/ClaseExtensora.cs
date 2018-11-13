using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace Entidades {

    public static class ClaseExtensora {

        public static string MostrarBD(this Producto objeto) {

            SqlConnection conexion = new SqlConnection(Properties.Settings.Default.conexion);
            SqlCommand sqlCom = new SqlCommand();
            Producto aux;
            StringBuilder sb = new StringBuilder();

            try {

                SqlDataReader sqlRead;
                sqlCom.Connection = conexion;
                sqlCom.CommandType = CommandType.Text;
                sqlCom.CommandText = "SELECT * FROM productosDB";
                sqlRead = sqlCom.ExecuteReader();
                conexion.Open();

                while (sqlRead.Read()) {

                    aux = new Producto((string)sqlRead[0], (int)sqlRead[1]);
                    sb.AppendLine(aux.ToString());

                }

                return sb.ToString();

            } catch (Exception) {

                conexion.Close();
                return "Error";

            }

        }

    }

}
