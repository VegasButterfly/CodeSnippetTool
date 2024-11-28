using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CodeSnippetTool.Migrations
{
    /// <inheritdoc />
    public partial class AddCodeAndAnalysisTextToSnippet : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "AnalysisText",
                table: "Snippets",
                type: "TEXT",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "CodeSnippetText",
                table: "Snippets",
                type: "TEXT",
                nullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "AnalysisText",
                table: "Snippets");

            migrationBuilder.DropColumn(
                name: "CodeSnippetText",
                table: "Snippets");
        }
    }
}
