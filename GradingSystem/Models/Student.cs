namespace GradingSystem.Models
{
    public class Student
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public School School { get; set; }
        public Class Class { get; set; }
        public Parent Parent { get; set; }
    }
}
