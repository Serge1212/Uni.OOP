namespace Uni.OOP.Interfaces
{
    /// <summary>
    /// The dedicated service for working with cars.
    /// </summary>
    public interface ICarService
    {
        /// <summary>
        /// Shows all cars.
        /// </summary>
        Task ShowAllAsync();

        /// <summary>
        /// Adds a brand new car.
        /// </summary>
        Task AddAsync();
    }
}
