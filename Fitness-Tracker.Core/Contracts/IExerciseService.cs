using Fitness_Tracker.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fitness_Tracker.Core.Contracts
{
    public interface IExerciseService
    {
        Task<IEnumerable<ExerciseViewModel>> GetAllAsync();

        Task<ExerciseViewModel> FindExercise(int id);
    }
}
