CREATE OR ALTER PROCEDURE dbo.ins_CarFeature
  @FeatureName varchar(512),
  @Description varchar(2048)

AS
  SET NOCOUNT ON;

  DECLARE @Now datetime = GetDate();

  INSERT INTO dbo.CarFeature
  ([Name], [Description], CreatedAt)
  VALUES
    ( @FeatureName, @Description, @Now);

GO
