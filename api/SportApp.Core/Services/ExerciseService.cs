using SportApp.Core.Data;
using SportApp.Core.DTOs.Exercise;
using SportApp.Core.Exceptions;

namespace SportApp.Core.Services
{
    internal class ExerciseService : IExerciseService
    {
        private IUnitOfWork _unitOfWork { get; }
        public ExerciseService(IUnitOfWork uow)
        {
            _unitOfWork = uow;
        }

        public async Task<IEnumerable<ExerciseDto>> GetAsync()
        {
            try
            {
                var entities = await _unitOfWork.ExerciseRepository.GetAsync();

                var result = entities.Select(e =>
                {
                    var dto = new ExerciseDto();
                    dto.Id = e.Id;
                    dto.Date = e.Date;
                    dto.IsFinished = e.IsFinished;
                    dto.TypeId = e.TypeId;
                    dto.Details = e.DetailsJson;
                    return dto;
                }).ToList();

                return result;
            }
            catch (Exception ex) when (ex is not RestCoreException)
            {
                throw new Exception("Failed to get exercises", ex);
            }
        }
    }
}
