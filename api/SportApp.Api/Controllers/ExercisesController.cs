using Microsoft.AspNetCore.Mvc;
using SportApp.Core.DTOs.Exercise;
using SportApp.Core.Extensions;
using SportApp.Core.Services;

namespace SportApp.Api.Controllers
{
    public class ExercisesController : BaseController
    {
        private readonly IExerciseService _exerciseService;
        public ExercisesController(IExerciseService exerciseService)
        {
            _exerciseService = exerciseService;
        }

        [HttpGet]
        public async Task<IActionResult> Get()
        {
            var result = await _exerciseService.GetAsync();
            return Ok(result);
        }

        [HttpPost]
        public async Task<IActionResult> Create(CreateExerciseDto model)
        {
            var result = await _exerciseService.CreateAsync(model);
            return this.ResolveResult(result, () => CreatedAtAction(nameof(Create), result.Result));
        }
    }
}
