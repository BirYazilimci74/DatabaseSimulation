using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Advanced_Database_Topics_II
{
    public class DatabaseOperations
    {
        private const string QUERY1 = "SELECT SOH.OrderDate," +
            "                                 PROV.Name AS StateProvinceName, " +
            "                                 ADDR.City," +
            "                                 SUM(SOD.OrderQty) AS TotalOrderQty," +
            "                                 SUM(SOD.LineTotal) AS TotalLineTotal " +
            "                            FROM Sales.SalesOrderDetail SOD " +
            "                           INNER JOIN Sales.SalesOrderHeader SOH" +
            "                              ON SOH.SalesOrderID = SOD.SalesOrderID " +
            "                           INNER JOIN Person.Address ADDR " +
            "                              ON ADDR.AddressID = SOH.ShipToAddressID " +
            "                           INNER JOIN Person.StateProvince PROV " +
            "                              ON PROV.StateProvinceID = ADDR.StateProvinceID " +
            "                           WHERE SOH.OrderDate BETWEEN '20130101' AND '20131231' " +
            "                             AND SOH.OnlineOrderFlag = 1 " +
            "                           GROUP BY SOH.OrderDate, PROV.Name, ADDR.City " +
            "                           ORDER BY SOH.OrderDate, PROV.Name, ADDR.City";
        
        private const string QUERY2 = "SELECT SOH.OrderDate, " +
            "                                 CAT.Name as CategoryName, " +
            "                                 SUM(SOD.OrderQty) AS TotalOrderQty, " +
            "                                 SUM(SOD.LineTotal) AS TotalLineTotal " +
            "                            FROM Sales.SalesOrderDetail SOD " +
            "                           INNER JOIN Sales.SalesOrderHeader SOH " +
            "                              ON SOH.SalesOrderID = SOD.SalesOrderID " +
            "                           INNER JOIN Production.Product P " +
            "                              ON P.ProductID = SOD.ProductID " +
            "                           INNER JOIN Production.ProductSubcategory SUBCAT " +
            "                              ON SUBCAT.ProductCategoryID = P.ProductSubcategoryID " +
            "                           INNER JOIN Production.ProductCategory CAT " +
            "                              ON CAT.ProductCategoryID = SUBCAT.ProductSubcategoryID " +
            "                           WHERE SOH.OrderDate BETWEEN '20130101' AND '20131231' " +
            "                             AND SOH.OnlineOrderFlag = 1 " +
            "                             AND (P.MakeFlag = 1 OR P.FinishedGoodsFlag = 1) " +
            "                             AND P.Color IN ('Black', 'Yellow') " +
            "                           GROUP BY SOH.OrderDate, CAT.Name " +
            "                           ORDER BY SOH.OrderDate, CAT.Name";
        
        private const string QUERY3 = "SELECT STOR.Name as StoreName, " +
            "                                 CAT.Name as CategoryName, " +
            "                                 SUM(SOD.OrderQty) AS TotalOrderQty, " +
            "                                 SUM(SOD.LineTotal) AS TotalLineTotal " +
            "                            FROM Sales.SalesOrderDetail SOD " +
            "                           INNER JOIN Sales.SalesOrderHeader SOH " +
            "                              ON SOH.SalesOrderID = SOD.SalesOrderID " +
            "                           INNER JOIN Production.Product P " +
            "                              ON P.ProductID = SOD.ProductID " +
            "                           INNER JOIN Production.ProductSubcategory SUBCAT " +
            "                              ON SUBCAT.ProductCategoryID = P.ProductSubcategoryID " +
            "                           INNER JOIN Production.ProductCategory CAT " +
            "                              ON CAT.ProductCategoryID = SUBCAT.ProductSubcategoryID " +
            "                           INNER JOIN Sales.Customer CUST " +
            "                              ON CUST.CustomerID = SOH.CustomerID " +
            "                           INNER JOIN Sales.Store STOR " +
            "                              ON STOR.BusinessEntityID = CUST.StoreID " +
            "                           WHERE SOH.OrderDate BETWEEN '20130101' AND '20131231' " +
            "                             AND SOH.OnlineOrderFlag = 0 " +
            "                             AND (P.MakeFlag = 1 OR P.FinishedGoodsFlag = 1) " +
            "                             AND P.Color IN ('Black', 'Yellow') " +
            "                           GROUP BY STOR.Name, CAT.Name " +
            "                           ORDER BY STOR.Name, CAT.Name";

        private readonly string _connectionString = "Data Source=localhost\\SQLEXPRESS;Initial Catalog=AdventureWorks2022;Integrated Security=True;MultipleActiveResultSets=True;Connect Timeout=120;Max Pool Size=100000;";


    }
}
