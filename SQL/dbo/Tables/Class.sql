CREATE TABLE [dbo].[Class] (
    [ClassID]     INT        NOT NULL,
    [Title]       NCHAR (10) NULL,
    [Description] NCHAR (25) NULL,
    CONSTRAINT [PK_Class] PRIMARY KEY CLUSTERED ([ClassID] ASC)
);

