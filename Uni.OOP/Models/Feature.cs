namespace Uni.OOP.Models
{
    /// <summary>
    /// The feature of a car.
    /// </summary>
    public class Feature
    {
        /// <summary>
        /// The feature's unique identifier.
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// The name of this feature.
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// The description of this feature.
        /// </summary>
        public string Description { get; set; }
    }
}
