CREATE OR ALTER PROCEDURE dbo.sel_Car

AS
  SET NOCOUNT ON;

  SELECT
    C.Car_ID AS Id,
    C.StockFID AS StockId,
    C.Make,
    C.Model,
    C.Price,
    C.ProducedAt,
    C.ImportedAt,
    C.Color,
    C.BodyType,
    C.EngineType,
    C.Transmission,
    C.FuelEfficiency,
    C.Condition,
    S.Street AS StockStreet,
    S.City AS StockCity,
    S.Country AS StockCountry,
    S.PostalCode AS StockPostalCode
  FROM dbo.Car AS C
  JOIN dbo.Stock AS S
    ON C.StockFID = S.Stock_ID

GO
