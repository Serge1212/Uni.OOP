namespace Uni.OOP.Interfaces
{
    /// <summary>
    /// The dedicated service for working with car features.
    /// </summary>
    public interface IFeatureService
    {
        /// <summary>
        /// Adds a brand new feature.
        /// </summary>
        Task AddAsync();
    }
}
