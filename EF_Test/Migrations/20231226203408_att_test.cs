using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EF_Test.Migrations
{
    /// <inheritdoc />
    public partial class att_test : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Grades_Students_studentId",
                table: "Grades");

            migrationBuilder.DropForeignKey(
                name: "FK_StudentBooks_Books_bookId",
                table: "StudentBooks");

            migrationBuilder.DropForeignKey(
                name: "FK_StudentBooks_Students_studentId",
                table: "StudentBooks");

            migrationBuilder.DropForeignKey(
                name: "FK_Students_Departments_departmentId",
                table: "Students");

            migrationBuilder.EnsureSchema(
                name: "mysc");

            migrationBuilder.CreateTable(
                name: "myAtt",
                schema: "mysc",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DayName = table.Column<string>(type: "nvarchar(14)", maxLength: 14, nullable: false, comment: "The dadsdsd "),
                    theName = table.Column<string>(type: "varchar(50)", nullable: true),
                    studentId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_myAtt", x => x.Id);
                    table.ForeignKey(
                        name: "FK_myAtt_Students_studentId",
                        column: x => x.studentId,
                        principalTable: "Students",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_myAtt_studentId",
                schema: "mysc",
                table: "myAtt",
                column: "studentId");

            migrationBuilder.AddForeignKey(
                name: "FK_Grades_Students_studentId",
                table: "Grades",
                column: "studentId",
                principalTable: "Students",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_StudentBooks_Books_bookId",
                table: "StudentBooks",
                column: "bookId",
                principalTable: "Books",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_StudentBooks_Students_studentId",
                table: "StudentBooks",
                column: "studentId",
                principalTable: "Students",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Students_Departments_departmentId",
                table: "Students",
                column: "departmentId",
                principalTable: "Departments",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Grades_Students_studentId",
                table: "Grades");

            migrationBuilder.DropForeignKey(
                name: "FK_StudentBooks_Books_bookId",
                table: "StudentBooks");

            migrationBuilder.DropForeignKey(
                name: "FK_StudentBooks_Students_studentId",
                table: "StudentBooks");

            migrationBuilder.DropForeignKey(
                name: "FK_Students_Departments_departmentId",
                table: "Students");

            migrationBuilder.DropTable(
                name: "myAtt",
                schema: "mysc");

            migrationBuilder.AddForeignKey(
                name: "FK_Grades_Students_studentId",
                table: "Grades",
                column: "studentId",
                principalTable: "Students",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_StudentBooks_Books_bookId",
                table: "StudentBooks",
                column: "bookId",
                principalTable: "Books",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_StudentBooks_Students_studentId",
                table: "StudentBooks",
                column: "studentId",
                principalTable: "Students",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Students_Departments_departmentId",
                table: "Students",
                column: "departmentId",
                principalTable: "Departments",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
