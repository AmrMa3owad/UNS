using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace Orion.Context.Migrations
{
    /// <inheritdoc />
    public partial class UpdateUser : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Admins_Websites_WebsiteId",
                table: "Admins");

            migrationBuilder.DropForeignKey(
                name: "FK_CustomerEvent_Customers_CustomersId",
                table: "CustomerEvent");

            migrationBuilder.DropForeignKey(
                name: "FK_Customers_Websites_WebsiteId",
                table: "Customers");

            migrationBuilder.DropForeignKey(
                name: "FK_DeliveryOrders_Deliveries_DeliveryId",
                table: "DeliveryOrders");

            migrationBuilder.DropForeignKey(
                name: "FK_DeliveryOrders_Orders_OrderId",
                table: "DeliveryOrders");

            migrationBuilder.DropForeignKey(
                name: "FK_Devices_Admins_AdminId",
                table: "Devices");

            migrationBuilder.DropForeignKey(
                name: "FK_Devices_OfficeWorkers_OfficeWorkerId",
                table: "Devices");

            migrationBuilder.DropForeignKey(
                name: "FK_EmployeeAdmin_Employees_EmployeeId",
                table: "EmployeeAdmin");

            migrationBuilder.DropForeignKey(
                name: "FK_EmployeeOfficeWorker_Employees_EmployeeId",
                table: "EmployeeOfficeWorker");

            migrationBuilder.DropForeignKey(
                name: "FK_EmployeeSupervisor_Employees_EmployeeId",
                table: "EmployeeSupervisor");

            migrationBuilder.DropForeignKey(
                name: "FK_FreelancerAbove12_Freelancers_FreelancerId",
                table: "FreelancerAbove12");

            migrationBuilder.DropForeignKey(
                name: "FK_Freelancers_Orphanages_OrphanageId",
                table: "Freelancers");

            migrationBuilder.DropForeignKey(
                name: "FK_FreelancerUnder12_Freelancers_FreelancerId",
                table: "FreelancerUnder12");

            migrationBuilder.DropForeignKey(
                name: "FK_Mentors_Crafts_CraftId",
                table: "Mentors");

            migrationBuilder.DropForeignKey(
                name: "FK_Orders_Customers_CustomerId",
                table: "Orders");

            migrationBuilder.DropForeignKey(
                name: "FK_Products_Above12s_Above12Id",
                table: "Products");

            migrationBuilder.DropForeignKey(
                name: "FK_Products_Events_EventId",
                table: "Products");

            migrationBuilder.DropForeignKey(
                name: "FK_Products_Supervisors_SupervisorId",
                table: "Products");

            migrationBuilder.DropForeignKey(
                name: "FK_Sponsors_Donations_DonationId",
                table: "Sponsors");

            migrationBuilder.DropForeignKey(
                name: "FK_Sponsors_Events_EventId",
                table: "Sponsors");

            migrationBuilder.DropForeignKey(
                name: "FK_Under12s_Supervisors_SupervisorId",
                table: "Under12s");

            migrationBuilder.DropForeignKey(
                name: "FK_Websites_OfficeWorkers_OfficeWorkerId",
                table: "Websites");

            migrationBuilder.DropTable(
                name: "EmployeeDelivery");

            migrationBuilder.DropTable(
                name: "UserCustomer");

            migrationBuilder.DropTable(
                name: "UserEmployee");

            migrationBuilder.DropTable(
                name: "UserFreelancer");

            migrationBuilder.DropTable(
                name: "UserMentor");

            migrationBuilder.DropTable(
                name: "UserPremiumUser");

            migrationBuilder.DropTable(
                name: "PremiumUsers");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Freelancers",
                table: "Freelancers");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Employees",
                table: "Employees");

            migrationBuilder.DropColumn(
                name: "OrderQuantity",
                table: "Orders");

            migrationBuilder.DropColumn(
                name: "Deleted",
                table: "Mentors");

            migrationBuilder.DropColumn(
                name: "Id",
                table: "Freelancers");

            migrationBuilder.DropColumn(
                name: "Deleted",
                table: "Freelancers");

            migrationBuilder.DropColumn(
                name: "Id",
                table: "Employees");

            migrationBuilder.DropColumn(
                name: "Deleted",
                table: "Employees");

            migrationBuilder.DropColumn(
                name: "EmployeePension",
                table: "Employees");

            migrationBuilder.DropColumn(
                name: "DeliveryShift",
                table: "Deliveries");

            migrationBuilder.DropColumn(
                name: "Deleted",
                table: "Customers");

            migrationBuilder.RenameColumn(
                name: "Phone",
                table: "Users",
                newName: "AccessFailedCount");

            migrationBuilder.RenameColumn(
                name: "Deleted",
                table: "Users",
                newName: "TwoFactorEnabled");

            migrationBuilder.RenameColumn(
                name: "OrphanageNumber",
                table: "Orphanages",
                newName: "OrphanageRegion");

            migrationBuilder.RenameColumn(
                name: "OrphanageAddress",
                table: "Orphanages",
                newName: "OrphanageInfo");

            migrationBuilder.RenameColumn(
                name: "OrphanNumber",
                table: "Mentors",
                newName: "OrphansNumber");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Mentors",
                newName: "UserId");

            migrationBuilder.RenameColumn(
                name: "OrphansNumber",
                table: "Freelancers",
                newName: "UserId");

            migrationBuilder.RenameColumn(
                name: "EmployeeRole",
                table: "Employees",
                newName: "EmployeeType");

            migrationBuilder.RenameColumn(
                name: "EmployeeInsurance",
                table: "Employees",
                newName: "UserId");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Customers",
                newName: "UserId");

            migrationBuilder.RenameColumn(
                name: "CustomersId",
                table: "CustomerEvent",
                newName: "CustomersUserId");

            migrationBuilder.RenameColumn(
                name: "CraftItem",
                table: "Crafts",
                newName: "CraftType");

            migrationBuilder.AlterColumn<int>(
                name: "OfficeWorkerId",
                table: "Websites",
                type: "integer",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "integer");

            migrationBuilder.AlterColumn<string>(
                name: "Email",
                table: "Users",
                type: "text",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "text");

            migrationBuilder.AlterColumn<string>(
                name: "BirthDate",
                table: "Users",
                type: "text",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "timestamp with time zone");

            migrationBuilder.AddColumn<string>(
                name: "ConcurrencyStamp",
                table: "Users",
                type: "text",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "EmailConfirmed",
                table: "Users",
                type: "boolean",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "LockoutEnabled",
                table: "Users",
                type: "boolean",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<DateTimeOffset>(
                name: "LockoutEnd",
                table: "Users",
                type: "timestamp with time zone",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "NormalizedEmail",
                table: "Users",
                type: "text",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "NormalizedUserName",
                table: "Users",
                type: "text",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "PasswordHash",
                table: "Users",
                type: "text",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "PhoneNumber",
                table: "Users",
                type: "text",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "PhoneNumberConfirmed",
                table: "Users",
                type: "boolean",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<string>(
                name: "SecurityStamp",
                table: "Users",
                type: "text",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "UserName",
                table: "Users",
                type: "text",
                nullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "SupervisorId",
                table: "Under12s",
                type: "integer",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "integer");

            migrationBuilder.AddColumn<string>(
                name: "SupervisorInfo",
                table: "Supervisors",
                type: "text",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<byte[]>(
                name: "SupervisorPhoto",
                table: "Supervisors",
                type: "bytea",
                nullable: false,
                defaultValue: new byte[0]);

            migrationBuilder.AddColumn<string>(
                name: "SupervisorRegion",
                table: "Supervisors",
                type: "text",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "SupervisorSkill",
                table: "Supervisors",
                type: "text",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AlterColumn<int>(
                name: "EventId",
                table: "Sponsors",
                type: "integer",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "integer");

            migrationBuilder.AlterColumn<int>(
                name: "DonationId",
                table: "Sponsors",
                type: "integer",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "integer");

            migrationBuilder.AlterColumn<int>(
                name: "SupervisorId",
                table: "Products",
                type: "integer",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "integer");

            migrationBuilder.AlterColumn<byte[]>(
                name: "ProductImage",
                table: "Products",
                type: "bytea",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "text");

            migrationBuilder.AlterColumn<int>(
                name: "EventId",
                table: "Products",
                type: "integer",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "integer");

            migrationBuilder.AlterColumn<int>(
                name: "Above12Id",
                table: "Products",
                type: "integer",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "integer");

            migrationBuilder.AlterColumn<int>(
                name: "CustomerId",
                table: "Payments",
                type: "integer",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "integer");

            migrationBuilder.AddColumn<byte[]>(
                name: "OrphanageLogo",
                table: "Orphanages",
                type: "bytea",
                nullable: false,
                defaultValue: new byte[0]);

            migrationBuilder.AlterColumn<string>(
                name: "OrderDate",
                table: "Orders",
                type: "text",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "timestamp with time zone");

            migrationBuilder.AlterColumn<int>(
                name: "CustomerId",
                table: "Orders",
                type: "integer",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "integer");

            migrationBuilder.AddColumn<string>(
                name: "OrderType",
                table: "Orders",
                type: "text",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AlterColumn<int>(
                name: "CraftId",
                table: "Mentors",
                type: "integer",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "integer");

            migrationBuilder.AlterColumn<int>(
                name: "UserId",
                table: "Mentors",
                type: "integer",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "integer")
                .OldAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

            migrationBuilder.AlterColumn<int>(
                name: "OrphanageId",
                table: "Freelancers",
                type: "integer",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "integer");

            migrationBuilder.AddColumn<string>(
                name: "FreelancerType",
                table: "Freelancers",
                type: "text",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Skill",
                table: "Freelancers",
                type: "text",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<byte[]>(
                name: "StarPhoto",
                table: "Freelancers",
                type: "bytea",
                nullable: false,
                defaultValue: new byte[0]);

            migrationBuilder.AlterColumn<string>(
                name: "EventDate",
                table: "Events",
                type: "text",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "timestamp with time zone");

            migrationBuilder.AlterColumn<int>(
                name: "BoothId",
                table: "Events",
                type: "integer",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "integer");

            migrationBuilder.AlterColumn<string>(
                name: "EmployeeDateOfJoin",
                table: "Employees",
                type: "text",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "timestamp with time zone");

            migrationBuilder.AlterColumn<string>(
                name: "DonationTime",
                table: "Donations",
                type: "text",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "timestamp with time zone");

            migrationBuilder.AlterColumn<int>(
                name: "CustomerId",
                table: "Donations",
                type: "integer",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "integer");

            migrationBuilder.AlterColumn<int>(
                name: "OfficeWorkerId",
                table: "Devices",
                type: "integer",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "integer");

            migrationBuilder.AlterColumn<string>(
                name: "MaintenanceDate",
                table: "Devices",
                type: "text",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "timestamp with time zone");

            migrationBuilder.AlterColumn<int>(
                name: "AdminId",
                table: "Devices",
                type: "integer",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "integer");

            migrationBuilder.AlterColumn<int>(
                name: "OrderId",
                table: "DeliveryOrders",
                type: "integer",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "integer");

            migrationBuilder.AlterColumn<int>(
                name: "DeliveryId",
                table: "DeliveryOrders",
                type: "integer",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "integer");

            migrationBuilder.AddColumn<int>(
                name: "Place",
                table: "DeliveryOrders",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "DeliveryPhone",
                table: "Deliveries",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AlterColumn<int>(
                name: "WebsiteId",
                table: "Customers",
                type: "integer",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "integer");

            migrationBuilder.AlterColumn<int>(
                name: "UserId",
                table: "Customers",
                type: "integer",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "integer")
                .OldAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

            migrationBuilder.AddColumn<int>(
                name: "PreCommunityId",
                table: "Customers",
                type: "integer",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "BoothPlace",
                table: "Booths",
                type: "text",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "AdvertisementPeriod",
                table: "Advertisements",
                type: "text",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AlterColumn<int>(
                name: "WebsiteId",
                table: "Admins",
                type: "integer",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "integer");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Freelancers",
                table: "Freelancers",
                column: "UserId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Employees",
                table: "Employees",
                column: "UserId");

            migrationBuilder.CreateTable(
                name: "Category",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Name = table.Column<string>(type: "text", nullable: false),
                    Img = table.Column<byte[]>(type: "bytea", nullable: false),
                    SubCategory = table.Column<string>(type: "text", nullable: false),
                    AdminId = table.Column<int>(type: "integer", nullable: true),
                    Deleted = table.Column<bool>(type: "boolean", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Category", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Category_Admins_AdminId",
                        column: x => x.AdminId,
                        principalTable: "Admins",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "ContactUs",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Mail = table.Column<string>(type: "text", nullable: false),
                    Msg = table.Column<string>(type: "text", nullable: false),
                    CustomerId = table.Column<int>(type: "integer", nullable: true),
                    AdminId = table.Column<int>(type: "integer", nullable: true),
                    Deleted = table.Column<bool>(type: "boolean", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ContactUs", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ContactUs_Admins_AdminId",
                        column: x => x.AdminId,
                        principalTable: "Admins",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_ContactUs_Customers_CustomerId",
                        column: x => x.CustomerId,
                        principalTable: "Customers",
                        principalColumn: "UserId");
                });

            migrationBuilder.CreateTable(
                name: "SupervisorOrphanage",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    SupervisorId = table.Column<int>(type: "integer", nullable: false),
                    OrphanageId = table.Column<int>(type: "integer", nullable: false),
                    Deleted = table.Column<bool>(type: "boolean", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SupervisorOrphanage", x => x.Id);
                    table.ForeignKey(
                        name: "FK_SupervisorOrphanage_Orphanages_OrphanageId",
                        column: x => x.OrphanageId,
                        principalTable: "Orphanages",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_SupervisorOrphanage_Supervisors_SupervisorId",
                        column: x => x.SupervisorId,
                        principalTable: "Supervisors",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Customers_PreCommunityId",
                table: "Customers",
                column: "PreCommunityId");

            migrationBuilder.CreateIndex(
                name: "IX_Category_AdminId",
                table: "Category",
                column: "AdminId");

            migrationBuilder.CreateIndex(
                name: "IX_ContactUs_AdminId",
                table: "ContactUs",
                column: "AdminId");

            migrationBuilder.CreateIndex(
                name: "IX_ContactUs_CustomerId",
                table: "ContactUs",
                column: "CustomerId");

            migrationBuilder.CreateIndex(
                name: "IX_SupervisorOrphanage_OrphanageId",
                table: "SupervisorOrphanage",
                column: "OrphanageId");

            migrationBuilder.CreateIndex(
                name: "IX_SupervisorOrphanage_SupervisorId",
                table: "SupervisorOrphanage",
                column: "SupervisorId");

            migrationBuilder.AddForeignKey(
                name: "FK_Admins_Websites_WebsiteId",
                table: "Admins",
                column: "WebsiteId",
                principalTable: "Websites",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_CustomerEvent_Customers_CustomersUserId",
                table: "CustomerEvent",
                column: "CustomersUserId",
                principalTable: "Customers",
                principalColumn: "UserId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Customers_PreCommunities_PreCommunityId",
                table: "Customers",
                column: "PreCommunityId",
                principalTable: "PreCommunities",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Customers_Users_UserId",
                table: "Customers",
                column: "UserId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Customers_Websites_WebsiteId",
                table: "Customers",
                column: "WebsiteId",
                principalTable: "Websites",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_DeliveryOrders_Deliveries_DeliveryId",
                table: "DeliveryOrders",
                column: "DeliveryId",
                principalTable: "Deliveries",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_DeliveryOrders_Orders_OrderId",
                table: "DeliveryOrders",
                column: "OrderId",
                principalTable: "Orders",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Devices_Admins_AdminId",
                table: "Devices",
                column: "AdminId",
                principalTable: "Admins",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Devices_OfficeWorkers_OfficeWorkerId",
                table: "Devices",
                column: "OfficeWorkerId",
                principalTable: "OfficeWorkers",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_EmployeeAdmin_Employees_EmployeeId",
                table: "EmployeeAdmin",
                column: "EmployeeId",
                principalTable: "Employees",
                principalColumn: "UserId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_EmployeeOfficeWorker_Employees_EmployeeId",
                table: "EmployeeOfficeWorker",
                column: "EmployeeId",
                principalTable: "Employees",
                principalColumn: "UserId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Employees_Users_UserId",
                table: "Employees",
                column: "UserId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_EmployeeSupervisor_Employees_EmployeeId",
                table: "EmployeeSupervisor",
                column: "EmployeeId",
                principalTable: "Employees",
                principalColumn: "UserId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_FreelancerAbove12_Freelancers_FreelancerId",
                table: "FreelancerAbove12",
                column: "FreelancerId",
                principalTable: "Freelancers",
                principalColumn: "UserId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Freelancers_Orphanages_OrphanageId",
                table: "Freelancers",
                column: "OrphanageId",
                principalTable: "Orphanages",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Freelancers_Users_UserId",
                table: "Freelancers",
                column: "UserId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_FreelancerUnder12_Freelancers_FreelancerId",
                table: "FreelancerUnder12",
                column: "FreelancerId",
                principalTable: "Freelancers",
                principalColumn: "UserId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Mentors_Crafts_CraftId",
                table: "Mentors",
                column: "CraftId",
                principalTable: "Crafts",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Mentors_Users_UserId",
                table: "Mentors",
                column: "UserId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Orders_Customers_CustomerId",
                table: "Orders",
                column: "CustomerId",
                principalTable: "Customers",
                principalColumn: "UserId");

            migrationBuilder.AddForeignKey(
                name: "FK_Products_Above12s_Above12Id",
                table: "Products",
                column: "Above12Id",
                principalTable: "Above12s",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Products_Events_EventId",
                table: "Products",
                column: "EventId",
                principalTable: "Events",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Products_Supervisors_SupervisorId",
                table: "Products",
                column: "SupervisorId",
                principalTable: "Supervisors",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Sponsors_Donations_DonationId",
                table: "Sponsors",
                column: "DonationId",
                principalTable: "Donations",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Sponsors_Events_EventId",
                table: "Sponsors",
                column: "EventId",
                principalTable: "Events",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Under12s_Supervisors_SupervisorId",
                table: "Under12s",
                column: "SupervisorId",
                principalTable: "Supervisors",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Websites_OfficeWorkers_OfficeWorkerId",
                table: "Websites",
                column: "OfficeWorkerId",
                principalTable: "OfficeWorkers",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Admins_Websites_WebsiteId",
                table: "Admins");

            migrationBuilder.DropForeignKey(
                name: "FK_CustomerEvent_Customers_CustomersUserId",
                table: "CustomerEvent");

            migrationBuilder.DropForeignKey(
                name: "FK_Customers_PreCommunities_PreCommunityId",
                table: "Customers");

            migrationBuilder.DropForeignKey(
                name: "FK_Customers_Users_UserId",
                table: "Customers");

            migrationBuilder.DropForeignKey(
                name: "FK_Customers_Websites_WebsiteId",
                table: "Customers");

            migrationBuilder.DropForeignKey(
                name: "FK_DeliveryOrders_Deliveries_DeliveryId",
                table: "DeliveryOrders");

            migrationBuilder.DropForeignKey(
                name: "FK_DeliveryOrders_Orders_OrderId",
                table: "DeliveryOrders");

            migrationBuilder.DropForeignKey(
                name: "FK_Devices_Admins_AdminId",
                table: "Devices");

            migrationBuilder.DropForeignKey(
                name: "FK_Devices_OfficeWorkers_OfficeWorkerId",
                table: "Devices");

            migrationBuilder.DropForeignKey(
                name: "FK_EmployeeAdmin_Employees_EmployeeId",
                table: "EmployeeAdmin");

            migrationBuilder.DropForeignKey(
                name: "FK_EmployeeOfficeWorker_Employees_EmployeeId",
                table: "EmployeeOfficeWorker");

            migrationBuilder.DropForeignKey(
                name: "FK_Employees_Users_UserId",
                table: "Employees");

            migrationBuilder.DropForeignKey(
                name: "FK_EmployeeSupervisor_Employees_EmployeeId",
                table: "EmployeeSupervisor");

            migrationBuilder.DropForeignKey(
                name: "FK_FreelancerAbove12_Freelancers_FreelancerId",
                table: "FreelancerAbove12");

            migrationBuilder.DropForeignKey(
                name: "FK_Freelancers_Orphanages_OrphanageId",
                table: "Freelancers");

            migrationBuilder.DropForeignKey(
                name: "FK_Freelancers_Users_UserId",
                table: "Freelancers");

            migrationBuilder.DropForeignKey(
                name: "FK_FreelancerUnder12_Freelancers_FreelancerId",
                table: "FreelancerUnder12");

            migrationBuilder.DropForeignKey(
                name: "FK_Mentors_Crafts_CraftId",
                table: "Mentors");

            migrationBuilder.DropForeignKey(
                name: "FK_Mentors_Users_UserId",
                table: "Mentors");

            migrationBuilder.DropForeignKey(
                name: "FK_Orders_Customers_CustomerId",
                table: "Orders");

            migrationBuilder.DropForeignKey(
                name: "FK_Products_Above12s_Above12Id",
                table: "Products");

            migrationBuilder.DropForeignKey(
                name: "FK_Products_Events_EventId",
                table: "Products");

            migrationBuilder.DropForeignKey(
                name: "FK_Products_Supervisors_SupervisorId",
                table: "Products");

            migrationBuilder.DropForeignKey(
                name: "FK_Sponsors_Donations_DonationId",
                table: "Sponsors");

            migrationBuilder.DropForeignKey(
                name: "FK_Sponsors_Events_EventId",
                table: "Sponsors");

            migrationBuilder.DropForeignKey(
                name: "FK_Under12s_Supervisors_SupervisorId",
                table: "Under12s");

            migrationBuilder.DropForeignKey(
                name: "FK_Websites_OfficeWorkers_OfficeWorkerId",
                table: "Websites");

            migrationBuilder.DropTable(
                name: "Category");

            migrationBuilder.DropTable(
                name: "ContactUs");

            migrationBuilder.DropTable(
                name: "SupervisorOrphanage");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Freelancers",
                table: "Freelancers");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Employees",
                table: "Employees");

            migrationBuilder.DropIndex(
                name: "IX_Customers_PreCommunityId",
                table: "Customers");

            migrationBuilder.DropColumn(
                name: "ConcurrencyStamp",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "EmailConfirmed",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "LockoutEnabled",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "LockoutEnd",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "NormalizedEmail",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "NormalizedUserName",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "PasswordHash",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "PhoneNumber",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "PhoneNumberConfirmed",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "SecurityStamp",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "UserName",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "SupervisorInfo",
                table: "Supervisors");

            migrationBuilder.DropColumn(
                name: "SupervisorPhoto",
                table: "Supervisors");

            migrationBuilder.DropColumn(
                name: "SupervisorRegion",
                table: "Supervisors");

            migrationBuilder.DropColumn(
                name: "SupervisorSkill",
                table: "Supervisors");

            migrationBuilder.DropColumn(
                name: "OrphanageLogo",
                table: "Orphanages");

            migrationBuilder.DropColumn(
                name: "OrderType",
                table: "Orders");

            migrationBuilder.DropColumn(
                name: "FreelancerType",
                table: "Freelancers");

            migrationBuilder.DropColumn(
                name: "Skill",
                table: "Freelancers");

            migrationBuilder.DropColumn(
                name: "StarPhoto",
                table: "Freelancers");

            migrationBuilder.DropColumn(
                name: "Place",
                table: "DeliveryOrders");

            migrationBuilder.DropColumn(
                name: "DeliveryPhone",
                table: "Deliveries");

            migrationBuilder.DropColumn(
                name: "PreCommunityId",
                table: "Customers");

            migrationBuilder.DropColumn(
                name: "BoothPlace",
                table: "Booths");

            migrationBuilder.DropColumn(
                name: "AdvertisementPeriod",
                table: "Advertisements");

            migrationBuilder.RenameColumn(
                name: "TwoFactorEnabled",
                table: "Users",
                newName: "Deleted");

            migrationBuilder.RenameColumn(
                name: "AccessFailedCount",
                table: "Users",
                newName: "Phone");

            migrationBuilder.RenameColumn(
                name: "OrphanageRegion",
                table: "Orphanages",
                newName: "OrphanageNumber");

            migrationBuilder.RenameColumn(
                name: "OrphanageInfo",
                table: "Orphanages",
                newName: "OrphanageAddress");

            migrationBuilder.RenameColumn(
                name: "OrphansNumber",
                table: "Mentors",
                newName: "OrphanNumber");

            migrationBuilder.RenameColumn(
                name: "UserId",
                table: "Mentors",
                newName: "Id");

            migrationBuilder.RenameColumn(
                name: "UserId",
                table: "Freelancers",
                newName: "OrphansNumber");

            migrationBuilder.RenameColumn(
                name: "EmployeeType",
                table: "Employees",
                newName: "EmployeeRole");

            migrationBuilder.RenameColumn(
                name: "UserId",
                table: "Employees",
                newName: "EmployeeInsurance");

            migrationBuilder.RenameColumn(
                name: "UserId",
                table: "Customers",
                newName: "Id");

            migrationBuilder.RenameColumn(
                name: "CustomersUserId",
                table: "CustomerEvent",
                newName: "CustomersId");

            migrationBuilder.RenameColumn(
                name: "CraftType",
                table: "Crafts",
                newName: "CraftItem");

            migrationBuilder.AlterColumn<int>(
                name: "OfficeWorkerId",
                table: "Websites",
                type: "integer",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "integer",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Email",
                table: "Users",
                type: "text",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "text",
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "BirthDate",
                table: "Users",
                type: "timestamp with time zone",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "text");

            migrationBuilder.AlterColumn<int>(
                name: "SupervisorId",
                table: "Under12s",
                type: "integer",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "integer",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "EventId",
                table: "Sponsors",
                type: "integer",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "integer",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "DonationId",
                table: "Sponsors",
                type: "integer",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "integer",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "SupervisorId",
                table: "Products",
                type: "integer",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "integer",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "ProductImage",
                table: "Products",
                type: "text",
                nullable: false,
                oldClrType: typeof(byte[]),
                oldType: "bytea");

            migrationBuilder.AlterColumn<int>(
                name: "EventId",
                table: "Products",
                type: "integer",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "integer",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "Above12Id",
                table: "Products",
                type: "integer",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "integer",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "CustomerId",
                table: "Payments",
                type: "integer",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "integer",
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "OrderDate",
                table: "Orders",
                type: "timestamp with time zone",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "text");

            migrationBuilder.AlterColumn<int>(
                name: "CustomerId",
                table: "Orders",
                type: "integer",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "integer",
                oldNullable: true);

            migrationBuilder.AddColumn<int>(
                name: "OrderQuantity",
                table: "Orders",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AlterColumn<int>(
                name: "CraftId",
                table: "Mentors",
                type: "integer",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "integer",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "Id",
                table: "Mentors",
                type: "integer",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "integer")
                .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

            migrationBuilder.AddColumn<bool>(
                name: "Deleted",
                table: "Mentors",
                type: "boolean",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AlterColumn<int>(
                name: "OrphanageId",
                table: "Freelancers",
                type: "integer",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "integer",
                oldNullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Id",
                table: "Freelancers",
                type: "integer",
                nullable: false,
                defaultValue: 0)
                .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

            migrationBuilder.AddColumn<bool>(
                name: "Deleted",
                table: "Freelancers",
                type: "boolean",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AlterColumn<DateTime>(
                name: "EventDate",
                table: "Events",
                type: "timestamp with time zone",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "text");

            migrationBuilder.AlterColumn<int>(
                name: "BoothId",
                table: "Events",
                type: "integer",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "integer",
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "EmployeeDateOfJoin",
                table: "Employees",
                type: "timestamp with time zone",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "text");

            migrationBuilder.AddColumn<int>(
                name: "Id",
                table: "Employees",
                type: "integer",
                nullable: false,
                defaultValue: 0)
                .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

            migrationBuilder.AddColumn<bool>(
                name: "Deleted",
                table: "Employees",
                type: "boolean",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<string>(
                name: "EmployeePension",
                table: "Employees",
                type: "text",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AlterColumn<DateTime>(
                name: "DonationTime",
                table: "Donations",
                type: "timestamp with time zone",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "text");

            migrationBuilder.AlterColumn<int>(
                name: "CustomerId",
                table: "Donations",
                type: "integer",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "integer",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "OfficeWorkerId",
                table: "Devices",
                type: "integer",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "integer",
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "MaintenanceDate",
                table: "Devices",
                type: "timestamp with time zone",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "text");

            migrationBuilder.AlterColumn<int>(
                name: "AdminId",
                table: "Devices",
                type: "integer",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "integer",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "OrderId",
                table: "DeliveryOrders",
                type: "integer",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "integer",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "DeliveryId",
                table: "DeliveryOrders",
                type: "integer",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "integer",
                oldNullable: true);

            migrationBuilder.AddColumn<string>(
                name: "DeliveryShift",
                table: "Deliveries",
                type: "text",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AlterColumn<int>(
                name: "WebsiteId",
                table: "Customers",
                type: "integer",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "integer",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "Id",
                table: "Customers",
                type: "integer",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "integer")
                .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

            migrationBuilder.AddColumn<bool>(
                name: "Deleted",
                table: "Customers",
                type: "boolean",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AlterColumn<int>(
                name: "WebsiteId",
                table: "Admins",
                type: "integer",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "integer",
                oldNullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Freelancers",
                table: "Freelancers",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Employees",
                table: "Employees",
                column: "Id");

            migrationBuilder.CreateTable(
                name: "EmployeeDelivery",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    DeliveryId = table.Column<int>(type: "integer", nullable: false),
                    EmployeeId = table.Column<int>(type: "integer", nullable: false),
                    Deleted = table.Column<bool>(type: "boolean", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EmployeeDelivery", x => x.Id);
                    table.ForeignKey(
                        name: "FK_EmployeeDelivery_Deliveries_DeliveryId",
                        column: x => x.DeliveryId,
                        principalTable: "Deliveries",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_EmployeeDelivery_Employees_EmployeeId",
                        column: x => x.EmployeeId,
                        principalTable: "Employees",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "PremiumUsers",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    PreCommunityId = table.Column<int>(type: "integer", nullable: false),
                    Deleted = table.Column<bool>(type: "boolean", nullable: false),
                    Fees = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PremiumUsers", x => x.Id);
                    table.ForeignKey(
                        name: "FK_PremiumUsers_PreCommunities_PreCommunityId",
                        column: x => x.PreCommunityId,
                        principalTable: "PreCommunities",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "UserCustomer",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    CustomerId = table.Column<int>(type: "integer", nullable: false),
                    UserId = table.Column<int>(type: "integer", nullable: false),
                    Deleted = table.Column<bool>(type: "boolean", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserCustomer", x => x.Id);
                    table.ForeignKey(
                        name: "FK_UserCustomer_Customers_CustomerId",
                        column: x => x.CustomerId,
                        principalTable: "Customers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_UserCustomer_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "UserEmployee",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    EmployeeId = table.Column<int>(type: "integer", nullable: false),
                    UserId = table.Column<int>(type: "integer", nullable: false),
                    Deleted = table.Column<bool>(type: "boolean", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserEmployee", x => x.Id);
                    table.ForeignKey(
                        name: "FK_UserEmployee_Employees_EmployeeId",
                        column: x => x.EmployeeId,
                        principalTable: "Employees",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_UserEmployee_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "UserFreelancer",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    FreelancerId = table.Column<int>(type: "integer", nullable: false),
                    UserId = table.Column<int>(type: "integer", nullable: false),
                    Deleted = table.Column<bool>(type: "boolean", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserFreelancer", x => x.Id);
                    table.ForeignKey(
                        name: "FK_UserFreelancer_Freelancers_FreelancerId",
                        column: x => x.FreelancerId,
                        principalTable: "Freelancers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_UserFreelancer_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "UserMentor",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    MentorId = table.Column<int>(type: "integer", nullable: false),
                    UserId = table.Column<int>(type: "integer", nullable: false),
                    Deleted = table.Column<bool>(type: "boolean", nullable: false),
                    FreelancerId = table.Column<int>(type: "integer", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserMentor", x => x.Id);
                    table.ForeignKey(
                        name: "FK_UserMentor_Freelancers_FreelancerId",
                        column: x => x.FreelancerId,
                        principalTable: "Freelancers",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_UserMentor_Mentors_MentorId",
                        column: x => x.MentorId,
                        principalTable: "Mentors",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_UserMentor_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "UserPremiumUser",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    PremiumUserId = table.Column<int>(type: "integer", nullable: false),
                    UserId = table.Column<int>(type: "integer", nullable: false),
                    Deleted = table.Column<bool>(type: "boolean", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserPremiumUser", x => x.Id);
                    table.ForeignKey(
                        name: "FK_UserPremiumUser_PremiumUsers_PremiumUserId",
                        column: x => x.PremiumUserId,
                        principalTable: "PremiumUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_UserPremiumUser_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_EmployeeDelivery_DeliveryId",
                table: "EmployeeDelivery",
                column: "DeliveryId");

            migrationBuilder.CreateIndex(
                name: "IX_EmployeeDelivery_EmployeeId",
                table: "EmployeeDelivery",
                column: "EmployeeId");

            migrationBuilder.CreateIndex(
                name: "IX_PremiumUsers_PreCommunityId",
                table: "PremiumUsers",
                column: "PreCommunityId");

            migrationBuilder.CreateIndex(
                name: "IX_UserCustomer_CustomerId",
                table: "UserCustomer",
                column: "CustomerId");

            migrationBuilder.CreateIndex(
                name: "IX_UserCustomer_UserId",
                table: "UserCustomer",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_UserEmployee_EmployeeId",
                table: "UserEmployee",
                column: "EmployeeId");

            migrationBuilder.CreateIndex(
                name: "IX_UserEmployee_UserId",
                table: "UserEmployee",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_UserFreelancer_FreelancerId",
                table: "UserFreelancer",
                column: "FreelancerId");

            migrationBuilder.CreateIndex(
                name: "IX_UserFreelancer_UserId",
                table: "UserFreelancer",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_UserMentor_FreelancerId",
                table: "UserMentor",
                column: "FreelancerId");

            migrationBuilder.CreateIndex(
                name: "IX_UserMentor_MentorId",
                table: "UserMentor",
                column: "MentorId");

            migrationBuilder.CreateIndex(
                name: "IX_UserMentor_UserId",
                table: "UserMentor",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_UserPremiumUser_PremiumUserId",
                table: "UserPremiumUser",
                column: "PremiumUserId");

            migrationBuilder.CreateIndex(
                name: "IX_UserPremiumUser_UserId",
                table: "UserPremiumUser",
                column: "UserId");

            migrationBuilder.AddForeignKey(
                name: "FK_Admins_Websites_WebsiteId",
                table: "Admins",
                column: "WebsiteId",
                principalTable: "Websites",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_CustomerEvent_Customers_CustomersId",
                table: "CustomerEvent",
                column: "CustomersId",
                principalTable: "Customers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Customers_Websites_WebsiteId",
                table: "Customers",
                column: "WebsiteId",
                principalTable: "Websites",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_DeliveryOrders_Deliveries_DeliveryId",
                table: "DeliveryOrders",
                column: "DeliveryId",
                principalTable: "Deliveries",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_DeliveryOrders_Orders_OrderId",
                table: "DeliveryOrders",
                column: "OrderId",
                principalTable: "Orders",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Devices_Admins_AdminId",
                table: "Devices",
                column: "AdminId",
                principalTable: "Admins",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Devices_OfficeWorkers_OfficeWorkerId",
                table: "Devices",
                column: "OfficeWorkerId",
                principalTable: "OfficeWorkers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_EmployeeAdmin_Employees_EmployeeId",
                table: "EmployeeAdmin",
                column: "EmployeeId",
                principalTable: "Employees",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_EmployeeOfficeWorker_Employees_EmployeeId",
                table: "EmployeeOfficeWorker",
                column: "EmployeeId",
                principalTable: "Employees",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_EmployeeSupervisor_Employees_EmployeeId",
                table: "EmployeeSupervisor",
                column: "EmployeeId",
                principalTable: "Employees",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_FreelancerAbove12_Freelancers_FreelancerId",
                table: "FreelancerAbove12",
                column: "FreelancerId",
                principalTable: "Freelancers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Freelancers_Orphanages_OrphanageId",
                table: "Freelancers",
                column: "OrphanageId",
                principalTable: "Orphanages",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_FreelancerUnder12_Freelancers_FreelancerId",
                table: "FreelancerUnder12",
                column: "FreelancerId",
                principalTable: "Freelancers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Mentors_Crafts_CraftId",
                table: "Mentors",
                column: "CraftId",
                principalTable: "Crafts",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Orders_Customers_CustomerId",
                table: "Orders",
                column: "CustomerId",
                principalTable: "Customers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Products_Above12s_Above12Id",
                table: "Products",
                column: "Above12Id",
                principalTable: "Above12s",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Products_Events_EventId",
                table: "Products",
                column: "EventId",
                principalTable: "Events",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Products_Supervisors_SupervisorId",
                table: "Products",
                column: "SupervisorId",
                principalTable: "Supervisors",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Sponsors_Donations_DonationId",
                table: "Sponsors",
                column: "DonationId",
                principalTable: "Donations",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Sponsors_Events_EventId",
                table: "Sponsors",
                column: "EventId",
                principalTable: "Events",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Under12s_Supervisors_SupervisorId",
                table: "Under12s",
                column: "SupervisorId",
                principalTable: "Supervisors",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Websites_OfficeWorkers_OfficeWorkerId",
                table: "Websites",
                column: "OfficeWorkerId",
                principalTable: "OfficeWorkers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
