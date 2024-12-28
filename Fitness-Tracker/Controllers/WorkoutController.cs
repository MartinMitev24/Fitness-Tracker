using Microsoft.AspNetCore.Mvc;
using Fitness_Tracker.Core.Contracts;
using Fitness_Tracker.Core.Models.Workout;
using System.Security.Claims;
using Microsoft.AspNetCore.Authorization;

namespace Fitness_Tracker.Controllers
{
    [Authorize]
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
            string userId = User.FindFirst(ClaimTypes.NameIdentifier)?.Value ?? string.Empty;

            int athleteId = await _workoutService.GetAthleteId(userId);

            IEnumerable<WorkoutViewModel> model = await _workoutService.GetAllAsync(athleteId);

            return View(model);
        }
    }
}
