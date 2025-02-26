using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Orion.Context.Migrations
{
    /// <inheritdoc />
    public partial class material5 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<byte[]>(
                name: "Mark",
                table: "Freelancers",
                type: "bytea",
                nullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Mark",
                table: "Freelancers");
        }
    }
}
