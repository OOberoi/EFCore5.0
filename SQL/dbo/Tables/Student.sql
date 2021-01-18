CREATE TABLE [dbo].[Student] (
    [StudentID] INT        NOT NULL,
    [FirstName] NCHAR (10) NULL,
    [LastName]  NCHAR (10) NULL,
    CONSTRAINT [PK_Student] PRIMARY KEY CLUSTERED ([StudentID] ASC)
);

