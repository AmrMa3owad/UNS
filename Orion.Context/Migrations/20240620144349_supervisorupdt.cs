using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace Orion.Context.Migrations
{
    /// <inheritdoc />
    public partial class supervisorupdt : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ContactUs_Customers_CustomerId",
                table: "ContactUs");

            migrationBuilder.DropForeignKey(
                name: "FK_CustomerAdvertisements_Customers_CustomerId",
                table: "CustomerAdvertisements");

            migrationBuilder.DropForeignKey(
                name: "FK_CustomerEvent_Customers_CustomersUserId",
                table: "CustomerEvent");

            migrationBuilder.DropForeignKey(
                name: "FK_CustomerProducts_Customers_CustomerId",
                table: "CustomerProducts");

            migrationBuilder.DropForeignKey(
                name: "FK_Customers_AspNetUsers_UserId",
                table: "Customers");

            migrationBuilder.DropForeignKey(
                name: "FK_Feedbacks_Customers_CustomerId",
                table: "Feedbacks");

            migrationBuilder.DropForeignKey(
                name: "FK_Freelancers_Supervisors_SupervisorId",
                table: "Freelancers");

            migrationBuilder.DropForeignKey(
                name: "FK_Orders_Customers_CustomerId",
                table: "Orders");

            migrationBuilder.DropForeignKey(
                name: "FK_Products_Supervisors_SupervisorId",
                table: "Products");

            migrationBuilder.DropForeignKey(
                name: "FK_SupervisorOrphanage_Supervisors_SupervisorId",
                table: "SupervisorOrphanage");

            migrationBuilder.DropTable(
                name: "EmployeeAdmin");

            migrationBuilder.DropTable(
                name: "EmployeeOfficeWorker");

            migrationBuilder.DropTable(
                name: "EmployeeSupervisor");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Supervisors",
                table: "Supervisors");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Customers",
                table: "Customers");

            migrationBuilder.DropColumn(
                name: "Deleted",
                table: "Supervisors");

            migrationBuilder.DropColumn(
                name: "Reviews",
                table: "Products");

            migrationBuilder.DropColumn(
                name: "Deleted",
                table: "OfficeWorkers");

            migrationBuilder.DropColumn(
                name: "Deleted",
                table: "Admins");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Supervisors",
                newName: "UserId");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "OfficeWorkers",
                newName: "EmployeeId");

            migrationBuilder.RenameColumn(
                name: "UserId",
                table: "Customers",
                newName: "EmployeeUserId");

            migrationBuilder.RenameColumn(
                name: "CustomersUserId",
                table: "CustomerEvent",
                newName: "CustomersEmployeeId");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Admins",
                newName: "EmployeeId");

            migrationBuilder.AlterColumn<int>(
                name: "UserId",
                table: "Supervisors",
                type: "integer",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "integer")
                .OldAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

            migrationBuilder.AddColumn<int>(
                name: "EmployeeId",
                table: "Supervisors",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AlterColumn<int>(
                name: "EmployeeId",
                table: "OfficeWorkers",
                type: "integer",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "integer")
                .OldAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

            migrationBuilder.AlterColumn<string>(
                name: "EmployeeType",
                table: "Employees",
                type: "text",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "text");

            migrationBuilder.AlterColumn<string>(
                name: "EmployeeStatus",
                table: "Employees",
                type: "text",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "text");

            migrationBuilder.AlterColumn<int>(
                name: "EmployeeSalary",
                table: "Employees",
                type: "integer",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "integer");

            migrationBuilder.AlterColumn<string>(
                name: "EmployeeQualifications",
                table: "Employees",
                type: "text",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "text");

            migrationBuilder.AlterColumn<string>(
                name: "EmployeeDateOfJoin",
                table: "Employees",
                type: "text",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "text");

            migrationBuilder.AddColumn<int>(
                name: "EmployeeId",
                table: "Customers",
                type: "integer",
                nullable: false,
                defaultValue: 0)
                .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

            migrationBuilder.AddColumn<int>(
                name: "CustomerEmployeeId",
                table: "AspNetUsers",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AlterColumn<int>(
                name: "EmployeeId",
                table: "Admins",
                type: "integer",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "integer")
                .OldAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Supervisors",
                table: "Supervisors",
                column: "EmployeeId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Customers",
                table: "Customers",
                column: "EmployeeId");

            migrationBuilder.CreateTable(
                name: "Reviews",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Msg = table.Column<string>(type: "text", nullable: true),
                    Time = table.Column<string>(type: "text", nullable: true),
                    CustomerId = table.Column<int>(type: "integer", nullable: true),
                    ProductId = table.Column<int>(type: "integer", nullable: true),
                    FreelancerUserId = table.Column<int>(type: "integer", nullable: false),
                    Deleted = table.Column<bool>(type: "boolean", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Reviews", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Reviews_Customers_CustomerId",
                        column: x => x.CustomerId,
                        principalTable: "Customers",
                        principalColumn: "EmployeeId");
                    table.ForeignKey(
                        name: "FK_Reviews_Freelancers_FreelancerUserId",
                        column: x => x.FreelancerUserId,
                        principalTable: "Freelancers",
                        principalColumn: "UserId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Reviews_Products_ProductId",
                        column: x => x.ProductId,
                        principalTable: "Products",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateIndex(
                name: "IX_Supervisors_UserId",
                table: "Supervisors",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_Customers_EmployeeUserId",
                table: "Customers",
                column: "EmployeeUserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUsers_CustomerEmployeeId",
                table: "AspNetUsers",
                column: "CustomerEmployeeId");

            migrationBuilder.CreateIndex(
                name: "IX_Reviews_CustomerId",
                table: "Reviews",
                column: "CustomerId");

            migrationBuilder.CreateIndex(
                name: "IX_Reviews_FreelancerUserId",
                table: "Reviews",
                column: "FreelancerUserId");

            migrationBuilder.CreateIndex(
                name: "IX_Reviews_ProductId",
                table: "Reviews",
                column: "ProductId");

            migrationBuilder.AddForeignKey(
                name: "FK_Admins_Employees_EmployeeId",
                table: "Admins",
                column: "EmployeeId",
                principalTable: "Employees",
                principalColumn: "UserId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_AspNetUsers_Customers_CustomerEmployeeId",
                table: "AspNetUsers",
                column: "CustomerEmployeeId",
                principalTable: "Customers",
                principalColumn: "EmployeeId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ContactUs_Customers_CustomerId",
                table: "ContactUs",
                column: "CustomerId",
                principalTable: "Customers",
                principalColumn: "EmployeeId");

            migrationBuilder.AddForeignKey(
                name: "FK_CustomerAdvertisements_Customers_CustomerId",
                table: "CustomerAdvertisements",
                column: "CustomerId",
                principalTable: "Customers",
                principalColumn: "EmployeeId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_CustomerEvent_Customers_CustomersEmployeeId",
                table: "CustomerEvent",
                column: "CustomersEmployeeId",
                principalTable: "Customers",
                principalColumn: "EmployeeId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_CustomerProducts_Customers_CustomerId",
                table: "CustomerProducts",
                column: "CustomerId",
                principalTable: "Customers",
                principalColumn: "EmployeeId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Customers_Employees_EmployeeUserId",
                table: "Customers",
                column: "EmployeeUserId",
                principalTable: "Employees",
                principalColumn: "UserId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Feedbacks_Customers_CustomerId",
                table: "Feedbacks",
                column: "CustomerId",
                principalTable: "Customers",
                principalColumn: "EmployeeId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Freelancers_Supervisors_SupervisorId",
                table: "Freelancers",
                column: "SupervisorId",
                principalTable: "Supervisors",
                principalColumn: "EmployeeId");

            migrationBuilder.AddForeignKey(
                name: "FK_OfficeWorkers_Employees_EmployeeId",
                table: "OfficeWorkers",
                column: "EmployeeId",
                principalTable: "Employees",
                principalColumn: "UserId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Orders_Customers_CustomerId",
                table: "Orders",
                column: "CustomerId",
                principalTable: "Customers",
                principalColumn: "EmployeeId");

            migrationBuilder.AddForeignKey(
                name: "FK_Products_Supervisors_SupervisorId",
                table: "Products",
                column: "SupervisorId",
                principalTable: "Supervisors",
                principalColumn: "EmployeeId");

            migrationBuilder.AddForeignKey(
                name: "FK_SupervisorOrphanage_Supervisors_SupervisorId",
                table: "SupervisorOrphanage",
                column: "SupervisorId",
                principalTable: "Supervisors",
                principalColumn: "EmployeeId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Supervisors_AspNetUsers_UserId",
                table: "Supervisors",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Supervisors_Employees_EmployeeId",
                table: "Supervisors",
                column: "EmployeeId",
                principalTable: "Employees",
                principalColumn: "UserId",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Admins_Employees_EmployeeId",
                table: "Admins");

            migrationBuilder.DropForeignKey(
                name: "FK_AspNetUsers_Customers_CustomerEmployeeId",
                table: "AspNetUsers");

            migrationBuilder.DropForeignKey(
                name: "FK_ContactUs_Customers_CustomerId",
                table: "ContactUs");

            migrationBuilder.DropForeignKey(
                name: "FK_CustomerAdvertisements_Customers_CustomerId",
                table: "CustomerAdvertisements");

            migrationBuilder.DropForeignKey(
                name: "FK_CustomerEvent_Customers_CustomersEmployeeId",
                table: "CustomerEvent");

            migrationBuilder.DropForeignKey(
                name: "FK_CustomerProducts_Customers_CustomerId",
                table: "CustomerProducts");

            migrationBuilder.DropForeignKey(
                name: "FK_Customers_Employees_EmployeeUserId",
                table: "Customers");

            migrationBuilder.DropForeignKey(
                name: "FK_Feedbacks_Customers_CustomerId",
                table: "Feedbacks");

            migrationBuilder.DropForeignKey(
                name: "FK_Freelancers_Supervisors_SupervisorId",
                table: "Freelancers");

            migrationBuilder.DropForeignKey(
                name: "FK_OfficeWorkers_Employees_EmployeeId",
                table: "OfficeWorkers");

            migrationBuilder.DropForeignKey(
                name: "FK_Orders_Customers_CustomerId",
                table: "Orders");

            migrationBuilder.DropForeignKey(
                name: "FK_Products_Supervisors_SupervisorId",
                table: "Products");

            migrationBuilder.DropForeignKey(
                name: "FK_SupervisorOrphanage_Supervisors_SupervisorId",
                table: "SupervisorOrphanage");

            migrationBuilder.DropForeignKey(
                name: "FK_Supervisors_AspNetUsers_UserId",
                table: "Supervisors");

            migrationBuilder.DropForeignKey(
                name: "FK_Supervisors_Employees_EmployeeId",
                table: "Supervisors");

            migrationBuilder.DropTable(
                name: "Reviews");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Supervisors",
                table: "Supervisors");

            migrationBuilder.DropIndex(
                name: "IX_Supervisors_UserId",
                table: "Supervisors");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Customers",
                table: "Customers");

            migrationBuilder.DropIndex(
                name: "IX_Customers_EmployeeUserId",
                table: "Customers");

            migrationBuilder.DropIndex(
                name: "IX_AspNetUsers_CustomerEmployeeId",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "EmployeeId",
                table: "Supervisors");

            migrationBuilder.DropColumn(
                name: "EmployeeId",
                table: "Customers");

            migrationBuilder.DropColumn(
                name: "CustomerEmployeeId",
                table: "AspNetUsers");

            migrationBuilder.RenameColumn(
                name: "UserId",
                table: "Supervisors",
                newName: "Id");

            migrationBuilder.RenameColumn(
                name: "EmployeeId",
                table: "OfficeWorkers",
                newName: "Id");

            migrationBuilder.RenameColumn(
                name: "EmployeeUserId",
                table: "Customers",
                newName: "UserId");

            migrationBuilder.RenameColumn(
                name: "CustomersEmployeeId",
                table: "CustomerEvent",
                newName: "CustomersUserId");

            migrationBuilder.RenameColumn(
                name: "EmployeeId",
                table: "Admins",
                newName: "Id");

            migrationBuilder.AlterColumn<int>(
                name: "Id",
                table: "Supervisors",
                type: "integer",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "integer")
                .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

            migrationBuilder.AddColumn<bool>(
                name: "Deleted",
                table: "Supervisors",
                type: "boolean",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<string>(
                name: "Reviews",
                table: "Products",
                type: "text",
                nullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "Id",
                table: "OfficeWorkers",
                type: "integer",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "integer")
                .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

            migrationBuilder.AddColumn<bool>(
                name: "Deleted",
                table: "OfficeWorkers",
                type: "boolean",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AlterColumn<string>(
                name: "EmployeeType",
                table: "Employees",
                type: "text",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "text",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "EmployeeStatus",
                table: "Employees",
                type: "text",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "text",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "EmployeeSalary",
                table: "Employees",
                type: "integer",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "integer",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "EmployeeQualifications",
                table: "Employees",
                type: "text",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "text",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "EmployeeDateOfJoin",
                table: "Employees",
                type: "text",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "text",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "Id",
                table: "Admins",
                type: "integer",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "integer")
                .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

            migrationBuilder.AddColumn<bool>(
                name: "Deleted",
                table: "Admins",
                type: "boolean",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Supervisors",
                table: "Supervisors",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Customers",
                table: "Customers",
                column: "UserId");

            migrationBuilder.CreateTable(
                name: "EmployeeAdmin",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    AdminId = table.Column<int>(type: "integer", nullable: false),
                    EmployeeId = table.Column<int>(type: "integer", nullable: false),
                    Deleted = table.Column<bool>(type: "boolean", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EmployeeAdmin", x => x.Id);
                    table.ForeignKey(
                        name: "FK_EmployeeAdmin_Admins_AdminId",
                        column: x => x.AdminId,
                        principalTable: "Admins",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_EmployeeAdmin_Employees_EmployeeId",
                        column: x => x.EmployeeId,
                        principalTable: "Employees",
                        principalColumn: "UserId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "EmployeeOfficeWorker",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    EmployeeId = table.Column<int>(type: "integer", nullable: false),
                    OfficeWorkerId = table.Column<int>(type: "integer", nullable: false),
                    Deleted = table.Column<bool>(type: "boolean", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EmployeeOfficeWorker", x => x.Id);
                    table.ForeignKey(
                        name: "FK_EmployeeOfficeWorker_Employees_EmployeeId",
                        column: x => x.EmployeeId,
                        principalTable: "Employees",
                        principalColumn: "UserId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_EmployeeOfficeWorker_OfficeWorkers_OfficeWorkerId",
                        column: x => x.OfficeWorkerId,
                        principalTable: "OfficeWorkers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "EmployeeSupervisor",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    EmployeeId = table.Column<int>(type: "integer", nullable: false),
                    SupervisorId = table.Column<int>(type: "integer", nullable: false),
                    Deleted = table.Column<bool>(type: "boolean", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EmployeeSupervisor", x => x.Id);
                    table.ForeignKey(
                        name: "FK_EmployeeSupervisor_Employees_EmployeeId",
                        column: x => x.EmployeeId,
                        principalTable: "Employees",
                        principalColumn: "UserId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_EmployeeSupervisor_Supervisors_SupervisorId",
                        column: x => x.SupervisorId,
                        principalTable: "Supervisors",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_EmployeeAdmin_AdminId",
                table: "EmployeeAdmin",
                column: "AdminId");

            migrationBuilder.CreateIndex(
                name: "IX_EmployeeAdmin_EmployeeId",
                table: "EmployeeAdmin",
                column: "EmployeeId");

            migrationBuilder.CreateIndex(
                name: "IX_EmployeeOfficeWorker_EmployeeId",
                table: "EmployeeOfficeWorker",
                column: "EmployeeId");

            migrationBuilder.CreateIndex(
                name: "IX_EmployeeOfficeWorker_OfficeWorkerId",
                table: "EmployeeOfficeWorker",
                column: "OfficeWorkerId");

            migrationBuilder.CreateIndex(
                name: "IX_EmployeeSupervisor_EmployeeId",
                table: "EmployeeSupervisor",
                column: "EmployeeId");

            migrationBuilder.CreateIndex(
                name: "IX_EmployeeSupervisor_SupervisorId",
                table: "EmployeeSupervisor",
                column: "SupervisorId");

            migrationBuilder.AddForeignKey(
                name: "FK_ContactUs_Customers_CustomerId",
                table: "ContactUs",
                column: "CustomerId",
                principalTable: "Customers",
                principalColumn: "UserId");

            migrationBuilder.AddForeignKey(
                name: "FK_CustomerAdvertisements_Customers_CustomerId",
                table: "CustomerAdvertisements",
                column: "CustomerId",
                principalTable: "Customers",
                principalColumn: "UserId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_CustomerEvent_Customers_CustomersUserId",
                table: "CustomerEvent",
                column: "CustomersUserId",
                principalTable: "Customers",
                principalColumn: "UserId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_CustomerProducts_Customers_CustomerId",
                table: "CustomerProducts",
                column: "CustomerId",
                principalTable: "Customers",
                principalColumn: "UserId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Customers_AspNetUsers_UserId",
                table: "Customers",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Feedbacks_Customers_CustomerId",
                table: "Feedbacks",
                column: "CustomerId",
                principalTable: "Customers",
                principalColumn: "UserId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Freelancers_Supervisors_SupervisorId",
                table: "Freelancers",
                column: "SupervisorId",
                principalTable: "Supervisors",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Orders_Customers_CustomerId",
                table: "Orders",
                column: "CustomerId",
                principalTable: "Customers",
                principalColumn: "UserId");

            migrationBuilder.AddForeignKey(
                name: "FK_Products_Supervisors_SupervisorId",
                table: "Products",
                column: "SupervisorId",
                principalTable: "Supervisors",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_SupervisorOrphanage_Supervisors_SupervisorId",
                table: "SupervisorOrphanage",
                column: "SupervisorId",
                principalTable: "Supervisors",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
