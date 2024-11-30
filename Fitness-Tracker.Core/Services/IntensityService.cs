using Fitness_Tracker.Core.Contracts;
using Fitness_Tracker.Core.Models.Intensity;
using Fitness_Tracker.Infrastructure.Data.Common;
using Fitness_Tracker.Infrastructure.Data.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fitness_Tracker.Core.Services
{
    public class IntensityService : IIntensityService
    {
        private readonly IRepository _repository;

        public IntensityService(IRepository repository)
        {
            _repository = repository;
        }
        public async Task<IEnumerable<IntensityViewModel>> GetAllAsync()
        {
            IEnumerable<IntensityViewModel> intensities = await _repository.AllReadOnly<Intensity>()
                .Select(i => new IntensityViewModel
                {
                    Id = i.Id,
                    ExerciseName = i.Exercise.ExerciseName,
                    LiftedWeight = i.LiftedWeight,
                    Reps = i.Reps,
                    Sets = i.Sets,
                    AvarageTimePerSet = i.AvarageTimePerSet,
                    WorkoutId = i.WorkoutId
                })
                .ToListAsync();

            return intensities;
        }

        public Task<IntensityViewModel> FindIntensity(int id)
        {
            throw new NotImplementedException();
        }
    }
}
