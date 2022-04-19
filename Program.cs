using cv11.DAL;
using Microsoft.EntityFrameworkCore;

namespace cv11
{
    class Program
    {
        static void Main(string[] args)
        {
            var context = new UniversityContext();
            //UniversityInitializer.Seed(context);

            var students = context.Students
                .Include(e => e.Enrollments)
                .ThenInclude(s => s.Subject)
                .ToList();

            foreach (var student in students)
            {
                Console.WriteLine("Student: {0} {1}", student.Name, student.Surname);

                foreach (var enrollment in student.Enrollments)
                {
                    Console.WriteLine("Enrollment: {0}", enrollment.Subject.Abbreviation);
                }
            }

            Console.WriteLine();

            var subjects = context.Subjects
                .Where(x => x.Abbreviation == "BPC-KOM")
                .Include(e => e.Enrollments)
                .ThenInclude(s => s.Student)
                .First();

            Console.WriteLine("Subject BPC-KOM:");

            foreach (var enrollment in subjects.Enrollments)
            {
                Console.WriteLine("Enrollment: {0} {1}", enrollment.Student.Name, enrollment.Student.Surname);
            }

            Console.WriteLine();

            var subjectStudents = context.SubjectTotalStudents.ToList();

            Console.WriteLine("Subjects:");

            foreach (var subject in subjectStudents)
            {
                Console.WriteLine("Subject: {0}, Total students: {1}", subject.Name, subject.Total);
            }
        }
    }
}