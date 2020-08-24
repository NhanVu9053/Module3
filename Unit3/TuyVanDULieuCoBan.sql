

--how may custumer?
SELECT COUNT([CustomerID]) FROM[dbo].[Customers]
--HOW MANY CATALOGUE? HOW MANY PRODUCTS?
SELECT COUNT ([ProductID]) FROM [dbo].[Products]
SELECT *FROM [dbo].[Products];
SELECT [ProductName],[QuantityPerUnit] FROM [dbo].[Products]
--Thông tin nhân viên. Có bao nhiêu nhân viên (Employee)?
-- Nâng cao: bạn có thể truy vấn được tên người quản lý (là người được nhân viên báo cáo) không?
SELECT CONCAT([LastName],' ',[FirstName],' ',[Address])FROM [dbo].[Employees];
SELECT COUNT([EmployeeID]) FROM [dbo].[Employees];
-- Thông tin các nhà cung cấp (supplier). Có bao nhiêu nhà cung cấp.
SELECT COUNT([SupplierID]) FROM [dbo].[Suppliers];
SELECT CONCAT([CompanyName],' ',[ContactName],' ',[Address]) FROM [dbo].[Suppliers]
--Đơn hàng (order) được lưu trữ gồm những năm nào?
SELECT DATENAME(YEAR,C.OrderDate) as nam FROM [dbo].[Orders] AS C GROUP BY DATENAME(YEAR,C.OrderDate);
--. Khách hàng thường sống ở những quốc gia nào?
SELECT[Country] FROM[dbo].[Customers];
-- Những quốc gia nào có nhà cung cấp?
SELECT [Country] FROM [dbo].[Suppliers];
--Liệt kê các khách hàng không có số Fax?
SELECT[CompanyName] FROM[dbo].[Customers]WHERE[Fax] IS NULL ;
--Liệt kê các khách hàng sống ở Pháp. Liệt kê các khách hang sống ở Pháp và Tây Ban Nha
SELECT[CompanyName],[Country] FROM[dbo].[Customers]WHERE[Country]='France' or [Country]='Spain';
-- Liệt kê các khách hàng không sống ở Châu Mỹ
SELECT[CompanyName],[Country] FROM[dbo].[Customers]WHERE[Region] IS  NULL;
--Liệt kê các hóa đơn của năm 1997
SELECT*FROM [dbo].[Orders];
SELECT [OrderID],[OrderDate],[RequiredDate],[ShippedDate]FROM[dbo].[Orders] AS C WHERE DATENAME(YEAR,[OrderDate])=1997
--Liệt kê 3 hóa đơn mới nhất
SELECT TOP 3 [OrderID] FROM [dbo].[Orders] ORDER BY [OrderDate] DESC
--Liệt kê các hóa đơn có cước phí >100$. Tìm hóa đơn có cước phí cao nhất, thấp nhất.
SELECT*FROM[dbo].[Orders] WHERE [Freight] =(SELECT MAX([Freight])FROM[dbo].[Orders] )
-- Đếm số hóa đơn bán được của năm 1996, 1997 và cả 2 năm 1996, 1997
SELECT COUNT([OrderID]) AS '1996' FROM[dbo].[Orders]  WHERE DATENAME(YEAR,[OrderDate])=1996 
SELECT COUNT([OrderID]) AS '1997' FROM[dbo].[Orders]  WHERE DATENAME(YEAR,[OrderDate])=1997
SELECT COUNT([OrderID]) AS '1996 +1997' FROM[dbo].[Orders]  WHERE DATENAME(YEAR,[OrderDate])=1996 OR DATENAME(YEAR,[OrderDate])=1997
--Tính đơn giá bình quân của tất cả sản phẩm, của sản phẩm thuộc loại hải sản (mã loại là 8)
SELECT*FROM[dbo].[Products]
SELECT AVG([UnitPrice]) as ' avarge price' FROM [dbo].[Products]
SELECT AVG([UnitPrice]) as ' avarge price' FROM [dbo].[Products] WHERE [ProductID]=8
--Liệt kê 3 sản phẩm có đơn giá mắc nhất.
SELECT TOP 3* FROM [dbo].[Products] ORDER BY [UnitPrice] DESC
--Liệt kê các sản phẩm có tên bắt đầu bằng ký tự N? Bắt đầu bằng ký tự N
--hoặc A? Liệt kê các sản phẩm có tên không bắt đầu bằng N? Không bắt đầu bằng N và A?
SELECT[ProductName] FROM[dbo].[Products] WHERE [ProductName] LIKE '%N'
SELECT[ProductName] FROM[dbo].[Products] WHERE [ProductName] LIKE 'N%'
SELECT[ProductName] FROM[dbo].[Products] WHERE [ProductName] NOT IN (SELECT[ProductName] FROM[dbo].[Products] WHERE [ProductName] LIKE '%N'
AND [ProductName] LIKE 'N%')
--Liệt kê các sản phẩm có đơn giá từ 100 đến 200
SELECT *FROM [dbo].[Products] WHERE [UnitPrice] BETWEEN 100 AND 200
--. Liệt kê các sản phẩm có số lượng tồn kho (units in stock) thấp hơn định mức
--tồn kho tối thiểu (reorder level)
SELECT*FROM [dbo].[Products]
SELECT*FROM [dbo].[Products] WHERE [UnitsInStock]<[ReorderLevel];
--Tính số sản phẩm được cung cấp bởi nhà cung cấp Tokyo Traders (có mã là 4)
SELECT COUNT([ProductID] ) AS ' TOKYO TRADER OF PROUCTS' FROM [dbo].[Products] WHERE [SupplierID]=4;





