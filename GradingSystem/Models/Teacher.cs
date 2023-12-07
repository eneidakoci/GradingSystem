namespace GradingSystem.Models
{
    public class Teacher : User
    {
        public int Id { get; set; }
        public User User { get; set; }
        public string? Name { get; set; }
        public bool IsPrincipal { get; set; }
        public Class? Class { get; set; }
        public School School { get; set; }
    }
}
