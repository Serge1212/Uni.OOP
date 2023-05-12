using Uni.OOP.Models;

namespace Uni.OOP.Interfaces
{
    /// <summary>
    /// The dedicated service for working with car features.
    /// </summary>
    public interface IFeatureService
    {
        /// <summary>
        /// Returns all car features.
        /// </summary>
        Task ShowAllAsync();

        /// <summary>
        /// Adds a brand new feature.
        /// </summary>
        Task AddAsync();
    }
}
