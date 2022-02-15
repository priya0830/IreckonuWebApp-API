CREATE TABLE [dbo].[Product]
(
	[Key] NVARCHAR(50) NOT NULL PRIMARY KEY, 
    [ArtikelCode] INT NOT NULL, 
    [Price] INT NOT NULL, 
    [DiscountPrice] INT NOT NULL, 
    [DeliveredIn] NVARCHAR(MAX) NOT NULL, 
    [Size] INT NOT NULL
)
