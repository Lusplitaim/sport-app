using Microsoft.EntityFrameworkCore.Storage;
using SportApp.Core.Data.Repositories;

namespace SportApp.Core.Data
{
    public interface IUnitOfWork
    {
        IExerciseRepository ExerciseRepository { get; }
        IExerciseTypeRepository ExerciseTypeRepository { get; }
        Task SaveAsync();
        IDbContextTransaction BeginTransaction();
    }
}
