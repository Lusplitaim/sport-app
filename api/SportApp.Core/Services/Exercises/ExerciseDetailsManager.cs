using SportApp.Core.Models.Interfaces;

namespace SportApp.Core.Services.Exercises
{
    public class ExerciseDetailsManager
    {
        private readonly List<IExerciseDetailsProvider> _detailsProviders = new()
        {
            new WarmupDetailsProvider(),
        };

        public IExerciseDetails? Resolve(int exerciseType, string detailsJson)
        {
            var provider = _detailsProviders.SingleOrDefault(p => p.ExerciseType == exerciseType);

            if (provider is not null)
            {
                return provider.ResolveDetails(detailsJson);
            }

            return null;
        }
    }
}
