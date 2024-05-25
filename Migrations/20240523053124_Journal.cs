using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Comics.Migrations
{
    public partial class Journal : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AuthUsers",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Password = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AuthUsers", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Comicss",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Year = table.Column<int>(type: "int", nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Comicss", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "subjects",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_subjects", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "SubjectGrades",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SubjectID = table.Column<int>(type: "int", nullable: false),
                    Grade = table.Column<int>(type: "int", nullable: false),
                    Date = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ComicsID = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SubjectGrades", x => x.Id);
                    table.ForeignKey(
                        name: "FK_SubjectGrades_Comicss_ComicsID",
                        column: x => x.ComicsID,
                        principalTable: "Comicss",
                        principalColumn: "ID");
                    table.ForeignKey(
                        name: "FK_SubjectGrades_subjects_SubjectID",
                        column: x => x.SubjectID,
                        principalTable: "subjects",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_SubjectGrades_ComicsID",
                table: "SubjectGrades",
                column: "ComicsID");

            migrationBuilder.CreateIndex(
                name: "IX_SubjectGrades_SubjectID",
                table: "SubjectGrades",
                column: "SubjectID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AuthUsers");

            migrationBuilder.DropTable(
                name: "SubjectGrades");

            migrationBuilder.DropTable(
                name: "Comicss");

            migrationBuilder.DropTable(
                name: "subjects");
        }
    }
}
