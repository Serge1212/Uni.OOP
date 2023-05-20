namespace Uni.OOP.Models.SP
{
    public class CarSpModel
    {
        /// <summary>
        /// The car's unique identifier.
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// The identifier of the stock where this car is located.
        /// </summary>
        public int StockId { get; set; }

        /// <summary>
        /// The car's manufacturer.
        /// </summary>
        public string Make { get; set; }

        /// <summary>
        /// The car's model.
        /// </summary>
        public string Model { get; set; }

        /// <summary>
        /// The car's price.
        /// </summary>
        public decimal Price { get; set; }

        /// <summary>
        /// The date and time this car was produced.
        /// </summary>
        public DateTime ProducedAt { get; set; }

        /// <summary>
        /// The date and time this car was imported.
        /// </summary>
        public DateTime ImportedAt { get; set; }

        /// <summary>
        /// The car's color.
        /// </summary>
        public string Color { get; set; }

        /// <summary>
        /// The car's body type.
        /// </summary>
        public string BodyType { get; set; }

        /// <summary>
        /// The type of engine for this car.
        /// </summary>
        public string EngineType { get; set; }

        /// <summary>
        /// The transmission description of this car.
        /// </summary>
        public string Transmission { get; set; }

        /// <summary>
        /// The fuel efficiency of this car.
        /// </summary>
        public double FuelEfficiency { get; set; }

        /// <summary>
        /// The condition description for this car.
        /// </summary>
        public string Condition { get; set; }

        /// <summary>
        /// The street of related stock.
        /// </summary>
        public string StockStreet { get; set; }

        /// <summary>
        /// The city of related stock.
        /// </summary>
        public string StockCity { get; set; }

        /// <summary>
        /// The country of related stock.
        /// </summary>
        public string StockCountry { get; set; }

        /// <summary>
        /// The postal code of related stock.
        /// </summary>
        public string StockPostalCode { get; set; }

        public Car ToModel()
        {
            return new Car
            {
                Id = Id,
                StockId = StockId,
                Make = Make,
                Model = Model,
                Price = Price,
                ProducedAt = ProducedAt,
                ImportedAt = ImportedAt,
                Color = Color,
                BodyType = BodyType,
                EngineType = EngineType,
                Transmission = Transmission,
                FuelEfficiency = FuelEfficiency,
                Condition = Condition,
                Stock = new Stock
                {
                    Street = StockStreet,
                    City = StockCity,
                    Country = StockCountry,
                    PostalCode = StockPostalCode,
                }
            };
        }
    }
}
