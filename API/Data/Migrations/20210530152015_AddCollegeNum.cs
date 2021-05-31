using Microsoft.EntityFrameworkCore.Migrations;

namespace API.Data.Migrations
{
    public partial class AddCollegeNum : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CollegeMajors_ColUsers_CollegeId",
                table: "CollegeMajors");

            migrationBuilder.DropForeignKey(
                name: "FK_FactFeatures_ColUsers_CollegeId",
                table: "FactFeatures");

            migrationBuilder.RenameColumn(
                name: "CollegeId",
                table: "FactFeatures",
                newName: "CollegeNum");

            migrationBuilder.RenameIndex(
                name: "IX_FactFeatures_CollegeId",
                table: "FactFeatures",
                newName: "IX_FactFeatures_CollegeNum");

            migrationBuilder.RenameColumn(
                name: "CollegeId",
                table: "ColUsers",
                newName: "CollegeNum");

            migrationBuilder.RenameColumn(
                name: "CollegeId",
                table: "CollegeMajors",
                newName: "CollegeNum");

            migrationBuilder.AddForeignKey(
                name: "FK_CollegeMajors_ColUsers_CollegeNum",
                table: "CollegeMajors",
                column: "CollegeNum",
                principalTable: "ColUsers",
                principalColumn: "ColUserId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_FactFeatures_ColUsers_CollegeNum",
                table: "FactFeatures",
                column: "CollegeNum",
                principalTable: "ColUsers",
                principalColumn: "ColUserId",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CollegeMajors_ColUsers_CollegeNum",
                table: "CollegeMajors");

            migrationBuilder.DropForeignKey(
                name: "FK_FactFeatures_ColUsers_CollegeNum",
                table: "FactFeatures");

            migrationBuilder.RenameColumn(
                name: "CollegeNum",
                table: "FactFeatures",
                newName: "CollegeId");

            migrationBuilder.RenameIndex(
                name: "IX_FactFeatures_CollegeNum",
                table: "FactFeatures",
                newName: "IX_FactFeatures_CollegeId");

            migrationBuilder.RenameColumn(
                name: "CollegeNum",
                table: "ColUsers",
                newName: "CollegeId");

            migrationBuilder.RenameColumn(
                name: "CollegeNum",
                table: "CollegeMajors",
                newName: "CollegeId");

            migrationBuilder.AddForeignKey(
                name: "FK_CollegeMajors_ColUsers_CollegeId",
                table: "CollegeMajors",
                column: "CollegeId",
                principalTable: "ColUsers",
                principalColumn: "ColUserId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_FactFeatures_ColUsers_CollegeId",
                table: "FactFeatures",
                column: "CollegeId",
                principalTable: "ColUsers",
                principalColumn: "ColUserId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
