using Fitness_Tracker.Core.Contracts;
using Fitness_Tracker.Core.Models.Workout;
using Fitness_Tracker.Infrastructure.Data.Common;
using Fitness_Tracker.Infrastructure.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fitness_Tracker.Core.Services
{
    internal class WorkoutService : IWorkoutService
    {
        private readonly IRepository _repository;

        public WorkoutService(IRepository repository)
        {
            _repository = repository;
        }

        public async Task<WorkoutViewModel> FindExercise(int id)
        {
            WorkoutViewModel model = await _repository
                .AllReadOnly<Workout>()
                .Select(w => new WorkoutViewModel 
                {
                    
                })
        }

        public Task<IEnumerable<WorkoutViewModel>> GetAllAsync()
        {
            throw new NotImplementedException();
        }
    }
}
