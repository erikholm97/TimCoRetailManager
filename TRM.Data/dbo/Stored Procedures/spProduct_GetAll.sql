CREATE PROCEDURE [dbo].[spProduct_GetAll]	
AS
begin
	set nocount on;
	
	select  Id, ProductName, [Description], RetailPrice, Quantity
	from dbo.Product
	order by ProductName
end
