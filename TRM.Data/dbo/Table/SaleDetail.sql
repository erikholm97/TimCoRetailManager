﻿CREATE TABLE [dbo].[SaleDetail]
(
	[Id] INT NOT NULL PRIMARY KEY, 
    [SaleId] INT NOT NULL, 
    [Quantity] INT NOT NULL DEFAULT 1,
    [ProductId] INT NOT NULL, 
    [PurchasePrice] MONEY NOT NULL, 
    [Tax] MONEY NULL DEFAULT 0, 
    CONSTRAINT [FK_SaleDetail_ToSale] FOREIGN KEY (SaleId) REFERENCES Sale([Id]), 
    CONSTRAINT [FK_SaleDetail_ToProduct] FOREIGN KEY (ProductId) REFERENCES Product(Id), 
)
