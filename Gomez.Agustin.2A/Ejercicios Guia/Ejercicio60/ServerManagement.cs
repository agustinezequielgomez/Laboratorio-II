using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Ejercicio60
{
    class ServerManagement
    {
        public static bool Agregar(Producto producto)
        {
            SqlConnection connection = new SqlConnection(Properties.Settings.Default.Conexion);
            SqlCommand command = new SqlCommand();
            command.CommandType = System.Data.CommandType.Text;
            command.CommandText = String.Format("SET IDENTITY_INSERT AdventureWorks.Production.Product ON INSERT INTO AdventureWorks.Production.Product VALUES({0},'{1}','{2}','{3}','{4}','{5}',{6},{7},{8},{9},'{10}','{11}','{12}',{13},{14},'{15}','{16}','{17}',{18},{19},'{20}','{21}','{22}',{23},'{24}')", producto.ProductID, producto.Name, producto.ProductNumber,Convert.ToByte(producto.MakeFlag), Convert.ToByte(producto.FinishedGoodsFlag), producto.Color, producto.SafetyStockLevel, producto.ReorderPoint, producto.StandardCost, producto.ListPrice, producto.Size, producto.SizeUnitMeasureCode, producto.WeightUnitMeasureCode, producto.Weight, producto.DaysToManufacturate, producto.ProductLine, producto.Class, producto.Style, producto.ProductSubcategoryID, producto.ProductModelID, producto.SellStartDate, producto.SellEndDate, producto.DiscontinuedDate, producto.rowguid, producto.ModifiedDate);
            command.Connection = connection;
            try
            {
                connection.Open();
                command.ExecuteNonQuery();
                connection.Close();
            }
            catch(Exception e)
            {
                return false;
            }
            return true;
        }

        public static bool Modificar(Producto producto)
        {
            SqlConnection conexion = new SqlConnection(Properties.Settings.Default.Conexion);
            SqlCommand command = new SqlCommand();
            command.CommandType = System.Data.CommandType.Text;
            command.CommandText = String.Format("UPDATE Production.Product SET Name = '{0}',ProductNumber = '{1}',MakeFlag = {2}, FinishedGoodsFlag = {3}, Color = '{4}', SafetyStockLevel = '{5}',ReorderPoint = {6},StandardCost={7},ListPrice={8},Size='{9}',SizeUnitMeasureCode='{10}',WeightUnitMeasureCode='{11}', Weight = {12}, DaysToManufacturate = {13},ProductLine = '{14}',Class = '{15}',Style = '{16}',ProductSubcategoryID={17},ProductModelID={18},SellStartDate='{19}',SellEndDate='{20}',DiscontinuedDate='{21}',rowguid='{22}',ModifiedDate='{23}',WHERE ProductID = {24}", producto.Name, producto.ProductNumber, producto.MakeFlag, producto.FinishedGoodsFlag, producto.Color, producto.SafetyStockLevel, producto.ReorderPoint, producto.StandardCost, producto.ListPrice, producto.Size, producto.SizeUnitMeasureCode, producto.WeightUnitMeasureCode, producto.Weight, producto.DaysToManufacturate, producto.ProductLine, producto.Class, producto.Style, producto.ProductSubcategoryID, producto.ProductModelID, producto.SellStartDate, producto.SellEndDate, producto.DiscontinuedDate, producto.rowguid, producto.ModifiedDate, producto.ProductID);
            command.Connection = conexion;
            try
            {
                conexion.Open();
                command.ExecuteNonQuery();
                conexion.Close();
            }
            catch(Exception e)
            {
                return false;
            }
            return true;

        }
    }
}
