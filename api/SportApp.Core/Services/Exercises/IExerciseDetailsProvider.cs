using SportApp.Core.Models.Interfaces;

namespace SportApp.Core.Services.Exercises
{
    public interface IExerciseDetailsProvider
    {
        int ExerciseType { get; }
        IExerciseDetails ResolveDetails(string detailsJson);
    }
}
