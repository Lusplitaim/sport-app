using Microsoft.EntityFrameworkCore;
using SportApp.Core.Data.Entities;
using SportApp.Core.Data.Repositories;
using SportApp.Core.DTOs.Exercise;
using SportApp.Core.Models;

namespace SportApp.Infrastructure.Data.Repositories
{
    internal class ExerciseRepository : IExerciseRepository
    {
        private DatabaseContext m_DbContext;
        public ExerciseRepository(DatabaseContext dbContext)
        {
            m_DbContext = dbContext;
        }

        public async Task<ExecResult<ExerciseDto>> CreateAsync(ExerciseEntity entity)
        {
            var result = new ExecResult<ExerciseDto>();
            m_DbContext.Exercises.Add(entity);
            await m_DbContext.SaveChangesAsync();
            result.Result = ExerciseDto.From(entity);
            return result;
        }

        public async Task<List<ExerciseEntity>> GetAsync()
        {
            return await m_DbContext.Exercises.ToListAsync();
        }
    }
}
