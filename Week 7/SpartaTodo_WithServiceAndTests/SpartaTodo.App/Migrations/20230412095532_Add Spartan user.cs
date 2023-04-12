using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SpartaTodo.App.Migrations
{
    /// <inheritdoc />
    public partial class AddSpartanuser : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "SpartanId",
                table: "TodoItems",
                type: "nvarchar(450)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Discriminator",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.CreateIndex(
                name: "IX_TodoItems_SpartanId",
                table: "TodoItems",
                column: "SpartanId");

            migrationBuilder.AddForeignKey(
                name: "FK_TodoItems_AspNetUsers_SpartanId",
                table: "TodoItems",
                column: "SpartanId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_TodoItems_AspNetUsers_SpartanId",
                table: "TodoItems");

            migrationBuilder.DropIndex(
                name: "IX_TodoItems_SpartanId",
                table: "TodoItems");

            migrationBuilder.DropColumn(
                name: "SpartanId",
                table: "TodoItems");

            migrationBuilder.DropColumn(
                name: "Discriminator",
                table: "AspNetUsers");
        }
    }
}
