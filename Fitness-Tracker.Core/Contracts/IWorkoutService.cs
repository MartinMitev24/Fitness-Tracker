using Fitness_Tracker.Core.Models.Workout;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fitness_Tracker.Core.Contracts
{
    internal interface IWorkoutService
    {
        Task<IEnumerable<WorkoutViewModel>> GetAllAsync();

        Task<WorkoutViewModel> FindExercise(int id);

        //Task<EditExerciseFormModel> GetExercise(int id);

        //Task EditExercise(EditExerciseFormModel model);

        //Task CreateExercise(AddExerciseFormModel model);
    }
}
