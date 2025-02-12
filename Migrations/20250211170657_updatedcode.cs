using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Car_Rental_Backend_Application.Migrations
{
    /// <inheritdoc />
    public partial class updatedcode : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Phone_Number",
                table: "Users",
                newName: "PhoneNumber");

            migrationBuilder.RenameColumn(
                name: "User_ID",
                table: "Users",
                newName: "UserId");

            migrationBuilder.RenameIndex(
                name: "IX_Users_Phone_Number",
                table: "Users",
                newName: "IX_Users_PhoneNumber");

            migrationBuilder.AddColumn<string>(
                name: "Role",
                table: "Users",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Role",
                table: "Users");

            migrationBuilder.RenameColumn(
                name: "PhoneNumber",
                table: "Users",
                newName: "Phone_Number");

            migrationBuilder.RenameColumn(
                name: "UserId",
                table: "Users",
                newName: "User_ID");

            migrationBuilder.RenameIndex(
                name: "IX_Users_PhoneNumber",
                table: "Users",
                newName: "IX_Users_Phone_Number");
        }
    }
}
