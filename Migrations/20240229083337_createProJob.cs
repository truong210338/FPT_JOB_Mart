using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FPT_JOB_Mart.Migrations
{
    /// <inheritdoc />
    public partial class createProJob : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Profile",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserID = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    FullName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Address = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Skill = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Education = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    MyFile = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Profile", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "ProJob",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RegDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Profile = table.Column<int>(type: "int", nullable: false),
                    ProId = table.Column<int>(type: "int", nullable: false),
                    JobId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProJob", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ProJob_Jobs_JobId",
                        column: x => x.JobId,
                        principalTable: "Jobs",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_ProJob_Profile_Profile",
                        column: x => x.Profile,
                        principalTable: "Profile",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_ProJob_JobId",
                table: "ProJob",
                column: "JobId");

            migrationBuilder.CreateIndex(
                name: "IX_ProJob_Profile",
                table: "ProJob",
                column: "Profile");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ProJob");

            migrationBuilder.DropTable(
                name: "Profile");
        }
    }
}
