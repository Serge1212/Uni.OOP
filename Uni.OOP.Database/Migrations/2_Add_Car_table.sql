DECLARE @TableName varchar(50) = 'dbo.Car';

PRINT 'Adding ' + @TableName +' table.';

IF OBJECT_ID(@TableName, 'U') IS NULL
  BEGIN
    CREATE TABLE dbo.Car (
      Car_ID int IDENTITY(1, 1),
      StockFID int,
      Make varchar(512) NOT NULL,
      Model varchar(512) NOT NULL,
      Price money NOT NULL,
      ProducedAt datetime NOT NULL,
      ImportedAt datetime NOT NULL,
      Color varchar(512) NOT NULL,
      BodyType varchar(512),
      EngineType varchar(512),
      Transmission varchar(512),
      FuelEfficiency varchar(512),
      Condition varchar(2048) NOT NULL,
      CreatedAt datetime NOT NULL,
      ChangedAt datetime,

      CONSTRAINT PK_Car PRIMARY KEY (Car_ID)
    );

    ALTER TABLE dbo.Car
    ADD CONSTRAINT FK_Car_Stock FOREIGN KEY (StockFID)
    REFERENCES dbo.Stock (Stock_ID);
  END
ELSE
  PRINT 'The table already exists.';

GO
