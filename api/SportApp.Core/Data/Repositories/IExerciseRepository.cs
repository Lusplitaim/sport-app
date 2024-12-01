using SportApp.Core.Data.Entities;
using SportApp.Core.DTOs.Exercise;
using SportApp.Core.Models;

namespace SportApp.Core.Data.Repositories
{
    public interface IExerciseRepository
    {
        Task<List<ExerciseEntity>> GetAsync();
        Task<ExecResult<ExerciseDto>> CreateAsync(ExerciseEntity entity);
    }
}
