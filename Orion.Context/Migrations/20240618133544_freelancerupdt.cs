using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace Orion.Context.Migrations
{
    /// <inheritdoc />
    public partial class freelancerupdt : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Products_Above12s_Above12Id",
                table: "Products");

            migrationBuilder.DropTable(
                name: "FreelancerAbove12");

            migrationBuilder.DropTable(
                name: "FreelancerUnder12");

            migrationBuilder.DropTable(
                name: "Above12s");

            migrationBuilder.DropTable(
                name: "Under12s");

            migrationBuilder.DropIndex(
                name: "IX_Products_Above12Id",
                table: "Products");

            migrationBuilder.AddColumn<int>(
                name: "FreelancerUserId",
                table: "Products",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "SupervisorId",
                table: "Freelancers",
                type: "integer",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Products_FreelancerUserId",
                table: "Products",
                column: "FreelancerUserId");

            migrationBuilder.CreateIndex(
                name: "IX_Freelancers_SupervisorId",
                table: "Freelancers",
                column: "SupervisorId");

            migrationBuilder.AddForeignKey(
                name: "FK_Freelancers_Supervisors_SupervisorId",
                table: "Freelancers",
                column: "SupervisorId",
                principalTable: "Supervisors",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Products_Freelancers_FreelancerUserId",
                table: "Products",
                column: "FreelancerUserId",
                principalTable: "Freelancers",
                principalColumn: "UserId",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Freelancers_Supervisors_SupervisorId",
                table: "Freelancers");

            migrationBuilder.DropForeignKey(
                name: "FK_Products_Freelancers_FreelancerUserId",
                table: "Products");

            migrationBuilder.DropIndex(
                name: "IX_Products_FreelancerUserId",
                table: "Products");

            migrationBuilder.DropIndex(
                name: "IX_Freelancers_SupervisorId",
                table: "Freelancers");

            migrationBuilder.DropColumn(
                name: "FreelancerUserId",
                table: "Products");

            migrationBuilder.DropColumn(
                name: "SupervisorId",
                table: "Freelancers");

            migrationBuilder.CreateTable(
                name: "Above12s",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Deleted = table.Column<bool>(type: "boolean", nullable: false),
                    OrphanageId = table.Column<int>(type: "integer", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Above12s", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Above12s_Orphanages_OrphanageId",
                        column: x => x.OrphanageId,
                        principalTable: "Orphanages",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Under12s",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    SupervisorId = table.Column<int>(type: "integer", nullable: true),
                    Deleted = table.Column<bool>(type: "boolean", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Under12s", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Under12s_Supervisors_SupervisorId",
                        column: x => x.SupervisorId,
                        principalTable: "Supervisors",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "FreelancerAbove12",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Above12Id = table.Column<int>(type: "integer", nullable: false),
                    FreelancerId = table.Column<int>(type: "integer", nullable: false),
                    Deleted = table.Column<bool>(type: "boolean", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FreelancerAbove12", x => x.Id);
                    table.ForeignKey(
                        name: "FK_FreelancerAbove12_Above12s_Above12Id",
                        column: x => x.Above12Id,
                        principalTable: "Above12s",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_FreelancerAbove12_Freelancers_FreelancerId",
                        column: x => x.FreelancerId,
                        principalTable: "Freelancers",
                        principalColumn: "UserId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "FreelancerUnder12",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    FreelancerId = table.Column<int>(type: "integer", nullable: false),
                    Under12Id = table.Column<int>(type: "integer", nullable: false),
                    Deleted = table.Column<bool>(type: "boolean", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FreelancerUnder12", x => x.Id);
                    table.ForeignKey(
                        name: "FK_FreelancerUnder12_Freelancers_FreelancerId",
                        column: x => x.FreelancerId,
                        principalTable: "Freelancers",
                        principalColumn: "UserId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_FreelancerUnder12_Under12s_Under12Id",
                        column: x => x.Under12Id,
                        principalTable: "Under12s",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Products_Above12Id",
                table: "Products",
                column: "Above12Id");

            migrationBuilder.CreateIndex(
                name: "IX_Above12s_OrphanageId",
                table: "Above12s",
                column: "OrphanageId");

            migrationBuilder.CreateIndex(
                name: "IX_FreelancerAbove12_Above12Id",
                table: "FreelancerAbove12",
                column: "Above12Id");

            migrationBuilder.CreateIndex(
                name: "IX_FreelancerAbove12_FreelancerId",
                table: "FreelancerAbove12",
                column: "FreelancerId");

            migrationBuilder.CreateIndex(
                name: "IX_FreelancerUnder12_FreelancerId",
                table: "FreelancerUnder12",
                column: "FreelancerId");

            migrationBuilder.CreateIndex(
                name: "IX_FreelancerUnder12_Under12Id",
                table: "FreelancerUnder12",
                column: "Under12Id");

            migrationBuilder.CreateIndex(
                name: "IX_Under12s_SupervisorId",
                table: "Under12s",
                column: "SupervisorId");

            migrationBuilder.AddForeignKey(
                name: "FK_Products_Above12s_Above12Id",
                table: "Products",
                column: "Above12Id",
                principalTable: "Above12s",
                principalColumn: "Id");
        }
    }
}
