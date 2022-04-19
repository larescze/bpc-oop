using cv11.Models;
using Microsoft.EntityFrameworkCore;

namespace cv11
{
    public class UniversityContext : DbContext
    {
        public UniversityContext()
        {
        }

        public DbSet<Student> Students { get; set; }
        public DbSet<Enrollment> Enrollments { get; set; }
        public DbSet<Subject> Subjects { get; set; }
        public DbSet<SubjectTotalStudents> SubjectTotalStudents { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder
                    .UseLazyLoadingProxies()
                    .UseSqlServer(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\lazar\Downloads\cv11\Database.mdf;Integrated Security=True");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder
                .Entity<SubjectTotalStudents>()
                .ToView(nameof(SubjectTotalStudents))
                .HasKey(t => t.SubjectId);

            modelBuilder
                .Entity<Enrollment>()
                .HasKey(e => new { e.StudentId, e.SubjectId });

            modelBuilder
                .Entity<Enrollment>()
                .HasOne<Student>(e => e.Student)
                .WithMany(s => s.Enrollments)
                .HasForeignKey(e => e.StudentId);

            modelBuilder
                .Entity<Enrollment>()
                .HasOne<Subject>(e => e.Subject)
                .WithMany(s => s.Enrollments)
                .HasForeignKey(e => e.SubjectId);
        }
    }
}