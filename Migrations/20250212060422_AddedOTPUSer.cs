using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Car_Rental_Backend_Application.Migrations
{
    /// <inheritdoc />
    public partial class AddedOTPUSer : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "ResetToken",
                table: "Users",
                newName: "OTP");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "OTP",
                table: "Users",
                newName: "ResetToken");
        }
    }
}
