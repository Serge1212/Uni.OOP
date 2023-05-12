CREATE TABLE dbo.Car_CarFeature (
  Car_CarFeature_ID int IDENTITY(1, 1),
  CarFID int,
  CarFeatureFID int,
  CreatedAt datetime NOT NULL,
  ChangedAt datetime,

  CONSTRAINT PK_Car_CarFeature PRIMARY KEY (Car_CarFeature_ID)
);
