# DatabaseSimulation
Database Optimization Simulation Program

This project is the second term project of the SE 308 – Advanced Topics in Database Systems course. The goal of the project is to simulate user transactions on the AdventureWorks2022 database and measure the performance with some optimization. 

Three queries were used:

•	1/3 Query: 
Select Order Date, Shipment Address State Name, Shipment Address City Name, Total Order Quantity, Total Order Line Total from Online orders between 1 Jan 2013 and 31 Dec 2013 
<pre> ```sql SELECT  SOH.OrderDate,  
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
ORDER BY SOH.OrderDate, PROV.Name, ADDR.City ``` </pre>


•	2/3 Query: 
Select Order Date, Product Category Name, Total Order Quantity, Total Order Line Total from Online orders between 1 Jan 2013 and 31 Dec 2013 of the products with MakeFlag = 1 or FinishedGoodsFlag = 1, and color Black or Yellow.

•	3/3 Query:  
Select Store Name, Product Category Name, Total Order Quantity, Total Order Line Total from orders (not online but from physical stores) between 1 Jan 2013 and 31 Dec 2013 of the products with MakeFlag = 1 or FinishedGoodsFlag = 1, and color Black or Yellow.


The simulation program is built with multi-threading by using C# and Windows Forms. Each query structure runs at least 100 times. During the simulation, the program measures the time for each thread and the number of effected rows by the queries. 
