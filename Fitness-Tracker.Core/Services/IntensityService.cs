using Fitness_Tracker.Core.Contracts;
using Fitness_Tracker.Core.Models.Intensity;
using Fitness_Tracker.Infrastructure.Data.Common;
using Fitness_Tracker.Infrastructure.Data.Models;
using Microsoft.EntityFrameworkCore;

namespace Fitness_Tracker.Core.Services
{
    /// <summary>
    /// Class is used for retrieving data from intensity data set.
    /// </summary>
    public class IntensityService : IIntensityService
    {
        private readonly IRepository _repository;

        public IntensityService(IRepository repository)
        {
            _repository = repository;
        }

        /// <summary>
        /// Method is used to retreive all intensity entities from database.
        /// </summary>
        /// <returns>List of IntensityVewModel</returns>
        public async Task<IEnumerable<IntensityViewModel>> GetAllAsync()
        {
            IEnumerable<IntensityViewModel> intensities = await _repository.AllReadOnly<Intensity>()
                .Where(i => i.IsDeleted == false)
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
