using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CodeSnippetTool.Migrations
{
    /// <inheritdoc />
    public partial class UpdateSnippetModel : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Snippets",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    SnippetName = table.Column<string>(type: "TEXT", nullable: false),
                    SnippetDescription = table.Column<string>(type: "TEXT", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "TEXT", nullable: false, defaultValueSql: "CURRENT_TIMESTAMP"),
                    CreatedById = table.Column<int>(type: "INTEGER", nullable: false),
                    ReviewedDate = table.Column<DateTime>(type: "TEXT", nullable: false, defaultValueSql: "CURRENT_TIMESTAMP"),
                    ReviewedById = table.Column<int>(type: "INTEGER", nullable: true),
                    IsAnalyzed = table.Column<bool>(type: "INTEGER", nullable: false),
                    IsReviewed = table.Column<bool>(type: "INTEGER", nullable: false),
                    IsDeleted = table.Column<bool>(type: "INTEGER", nullable: false, defaultValue: false),
                    LanguageId = table.Column<int>(type: "INTEGER", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Snippets", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Snippets_Languages_LanguageId",
                        column: x => x.LanguageId,
                        principalTable: "Languages",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.SetNull);
                    table.ForeignKey(
                        name: "FK_Snippets_Users_CreatedById",
                        column: x => x.CreatedById,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.SetNull);
                    table.ForeignKey(
                        name: "FK_Snippets_Users_ReviewedById",
                        column: x => x.ReviewedById,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.SetNull);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Snippets_CreatedById",
                table: "Snippets",
                column: "CreatedById");

            migrationBuilder.CreateIndex(
                name: "IX_Snippets_LanguageId",
                table: "Snippets",
                column: "LanguageId");

            migrationBuilder.CreateIndex(
                name: "IX_Snippets_ReviewedById",
                table: "Snippets",
                column: "ReviewedById");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Snippets");
        }
    }
}
