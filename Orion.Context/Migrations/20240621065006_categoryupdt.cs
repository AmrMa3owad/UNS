using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Orion.Context.Migrations
{
    /// <inheritdoc />
    public partial class categoryupdt : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "MaterialType",
                table: "Materials",
                newName: "MaterialName");

            migrationBuilder.RenameColumn(
                name: "MaterialQuantity",
                table: "Materials",
                newName: "MaterialSizes");

            migrationBuilder.AddColumn<byte[]>(
                name: "Image",
                table: "Materials",
                type: "bytea",
                nullable: false,
                defaultValue: new byte[0]);

            migrationBuilder.AddColumn<int>(
                name: "MaterialColors",
                table: "Materials",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "MaterialDetails",
                table: "Materials",
                type: "text",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AlterColumn<string>(
                name: "SubCategory",
                table: "Category",
                type: "text",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "text");

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Category",
                type: "text",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "text");

            migrationBuilder.AlterColumn<byte[]>(
                name: "Img",
                table: "Category",
                type: "bytea",
                nullable: true,
                oldClrType: typeof(byte[]),
                oldType: "bytea");

            migrationBuilder.AddColumn<byte[]>(
                name: "Image",
                table: "Admins",
                type: "bytea",
                nullable: false,
                defaultValue: new byte[0]);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Image",
                table: "Materials");

            migrationBuilder.DropColumn(
                name: "MaterialColors",
                table: "Materials");

            migrationBuilder.DropColumn(
                name: "MaterialDetails",
                table: "Materials");

            migrationBuilder.DropColumn(
                name: "Image",
                table: "Admins");

            migrationBuilder.RenameColumn(
                name: "MaterialSizes",
                table: "Materials",
                newName: "MaterialQuantity");

            migrationBuilder.RenameColumn(
                name: "MaterialName",
                table: "Materials",
                newName: "MaterialType");

            migrationBuilder.AlterColumn<string>(
                name: "SubCategory",
                table: "Category",
                type: "text",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "text",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Category",
                type: "text",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "text",
                oldNullable: true);

            migrationBuilder.AlterColumn<byte[]>(
                name: "Img",
                table: "Category",
                type: "bytea",
                nullable: false,
                defaultValue: new byte[0],
                oldClrType: typeof(byte[]),
                oldType: "bytea",
                oldNullable: true);
        }
    }
}
