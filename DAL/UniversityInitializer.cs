using System;
using System.Collections.Generic;
using cv11.Models;

namespace cv11.DAL
{
    public class UniversityInitializer
    {
        public static void Seed(UniversityContext context)
        {
            var students = new List<Student>
            {
            new Student{Name="Carson",Surname="Collman",Birthdate=DateTime.Parse("2005-09-01")},
            new Student{Name="Meredith",Surname="Riden",Birthdate=DateTime.Parse("2002-09-01")},
            new Student{Name="Arturo",Surname="Hassard",Birthdate=DateTime.Parse("2003-09-01")},
            new Student{Name="Gytis",Surname="Adelsberg",Birthdate=DateTime.Parse("2002-09-01")},
            new Student{Name="Jon",Surname="Waudby",Birthdate=DateTime.Parse("2002-09-01")},
            new Student{Name="Peggy",Surname="Justice",Birthdate=DateTime.Parse("2001-09-01")},
            new Student{Name="Laura",Surname="Pea",Birthdate=DateTime.Parse("2003-09-01")},
            new Student{Name="Nino",Surname="Adelsberg",Birthdate=DateTime.Parse("2005-09-01")}
            };

            students.ForEach(s => context.Students.Add(s));
            context.SaveChanges();
            var subjects = new List<Subject>
            {
            new Subject{Name="Communication Technology",Abbreviation="BPC-KOM"},
            new Subject{Name="Mathematics",Abbreviation="BPC-MA1"},
            new Subject{Name="Computers and Programming",Abbreviation="BPC-PC1"},
            new Subject{Name="Security of Database Systems",Abbreviation="BPC-BDS"},
            new Subject{Name="Applied Cryptography",Abbreviation="BPC-AKR"},
            new Subject{Name="Network Operating Systems",Abbreviation="BPC-SOS"},
            new Subject{Name="Security Systems",Abbreviation="BPC-ZSY"}
            };
            subjects.ForEach(s => context.Subjects.Add(s));
            context.SaveChanges();
            var enrollments = new List<Enrollment>
            {
            new Enrollment{StudentId=1,SubjectId=1},
            new Enrollment{StudentId=1,SubjectId=2},
            new Enrollment{StudentId=1,SubjectId=3},
            new Enrollment{StudentId=2,SubjectId=1},
            new Enrollment{StudentId=2,SubjectId=4},
            new Enrollment{StudentId=2,SubjectId=3},
            new Enrollment{StudentId=3,SubjectId=2},
            new Enrollment{StudentId=4,SubjectId=1},
            new Enrollment{StudentId=4,SubjectId=2},
            new Enrollment{StudentId=5,SubjectId=1},
            new Enrollment{StudentId=6,SubjectId=1},
            new Enrollment{StudentId=7,SubjectId=2},
            };
            enrollments.ForEach(s => context.Enrollments.Add(s));
            context.SaveChanges();
        }
    }
}
