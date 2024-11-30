namespace SportApp.Core.DTOs.Exercise
{
    public class ExerciseDto
    {
        public int Id { get; set; }
        public DateTime Date { get; set; }
        public bool IsFinished { get; set; }
        public int TypeId { get; set; }
        public string? Details { get; set; }
    }
}
