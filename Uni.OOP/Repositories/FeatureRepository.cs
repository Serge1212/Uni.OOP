using Microsoft.Data.SqlClient;
using Uni.OOP.Interfaces;
using Uni.OOP.Models;

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
