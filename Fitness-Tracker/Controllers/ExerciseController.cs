using Fitness_Tracker.Core.Contracts;
using Fitness_Tracker.Core.Models.Exercise;
using Microsoft.AspNetCore.Mvc;

namespace Fitness_Tracker.Controllers
{
    /// <summary>
    /// Class for Exercise controller.
    /// </summary>
    public class ExerciseController : Controller
    {
        private readonly IExerciseService _exerciseService;

        public ExerciseController(IExerciseService exerciseService)
        {
            _exerciseService = exerciseService;
        }

        /// <summary>
        /// HTTPGet Method to retreive all exercises.
        /// </summary>
        /// <returns>View model with a List of all exercises.</returns>
        [HttpGet]
        public async Task<IActionResult> All()
        {
            IEnumerable<ExerciseViewModel> model = await _exerciseService.GetAllAsync();

            return View(model);
        }

        /// <summary>
        /// HTTPGet Method to retreive a single exercise for viewing details.
        /// </summary>
        /// <param name="id">Receives integer for exercise identifier.</param>
        /// <returns>View model for the details of an exercise.</returns>
        [HttpGet]
        public async Task<IActionResult> Details(int id)
        {
            ExerciseViewModel model = await _exerciseService.FindExercise(id);

            return View(model);
        }

        /// <summary>
        /// HTTPGet method to retreive data of a single exercise for editing.
        /// </summary>
        /// <param name="id">Receives integer for exercise identifier.</param>
        /// <returns>View model for editing an exercise.</returns>
        [HttpGet]
        public async Task<IActionResult> Edit(int id)
        {
            var model = await _exerciseService.GetExercise(id);

            return View(model);
        }

        /// <summary>
        /// HTTPPost Method for editing data of a single exercise.
        /// </summary>
        /// <param name="model">Receives class EditExerciseFormModel.</param>
        /// <returns>Saves changes and redirects user to Details of the exercise</returns>
        [HttpPost]
        public async Task<IActionResult> Edit(EditExerciseFormModel model)
        {
            int exerciseId = model.Id;

            await _exerciseService.EditExercise(model);

            return RedirectToAction(nameof(Details), new { id = exerciseId });
        }

        /// <summary>
        /// HTTPGet Method for creating a new exercise.
        /// </summary>
        /// <returns>View model of class AddExerciseFormModel.</returns>
        [HttpGet]
        public IActionResult AddExercise()
        {
            var model = new AddExerciseFormModel();

            return View(model);
        }

        /// <summary>
        /// HTTPPost Method for creating a new exercise.
        /// </summary>
        /// <param name="model">Receives class AddExerciseFormModel.</param>
        /// <returns>Saves new exercise to database and redirects to AllExercises page.</returns>
        [HttpPost]
        public async Task<IActionResult> AddExercise(AddExerciseFormModel model)
        {
            await _exerciseService.CreateExercise(model);

            return RedirectToAction(nameof(All));
        }
    }
}
