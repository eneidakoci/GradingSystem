using System.ComponentModel.DataAnnotations.Schema;

namespace GradingSystem.Models
{
    public class Class
    {
        public int Id { get; set; }
        public int Capacity { get; set; }
        [ForeignKey("schoolID")]
        public School School { get; set; }
    }
}
