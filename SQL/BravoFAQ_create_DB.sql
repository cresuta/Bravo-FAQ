USE [master]

IF db_id('Bravo-FAQ') IS NULl
  CREATE DATABASE [Bravo-FAQ]
GO

USE [Bravo-FAQ]
GO


DROP TABLE IF EXISTS [Question];
DROP TABLE IF EXISTS [Answer];

GO

CREATE TABLE [Question] (
  [Id] integer PRIMARY KEY IDENTITY,
  [Content] nvarchar(255) NOT NULL
)

CREATE TABLE [Answer] (
  [Id] integer PRIMARY KEY IDENTITY,
  [Content] nvarchar(50) NOT NULL,
  [QuestionId] integer not null

  CONSTRAINT FK_Answer_Question FOREIGN KEY([QuestionId]) REFERENCES [Question] ([Id])
)

GO