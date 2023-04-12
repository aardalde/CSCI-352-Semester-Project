﻿CREATE TABLE [dbo].[Events]
(
	[Id] INT NOT NULL PRIMARY KEY, 
    [UserID] INT NOT NULL, 
    [EventDescription] VARCHAR(MAX) NOT NULL, 
    [DateTime] DATETIME2(7) NOT NULL
	FOREIGN KEY (Id) REFERENCES UserID(Id)
)
