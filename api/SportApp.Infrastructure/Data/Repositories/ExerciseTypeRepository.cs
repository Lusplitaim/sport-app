using SportApp.Core.Data.Repositories;

namespace SportApp.Infrastructure.Data.Repositories
{
    internal class ExerciseTypeRepository : IExerciseTypeRepository
    {
        private DatabaseContext m_DbContext;
        public ExerciseTypeRepository(DatabaseContext dbContext)
        {
            m_DbContext = dbContext;
        }


    }
}
