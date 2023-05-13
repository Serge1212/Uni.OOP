using Uni.OOP.Models;

namespace Uni.OOP.Interfaces
{
    /// <summary>
    /// The dedicated repo for working with cars.
    /// </summary>
    public interface ICarRepository
    {
        /// <summary>
        /// Adds a brand new car.
        /// </summary>
        Task AddAsync(Car car);
    }
}
