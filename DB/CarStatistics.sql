CREATE TABLE [dbo].[CarStatistics]
(
	[Id] INT NOT NULL PRIMARY KEY,
	CarId nvarchar(16) NOT NULL,
	t datetimeoffset(7) NOT NULL,
	VelocitaMedia decimal(18,3) NOT NULL,
	VelocitaMassima decimal(18,3) NOT NULL
)
