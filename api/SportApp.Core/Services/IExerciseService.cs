using SportApp.Core.DTOs.Exercise;

namespace SportApp.Core.Services
{
    public interface IExerciseService
    {
        Task<IEnumerable<ExerciseDto>> GetAsync();
    }
}