using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EF_Test.Migrations
{
    /// <inheritdoc />
    public partial class init_db : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "departmentId",
                table: "Students",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "Books",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Author = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Created = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Books", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Departments",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    des = table.Column<string>(type: "nvarchar(5)", maxLength: 5, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Departments", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Grades",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    physics = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    chemistry = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    programming = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    studentId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Grades", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Grades_Students_studentId",
                        column: x => x.studentId,
                        principalTable: "Students",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "StudentBooks",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    studentId = table.Column<int>(type: "int", nullable: false),
                    bookId = table.Column<int>(type: "int", nullable: false),
                    getDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_StudentBooks", x => x.Id);
                    table.ForeignKey(
                        name: "FK_StudentBooks_Books_bookId",
                        column: x => x.bookId,
                        principalTable: "Books",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_StudentBooks_Students_studentId",
                        column: x => x.studentId,
                        principalTable: "Students",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Students_departmentId",
                table: "Students",
                column: "departmentId");

            migrationBuilder.CreateIndex(
                name: "IX_Grades_studentId",
                table: "Grades",
                column: "studentId",
                unique: true,
                filter: "[studentId] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_StudentBooks_bookId",
                table: "StudentBooks",
                column: "bookId");

            migrationBuilder.CreateIndex(
                name: "IX_StudentBooks_studentId",
                table: "StudentBooks",
                column: "studentId");

            migrationBuilder.AddForeignKey(
                name: "FK_Students_Departments_departmentId",
                table: "Students",
                column: "departmentId",
                principalTable: "Departments",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Students_Departments_departmentId",
                table: "Students");

            migrationBuilder.DropTable(
                name: "Departments");

            migrationBuilder.DropTable(
                name: "Grades");

            migrationBuilder.DropTable(
                name: "StudentBooks");

            migrationBuilder.DropTable(
                name: "Books");

            migrationBuilder.DropIndex(
                name: "IX_Students_departmentId",
                table: "Students");

            migrationBuilder.DropColumn(
                name: "departmentId",
                table: "Students");
        }
    }
}
