using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ASP.NET_Core_Lect1.Migrations
{
    /// <inheritdoc />
    public partial class Tablenamesnowusingjusttheconventions : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ElEshtrakat_ElDawrat_CourseID",
                table: "ElEshtrakat");

            migrationBuilder.DropForeignKey(
                name: "FK_ElEshtrakat_ElTalba_StudentID",
                table: "ElEshtrakat");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ElTalba",
                table: "ElTalba");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ElEshtrakat",
                table: "ElEshtrakat");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ElDawrat",
                table: "ElDawrat");

            migrationBuilder.RenameTable(
                name: "ElTalba",
                newName: "Students");

            migrationBuilder.RenameTable(
                name: "ElEshtrakat",
                newName: "Enrollments");

            migrationBuilder.RenameTable(
                name: "ElDawrat",
                newName: "Courses");

            migrationBuilder.RenameIndex(
                name: "IX_ElEshtrakat_StudentID",
                table: "Enrollments",
                newName: "IX_Enrollments_StudentID");

            migrationBuilder.RenameIndex(
                name: "IX_ElEshtrakat_CourseID",
                table: "Enrollments",
                newName: "IX_Enrollments_CourseID");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Students",
                table: "Students",
                column: "ID");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Enrollments",
                table: "Enrollments",
                column: "EnrollmentID");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Courses",
                table: "Courses",
                column: "CourseID");

            migrationBuilder.AddForeignKey(
                name: "FK_Enrollments_Courses_CourseID",
                table: "Enrollments",
                column: "CourseID",
                principalTable: "Courses",
                principalColumn: "CourseID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Enrollments_Students_StudentID",
                table: "Enrollments",
                column: "StudentID",
                principalTable: "Students",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Enrollments_Courses_CourseID",
                table: "Enrollments");

            migrationBuilder.DropForeignKey(
                name: "FK_Enrollments_Students_StudentID",
                table: "Enrollments");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Students",
                table: "Students");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Enrollments",
                table: "Enrollments");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Courses",
                table: "Courses");

            migrationBuilder.RenameTable(
                name: "Students",
                newName: "ElTalba");

            migrationBuilder.RenameTable(
                name: "Enrollments",
                newName: "ElEshtrakat");

            migrationBuilder.RenameTable(
                name: "Courses",
                newName: "ElDawrat");

            migrationBuilder.RenameIndex(
                name: "IX_Enrollments_StudentID",
                table: "ElEshtrakat",
                newName: "IX_ElEshtrakat_StudentID");

            migrationBuilder.RenameIndex(
                name: "IX_Enrollments_CourseID",
                table: "ElEshtrakat",
                newName: "IX_ElEshtrakat_CourseID");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ElTalba",
                table: "ElTalba",
                column: "ID");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ElEshtrakat",
                table: "ElEshtrakat",
                column: "EnrollmentID");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ElDawrat",
                table: "ElDawrat",
                column: "CourseID");

            migrationBuilder.AddForeignKey(
                name: "FK_ElEshtrakat_ElDawrat_CourseID",
                table: "ElEshtrakat",
                column: "CourseID",
                principalTable: "ElDawrat",
                principalColumn: "CourseID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ElEshtrakat_ElTalba_StudentID",
                table: "ElEshtrakat",
                column: "StudentID",
                principalTable: "ElTalba",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
