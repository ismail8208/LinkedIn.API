using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class one_to_one_projects_experinces : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "ExperienceId",
                table: "Projects",
                type: "int",
                nullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Projects_Experiences_ProjectId",
                table: "Projects",
                column: "ProjectId",
                principalTable: "Experiences",
                principalColumn: "ExperienceId",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Projects_Experiences_ProjectId",
                table: "Projects");

            migrationBuilder.DropColumn(
                name: "ExperienceId",
                table: "Projects");
        }
    }
}
