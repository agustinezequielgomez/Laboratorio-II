using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace EjercicioClase17
{
    public class Televisor
    {
        #region Atributos
        public int id;
        public string marca;
        public double precio;
        public int pulgadas;
        public string pais;
        #endregion

        #region Constructor
        public Televisor()
        {

        }

        public Televisor(int id, string marca, double precio, int pulgadas, string pais)
        {
            this.id = id;
            this.marca = marca;
            this.precio = precio;
            this.pulgadas = pulgadas;
            this.pais = pais;
        }
        #endregion

        #region Metodos
        public bool Insertar()
        {
            SqlConnection conexion = new SqlConnection(Properties.Settings.Default.Conexion2);
            SqlCommand command = new SqlCommand();
            command.CommandType = System.Data.CommandType.Text;
            command.CommandText = String.Format("INSERT INTO Televisores values({0},'{1}',{2},{3},'{4}')", this.id, this.marca, this.precio, this.pulgadas, this.pais);
            command.Connection = conexion;
            //string cadena = "INSERT INTO Televisores values("+this.id+",'"+this.marca+"',"+this.precio+","+this.pulgadas+",'"+this.pais+"')";

            //command.CommandText = cadena;
            try
            {
                conexion.Open();
                command.ExecuteNonQuery(); //Ejecuto consultas que no retornan resultado
                conexion.Close();
            }
            catch (Exception)
            {
                return false;
            }
            return true;
        }
        #endregion
    }
}
