using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace Orion.Context.Migrations
{
    /// <inheritdoc />
    public partial class DatabaseUpdate2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Earnings",
                table: "Under12s");

            migrationBuilder.DropColumn(
                name: "OrphansNumber",
                table: "Under12s");

            migrationBuilder.DropColumn(
                name: "ProductType",
                table: "Under12s");

            migrationBuilder.DropColumn(
                name: "EmployeeDateOfJoin",
                table: "Supervisors");

            migrationBuilder.DropColumn(
                name: "EmployeeInsurance",
                table: "Supervisors");

            migrationBuilder.DropColumn(
                name: "EmployeePension",
                table: "Supervisors");

            migrationBuilder.DropColumn(
                name: "EmployeeQualifications",
                table: "Supervisors");

            migrationBuilder.DropColumn(
                name: "EmployeeRole",
                table: "Supervisors");

            migrationBuilder.DropColumn(
                name: "EmployeeSalary",
                table: "Supervisors");

            migrationBuilder.DropColumn(
                name: "EmployeeStatus",
                table: "Supervisors");

            migrationBuilder.DropColumn(
                name: "Address",
                table: "PremiumUsers");

            migrationBuilder.DropColumn(
                name: "BirthDate",
                table: "PremiumUsers");

            migrationBuilder.DropColumn(
                name: "Email",
                table: "PremiumUsers");

            migrationBuilder.DropColumn(
                name: "FirstName",
                table: "PremiumUsers");

            migrationBuilder.DropColumn(
                name: "Gender",
                table: "PremiumUsers");

            migrationBuilder.DropColumn(
                name: "LastName",
                table: "PremiumUsers");

            migrationBuilder.DropColumn(
                name: "Password",
                table: "PremiumUsers");

            migrationBuilder.DropColumn(
                name: "Phone",
                table: "PremiumUsers");

            migrationBuilder.DropColumn(
                name: "EmployeeDateOfJoin",
                table: "OfficeWorkers");

            migrationBuilder.DropColumn(
                name: "EmployeeInsurance",
                table: "OfficeWorkers");

            migrationBuilder.DropColumn(
                name: "EmployeePension",
                table: "OfficeWorkers");

            migrationBuilder.DropColumn(
                name: "EmployeeQualifications",
                table: "OfficeWorkers");

            migrationBuilder.DropColumn(
                name: "EmployeeRole",
                table: "OfficeWorkers");

            migrationBuilder.DropColumn(
                name: "EmployeeSalary",
                table: "OfficeWorkers");

            migrationBuilder.DropColumn(
                name: "EmployeeStatus",
                table: "OfficeWorkers");

            migrationBuilder.DropColumn(
                name: "Address",
                table: "Mentors");

            migrationBuilder.DropColumn(
                name: "BirthDate",
                table: "Mentors");

            migrationBuilder.DropColumn(
                name: "Email",
                table: "Mentors");

            migrationBuilder.DropColumn(
                name: "FirstName",
                table: "Mentors");

            migrationBuilder.DropColumn(
                name: "Gender",
                table: "Mentors");

            migrationBuilder.DropColumn(
                name: "LastName",
                table: "Mentors");

            migrationBuilder.DropColumn(
                name: "Password",
                table: "Mentors");

            migrationBuilder.DropColumn(
                name: "Phone",
                table: "Mentors");

            migrationBuilder.DropColumn(
                name: "Address",
                table: "Freelancers");

            migrationBuilder.DropColumn(
                name: "BirthDate",
                table: "Freelancers");

            migrationBuilder.DropColumn(
                name: "Email",
                table: "Freelancers");

            migrationBuilder.DropColumn(
                name: "FirstName",
                table: "Freelancers");

            migrationBuilder.DropColumn(
                name: "Gender",
                table: "Freelancers");

            migrationBuilder.DropColumn(
                name: "LastName",
                table: "Freelancers");

            migrationBuilder.DropColumn(
                name: "Password",
                table: "Freelancers");

            migrationBuilder.DropColumn(
                name: "Phone",
                table: "Freelancers");

            migrationBuilder.DropColumn(
                name: "Address",
                table: "Employees");

            migrationBuilder.DropColumn(
                name: "BirthDate",
                table: "Employees");

            migrationBuilder.DropColumn(
                name: "Email",
                table: "Employees");

            migrationBuilder.DropColumn(
                name: "FirstName",
                table: "Employees");

            migrationBuilder.DropColumn(
                name: "Gender",
                table: "Employees");

            migrationBuilder.DropColumn(
                name: "LastName",
                table: "Employees");

            migrationBuilder.DropColumn(
                name: "Password",
                table: "Employees");

            migrationBuilder.DropColumn(
                name: "Phone",
                table: "Employees");

            migrationBuilder.DropColumn(
                name: "EmployeeDateOfJoin",
                table: "Deliveries");

            migrationBuilder.DropColumn(
                name: "EmployeeInsurance",
                table: "Deliveries");

            migrationBuilder.DropColumn(
                name: "EmployeePension",
                table: "Deliveries");

            migrationBuilder.DropColumn(
                name: "EmployeeQualifications",
                table: "Deliveries");

            migrationBuilder.DropColumn(
                name: "EmployeeRole",
                table: "Deliveries");

            migrationBuilder.DropColumn(
                name: "EmployeeSalary",
                table: "Deliveries");

            migrationBuilder.DropColumn(
                name: "EmployeeStatus",
                table: "Deliveries");

            migrationBuilder.DropColumn(
                name: "Address",
                table: "Customers");

            migrationBuilder.DropColumn(
                name: "BirthDate",
                table: "Customers");

            migrationBuilder.DropColumn(
                name: "Email",
                table: "Customers");

            migrationBuilder.DropColumn(
                name: "FirstName",
                table: "Customers");

            migrationBuilder.DropColumn(
                name: "Gender",
                table: "Customers");

            migrationBuilder.DropColumn(
                name: "LastName",
                table: "Customers");

            migrationBuilder.DropColumn(
                name: "Password",
                table: "Customers");

            migrationBuilder.DropColumn(
                name: "Phone",
                table: "Customers");

            migrationBuilder.DropColumn(
                name: "EmployeeDateOfJoin",
                table: "Admins");

            migrationBuilder.DropColumn(
                name: "EmployeeInsurance",
                table: "Admins");

            migrationBuilder.DropColumn(
                name: "EmployeePension",
                table: "Admins");

            migrationBuilder.DropColumn(
                name: "EmployeeQualifications",
                table: "Admins");

            migrationBuilder.DropColumn(
                name: "EmployeeRole",
                table: "Admins");

            migrationBuilder.DropColumn(
                name: "EmployeeSalary",
                table: "Admins");

            migrationBuilder.DropColumn(
                name: "EmployeeStatus",
                table: "Admins");

            migrationBuilder.DropColumn(
                name: "Earnings",
                table: "Above12s");

            migrationBuilder.DropColumn(
                name: "OrphansNumber",
                table: "Above12s");

            migrationBuilder.DropColumn(
                name: "ProductType",
                table: "Above12s");

            migrationBuilder.RenameColumn(
                name: "Deleted",
                table: "Users",
                newName: "TwoFactorEnabled");

            migrationBuilder.AddColumn<int>(
                name: "AccessFailedCount",
                table: "Users",
                type: "integer",
                nullable: false,
                defaultValue: 0);

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

            migrationBuilder.CreateTable(
                name: "EmployeeAdmin",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    EmployeeId = table.Column<int>(type: "integer", nullable: false),
                    AdminId = table.Column<int>(type: "integer", nullable: false),
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
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "EmployeeDelivery",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    EmployeeId = table.Column<int>(type: "integer", nullable: false),
                    DeliveryId = table.Column<int>(type: "integer", nullable: false),
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
                        principalColumn: "Id",
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
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_EmployeeSupervisor_Supervisors_SupervisorId",
                        column: x => x.SupervisorId,
                        principalTable: "Supervisors",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "FreelancerAbove12",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    FreelancerId = table.Column<int>(type: "integer", nullable: false),
                    Above12Id = table.Column<int>(type: "integer", nullable: false),
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
                        principalColumn: "Id",
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
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_FreelancerUnder12_Under12s_Under12Id",
                        column: x => x.Under12Id,
                        principalTable: "Under12s",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "UserCustomer",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    UserId = table.Column<int>(type: "integer", nullable: false),
                    CustomerId = table.Column<int>(type: "integer", nullable: false),
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
                    UserId = table.Column<int>(type: "integer", nullable: false),
                    EmployeeId = table.Column<int>(type: "integer", nullable: false),
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
                    UserId = table.Column<int>(type: "integer", nullable: false),
                    FreelancerId = table.Column<int>(type: "integer", nullable: false),
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
                    UserId = table.Column<int>(type: "integer", nullable: false),
                    MentorId = table.Column<int>(type: "integer", nullable: false),
                    FreelancerId = table.Column<int>(type: "integer", nullable: true),
                    Deleted = table.Column<bool>(type: "boolean", nullable: false)
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
                    UserId = table.Column<int>(type: "integer", nullable: false),
                    PremiumUserId = table.Column<int>(type: "integer", nullable: false),
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
                name: "IX_EmployeeAdmin_AdminId",
                table: "EmployeeAdmin",
                column: "AdminId");

            migrationBuilder.CreateIndex(
                name: "IX_EmployeeAdmin_EmployeeId",
                table: "EmployeeAdmin",
                column: "EmployeeId");

            migrationBuilder.CreateIndex(
                name: "IX_EmployeeDelivery_DeliveryId",
                table: "EmployeeDelivery",
                column: "DeliveryId");

            migrationBuilder.CreateIndex(
                name: "IX_EmployeeDelivery_EmployeeId",
                table: "EmployeeDelivery",
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
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "EmployeeAdmin");

            migrationBuilder.DropTable(
                name: "EmployeeDelivery");

            migrationBuilder.DropTable(
                name: "EmployeeOfficeWorker");

            migrationBuilder.DropTable(
                name: "EmployeeSupervisor");

            migrationBuilder.DropTable(
                name: "FreelancerAbove12");

            migrationBuilder.DropTable(
                name: "FreelancerUnder12");

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

            migrationBuilder.DropColumn(
                name: "AccessFailedCount",
                table: "Users");

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

            migrationBuilder.RenameColumn(
                name: "TwoFactorEnabled",
                table: "Users",
                newName: "Deleted");

            migrationBuilder.AddColumn<int>(
                name: "Earnings",
                table: "Under12s",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "OrphansNumber",
                table: "Under12s",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "ProductType",
                table: "Under12s",
                type: "text",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<DateTime>(
                name: "EmployeeDateOfJoin",
                table: "Supervisors",
                type: "timestamp with time zone",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<int>(
                name: "EmployeeInsurance",
                table: "Supervisors",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "EmployeePension",
                table: "Supervisors",
                type: "text",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "EmployeeQualifications",
                table: "Supervisors",
                type: "text",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "EmployeeRole",
                table: "Supervisors",
                type: "text",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<int>(
                name: "EmployeeSalary",
                table: "Supervisors",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "EmployeeStatus",
                table: "Supervisors",
                type: "text",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Address",
                table: "PremiumUsers",
                type: "text",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<DateTime>(
                name: "BirthDate",
                table: "PremiumUsers",
                type: "timestamp with time zone",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<string>(
                name: "Email",
                table: "PremiumUsers",
                type: "text",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "FirstName",
                table: "PremiumUsers",
                type: "text",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Gender",
                table: "PremiumUsers",
                type: "text",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "LastName",
                table: "PremiumUsers",
                type: "text",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Password",
                table: "PremiumUsers",
                type: "text",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<int>(
                name: "Phone",
                table: "PremiumUsers",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<DateTime>(
                name: "EmployeeDateOfJoin",
                table: "OfficeWorkers",
                type: "timestamp with time zone",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<int>(
                name: "EmployeeInsurance",
                table: "OfficeWorkers",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "EmployeePension",
                table: "OfficeWorkers",
                type: "text",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "EmployeeQualifications",
                table: "OfficeWorkers",
                type: "text",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "EmployeeRole",
                table: "OfficeWorkers",
                type: "text",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<int>(
                name: "EmployeeSalary",
                table: "OfficeWorkers",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "EmployeeStatus",
                table: "OfficeWorkers",
                type: "text",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Address",
                table: "Mentors",
                type: "text",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<DateTime>(
                name: "BirthDate",
                table: "Mentors",
                type: "timestamp with time zone",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<string>(
                name: "Email",
                table: "Mentors",
                type: "text",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "FirstName",
                table: "Mentors",
                type: "text",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Gender",
                table: "Mentors",
                type: "text",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "LastName",
                table: "Mentors",
                type: "text",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Password",
                table: "Mentors",
                type: "text",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<int>(
                name: "Phone",
                table: "Mentors",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "Address",
                table: "Freelancers",
                type: "text",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<DateTime>(
                name: "BirthDate",
                table: "Freelancers",
                type: "timestamp with time zone",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<string>(
                name: "Email",
                table: "Freelancers",
                type: "text",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "FirstName",
                table: "Freelancers",
                type: "text",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Gender",
                table: "Freelancers",
                type: "text",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "LastName",
                table: "Freelancers",
                type: "text",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Password",
                table: "Freelancers",
                type: "text",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<int>(
                name: "Phone",
                table: "Freelancers",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "Address",
                table: "Employees",
                type: "text",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<DateTime>(
                name: "BirthDate",
                table: "Employees",
                type: "timestamp with time zone",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<string>(
                name: "Email",
                table: "Employees",
                type: "text",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "FirstName",
                table: "Employees",
                type: "text",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Gender",
                table: "Employees",
                type: "text",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "LastName",
                table: "Employees",
                type: "text",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Password",
                table: "Employees",
                type: "text",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<int>(
                name: "Phone",
                table: "Employees",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<DateTime>(
                name: "EmployeeDateOfJoin",
                table: "Deliveries",
                type: "timestamp with time zone",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<int>(
                name: "EmployeeInsurance",
                table: "Deliveries",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "EmployeePension",
                table: "Deliveries",
                type: "text",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "EmployeeQualifications",
                table: "Deliveries",
                type: "text",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "EmployeeRole",
                table: "Deliveries",
                type: "text",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<int>(
                name: "EmployeeSalary",
                table: "Deliveries",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "EmployeeStatus",
                table: "Deliveries",
                type: "text",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Address",
                table: "Customers",
                type: "text",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<DateTime>(
                name: "BirthDate",
                table: "Customers",
                type: "timestamp with time zone",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<string>(
                name: "Email",
                table: "Customers",
                type: "text",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "FirstName",
                table: "Customers",
                type: "text",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Gender",
                table: "Customers",
                type: "text",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "LastName",
                table: "Customers",
                type: "text",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Password",
                table: "Customers",
                type: "text",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<int>(
                name: "Phone",
                table: "Customers",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<DateTime>(
                name: "EmployeeDateOfJoin",
                table: "Admins",
                type: "timestamp with time zone",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<int>(
                name: "EmployeeInsurance",
                table: "Admins",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "EmployeePension",
                table: "Admins",
                type: "text",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "EmployeeQualifications",
                table: "Admins",
                type: "text",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "EmployeeRole",
                table: "Admins",
                type: "text",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<int>(
                name: "EmployeeSalary",
                table: "Admins",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "EmployeeStatus",
                table: "Admins",
                type: "text",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<int>(
                name: "Earnings",
                table: "Above12s",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "OrphansNumber",
                table: "Above12s",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "ProductType",
                table: "Above12s",
                type: "text",
                nullable: false,
                defaultValue: "");
        }
    }
}
