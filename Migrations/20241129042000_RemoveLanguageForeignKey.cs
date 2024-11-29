using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CodeSnippetTool.Migrations
{
    /// <inheritdoc />
    public partial class RemoveLanguageForeignKey : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Snippets_Languages_LanguageId",
                table: "Snippets");           
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            
            migrationBuilder.AddForeignKey(
                name: "FK_Snippets_Languages_LanguageId",
                table: "Snippets",
                column: "LanguageId",
                principalTable: "Languages",
                principalColumn: "Id",
                onDelete: ReferentialAction.SetNull);
        }
    }
}
