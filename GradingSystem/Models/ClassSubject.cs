using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace GradingSystem.Models
{
    public class ClassSubject
    {

        [Key, Column(Order = 0)]
        public string ClassId { get; set; }

        [Key, Column(Order = 1)]
        public int SubjectId { get; set; }
    }
}
