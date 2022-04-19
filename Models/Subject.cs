using cv11.Models;
using System.ComponentModel.DataAnnotations.Schema;

namespace cv11
{
    public class Subject
    {
        public int SubjectId { get; set; }
        public string Name { get; set; }
        public string Abbreviation { get; set; }
        public virtual ICollection<Enrollment> Enrollments { get; set; }
    }
}
