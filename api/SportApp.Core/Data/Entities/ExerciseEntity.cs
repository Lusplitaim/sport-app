namespace SportApp.Core.Data.Entities
{
    public class ExerciseEntity
    {
        public int Id { get; set; }
        public DateTime Date { get; set; }
        public bool IsFinished { get; set; }
        public int TypeId { get; set; }
        public string? Details { get; set; }
    }
}
