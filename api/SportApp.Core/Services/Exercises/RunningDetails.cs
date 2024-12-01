using SportApp.Core.Models.Interfaces;

namespace SportApp.Core.Services.Exercises
{
    public class RunningDetails : IExerciseDetails
    {
        public double Distance { get; set; }
    }
}
