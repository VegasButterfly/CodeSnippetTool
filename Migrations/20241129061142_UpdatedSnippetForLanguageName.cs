using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CodeSnippetTool.Migrations
{
    /// <inheritdoc />
    public partial class UpdatedSnippetForLanguageName : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "LanguageName",
                table: "Snippets",
                type: "TEXT",
                nullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "LanguageName",
                table: "Snippets");
        }
    }
}
