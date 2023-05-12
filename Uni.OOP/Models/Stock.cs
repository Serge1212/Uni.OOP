namespace Uni.OOP.Models
{
    /// <summary>
    /// The model that has information about cars stock.
    /// </summary>
    public class Stock
    {
        /// <summary>
        /// The unique identifier for this stock.
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// The street where this stock's located.
        /// </summary>
        public string Street { get; set; }

        /// <summary>
        /// The city where this stock's located.
        /// </summary>
        public string City { get; set; }

        /// <summary>
        /// The country where this stock's located.
        /// </summary>
        public string Country { get; set; }

        /// <summary>
        /// The postal code of this stock's location.
        /// </summary>
        public string PostalCode { get; set; }
    }
}
