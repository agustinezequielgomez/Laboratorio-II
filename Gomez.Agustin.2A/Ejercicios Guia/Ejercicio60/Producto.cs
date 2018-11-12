using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio60
{
    class Producto
    {
        #region Atributos
        public int ProductID;
        public string Name;
        public string ProductNumber;
        public bool MakeFlag;
        public bool FinishedGoodsFlag;
        public string Color;
        public short SafetyStockLevel;
        public short ReorderPoint;
        public decimal StandardCost;
        public decimal ListPrice;
        public string Size;
        public string SizeUnitMeasureCode;
        public string WeightUnitMeasureCode;
        public decimal Weight;
        public int DaysToManufacturate;
        public string ProductLine;
        public string Class;
        public string Style;
        public int ProductSubcategoryID;
        public int ProductModelID;
        public DateTime SellStartDate;
        public DateTime SellEndDate;
        public DateTime DiscontinuedDate;
        public Guid rowguid;
        public DateTime ModifiedDate;
        #endregion

        #region Constructor
        public Producto(int ProductID, string Name, string ProductNumber, bool MakeFlag, bool FinishedGoodsFlag, string Color, short SafetyStockLevel, short ReorderPoint,decimal StandardCost, decimal ListPrice, string size, string SizeUniteMeasureCode, string weightUnit, decimal weight
            ,int daysToManufacturate, string ProductLine, string Class, string Style, int ProductSub, int ProductModel, DateTime start, DateTime end, DateTime discontinued, Guid row, DateTime modified)
        {
            this.ProductID = ProductID;
            this.Class = Class;
            this.Color = Color;
            this.DaysToManufacturate = daysToManufacturate;
            this.DiscontinuedDate = discontinued;
            this.FinishedGoodsFlag = FinishedGoodsFlag;
            this.ListPrice = ListPrice;
            this.MakeFlag = MakeFlag;
            this.ModifiedDate = modified;
            this.Name = Name;
            this.ProductLine = ProductLine;
            this.ProductModelID = ProductModel;
            this.ProductNumber = ProductNumber;
            this.ProductSubcategoryID = ProductSub;
            this.ReorderPoint = ReorderPoint;
            this.rowguid = row;
            this.SafetyStockLevel = SafetyStockLevel;
            this.SellEndDate = end;
            this.SellStartDate = start;
            this.Size = size;
            this.SizeUnitMeasureCode = SizeUniteMeasureCode;
            this.StandardCost = StandardCost;
            this.Style = Style;
            this.Weight = weight;
            this.WeightUnitMeasureCode = weightUnit;
        }
        #endregion
    }
}
