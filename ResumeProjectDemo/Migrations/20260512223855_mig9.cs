using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ResumeProjectDemo.Migrations
{
    /// <inheritdoc />
    public partial class mig9 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "EducationDate1",
                table: "Abouts",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "EducationDate2",
                table: "Abouts",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "EducationTitle1",
                table: "Abouts",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "EducationTitle2",
                table: "Abouts",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "SummaryExperienceDesc1",
                table: "Abouts",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "SummaryExperienceDesc2",
                table: "Abouts",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "SummaryExperienceTitle1",
                table: "Abouts",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "SummaryExperienceTitle2",
                table: "Abouts",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "EducationDate1",
                table: "Abouts");

            migrationBuilder.DropColumn(
                name: "EducationDate2",
                table: "Abouts");

            migrationBuilder.DropColumn(
                name: "EducationTitle1",
                table: "Abouts");

            migrationBuilder.DropColumn(
                name: "EducationTitle2",
                table: "Abouts");

            migrationBuilder.DropColumn(
                name: "SummaryExperienceDesc1",
                table: "Abouts");

            migrationBuilder.DropColumn(
                name: "SummaryExperienceDesc2",
                table: "Abouts");

            migrationBuilder.DropColumn(
                name: "SummaryExperienceTitle1",
                table: "Abouts");

            migrationBuilder.DropColumn(
                name: "SummaryExperienceTitle2",
                table: "Abouts");
        }
    }
}
