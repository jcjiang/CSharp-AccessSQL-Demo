DROP DATABASE IF EXISTS [Blogging];
GO

CREATE DATABASE [Blogging];
GO

USE [Blogging];
GO

CREATE TABLE [Blogs](
	[BlogId] int IDENTITY NOT NULL,
	[Url] nvarchar(max) NOT NULL
)
GO

CREATE TABLE [Posts](
	[PostId] int IDENTITY NOT NULL,
	[Title] nvarchar(max) NOT NULL,
	[Content] nvarchar(max) NOT NULL,
	[BlogId] int NOT NULL
)
GO

INSERT INTO [Blogs] (Url) VALUES ('https://devblogs.microsoft.com/dotnet/tag/entity-framework-core/');
INSERT INTO [Blogs] (Url) VALUES ('https://devblogs.microsoft.com/dotnet/category/aspnet/');
INSERT INTO [Blogs] (Url) VALUES ('http://blogs.msdn.com/adonet');
GO
