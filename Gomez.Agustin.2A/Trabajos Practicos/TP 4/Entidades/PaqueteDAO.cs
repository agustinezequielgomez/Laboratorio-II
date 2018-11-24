using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Entidades
{
    public static class PaqueteDAO
    {
        #region Atributos
        static SqlCommand comando;
        static SqlConnection conexion;
        #endregion
                
        #region Constructor
        static PaqueteDAO()
        {
            PaqueteDAO.conexion = new SqlConnection(Properties.Settings.Default.conexion);
            PaqueteDAO.comando = new SqlCommand();

        }
        #endregion

        #region Metodos
        public static bool Insertar(Paquete p)
        {
            PaqueteDAO.comando.CommandType = System.Data.CommandType.Text;
            PaqueteDAO.comando.CommandText = String.Format("INSERT INTO Paquetes values('{0}','{1}','{2}')", p.DireccionEntrega, p.TrackingID, "Agustin Gomez");
            PaqueteDAO.comando.Connection = PaqueteDAO.conexion;
            try
            {
                PaqueteDAO.conexion.Open();
                PaqueteDAO.comando.ExecuteNonQuery();
                PaqueteDAO.conexion.Close();
            }
            catch(Exception e)
            {
                throw e;
            }
            return true;
        }
        #endregion
    }
}
