using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace UniversityEnvironment.Data.Migrations
{
    /// <inheritdoc />
    public partial class AddedCourseStudent2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "coursestudent",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "char(36)", nullable: false, collation: "ascii_general_ci"),
                    CousesId = table.Column<Guid>(type: "char(36)", nullable: true, collation: "ascii_general_ci"),
                    StudentsId = table.Column<Guid>(type: "char(36)", nullable: true, collation: "ascii_general_ci")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_coursestudent", x => x.Id);
                    table.ForeignKey(
                        name: "FK_coursestudent_Courses_Id",
                        column: x => x.Id,
                        principalTable: "Courses",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_coursestudent_Students_Id",
                        column: x => x.Id,
                        principalTable: "Students",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "coursestudent");
        }
    }
}
