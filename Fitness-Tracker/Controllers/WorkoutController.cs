using Microsoft.AspNetCore.Mvc;
using Fitness_Tracker.Core.Contracts;
using Fitness_Tracker.Core.Models.Workout;

namespace Fitness_Tracker.Controllers
{
    public class WorkoutController : Controller
    {
        private readonly IWorkoutService _workoutService;

        public WorkoutController(IWorkoutService workoutService)
        {
            _workoutService = workoutService;
        }

        [HttpGet]
        public async Task<IActionResult> All()
        {
            IEnumerable<WorkoutViewModel> model = await _workoutService.GetAllAsync();

            return View(model);
        }
    }
}
