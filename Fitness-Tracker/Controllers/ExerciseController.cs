using Fitness_Tracker.Core.Contracts;
using Fitness_Tracker.Core.Models;
using Microsoft.AspNetCore.Mvc;

namespace Fitness_Tracker.Controllers
{
    public class ExerciseController : Controller
    {
        private readonly IExerciseService _exerciseService;

        public ExerciseController(IExerciseService exerciseService)
        {
            _exerciseService = exerciseService;
        }

        [HttpGet]
        public async Task<IActionResult> All()
        {
            IEnumerable<ExerciseViewModel> model = await _exerciseService.GetAllAsync();

            return View(model);
        }
    }
}
