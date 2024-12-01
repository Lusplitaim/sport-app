using SportApp.Core.Data;
using SportApp.Core.Data.Entities;
using SportApp.Core.DTOs.Exercise;
using SportApp.Core.Exceptions;
using SportApp.Core.Models;

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

                var result = entities.Select(ExerciseDto.From).ToList();

                return result;
            }
            catch (Exception ex) when (ex is not RestCoreException)
            {
                throw new Exception("Failed to get exercises", ex);
            }
        }

        public async Task<ExecResult<ExerciseDto>> CreateAsync(CreateExerciseDto model)
        {
            try
            {
                var entity = new ExerciseEntity()
                {
                    Date = model.Date,
                    IsFinished = false,
                    TypeId = model.TypeId,
                    DetailsJson = model.Details,
                };
                var result = await _unitOfWork.ExerciseRepository.CreateAsync(entity);

                return result;
            }
            catch (Exception ex) when (ex is not RestCoreException)
            {
                throw new Exception("Failed to create exercise", ex);
            }
        }
    }
}
