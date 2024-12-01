using SportApp.Core.Models.Interfaces;

namespace SportApp.Core.DTOs.Exercise
{
    public class CreateExerciseDto
    {
        public DateTime Date { get; set; }
        public int TypeId { get; set; }
        public string? Details { get; set; }
    }
}
