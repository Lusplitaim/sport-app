using SportApp.Core.Models.Interfaces;
using System.Text.Json;

namespace SportApp.Core.Services.Exercises
{
    internal class WarmupDetails : IExerciseDetails
    {
        public double Minutes { get; set; }
    }

    public class WarmupDetailsProvider : IExerciseDetailsProvider
    {
        public int ExerciseType => 1;

        public IExerciseDetails ResolveDetails(string detailsJson)
        {
            return JsonSerializer.Deserialize<WarmupDetails>(detailsJson)!;
        }
    }
}
