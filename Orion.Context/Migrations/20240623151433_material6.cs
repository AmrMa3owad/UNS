using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Orion.Context.Migrations
{
    /// <inheritdoc />
    public partial class material6 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "CartId",
                table: "Materials",
                type: "integer",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Materials_CartId",
                table: "Materials",
                column: "CartId");

            migrationBuilder.AddForeignKey(
                name: "FK_Materials_Carts_CartId",
                table: "Materials",
                column: "CartId",
                principalTable: "Carts",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Materials_Carts_CartId",
                table: "Materials");

            migrationBuilder.DropIndex(
                name: "IX_Materials_CartId",
                table: "Materials");

            migrationBuilder.DropColumn(
                name: "CartId",
                table: "Materials");
        }
    }
}
