CREATE TABLE dbo.Stock (
  Stock_ID int IDENTITY(1, 1),
  Street varchar(1024) NOT NULL,
  Region varchar(512) NOT NULL,
  City varchar(512),
  Country varchar(512),
  PostalCode varchar(512),

  CONSTRAINT PK_Stock PRIMARY KEY (Stock_ID)
);
