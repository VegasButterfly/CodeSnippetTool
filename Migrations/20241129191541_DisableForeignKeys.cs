using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CodeSnippetTool.Migrations
{
    /// <inheritdoc />
    public partial class DisableForeignKeys : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            // Disable foreign key checks
            migrationBuilder.Sql("PRAGMA foreign_keys = 0;");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            // Re-enable foreign key checks
            migrationBuilder.Sql("PRAGMA foreign_keys = 1;");
        }
    }
}
