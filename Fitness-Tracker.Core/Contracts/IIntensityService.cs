using Fitness_Tracker.Core.Models.Intensity;

namespace Fitness_Tracker.Core.Contracts
{
    public interface IIntensityService
    {
        Task<IEnumerable<IntensityViewModel>> GetAllAsync();

        Task<IntensityViewModel> FindIntensity(int id);

        //Task<EditExerciseFormModel> GetExercise(int id);

        //Task EditExercise(EditExerciseFormModel model);

        //Task CreateExercise(AddExerciseFormModel model);
    }
}
