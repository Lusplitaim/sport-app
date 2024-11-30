using Microsoft.EntityFrameworkCore;
using SportApp.Core.Data.Entities;
using SportApp.Core.Data.Repositories;

namespace SportApp.Infrastructure.Data.Repositories
{
    internal class ExerciseRepository : IExerciseRepository
    {
        private DatabaseContext m_DbContext;
        public ExerciseRepository(DatabaseContext dbContext)
        {
            m_DbContext = dbContext;
        }

        public async Task<List<ExerciseEntity>> GetAsync()
        {
            return await m_DbContext.Exercises.ToListAsync();
        }
    }
}
