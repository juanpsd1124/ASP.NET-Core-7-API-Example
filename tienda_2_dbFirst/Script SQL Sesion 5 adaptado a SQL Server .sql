
CREATE TABLE Categoria (
  Id int NOT NULL IDENTITY(1,1),
  Nombre varchar(100) NOT NULL,
  PRIMARY KEY (Id)
);

CREATE TABLE Marca (
  Id int NOT NULL IDENTITY(1,1),
  Nombre varchar(100) NOT NULL,
  PRIMARY KEY (Id)
) ;

CREATE TABLE Producto (
  Id int NOT NULL IDENTITY(1,1),
  Nombre varchar(100) NOT NULL,
  Precio decimal(18,2) NOT NULL,
  FechaCreacion DATETIME NOT NULL,
  CategoriaId int NOT NULL DEFAULT '0',
  MarcaId int NOT NULL DEFAULT '0',
  PRIMARY KEY (Id),
  INDEX IX_Producto_CategoriaId (CategoriaId),
  INDEX IX_Producto_MarcaId (MarcaId),
  CONSTRAINT FK_Producto_Categoria_CategoriaId FOREIGN KEY (CategoriaId) REFERENCES Categoria (Id) ON DELETE CASCADE,
  CONSTRAINT FK_Producto_Marca_MarcaId FOREIGN KEY (MarcaId) REFERENCES Marca (Id) ON DELETE CASCADE
);


