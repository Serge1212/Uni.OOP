using Uni.OOP.Models;

namespace Uni.OOP.Interfaces
{
    /// <summary>
    /// The dedicated repo for working with cars.
    /// </summary>
    public interface ICarRepository
    {
        /// <summary>
        /// Returns all cars.
        /// </summary>
        Task<List<Car>> GetAllAsync();

        /// <summary>
        /// Adds a brand new car.
        /// </summary>
        Task AddAsync(Car car);
    }
}
