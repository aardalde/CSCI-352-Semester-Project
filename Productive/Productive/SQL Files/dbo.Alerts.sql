﻿CREATE TABLE [dbo].[Alerts]
(
	[Id] INT NOT NULL PRIMARY KEY, 
    [EventID] INT NULL
	FOREIGN KEY (EventId) REFERENCES Events(Id)
)
