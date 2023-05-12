ALTER TABLE dbo.Car
  ADD CONSTRAINT FK_Car_Stock FOREIGN KEY (StockFID)
    REFERENCES dbo.Stock (Stock_ID);

ALTER TABLE dbo.Car_CarFeature
  ADD
    CONSTRAINT FK_Car_CarFeature_Car FOREIGN KEY (CarFID)
      REFERENCES dbo.Car (Car_ID),
    CONSTRAINT FK_Car_CarFeature_Feature FOREIGN KEY (CarFeatureFID)
      REFERENCES dbo.CarFeature (CarFeature_ID);
