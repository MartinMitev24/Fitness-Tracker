using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Fitness_Tracker.Infrastructure.Data.Constants.DataConstants;


namespace Fitness_Tracker.Infrastructure.Data.Constants
{
    public class ErrorMassages
    {
        public string ExerciseNameErrorMassage = $"Exercise name can be between {ExerciseNameMinLength} and {ExerciseNameMaxLength}";
        public string ExerciseDescriptionErrorMassage = $"Exercise name can be between {ExerciseDescriptionMinLength} and {ExerciseDescriptionMaxLength}";
        
    }
}
