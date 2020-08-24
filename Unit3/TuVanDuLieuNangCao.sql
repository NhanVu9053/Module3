SELECT [OrderID] ,[RequiredDate],[ShippedDate] FROM [dbo].[Orders] 
-- Liệt kê thông tin các hóa đơn bao gồm số hóa đơn, ngày và ngày giao hàng trong tháng 7/1997?  
SELECT [OrderID] ,[RequiredDate],[ShippedDate] FROM [dbo].[Orders]
WHERE [RequiredDate]BETWEEN '1997-07-01' AND '1997-07-31'AND[ShippedDate] BETWEEN '1997-07-01' AND '1997-07-31'

SELECT [OrderID] ,[RequiredDate],[ShippedDate] FROM [dbo].[Orders]
WHERE [RequiredDate]BETWEEN '1997-07-01' AND '1997-07-31'AND[ShippedDate] BETWEEN '1997-07-01' AND '1997-07-31'
--Trong quý 1 năm 1997?
SELECT [OrderID] ,[RequiredDate],[ShippedDate] FROM [dbo].[Orders]
WHERE [RequiredDate]BETWEEN '1997-01-01' AND '1997-03-31'AND[ShippedDate] BETWEEN '1997-01-01' AND '1997-03-31'
--Trong nữa tháng đầu tiên của tháng 7/1997?
SELECT [OrderID] ,[RequiredDate],[ShippedDate] FROM [dbo].[Orders]
WHERE [OrderDate] BETWEEN '1997-07-01' AND '1997-07-15'AND[ShippedDate] BETWEEN '1997-07-01' AND '1997-07-15'
--Liệt kê thông tin STT, Tên, Ngày sinh của nhân viên
SELECT[EmployeeID], CONCAT([FirstName],' ',[LastName])AS 'NAME',[Address] FROM [dbo].[Employees]
--Liệt kê các khách hàng đã mua hàng trong năm 1997
SELECT*FROM[dbo].[Customers]
SELECT*FROM [dbo].[Customers] INNER JOIN [dbo].[Orders] ON Customers.CustomerID=Orders.CustomerID WHERE DATENAME(YEAR,[OrderDate])=1997
--Liệt kê các sản phẩm do công ty Exotic Liquids cung cấp trong năm 1997 và 1998
SELECT DISTINCT P.ProductName FROM Products P
INNER JOIN Suppliers S
ON S.SupplierID = P.SupplierID
INNER JOIN [dbo].[Order Details] OD
ON OD.ProductID = P.ProductID
INNER JOIN Orders O
ON O.OrderID = OD.OrderID
WHERE S.CompanyName = 'Exotic Liquids'
AND (DATENAME(YEAR,O.OrderDate) = '1997'OR DATENAME(YEAR,O.OrderDate) = '1998')
-- Liệt kê chi tiết về ID, Tên sản phẩm, Số lượng, Đơn giá, Giảm giá, Thành tiền (trước giảm giá) của các đơn đặt hàng
--8. Tính tổng doanh thu bán hàng:

 -- a. Theo từng năm
 SELECT DATEPART(YEAR,O.OrderDate) AS 'QUARTER',
  ROUND(SUM((1-OD.Discount)*OD.Quantity*OD.UnitPrice),1) AS 'AMOUT'
  FROM Orders O
  INNER JOIN [dbo].[Order Details] OD ON OD.OrderID = O.OrderID
  
  GROUP BY DATEPART(YEAR,O.OrderDate)
  ORDER BY DATEPART(YEAR,O.OrderDate)
--  b. Theo từng quý năm 1997 
SELECT DATEPART(QUARTER,O.OrderDate) AS 'QUARTER',
  ROUND(SUM((1-OD.Discount)*OD.Quantity*OD.UnitPrice),1) AS 'AMOUT'
  FROM Orders O
  INNER JOIN [dbo].[Order Details] OD ON OD.OrderID = O.OrderID
  WHERE YEAR(O.OrderDate) = '1997'
  GROUP BY DATEPART(QUARTER,O.OrderDate)
  ORDER BY DATEPART(QUARTER,O.OrderDate)
  --Đếm số hóa đơn bán được trong mỗi năm
  SELECT 
  COUNT( O.OrderID),
  DATEPART(YEAR,O.OrderDate)
  FROM Orders O
  GROUP BY DATEPART(YEAR,O.OrderDate)
  --Tính tổng doanh số bán hàng của mỗi nhân viên trong năm 1997.
  SELECT DATEPART(YEAR,O.OrderDate) AS 'YEAR',
  ROUND(SUM((1-OD.Discount)*OD.Quantity*OD.UnitPrice),1) AS 'AMOUT',
  CONCAT([FirstName],' ',[LastName])
  FROM Orders O
  INNER JOIN [dbo].[Order Details] OD ON OD.OrderID = O.OrderID
  INNER JOIN [dbo].[Employees] E ON E.EmployeeID= O.EmployeeID
 WHERE DATEPART(YEAR , O.OrderDate)='1997'
  GROUP BY DATEPART(YEAR,O.OrderDate), CONCAT([FirstName],' ',[LastName])
  ORDER BY DATEPART(YEAR,O.OrderDate)
  -- Tìm nhân viên có doanh số bán hàng cao nhất.
   SELECT TOP 1
   DATEPART(YEAR,O.OrderDate) AS 'YEAR',
  ROUND(SUM((1-OD.Discount)*OD.Quantity*OD.UnitPrice),1) AS 'AMOUT',
  CONCAT([FirstName],' ',[LastName])
  FROM Orders O
  INNER JOIN [dbo].[Order Details] OD ON OD.OrderID = O.OrderID
  INNER JOIN [dbo].[Employees] E ON E.EmployeeID= O.EmployeeID
 WHERE DATEPART(YEAR , O.OrderDate)='1997'
  GROUP BY DATEPART(YEAR,O.OrderDate), CONCAT([FirstName],' ',[LastName])
  ORDER BY  ROUND(SUM((1-OD.Discount)*OD.Quantity*OD.UnitPrice),1) DESC
  
  
