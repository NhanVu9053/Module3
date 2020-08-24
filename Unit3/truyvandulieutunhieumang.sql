--Liệt kê thông tin ID, Họ tên, Tuổi của nhân viên.
SELECT[EmployeeID],CONCAT([FirstName],' ',[FirstName]),ROUND(DATEDIFF(YEAR,[BirthDate],CURRENT_TIMESTAMP),0) AS 'AGE'
FROM[dbo].[Employees]
--Bổ sung thêm thông tin về quốc gia
SELECT[EmployeeID],CONCAT([FirstName],' ',[FirstName]),ROUND(DATEDIFF(YEAR,[BirthDate],CURRENT_TIMESTAMP),0) AS 'AGE',[Country]
FROM[dbo].[Employees]
--Lọc lấy các khách hàng thuộc nước Pháp và Tây Ban Nha cùng mã số hóa đơn khách đã mua trong quý 3 và 4 của năm 1997.
SELECT DATEPART(QUARTER,O.OrderDate) as 'quarter',o.OrderID,
C.CustomerID,c.Country	
FROM [dbo].[Customers] C
INNER JOIN [dbo].[Orders] O ON O.CustomerID= C.CustomerID
WHERE DATEPART(YEAR,O.OrderDate)=1997
		AND C.Country='France' or C.Country='Spain'
GROUP BY C.CustomerID,c.Country,o.OrderID,
		DATEPART(QUARTER,O.OrderDate)
		ORDER BY DATEPART(QUARTER,O.OrderDate)
--Giới hạn lại trong các hóa đơn khách đã mua trong quý 3 và 4 của năm 1997.
SELECT DATEPART(QUARTER,O.OrderDate) as 'quarter',o.OrderID

FROM [dbo].[Customers] C
INNER JOIN [dbo].[Orders] O ON O.CustomerID= C.CustomerID
WHERE DATEPART(YEAR,O.OrderDate)=1997
		
GROUP BY C.CustomerID,c.Country,o.OrderID,
		DATEPART(QUARTER,O.OrderDate)
		ORDER BY DATEPART(QUARTER,O.OrderDate)
--Tính tổng cước phí mỗi khách hàng đã trả cho mỗi nhà chuyên chở. Cước phí: Freight, Nhà chuyên chở: ShipVia/Shipper.	
SELECT O.ShipName, SUM(O.Freight) AS 'TOTAL FREIGHT'
FROM [dbo].[Orders] O
INNER JOIN [dbo].[Shippers] S ON S.ShipperID=O.ShipVia
GROUP BY O.ShipName
--Tính tổng số tiền mỗi khách đã mua trong năm 1997.
SELECT C.CustomerID,SUM(OD.Quantity*OD.UnitPrice) AS 'TOTAL CASH'
FROM[dbo].[Orders] O
INNER JOIN[dbo].[Customers] C ON C.CustomerID=O.CustomerID
INNER JOIN [dbo].[Order Details] OD ON OD.OrderID=O.OrderID
WHERE DATEPART(YEAR,[OrderDate]) =1997
GROUP BY C.CustomerID
--Tính tổng doanh số mỗi nhân viên đã bán được trong năm 1997
SELECT S.EmployeeID,SUM(OD.Quantity*OD.UnitPrice) AS 'TOTAL MONEY'
FROM [dbo].[Orders] O
INNER JOIN [dbo].[Employees] S ON S.EmployeeID=O.EmployeeID
INNER JOIN [dbo].[Order Details] OD ON OD.OrderID=O.OrderID
WHERE DATEPART(YEAR,[OrderDate])=1997
GROUP BY S.EmployeeID
ORDER BY SUM(OD.Quantity*OD.UnitPrice) DESC
--Tính tổng tiền bán được của mỗi loại sản phẩm trong năm 1997? 
SELECT P.ProductID,P.ProductName,SUM(OD.Quantity*OD.UnitPrice) AS 'TOTAL MONEY'
FROM[dbo].[Orders] O
INNER JOIN[dbo].[Order Details] OD ON OD.OrderID=O.OrderID
INNER JOIN [dbo].[Products] P ON P.ProductID=OD.ProductID
WHERE DATEPART(YEAR, [OrderDate])=1997
GROUP BY P.ProductID,P.ProductName
ORDER BY P.ProductID
--Từng quý năm 1997?
SELECT DATEPART(QUARTER, [OrderDate])AS 'QUARTER', P.ProductID,P.ProductName,SUM(OD.Quantity*OD.UnitPrice) AS 'TOTAL MONEY'
FROM[dbo].[Orders] O
INNER JOIN[dbo].[Order Details] OD ON OD.OrderID=O.OrderID
INNER JOIN [dbo].[Products] P ON P.ProductID=OD.ProductID
WHERE DATEPART(YEAR, [OrderDate])=1997
GROUP BY DATEPART(QUARTER, [OrderDate]), P.ProductID,P.ProductName
ORDER BY DATEPART(QUARTER, [OrderDate])
--Liệt kê các quốc gia có trên 3 khách hàng
SELECT [Country],COUNT([Country])
FROM[dbo].[Customers] 
GROUP BY  [Country]
HAVING COUNT([Country])>3
--Liệt kê loại sản phẩm có nhiều sản phẩm nhất
SELECT TOP(1)
C.CategoryID,C.CategoryName,P.ProductName,P.QuantityPerUnit
FROM [dbo].[Categories] C
INNER JOIN [dbo].[Products] P ON P.CategoryID= C.CategoryID
GROUP BY C.CategoryID,C.CategoryName,P.ProductName,P.QuantityPerUnit
ORDER BY C.CategoryID DESC
--Liệt kê tên khách hàng mua hàng nhiều nhất trong năm 1997? Trong mỗi năm?
DECLARE @tbYear TABLE([Year] INT)
DECLARE @tbData TABLE([Year] INT, CustomerId NCHAR(5), Price FLOAT)
DECLARE @tbResult TABLE([Year] INT, CustomerId NCHAR(5), Price FLOAT)
INSERT INTO @tbData SELECT
		YEAR(O.OrderDate) year,
		o.CustomerID,
		SUM((1 - Discount) * OD.UnitPrice * Quantity) price
FROM dbo.Orders O
INNER JOIN dbo.[Order Details] OD ON OD.OrderID = O.OrderID
GROUP BY
		YEAR(O.OrderDate),
		o.CustomerID
ORDER BY price DESC
INSERT INTO @tbYear SELECT DISTINCT YEAR(OrderDate) FROM dbo.Orders
WHILE(EXISTS(SELECT * FROM @tbYear))
BEGIN
	DECLARE @year INT = (SELECT TOP(1) [year] FROM @tbYear)
	INSERT INTO @tbResult SELECT TOP(1) * FROM @tbData WHERE [year] = @year
	ORDER BY Price DESC
	DELETE FROM @tbYear WHERE [year] = @year
END
SELECT * FROM @tbResult