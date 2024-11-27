using Fitness_Tracker.Core.Contracts;
using Fitness_Tracker.Core.Models.Workout;
using Fitness_Tracker.Infrastructure.Data.Common;
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

        public WorkoutService(var repository)
        {
            _repository = repository;
        }

        public Task<WorkoutViewModel> FindExercise(int id)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<WorkoutViewModel>> GetAllAsync()
        {
            throw new NotImplementedException();
        }
    }
}
