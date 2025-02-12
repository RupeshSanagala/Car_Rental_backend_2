using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Car_Rental_Backend_Application.Migrations
{
    /// <inheritdoc />
    public partial class Licence_NumberIsUnique : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "License_Plate",
                table: "Cars",
                type: "nvarchar(450)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.CreateIndex(
                name: "IX_Cars_License_Plate",
                table: "Cars",
                column: "License_Plate",
                unique: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_Cars_License_Plate",
                table: "Cars");

            migrationBuilder.AlterColumn<string>(
                name: "License_Plate",
                table: "Cars",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)");
        }
    }
}
