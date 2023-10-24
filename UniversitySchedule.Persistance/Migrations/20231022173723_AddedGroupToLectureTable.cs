using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace UniversitySchedule.Persistance.Migrations
{
    public partial class AddedGroupToLectureTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "GroupId",
                table: "Lectures",
                type: "INTEGER",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Lectures_GroupId",
                table: "Lectures",
                column: "GroupId");

            migrationBuilder.AddForeignKey(
                name: "FK_Lectures_Groups_GroupId",
                table: "Lectures",
                column: "GroupId",
                principalTable: "Groups",
                principalColumn: "GroupId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Lectures_Groups_GroupId",
                table: "Lectures");

            migrationBuilder.DropIndex(
                name: "IX_Lectures_GroupId",
                table: "Lectures");

            migrationBuilder.DropColumn(
                name: "GroupId",
                table: "Lectures");
        }
    }
}
