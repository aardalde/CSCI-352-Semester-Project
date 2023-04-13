CREATE TABLE [dbo].[Events]
(
	[Id] INT NOT NULL PRIMARY KEY, 
    [UserID] INT NOT NULL, 
    [EventDescription] VARCHAR(MAX) NOT NULL, 
    [DueDate] DATETIME2 NOT NULL
	FOREIGN KEY (UserId) REFERENCES Users(Id)
)
