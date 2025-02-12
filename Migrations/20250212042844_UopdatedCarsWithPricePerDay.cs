using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Car_Rental_Backend_Application.Migrations
{
    /// <inheritdoc />
    public partial class UopdatedCarsWithPricePerDay : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "PricePerDay",
                table: "Cars",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "PricePerDay",
                table: "Cars");
        }
    }
}
