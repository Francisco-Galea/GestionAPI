using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace GestionAPI.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class stockMigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "ProductStock",
                table: "Products",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ProductStock",
                table: "Products");
        }
    }
}
