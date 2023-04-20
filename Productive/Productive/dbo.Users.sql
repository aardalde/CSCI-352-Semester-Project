CREATE TABLE [dbo].[Users] (
    [Id]       UNIQUEIDENTIFIER DEFAULT (newid()) NOT NULL,
    [Username] VARCHAR (50)     NOT NULL,
    [Password] VARCHAR (255)    NOT NULL,
    PRIMARY KEY CLUSTERED ([Id] ASC)
);