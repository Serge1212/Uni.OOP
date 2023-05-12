CREATE TABLE dbo.CarFeature (
  CarFeature_ID int IDENTITY(1, 1),
  [Name] varchar(512) NOT NULL,
  [Description] varchar(2048),
  CreatedAt datetime NOT NULL,
  ChangedAt datetime,

  CONSTRAINT PK_CarFeature PRIMARY KEY (CarFeature_ID)
);
