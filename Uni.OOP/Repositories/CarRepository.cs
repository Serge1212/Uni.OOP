using Microsoft.Data.SqlClient;
using Uni.OOP.Extensions;
using Uni.OOP.Interfaces;
using Uni.OOP.Models;
using Uni.OOP.Models.SP;

namespace Uni.OOP.Repositories
{
    /// <summary>
    /// The dedicated repo for working with cars.
    /// </summary>
    public class CarRepository : ICarRepository
    {
        readonly SqlConnection _connection;
        public CarRepository(SqlConnection connection)
        {
            _connection = connection;
        }

        /// <inheritdoc />
        public async Task<List<Car>> GetAllAsync()
        {
            // Declare.
            using var command = new SqlCommand()
            {
                Connection = _connection,
                CommandType = System.Data.CommandType.StoredProcedure,
                CommandText = "dbo.sel_Car",
            };

            // Execute.
            await _connection.OpenAsync();
            await using var reader = await command.ExecuteReaderAsync();

            // Map.
            var result = reader.MapToCollection<CarSpModel>().Select(c => c.ToModel()).ToList();
            await _connection.CloseAsync();

            return result;
        }

        /// <inheritdoc />
        public async Task AddAsync(Car car)
        {
            // Declare.
            using var command = new SqlCommand()
            {
                Connection = _connection,
                CommandType = System.Data.CommandType.StoredProcedure,
                CommandText = "dbo.ins_Car",
            };

            // Add params.
            var parameters = new List<SqlParameter>
            {
                new SqlParameter("@StockFID", car.StockId),
                new SqlParameter("@Make", car.Make),
                new SqlParameter("@Model", car.Model),
                new SqlParameter("@Price", car.Price),
                new SqlParameter("@ProducedAt", car.ProducedAt),
                new SqlParameter("@ImportedAt", car.ImportedAt),
                new SqlParameter("@Color", car.Color),
                new SqlParameter("@BodyType", car.BodyType),
                new SqlParameter("@EngineType", car.EngineType),
                new SqlParameter("@Transmission", car.Transmission),
                new SqlParameter("@FuelEfficiency", car.FuelEfficiency),
                new SqlParameter("@Condition", car.Condition),
            };

            command.Parameters.AddRange(parameters.ToArray());

            // Execute.
            await _connection.OpenAsync();
            await command.ExecuteNonQueryAsync();
            await _connection.CloseAsync();
        }
    }
}
