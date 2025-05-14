using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ExpenseTracker.Migrations
{
    /// <inheritdoc />
    public partial class LinkCategoriesToAccounts : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "account_id",
                table: "categories",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_categories_account_id",
                table: "categories",
                column: "account_id");

            migrationBuilder.AddForeignKey(
                name: "FK_categories_accounts_account_id",
                table: "categories",
                column: "account_id",
                principalTable: "accounts",
                principalColumn: "account_id",
                onDelete: ReferentialAction.Restrict);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_categories_accounts_account_id",
                table: "categories");

            migrationBuilder.DropIndex(
                name: "IX_categories_account_id",
                table: "categories");

            migrationBuilder.DropColumn(
                name: "account_id",
                table: "categories");
        }
    }
}
