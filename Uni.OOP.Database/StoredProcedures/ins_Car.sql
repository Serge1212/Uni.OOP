CREATE OR ALTER PROCEDURE dbo.ins_Car
  @StockFID int,
  @Make varchar(512),
  @Model varchar(512),
  @Price money,
  @ProducedAt datetime,
  @ImportedAt datetime,
  @Color varchar(512),
  @BodyType varchar(512),
  @EngineType varchar(512),
  @Transmission varchar(512),
  @FuelEfficiency float,
  @Condition varchar(2048)
AS
  SET NOCOUNT ON;

  IF ( @Make IS NULL OR
       @Model IS NULL OR
       @Price IS NULL OR
       @ProducedAt IS NULL OR
       @ImportedAt IS NULL OR
       @Color IS NULL OR
       @Condition IS NULL)
    BEGIN
      RAISERROR('Parameters cannot be null.', 16, 1)
      RETURN
    END

  DECLARE @Now datetime = GetDate();

  INSERT INTO dbo.Car
  ( StockFID,
    Make,
    Model,
    Price,
    ProducedAt,
    ImportedAt,
    Color,
    BodyType,
    EngineType,
    Transmission,
    FuelEfficiency,
    Condition,
    CreatedAt )
  VALUES
  ( @StockFID,
    @Make,
    @Model,
    @Price,
    @ProducedAt,
    @ImportedAt,
    @Color,
    @BodyType,
    @EngineType,
    @Transmission,
    @FuelEfficiency,
    @Condition,
    @Now );

GO
