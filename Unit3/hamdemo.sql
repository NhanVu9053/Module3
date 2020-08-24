SELECT*FROM [dbo].[Orders]
SELECT*FROM[dbo].[Order Details] WHERE [OrderID] =10248
SELECT SUM ([UnitPrice]*[Quantity]*(1-[Discount]) )as Amount
FROM [dbo].[Order Details] where OrderID=10248


CREATE FUNCTION FN_PAYMENorder
(
@Order_id int)
RETURNs MONEY
AS
BEGIN
DECLARE @Amount Money
set @Amount=(select SUM ([UnitPrice]*[Quantity]*(1-[Discount]) )as Amount
				from [dbo].[Order Details] where OrderID =@Order_id )
RETURN @Amount
END

CREATE FUNCTION FN_CALCULATORAMOUT
(
@unitPrice money,
@quaniti smallint,
@discout real)
returns money
as
return ([@unitPrice]*[@quaniti]*(1-[@discout]))
end



	CREATE FUNCTION fn_orderdetails(
	@orderID int)
	returns table
	as
return 
	select*from [Order Details] od inner join Products p on od.ProductID= p.ProductID
	where od.OrderID= @orderID