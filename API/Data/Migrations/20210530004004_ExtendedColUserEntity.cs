using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace API.Data.Migrations
{
    public partial class ExtendedColUserEntity : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "Active",
                table: "ColUsers",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<string>(
                name: "AdminContact",
                table: "ColUsers",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "AdminTitle",
                table: "ColUsers",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "AverageAid",
                table: "ColUsers",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "ClassYear",
                table: "ColUsers",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "CollegeCity",
                table: "ColUsers",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "CollegeDescription",
                table: "ColUsers",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "CollegeEmail",
                table: "ColUsers",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "CollegeEnrollment",
                table: "ColUsers",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "CollegeLocation",
                table: "ColUsers",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "CollegeName",
                table: "ColUsers",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "CollegePhone",
                table: "ColUsers",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "CollegePresident",
                table: "ColUsers",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "CollegeState",
                table: "ColUsers",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "CollegeStreet",
                table: "ColUsers",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "CollegeVirtual",
                table: "ColUsers",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "CollegeWebsite",
                table: "ColUsers",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "CollegeYearFounded",
                table: "ColUsers",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "CollegeZip",
                table: "ColUsers",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "Created",
                table: "ColUsers",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<string>(
                name: "DreamJob",
                table: "ColUsers",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ExtraCurricular",
                table: "ColUsers",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "FirstName",
                table: "ColUsers",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "GPA",
                table: "ColUsers",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "GradDate",
                table: "ColUsers",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "HsGradDate",
                table: "ColUsers",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<string>(
                name: "HsLocation",
                table: "ColUsers",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "HsName",
                table: "ColUsers",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "IsActive",
                table: "ColUsers",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<DateTime>(
                name: "LastActive",
                table: "ColUsers",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<string>(
                name: "LastName",
                table: "ColUsers",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "NetPay",
                table: "ColUsers",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "ProposedMajor",
                table: "ColUsers",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "RoomAndBoard",
                table: "ColUsers",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Tuition",
                table: "ColUsers",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "ColPhotos",
                columns: table => new
                {
                    ColPhotoId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ColUrl = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    HsStudentUrl = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AdminUrl = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DateAdded = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsMainCol = table.Column<bool>(type: "bit", nullable: false),
                    IsMainHs = table.Column<bool>(type: "bit", nullable: false),
                    IsMainAdmin = table.Column<bool>(type: "bit", nullable: false),
                    PublicId = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ColUserId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ColPhotos", x => x.ColPhotoId);
                    table.ForeignKey(
                        name: "FK_ColPhotos_ColUsers_ColUserId",
                        column: x => x.ColUserId,
                        principalTable: "ColUsers",
                        principalColumn: "ColUserId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "FactFeatures",
                columns: table => new
                {
                    FactId = table.Column<int>(type: "int", nullable: false),
                    FactBullet = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CollegeId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FactFeatures", x => x.FactId);
                    table.ForeignKey(
                        name: "FK_FactFeatures_ColUsers_CollegeId",
                        column: x => x.CollegeId,
                        principalTable: "ColUsers",
                        principalColumn: "ColUserId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "MajorCats",
                columns: table => new
                {
                    MajorCatId = table.Column<int>(type: "int", nullable: false),
                    MajorCatName = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MajorCats", x => x.MajorCatId);
                });

            migrationBuilder.CreateTable(
                name: "Majors",
                columns: table => new
                {
                    MajorId = table.Column<int>(type: "int", nullable: false),
                    MajorName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MajorCatId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Majors", x => x.MajorId);
                    table.ForeignKey(
                        name: "FK_Majors_MajorCats_MajorCatId",
                        column: x => x.MajorCatId,
                        principalTable: "MajorCats",
                        principalColumn: "MajorCatId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "CollegeMajors",
                columns: table => new
                {
                    CollegeId = table.Column<int>(type: "int", nullable: false),
                    MajorId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CollegeMajors", x => new { x.CollegeId, x.MajorId });
                    table.ForeignKey(
                        name: "FK_CollegeMajors_ColUsers_CollegeId",
                        column: x => x.CollegeId,
                        principalTable: "ColUsers",
                        principalColumn: "ColUserId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CollegeMajors_Majors_MajorId",
                        column: x => x.MajorId,
                        principalTable: "Majors",
                        principalColumn: "MajorId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_CollegeMajors_MajorId",
                table: "CollegeMajors",
                column: "MajorId");

            migrationBuilder.CreateIndex(
                name: "IX_ColPhotos_ColUserId",
                table: "ColPhotos",
                column: "ColUserId");

            migrationBuilder.CreateIndex(
                name: "IX_FactFeatures_CollegeId",
                table: "FactFeatures",
                column: "CollegeId");

            migrationBuilder.CreateIndex(
                name: "IX_Majors_MajorCatId",
                table: "Majors",
                column: "MajorCatId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CollegeMajors");

            migrationBuilder.DropTable(
                name: "ColPhotos");

            migrationBuilder.DropTable(
                name: "FactFeatures");

            migrationBuilder.DropTable(
                name: "Majors");

            migrationBuilder.DropTable(
                name: "MajorCats");

            migrationBuilder.DropColumn(
                name: "Active",
                table: "ColUsers");

            migrationBuilder.DropColumn(
                name: "AdminContact",
                table: "ColUsers");

            migrationBuilder.DropColumn(
                name: "AdminTitle",
                table: "ColUsers");

            migrationBuilder.DropColumn(
                name: "AverageAid",
                table: "ColUsers");

            migrationBuilder.DropColumn(
                name: "ClassYear",
                table: "ColUsers");

            migrationBuilder.DropColumn(
                name: "CollegeCity",
                table: "ColUsers");

            migrationBuilder.DropColumn(
                name: "CollegeDescription",
                table: "ColUsers");

            migrationBuilder.DropColumn(
                name: "CollegeEmail",
                table: "ColUsers");

            migrationBuilder.DropColumn(
                name: "CollegeEnrollment",
                table: "ColUsers");

            migrationBuilder.DropColumn(
                name: "CollegeLocation",
                table: "ColUsers");

            migrationBuilder.DropColumn(
                name: "CollegeName",
                table: "ColUsers");

            migrationBuilder.DropColumn(
                name: "CollegePhone",
                table: "ColUsers");

            migrationBuilder.DropColumn(
                name: "CollegePresident",
                table: "ColUsers");

            migrationBuilder.DropColumn(
                name: "CollegeState",
                table: "ColUsers");

            migrationBuilder.DropColumn(
                name: "CollegeStreet",
                table: "ColUsers");

            migrationBuilder.DropColumn(
                name: "CollegeVirtual",
                table: "ColUsers");

            migrationBuilder.DropColumn(
                name: "CollegeWebsite",
                table: "ColUsers");

            migrationBuilder.DropColumn(
                name: "CollegeYearFounded",
                table: "ColUsers");

            migrationBuilder.DropColumn(
                name: "CollegeZip",
                table: "ColUsers");

            migrationBuilder.DropColumn(
                name: "Created",
                table: "ColUsers");

            migrationBuilder.DropColumn(
                name: "DreamJob",
                table: "ColUsers");

            migrationBuilder.DropColumn(
                name: "ExtraCurricular",
                table: "ColUsers");

            migrationBuilder.DropColumn(
                name: "FirstName",
                table: "ColUsers");

            migrationBuilder.DropColumn(
                name: "GPA",
                table: "ColUsers");

            migrationBuilder.DropColumn(
                name: "GradDate",
                table: "ColUsers");

            migrationBuilder.DropColumn(
                name: "HsGradDate",
                table: "ColUsers");

            migrationBuilder.DropColumn(
                name: "HsLocation",
                table: "ColUsers");

            migrationBuilder.DropColumn(
                name: "HsName",
                table: "ColUsers");

            migrationBuilder.DropColumn(
                name: "IsActive",
                table: "ColUsers");

            migrationBuilder.DropColumn(
                name: "LastActive",
                table: "ColUsers");

            migrationBuilder.DropColumn(
                name: "LastName",
                table: "ColUsers");

            migrationBuilder.DropColumn(
                name: "NetPay",
                table: "ColUsers");

            migrationBuilder.DropColumn(
                name: "ProposedMajor",
                table: "ColUsers");

            migrationBuilder.DropColumn(
                name: "RoomAndBoard",
                table: "ColUsers");

            migrationBuilder.DropColumn(
                name: "Tuition",
                table: "ColUsers");
        }
    }
}
