using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace UniversitySchedule.Persistance.Migrations
{
    public partial class InitialMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Groups",
                columns: table => new
                {
                    GroupId = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Name = table.Column<string>(type: "TEXT", maxLength: 6, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Groups", x => x.GroupId);
                });

            migrationBuilder.CreateTable(
                name: "LectureRooms",
                columns: table => new
                {
                    LectureRoomId = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    LectureRoomNumber = table.Column<string>(type: "TEXT", maxLength: 5, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LectureRooms", x => x.LectureRoomId);
                });

            migrationBuilder.CreateTable(
                name: "Teachers",
                columns: table => new
                {
                    TeacherId = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Name = table.Column<string>(type: "TEXT", maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Teachers", x => x.TeacherId);
                });

            migrationBuilder.CreateTable(
                name: "Lectures",
                columns: table => new
                {
                    LectureId = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Name = table.Column<string>(type: "TEXT", maxLength: 50, nullable: false),
                    TimePeriod = table.Column<int>(type: "INTEGER", nullable: false),
                    DayOfTheWeek = table.Column<int>(type: "INTEGER", nullable: false),
                    IsEvenWeek = table.Column<bool>(type: "INTEGER", nullable: true),
                    LectureRoomId = table.Column<int>(type: "INTEGER", nullable: true),
                    TeacherId = table.Column<int>(type: "INTEGER", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Lectures", x => x.LectureId);
                    table.ForeignKey(
                        name: "FK_Lectures_LectureRooms_LectureRoomId",
                        column: x => x.LectureRoomId,
                        principalTable: "LectureRooms",
                        principalColumn: "LectureRoomId");
                    table.ForeignKey(
                        name: "FK_Lectures_Teachers_TeacherId",
                        column: x => x.TeacherId,
                        principalTable: "Teachers",
                        principalColumn: "TeacherId");
                });

            migrationBuilder.CreateIndex(
                name: "IX_Lectures_LectureRoomId",
                table: "Lectures",
                column: "LectureRoomId");

            migrationBuilder.CreateIndex(
                name: "IX_Lectures_TeacherId",
                table: "Lectures",
                column: "TeacherId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Groups");

            migrationBuilder.DropTable(
                name: "Lectures");

            migrationBuilder.DropTable(
                name: "LectureRooms");

            migrationBuilder.DropTable(
                name: "Teachers");
        }
    }
}
