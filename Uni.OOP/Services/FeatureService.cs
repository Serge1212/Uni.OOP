using Uni.OOP.Interfaces;
using Uni.OOP.Models;

namespace Uni.OOP.Services
{
    /// <summary>
    /// The dedicated service for working with car features.
    /// </summary>
    public class FeatureService : IFeatureService
    {
        readonly IFeatureRepository _featureRepository;

        public FeatureService(IFeatureRepository featureRepository)
        {
            _featureRepository = featureRepository;
        }

        public async Task AddAsync()
        {
            Console.WriteLine("Please enter the feature info in the following fashion: <Feature name>,<Feature description>");

            var result = Console.ReadLine();

            var info = result.Split(',');

            if (info is null || info.Length < 2)
            {
                Console.WriteLine("Invalid input, please try again.");
            }

            var feature = new Feature
            {
                Name = info[0],
                Description = info[1],
            };

            await _featureRepository.AddAsync(feature);
            Console.WriteLine("The feature has been added.");
        }
    }
}
