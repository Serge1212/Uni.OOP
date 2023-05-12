namespace Uni.OOP.Models.SP
{
    public class FeatureSpModel
    {
        /// <summary>
        /// The feature's unique identifier.
        /// </summary>
        public int CarFeature_ID { get; set; }

        /// <summary>
        /// The name of this feature.
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// The description of this feature.
        /// </summary>
        public string Description { get; set; }

        /// <summary>
        /// The date and time this feature was created.
        /// </summary>
        public DateTime CreatedAt { get; set; }

        /// <summary>
        /// The date and time this feature was last changed.
        /// </summary>
        public DateTime? ChangedAt { get; set; }

        public Feature ToModel()
        {
            return new Feature
            {
                Id = CarFeature_ID,
                Name = Name,
                Description = Description,
            };
        }
    }
}
