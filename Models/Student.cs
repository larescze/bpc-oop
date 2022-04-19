using cv11.Models;

namespace cv11
{
    public class Student
    {
        public int StudentId { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public DateTime Birthdate { get; set; }
        public virtual ICollection<Enrollment> Enrollments { get; set; }
    }
}
