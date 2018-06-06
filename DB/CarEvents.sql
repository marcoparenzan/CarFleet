CREATE TABLE [dbo].[CarEvents]
(
	[Id] INT NOT NULL PRIMARY KEY,
	[CarId] nvarchar(16) NOT NULL, 
    [Velocita] DECIMAL(18, 3) NOT NULL, 
    [t] DATETIMEOFFSET NOT NULL

)
