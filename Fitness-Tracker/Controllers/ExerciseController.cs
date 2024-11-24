using Fitness_Tracker.Core.Contracts;
using Fitness_Tracker.Core.Models.Exercise;
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

        [HttpGet]
        public async Task<IActionResult> Details(int id)
        {
            ExerciseViewModel model = await _exerciseService.FindExercise(id);

            return View(model);
        }

        [HttpGet]
        public async Task<IActionResult> Edit(int id)
        {
            var model = await _exerciseService.GetExercise(id);

            return View(model);
        }

        [HttpPost]
        public async Task<IActionResult> Edit(ExerciseFormModel model)
        {
            int exerciseId = model.Id;

            await _exerciseService.EditExercise(model);

            return RedirectToAction(nameof(Details), new { id = exerciseId });
        }
    }
}
