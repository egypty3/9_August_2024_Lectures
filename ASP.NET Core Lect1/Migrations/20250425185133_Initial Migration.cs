using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ASP.NET_Core_Lect1.Migrations
{
    /// <inheritdoc />
    public partial class InitialMigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "ElDawrat",
                columns: table => new
                {
                    CourseID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Credits = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ElDawrat", x => x.CourseID);
                });

            migrationBuilder.CreateTable(
                name: "ElTalba",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstMidName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    EnrollmentDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ElTalba", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "ElEshtrakat",
                columns: table => new
                {
                    EnrollmentID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CourseID = table.Column<int>(type: "int", nullable: false),
                    StudentID = table.Column<int>(type: "int", nullable: false),
                    Grade = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ElEshtrakat", x => x.EnrollmentID);
                    table.ForeignKey(
                        name: "FK_ElEshtrakat_ElDawrat_CourseID",
                        column: x => x.CourseID,
                        principalTable: "ElDawrat",
                        principalColumn: "CourseID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ElEshtrakat_ElTalba_StudentID",
                        column: x => x.StudentID,
                        principalTable: "ElTalba",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_ElEshtrakat_CourseID",
                table: "ElEshtrakat",
                column: "CourseID");

            migrationBuilder.CreateIndex(
                name: "IX_ElEshtrakat_StudentID",
                table: "ElEshtrakat",
                column: "StudentID");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ElEshtrakat");

            migrationBuilder.DropTable(
                name: "ElDawrat");

            migrationBuilder.DropTable(
                name: "ElTalba");
        }
    }
}
