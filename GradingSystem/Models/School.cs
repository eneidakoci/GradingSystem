namespace GradingSystem.Models
{
    public class School
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string? Address { get; set; }
        public Class Classes { get; set; }
    }
}
