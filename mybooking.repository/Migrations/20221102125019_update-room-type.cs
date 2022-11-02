using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace mybooking.repository.Migrations
{
    public partial class updateroomtype : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_ApartmentTypes",
                table: "ApartmentTypes");

            migrationBuilder.RenameTable(
                name: "ApartmentTypes",
                newName: "apartment_type");

            migrationBuilder.AddColumn<long>(
                name: "ApartmentTypeId",
                table: "apartment",
                type: "bigint",
                nullable: false,
                defaultValue: 0L);

            migrationBuilder.AddPrimaryKey(
                name: "PK_apartment_type",
                table: "apartment_type",
                column: "Id");

            migrationBuilder.CreateIndex(
                name: "IX_apartment_ApartmentTypeId",
                table: "apartment",
                column: "ApartmentTypeId");

            migrationBuilder.AddForeignKey(
                name: "FK_apartment_apartment_type_ApartmentTypeId",
                table: "apartment",
                column: "ApartmentTypeId",
                principalTable: "apartment_type",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_apartment_apartment_type_ApartmentTypeId",
                table: "apartment");

            migrationBuilder.DropIndex(
                name: "IX_apartment_ApartmentTypeId",
                table: "apartment");

            migrationBuilder.DropPrimaryKey(
                name: "PK_apartment_type",
                table: "apartment_type");

            migrationBuilder.DropColumn(
                name: "ApartmentTypeId",
                table: "apartment");

            migrationBuilder.RenameTable(
                name: "apartment_type",
                newName: "ApartmentTypes");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ApartmentTypes",
                table: "ApartmentTypes",
                column: "Id");
        }
    }
}
