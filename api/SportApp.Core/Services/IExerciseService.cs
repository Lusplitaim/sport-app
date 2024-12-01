using SportApp.Core.DTOs.Exercise;
using SportApp.Core.Models;

namespace SportApp.Core.Services
{
    public interface IExerciseService
    {
        Task<IEnumerable<ExerciseDto>> GetAsync();
        Task<ExecResult<ExerciseDto>> CreateAsync(CreateExerciseDto model);
    }
}