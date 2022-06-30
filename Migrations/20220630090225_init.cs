using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EF_CodeFirst.Migrations
{
    public partial class init : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Student",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    StudentName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DateOfBirth = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Height = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Weight = table.Column<float>(type: "real", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Student", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Grade",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    StudentId = table.Column<int>(type: "int", nullable: false),
                    GradeName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Section = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Grade", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Grade_Student_StudentId",
                        column: x => x.StudentId,
                        principalTable: "Student",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Student",
                columns: new[] { "Id", "DateOfBirth", "Height", "StudentName", "Weight" },
                values: new object[] { 1, new DateTime(2022, 6, 30, 9, 2, 25, 484, DateTimeKind.Utc).AddTicks(9238), 170m, "Borka Borkić", 65f });

            migrationBuilder.InsertData(
                table: "Student",
                columns: new[] { "Id", "DateOfBirth", "Height", "StudentName", "Weight" },
                values: new object[] { 2, new DateTime(2022, 6, 30, 9, 2, 25, 484, DateTimeKind.Utc).AddTicks(9241), 180m, "Joža Kožić", 97f });

            migrationBuilder.InsertData(
                table: "Grade",
                columns: new[] { "Id", "GradeName", "Section", "StudentId", "Title" },
                values: new object[,]
                {
                    { 1, "Odličan", "Hravtski", 1, "5" },
                    { 2, "Vrlo dobar", "Likovni", 1, "4" },
                    { 3, "Dobar", "Matematika", 1, "3" },
                    { 4, "Odličan", "Matematika", 2, "5" },
                    { 5, "Dovoljan", "Glazbeni", 2, "2" },
                    { 6, "Vrlo dobar", "Hravtski", 2, "4" },
                    { 7, "Dovoljan", "Informatika", 1, "2" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Grade_StudentId",
                table: "Grade",
                column: "StudentId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Grade");

            migrationBuilder.DropTable(
                name: "Student");
        }
    }
}
