using Microsoft.EntityFrameworkCore.Storage;
using SportApp.Core.Data;
using SportApp.Core.Data.Repositories;
using SportApp.Infrastructure.Data.Repositories;

namespace SportApp.Infrastructure.Data
{
    internal class UnitOfWork : IUnitOfWork
    {
        private DatabaseContext m_DbContext;
        public UnitOfWork(DatabaseContext dbContext)
        {
            m_DbContext = dbContext;
        }

        public IExerciseRepository ExerciseRepository => new ExerciseRepository(m_DbContext);
        public IExerciseTypeRepository ExerciseTypeRepository => new ExerciseTypeRepository(m_DbContext);

        public async Task SaveAsync()
        {
            await m_DbContext.SaveChangesAsync();
        }

        public IDbContextTransaction BeginTransaction()
        {
            return m_DbContext.Database.BeginTransaction();
        }
    }
}
