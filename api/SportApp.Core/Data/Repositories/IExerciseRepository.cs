using SportApp.Core.Data.Entities;

namespace SportApp.Core.Data.Repositories
{
    public interface IExerciseRepository
    {
        Task<List<ExerciseEntity>> GetAsync();
    }
}
