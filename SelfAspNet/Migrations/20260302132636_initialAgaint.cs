using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SelfAspNet_MVC.Migrations
{
    /// <inheritdoc />
    public partial class initialAgaint : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "price",
                table: "Books",
                newName: "Price");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Price",
                table: "Books",
                newName: "price");
        }
    }
}
