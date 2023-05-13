namespace Uni.OOP.Models
{
    /// <summary>
    /// The car model. Contains all information about a car.
    /// </summary>
    public class Car
    {
        /// <summary>
        /// The car's unique identifier.
        /// </summary>
        public int Id { get; set; }

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
        /// The identifier of the stock where this car is located.
        /// </summary>
        public int StockId { get; set; }

        /// <summary>
        /// The stock information where this car is located.
        /// </summary>
        public Stock Stock { get; set; }

        /// <summary>
        /// The features this car has.
        /// </summary>
        public List<Feature> Features { get; set; }
    }
}
