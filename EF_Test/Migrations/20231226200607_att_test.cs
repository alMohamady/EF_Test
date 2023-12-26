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
            migrationBuilder.EnsureSchema(
                name: "std");

            migrationBuilder.CreateTable(
                name: "StudentsAtts",
                schema: "std",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DayName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    theName = table.Column<string>(type: "varchar(20)", nullable: true),
                    studentId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_StudentsAtts", x => x.Id);
                    table.ForeignKey(
                        name: "FK_StudentsAtts_Students_studentId",
                        column: x => x.studentId,
                        principalTable: "Students",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_StudentsAtts_studentId",
                schema: "std",
                table: "StudentsAtts",
                column: "studentId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "StudentsAtts",
                schema: "std");
        }
    }
}
