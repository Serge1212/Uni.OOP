using System.Globalization;
using Uni.OOP.Interfaces;
using Uni.OOP.Models;

namespace Uni.OOP.Services
{
    /// <summary>
    /// The dedicated service for working with cars.
    /// </summary>
    public class CarService : ICarService
    {
        readonly ICarRepository _carRepository;

        public CarService(ICarRepository carRepository)
        {
            _carRepository = carRepository;
        }

        /// <inheritdoc />
        public async Task AddAsync()
        {
            Console.WriteLine("Please enter the feature info in the following fashion: " +
                "<Stock number>," +
                " <Make>," +
                " <Model>," +
                " <Price>," +
                " <Date produced>," +
                " <Date imported>," +
                " <Color>," +
                " <Body type>," +
                " <Engine type>," +
                " <Transmission>," +
                " <Fuel Efficiency>," +
                " <Condition>");

            var result = Console.ReadLine();

            var info = result?.Split(",");

            if (info is null || info.Length != 12)
            {
                Console.WriteLine("Invalid input, please try again.");
                return;
            }

            // Parse values.
            DateTime.TryParseExact(info[4].Trim(), "d/M/yyyy", CultureInfo.InvariantCulture, DateTimeStyles.None, out DateTime producedAt);
            DateTime.TryParseExact(info[5].Trim(), "d/M/yyyy", CultureInfo.InvariantCulture, DateTimeStyles.None, out DateTime importedAt);
            int.TryParse(info[0], out int stockId);
            decimal.TryParse(info[3], out decimal price);
            double.TryParse(info[10], out double fuelEfficiency);


            var car = new Car();

            car.StockId = stockId;
            car.Make = info[1].ToString();
            car.Model = info[2].ToString();
            car.Price = price;
            car.ProducedAt = producedAt;
            car.ImportedAt = importedAt;
            car.Color = info[6].ToString();
            car.BodyType = info[7].ToString();
            car.EngineType = info[8].ToString();
            car.Transmission = info[9].ToString();
            car.FuelEfficiency = fuelEfficiency;
            car.Condition = info[11].ToString();

            await _carRepository.AddAsync(car);
            Console.WriteLine("The car has been added.");
        }
    }
}
