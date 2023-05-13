using Microsoft.Data.SqlClient;
using Uni.OOP.Extensions;
using Uni.OOP.Interfaces;
using Uni.OOP.Models;
using Uni.OOP.Models.SP;

namespace Uni.OOP.Repositories
{
    /// <summary>
    /// The dedicated repo for working with car features.
    /// </summary>
    public class FeatureRepository : IFeatureRepository
    {
        readonly SqlConnection _connection;
        public FeatureRepository(SqlConnection connection)
        {
            _connection = connection;
        }

        /// <inheritdoc />
        public async Task<List<Feature>> GetAllAsync()
        {
            // Declare.
            using var command = new SqlCommand()
            {
                Connection = _connection,
                CommandType = System.Data.CommandType.StoredProcedure,
                CommandText = "dbo.sel_CarFeature",
            };

            // Execute.
            await _connection.OpenAsync();
            await using var reader = await command.ExecuteReaderAsync();

            // Map.
            var result = reader.MapToCollection<FeatureSpModel>().Select(f => f.ToModel()).ToList();
            await _connection.CloseAsync();

            return result;
        }

        /// <inheritdoc />
        public async Task AddAsync(Feature feature)
        {
            // Declare.
            using var command = new SqlCommand()
            {
                Connection = _connection,
                CommandType = System.Data.CommandType.StoredProcedure,
                CommandText = "dbo.ins_CarFeature",
            };

            // Add params.
            var parameters = new List<SqlParameter>
            {
                new SqlParameter("@FeatureName", feature.Name),
                new SqlParameter("@Description", feature.Description),
            };

            command.Parameters.AddRange(parameters.ToArray());

            // Execute.
            await _connection.OpenAsync();
            await command.ExecuteNonQueryAsync();
            await _connection.CloseAsync();
        }
    }
}
