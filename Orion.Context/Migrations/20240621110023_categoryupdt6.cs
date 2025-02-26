using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Orion.Context.Migrations
{
    /// <inheritdoc />
    public partial class categoryupdt6 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "UserId",
                table: "Supervisors",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Supervisors_UserId",
                table: "Supervisors",
                column: "UserId");

            migrationBuilder.AddForeignKey(
                name: "FK_Supervisors_AspNetUsers_UserId",
                table: "Supervisors",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Supervisors_AspNetUsers_UserId",
                table: "Supervisors");

            migrationBuilder.DropIndex(
                name: "IX_Supervisors_UserId",
                table: "Supervisors");

            migrationBuilder.DropColumn(
                name: "UserId",
                table: "Supervisors");
        }
    }
}
