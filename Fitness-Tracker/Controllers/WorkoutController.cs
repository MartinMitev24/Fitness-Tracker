using Fitness_Tracker.Core.Contracts;
using Fitness_Tracker.Core.Models.Intensity;
using Fitness_Tracker.Core.Models.Workout;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Security.Claims;
using System.Text.Json;

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

        [HttpGet]
        public async Task<IActionResult> AddWorkout()
        {
            string userId = User.FindFirst(ClaimTypes.NameIdentifier)?.Value ?? string.Empty;

            int athleteId = await _workoutService.GetAthleteId(userId);

            var model = new WorkoutFormModel();

            model.AthleteId = athleteId;

            List<IntensityFormModel> workoutData = new List<IntensityFormModel>();

            if (TempData["WorkoutData"] is string json)
            {
                workoutData = JsonSerializer.Deserialize<List<IntensityFormModel>>(json);

                TempData.Keep("WorkoutData");
            }

            model.Intensities = workoutData;

            var exerciseToChooses = await _workoutService.GetExerciseToChoose();

            ViewBag.WorkoutData = workoutData;
            ViewBag.Exercises = exerciseToChooses;

            return View(model);
        }

        [HttpPost]
        [IgnoreAntiforgeryToken]
        public IActionResult AddExercise(IntensityFormModel intensity)
        {
            if (!ModelState.IsValid)
            {
                return View(intensity);
            }

            if (TempData.ContainsKey("WorkoutData"))
            {
                string json = string.Empty;

                if (TempData["WorkoutData"] is string data)
                {
                    json = data;
                }

                List<IntensityFormModel> workoutData = JsonSerializer.Deserialize<List<IntensityFormModel>>(json);

                workoutData.Add(intensity);

                json = JsonSerializer.Serialize<List<IntensityFormModel>>(workoutData);

                TempData["WorkoutData"] = json;
            }
            else
            {
                List<IntensityFormModel> workoutData = new List<IntensityFormModel>();

                workoutData.Add(intensity);

                string json = JsonSerializer.Serialize<List<IntensityFormModel>>(workoutData);

                TempData["WorkoutData"] = json;
            }

            return RedirectToAction(nameof(AddWorkout));
        }

        [HttpPost]
        public async Task<IActionResult> AddWorkout(WorkoutFormModel model)
        {
            if (TempData["WorkoutData"] is string json)
            {
                List<IntensityFormModel> workoutData = JsonSerializer.Deserialize<List<IntensityFormModel>>(json);

                model.Intensities = workoutData;
            }

            string userId = User.FindFirst(ClaimTypes.NameIdentifier)?.Value ?? string.Empty;

            int athleteId = await _workoutService.GetAthleteId(userId);

            model.AthleteId = athleteId;

            if (!ModelState.IsValid || model.Intensities.Count() < 1)
            {
                model = new WorkoutFormModel();

                List<IntensityFormModel> workoutData = new List<IntensityFormModel>();

                var exercises = await _workoutService.GetExerciseToChoose();

                if (TempData["WorkoutData"] is string data)
                {
                    workoutData = JsonSerializer.Deserialize<List<IntensityFormModel>>(data);

                    TempData.Keep("WorkoutData");
                }

                ViewBag.WorkoutData = workoutData;
                ViewBag.Exercises = exercises;

                return View(model);
            }

            TempData.Clear();

            await _workoutService.CreateWorkout(model, model.AthleteId);

            return RedirectToAction(nameof(All));
        }
    }
}
