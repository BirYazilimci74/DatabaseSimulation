# DatabaseSimulation
Database Optimization Simulation Program

This project is the second term project of the SE 308 – Advanced Topics in Database Systems course. The goal of the project is to simulate user transactions on the AdventureWorks2022 database and measure the performance with some optimization. 

Three queries were used:

•	1/3 Query: 
Select Order Date, Shipment Address State Name, Shipment Address City Name, Total Order Quantity, Total Order Line Total from Online orders between 1 Jan 2013 and 31 Dec 2013 
``` sql
SELECT SOH.OrderDate,  
       PROV.Name AS StateProvinceName,  
       ADDR.City,  
       SUM(SOD.OrderQty) AS TotalOrderQty,  
       SUM(SOD.LineTotal) AS TotalLineTotal  
  FROM Sales.SalesOrderDetail SOD  
 INNER JOIN Sales.SalesOrderHeader SOH  
    ON SOH.SalesOrderID = SOD.SalesOrderID  
 INNER JOIN Person.Address ADDR  
    ON ADDR.AddressID = SOH.ShipToAddressID  
 INNER JOIN Person.StateProvince PROV  
    ON PROV.StateProvinceID = ADDR.StateProvinceID  
 WHERE SOH.OrderDate BETWEEN '20130101' AND '20131231'  
   AND SOH.OnlineOrderFlag = 1  
 GROUP BY SOH.OrderDate, PROV.Name, ADDR.City  
 ORDER BY SOH.OrderDate, PROV.Name, ADDR.City
```

•	2/3 Query: 
Select Order Date, Product Category Name, Total Order Quantity, Total Order Line Total from Online orders between 1 Jan 2013 and 31 Dec 2013 of the products with MakeFlag = 1 or FinishedGoodsFlag = 1, and color Black or Yellow.
``` sql
SELECT SOH.OrderDate,  
       CAT.Name as CategoryName,  
       SUM(SOD.OrderQty) AS TotalOrderQty,  
       SUM(SOD.LineTotal) AS TotalLineTotal  
  FROM Sales.SalesOrderDetail SOD  
 INNER JOIN Sales.SalesOrderHeader SOH  
    ON SOH.SalesOrderID = SOD.SalesOrderID  
 INNER JOIN Production.Product P  
    ON P.ProductID = SOD.ProductID  
 INNER JOIN Production.ProductSubcategory SUBCAT  
    ON SUBCAT.ProductCategoryID = P.ProductSubcategoryID  
 INNER JOIN Production.ProductCategory CAT  
    ON CAT.ProductCategoryID = SUBCAT.ProductSubcategoryID  
 WHERE SOH.OrderDate BETWEEN '20130101' AND '20131231'  
   AND SOH.OnlineOrderFlag = 1
   AND (P.MakeFlag = 1 OR P.FinishedGoodsFlag = 1)  
   AND P.Color IN ('Black', 'Yellow')  
 GROUP BY SOH.OrderDate, CAT.Name  
 ORDER BY SOH.OrderDate, CAT.Name
```

•	3/3 Query:  
Select Store Name, Product Category Name, Total Order Quantity, Total Order Line Total from orders (not online but from physical stores) between 1 Jan 2013 and 31 Dec 2013 of the products with MakeFlag = 1 or FinishedGoodsFlag = 1, and color Black or Yellow.
``` sql
SELECT STOR.Name as StoreName,  
       CAT.Name as CategoryName,  
       SUM(SOD.OrderQty) AS TotalOrderQty,  
       SUM(SOD.LineTotal) AS TotalLineTotal  
  FROM Sales.SalesOrderDetail SOD
 INNER JOIN Sales.SalesOrderHeader SOH  
    ON SOH.SalesOrderID = SOD.SalesOrderID  
 INNER JOIN Production.Product P
    ON P.ProductID = SOD.ProductID
 INNER JOIN Production.ProductSubcategory SUBCAT
    ON SUBCAT.ProductCategoryID = P.ProductSubcategoryID  
 INNER JOIN Production.ProductCategory CAT  
    ON CAT.ProductCategoryID = SUBCAT.ProductSubcategoryID  
 INNER JOIN Sales.Customer CUST  
    ON CUST.CustomerID = SOH.CustomerID  
 INNER JOIN Sales.Store STOR  
    ON STOR.BusinessEntityID = CUST.StoreID
 WHERE SOH.OrderDate BETWEEN '20130101' AND '20131231'  
   AND SOH.OnlineOrderFlag = 0  
   AND (P.MakeFlag = 1 OR P.FinishedGoodsFlag = 1)  
   AND P.Color IN ('Black', 'Yellow')  
 GROUP BY STOR.Name, CAT.Name  
 ORDER BY STOR.Name, CAT.Name
```

The simulation program is built with multi-threading by using C# and Windows Forms. Each query structure runs at least 100 times. During the simulation, the program measures the time for each thread and the number of effected rows by the queries. 
