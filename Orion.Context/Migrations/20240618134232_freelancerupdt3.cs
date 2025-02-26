using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Orion.Context.Migrations
{
    /// <inheritdoc />
    public partial class freelancerupdt3 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Products_Freelancers_FreelancerUserId",
                table: "Products");

            migrationBuilder.DropIndex(
                name: "IX_Products_FreelancerUserId",
                table: "Products");

            migrationBuilder.DropColumn(
                name: "FreelancerUserId",
                table: "Products");

            migrationBuilder.AddColumn<int>(
                name: "FreelancerId",
                table: "Products",
                type: "integer",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Products_FreelancerId",
                table: "Products",
                column: "FreelancerId");

            migrationBuilder.AddForeignKey(
                name: "FK_Products_Freelancers_FreelancerId",
                table: "Products",
                column: "FreelancerId",
                principalTable: "Freelancers",
                principalColumn: "UserId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Products_Freelancers_FreelancerId",
                table: "Products");

            migrationBuilder.DropIndex(
                name: "IX_Products_FreelancerId",
                table: "Products");

            migrationBuilder.DropColumn(
                name: "FreelancerId",
                table: "Products");

            migrationBuilder.AddColumn<int>(
                name: "FreelancerUserId",
                table: "Products",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Products_FreelancerUserId",
                table: "Products",
                column: "FreelancerUserId");

            migrationBuilder.AddForeignKey(
                name: "FK_Products_Freelancers_FreelancerUserId",
                table: "Products",
                column: "FreelancerUserId",
                principalTable: "Freelancers",
                principalColumn: "UserId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
