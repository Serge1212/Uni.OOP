CREATE TABLE dbo.Car (
  Car_ID int IDENTITY(1, 1),
  Stock_FID int,
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

  CONSTRAINT PK_Car PRIMARY KEY (Car_ID)
);
