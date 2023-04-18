CREATE TABLE [dbo].[Alerts]
(
	[Id] INT NOT NULL PRIMARY KEY,
    EventId INTEGER NOT NULL,
    AlertTime DATETIME NOT NULL,
    AlertDescription TEXT,
    FOREIGN KEY (EventId) REFERENCES Events (Id)
)
