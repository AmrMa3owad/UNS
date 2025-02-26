using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace Orion.Context.Migrations
{
    /// <inheritdoc />
    public partial class supervisorupdt3 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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
                name: "FK_Orders_Customers_CustomerId",
                table: "Orders");

            migrationBuilder.DropForeignKey(
                name: "FK_Reviews_Customers_CustomerId",
                table: "Reviews");

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
                table: "Customers");

            migrationBuilder.DropColumn(
                name: "CustomerEmployeeId",
                table: "AspNetUsers");

            migrationBuilder.RenameColumn(
                name: "EmployeeUserId",
                table: "Customers",
                newName: "UserId");

            migrationBuilder.RenameColumn(
                name: "CustomersEmployeeId",
                table: "CustomerEvent",
                newName: "CustomersUserId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Customers",
                table: "Customers",
                column: "UserId");

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
                name: "FK_Orders_Customers_CustomerId",
                table: "Orders",
                column: "CustomerId",
                principalTable: "Customers",
                principalColumn: "UserId");

            migrationBuilder.AddForeignKey(
                name: "FK_Reviews_Customers_CustomerId",
                table: "Reviews",
                column: "CustomerId",
                principalTable: "Customers",
                principalColumn: "UserId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
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
                name: "FK_Orders_Customers_CustomerId",
                table: "Orders");

            migrationBuilder.DropForeignKey(
                name: "FK_Reviews_Customers_CustomerId",
                table: "Reviews");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Customers",
                table: "Customers");

            migrationBuilder.RenameColumn(
                name: "UserId",
                table: "Customers",
                newName: "EmployeeUserId");

            migrationBuilder.RenameColumn(
                name: "CustomersUserId",
                table: "CustomerEvent",
                newName: "CustomersEmployeeId");

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

            migrationBuilder.AddPrimaryKey(
                name: "PK_Customers",
                table: "Customers",
                column: "EmployeeId");

            migrationBuilder.CreateIndex(
                name: "IX_Customers_EmployeeUserId",
                table: "Customers",
                column: "EmployeeUserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUsers_CustomerEmployeeId",
                table: "AspNetUsers",
                column: "CustomerEmployeeId");

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
                name: "FK_Orders_Customers_CustomerId",
                table: "Orders",
                column: "CustomerId",
                principalTable: "Customers",
                principalColumn: "EmployeeId");

            migrationBuilder.AddForeignKey(
                name: "FK_Reviews_Customers_CustomerId",
                table: "Reviews",
                column: "CustomerId",
                principalTable: "Customers",
                principalColumn: "EmployeeId");
        }
    }
}
