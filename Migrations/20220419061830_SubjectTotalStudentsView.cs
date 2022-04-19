using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace cv11.Migrations
{
    public partial class SubjectStudentsView : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql(@"
                CREATE VIEW SubjectTotalStudents AS
                    SELECT s.SubjectId, s.Name, COUNT(s.SubjectId) AS Total FROM Subjects as s 
                    LEFT JOIN Enrollments as e ON e.SubjectId = s.SubjectId 
                    GROUP BY s.SubjectId, s.Name
            ");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql(@"DROP VIEW SubjectTotalStudents");
        }
    }
}
