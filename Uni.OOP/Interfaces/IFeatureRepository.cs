using Uni.OOP.Models;

namespace Uni.OOP.Interfaces
{
    /// <summary>
    /// The dedicated repo for working with car features.
    /// </summary>
    public interface IFeatureRepository
    {
        /// <summary>
        /// Adds a brand new car feature.
        /// </summary>
        Task AddAsync(Feature feature);
    }
}
