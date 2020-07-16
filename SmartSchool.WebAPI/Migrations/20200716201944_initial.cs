using Microsoft.EntityFrameworkCore.Migrations;

namespace SmartSchool.WebAPI.Migrations
{
    public partial class initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Students",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Name = table.Column<string>(nullable: true),
                    Surname = table.Column<string>(nullable: true),
                    PhoneNumber = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Students", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Teachers",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Name = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Teachers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Subjects",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Name = table.Column<string>(nullable: true),
                    TeacherId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Subjects", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Subjects_Teachers_TeacherId",
                        column: x => x.TeacherId,
                        principalTable: "Teachers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "SudentsSubjects",
                columns: table => new
                {
                    StudentId = table.Column<int>(nullable: false),
                    SubjectId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SudentsSubjects", x => new { x.StudentId, x.SubjectId });
                    table.ForeignKey(
                        name: "FK_SudentsSubjects_Students_StudentId",
                        column: x => x.StudentId,
                        principalTable: "Students",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_SudentsSubjects_Subjects_SubjectId",
                        column: x => x.SubjectId,
                        principalTable: "Subjects",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Students",
                columns: new[] { "Id", "Name", "PhoneNumber", "Surname" },
                values: new object[] { 1, "Marta", "33225555", "Kent" });

            migrationBuilder.InsertData(
                table: "Students",
                columns: new[] { "Id", "Name", "PhoneNumber", "Surname" },
                values: new object[] { 2, "Paula", "3354288", "Isabela" });

            migrationBuilder.InsertData(
                table: "Students",
                columns: new[] { "Id", "Name", "PhoneNumber", "Surname" },
                values: new object[] { 3, "Laura", "55668899", "Antonia" });

            migrationBuilder.InsertData(
                table: "Students",
                columns: new[] { "Id", "Name", "PhoneNumber", "Surname" },
                values: new object[] { 4, "Luiza", "6565659", "Maria" });

            migrationBuilder.InsertData(
                table: "Students",
                columns: new[] { "Id", "Name", "PhoneNumber", "Surname" },
                values: new object[] { 5, "Lucas", "565685415", "Machado" });

            migrationBuilder.InsertData(
                table: "Students",
                columns: new[] { "Id", "Name", "PhoneNumber", "Surname" },
                values: new object[] { 6, "Pedro", "456454545", "Alvares" });

            migrationBuilder.InsertData(
                table: "Students",
                columns: new[] { "Id", "Name", "PhoneNumber", "Surname" },
                values: new object[] { 7, "Paulo", "9874512", "José" });

            migrationBuilder.InsertData(
                table: "Teachers",
                columns: new[] { "Id", "Name" },
                values: new object[] { 1, "Lauro" });

            migrationBuilder.InsertData(
                table: "Teachers",
                columns: new[] { "Id", "Name" },
                values: new object[] { 2, "Roberto" });

            migrationBuilder.InsertData(
                table: "Teachers",
                columns: new[] { "Id", "Name" },
                values: new object[] { 3, "Ronaldo" });

            migrationBuilder.InsertData(
                table: "Teachers",
                columns: new[] { "Id", "Name" },
                values: new object[] { 4, "Rodrigo" });

            migrationBuilder.InsertData(
                table: "Teachers",
                columns: new[] { "Id", "Name" },
                values: new object[] { 5, "Alexandre" });

            migrationBuilder.InsertData(
                table: "Subjects",
                columns: new[] { "Id", "Name", "TeacherId" },
                values: new object[] { 1, "Mathematics", 1 });

            migrationBuilder.InsertData(
                table: "Subjects",
                columns: new[] { "Id", "Name", "TeacherId" },
                values: new object[] { 2, "Physics", 2 });

            migrationBuilder.InsertData(
                table: "Subjects",
                columns: new[] { "Id", "Name", "TeacherId" },
                values: new object[] { 3, "Portuguese", 3 });

            migrationBuilder.InsertData(
                table: "Subjects",
                columns: new[] { "Id", "Name", "TeacherId" },
                values: new object[] { 4, "English", 4 });

            migrationBuilder.InsertData(
                table: "Subjects",
                columns: new[] { "Id", "Name", "TeacherId" },
                values: new object[] { 5, "Programming", 5 });

            migrationBuilder.InsertData(
                table: "SudentsSubjects",
                columns: new[] { "StudentId", "SubjectId" },
                values: new object[] { 2, 1 });

            migrationBuilder.InsertData(
                table: "SudentsSubjects",
                columns: new[] { "StudentId", "SubjectId" },
                values: new object[] { 4, 5 });

            migrationBuilder.InsertData(
                table: "SudentsSubjects",
                columns: new[] { "StudentId", "SubjectId" },
                values: new object[] { 2, 5 });

            migrationBuilder.InsertData(
                table: "SudentsSubjects",
                columns: new[] { "StudentId", "SubjectId" },
                values: new object[] { 1, 5 });

            migrationBuilder.InsertData(
                table: "SudentsSubjects",
                columns: new[] { "StudentId", "SubjectId" },
                values: new object[] { 7, 4 });

            migrationBuilder.InsertData(
                table: "SudentsSubjects",
                columns: new[] { "StudentId", "SubjectId" },
                values: new object[] { 6, 4 });

            migrationBuilder.InsertData(
                table: "SudentsSubjects",
                columns: new[] { "StudentId", "SubjectId" },
                values: new object[] { 5, 4 });

            migrationBuilder.InsertData(
                table: "SudentsSubjects",
                columns: new[] { "StudentId", "SubjectId" },
                values: new object[] { 4, 4 });

            migrationBuilder.InsertData(
                table: "SudentsSubjects",
                columns: new[] { "StudentId", "SubjectId" },
                values: new object[] { 1, 4 });

            migrationBuilder.InsertData(
                table: "SudentsSubjects",
                columns: new[] { "StudentId", "SubjectId" },
                values: new object[] { 7, 3 });

            migrationBuilder.InsertData(
                table: "SudentsSubjects",
                columns: new[] { "StudentId", "SubjectId" },
                values: new object[] { 5, 5 });

            migrationBuilder.InsertData(
                table: "SudentsSubjects",
                columns: new[] { "StudentId", "SubjectId" },
                values: new object[] { 6, 3 });

            migrationBuilder.InsertData(
                table: "SudentsSubjects",
                columns: new[] { "StudentId", "SubjectId" },
                values: new object[] { 7, 2 });

            migrationBuilder.InsertData(
                table: "SudentsSubjects",
                columns: new[] { "StudentId", "SubjectId" },
                values: new object[] { 6, 2 });

            migrationBuilder.InsertData(
                table: "SudentsSubjects",
                columns: new[] { "StudentId", "SubjectId" },
                values: new object[] { 3, 2 });

            migrationBuilder.InsertData(
                table: "SudentsSubjects",
                columns: new[] { "StudentId", "SubjectId" },
                values: new object[] { 2, 2 });

            migrationBuilder.InsertData(
                table: "SudentsSubjects",
                columns: new[] { "StudentId", "SubjectId" },
                values: new object[] { 1, 2 });

            migrationBuilder.InsertData(
                table: "SudentsSubjects",
                columns: new[] { "StudentId", "SubjectId" },
                values: new object[] { 7, 1 });

            migrationBuilder.InsertData(
                table: "SudentsSubjects",
                columns: new[] { "StudentId", "SubjectId" },
                values: new object[] { 6, 1 });

            migrationBuilder.InsertData(
                table: "SudentsSubjects",
                columns: new[] { "StudentId", "SubjectId" },
                values: new object[] { 4, 1 });

            migrationBuilder.InsertData(
                table: "SudentsSubjects",
                columns: new[] { "StudentId", "SubjectId" },
                values: new object[] { 3, 1 });

            migrationBuilder.InsertData(
                table: "SudentsSubjects",
                columns: new[] { "StudentId", "SubjectId" },
                values: new object[] { 3, 3 });

            migrationBuilder.InsertData(
                table: "SudentsSubjects",
                columns: new[] { "StudentId", "SubjectId" },
                values: new object[] { 7, 5 });

            migrationBuilder.CreateIndex(
                name: "IX_Subjects_TeacherId",
                table: "Subjects",
                column: "TeacherId");

            migrationBuilder.CreateIndex(
                name: "IX_SudentsSubjects_SubjectId",
                table: "SudentsSubjects",
                column: "SubjectId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "SudentsSubjects");

            migrationBuilder.DropTable(
                name: "Students");

            migrationBuilder.DropTable(
                name: "Subjects");

            migrationBuilder.DropTable(
                name: "Teachers");
        }
    }
}
