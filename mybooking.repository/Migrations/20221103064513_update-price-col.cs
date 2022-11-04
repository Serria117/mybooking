using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace mybooking.repository.Migrations
{
    public partial class updatepricecol : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "RoomNumber",
                table: "apartment",
                type: "nvarchar(50)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "longtext")
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AddColumn<decimal>(
                name: "BasePrice",
                table: "apartment",
                type: "decimal(18,2)",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<decimal>(
                name: "DiscountRate",
                table: "apartment",
                type: "decimal(65,30)",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "IsDiscount",
                table: "apartment",
                type: "tinyint(1)",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<int>(
                name: "NumberOfBed",
                table: "apartment",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "NumberOfGuest",
                table: "apartment",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "NumberOfRoom",
                table: "apartment",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "BasePrice",
                table: "apartment");

            migrationBuilder.DropColumn(
                name: "DiscountRate",
                table: "apartment");

            migrationBuilder.DropColumn(
                name: "IsDiscount",
                table: "apartment");

            migrationBuilder.DropColumn(
                name: "NumberOfBed",
                table: "apartment");

            migrationBuilder.DropColumn(
                name: "NumberOfGuest",
                table: "apartment");

            migrationBuilder.DropColumn(
                name: "NumberOfRoom",
                table: "apartment");

            migrationBuilder.AlterColumn<string>(
                name: "RoomNumber",
                table: "apartment",
                type: "longtext",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(50)")
                .Annotation("MySql:CharSet", "utf8mb4");
        }
    }
}
