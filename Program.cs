using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SqlKata;
using SqlKata.Execution;
using SqlKata.Compilers;

namespace cv10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string conn = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\lazar\Downloads\cv10\cv10\Database.mdf;Integrated Security=True";

            var connection = new SqlConnection(conn);
            var compiler = new SqlServerCompiler();

            var db = new QueryFactory(connection, compiler)
            {
                Logger = compiled =>
                {
                    //Console.WriteLine(compiled.ToString());
                    //Console.WriteLine();
                }
            };

            Console.WriteLine();

            var studentsOld = db.Query("Students")
                .Select(
                    "Students.{Name, Surname}",
                    "Subjects.Name as Subject"
                )
                .LeftJoin("StudentsSubjects", "Students.StudentId", "StudentsSubjects.StudentId")
                .LeftJoin("Subjects", "Subjects.SubjectId", "Subjects.SubjectId")
                .Get();

            var students = db.Query("Students")
                .Select("Students.{StudentId, Name, Surname}")
                .Get();

            foreach (var student in students)
            {
                Console.Write($"{student.Name.Trim()} {student.Surname.Trim()}");

                var studentSubjects = db.Query("Subjects")
                    .Select("Subjects.Name")
                    .Join("StudentsSubjects", j =>
                        j.On("StudentsSubjects.SubjectId", "Subjects.SubjectId")
                        .Where("StudentsSubjects.StudentId", "=", student.StudentId)
                     )
                    .Get();

                foreach (var subject in studentSubjects)
                {
                    Console.Write($", {subject.Name.Trim()}");
                }

                Console.WriteLine();
            }

            var studentsBySurname = db.Query("Students")
                .Select("Students.Surname")
                .SelectRaw("count(Students.Surname) as Total")
                .GroupBy("Students.Surname")
                .OrderByDesc("Total")
                .Get();

            Console.WriteLine();

            foreach (var surname in studentsBySurname)
            {
                Console.WriteLine($"{surname.Surname.Trim()} {surname.Total}");
            }

            var subjects = db.Query("Subjects")
                .Select("Subjects.Name")
                .LeftJoin("StudentsSubjects", "StudentsSubjects.SubjectId", "Subjects.SubjectId")
                .GroupBy("Subjects.Name")
                .HavingRaw("count(StudentsSubjects.SubjectId) < 3")
                .Get();

            Console.WriteLine();

            foreach (var subject in subjects)
            {
                Console.WriteLine($"{subject.Name}");
            }

            Console.WriteLine();

            var reviews = db.Query("SubjectsReviews")
                .Select("Subjects.Name as SubjectName")
                .SelectRaw("max(SubjectsReviews.Rating) as HighestRating")
                .SelectRaw("min(SubjectsReviews.Rating) as LowestRating")
                .SelectRaw("avg(SubjectsReviews.Rating) as AverageRating")
                .SelectRaw("count(SubjectsReviews.StudentId) as TotalRatings")
                .LeftJoin("Subjects", "Subjects.SubjectId", "SubjectsReviews.SubjectId")
                .GroupBy("Subjects.Name")
                .Get();

            foreach (var review in reviews)
            {
                Console.WriteLine($"Subject: {review.SubjectName}");
                Console.WriteLine($"Highest: {review.HighestRating}");
                Console.WriteLine($"Lowest: {review.LowestRating}");
                Console.WriteLine($"Average: {review.AverageRating}");
                Console.WriteLine($"Total: {review.TotalRatings}");
            }

            Console.ReadLine();
        }
    }
}
