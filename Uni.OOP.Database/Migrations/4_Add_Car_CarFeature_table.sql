DECLARE @TableName varchar(50) = 'dbo.Car_CarFeature';

PRINT 'Adding ' + @TableName +' table.';

IF OBJECT_ID(@TableName, 'U') IS NULL
  BEGIN
    CREATE TABLE dbo.Car_CarFeature (
      Car_CarFeature_ID int IDENTITY(1, 1),
      CarFID int,
      CarFeatureFID int,
      CreatedAt datetime NOT NULL,
      ChangedAt datetime,
    
      CONSTRAINT PK_Car_CarFeature PRIMARY KEY (Car_CarFeature_ID)
    );

    ALTER TABLE dbo.Car_CarFeature
      ADD
        CONSTRAINT FK_Car_CarFeature_Car FOREIGN KEY (CarFID)
          REFERENCES dbo.Car (Car_ID),
        CONSTRAINT FK_Car_CarFeature_Feature FOREIGN KEY (CarFeatureFID)
          REFERENCES dbo.CarFeature (CarFeature_ID);
  END
ELSE
  PRINT 'The table already exists.';

GO
