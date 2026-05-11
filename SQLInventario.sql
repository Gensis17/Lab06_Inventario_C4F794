CREATE TABLE [dbo].[Productos] (
    [Id] INT IDENTITY (1,1) NOT NULL,
    [Nombre] NVARCHAR(100) NOT NULL,
    [Categoria] NVARCHAR(100) NOT NULL,
    [Precio] FLOAT(53) NOT NULL,
    [Stock] INT NOT NULL,
    CONSTRAINT [PK_Productos] PRIMARY KEY CLUSTERED ([Id] ASC)
);