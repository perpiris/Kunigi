using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Kunigi.Data.Migrations
{
    /// <inheritdoc />
    public partial class teamslug : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Slug",
                table: "Teams",
                type: "varchar(150)",
                nullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Slug",
                table: "Teams");
        }
    }
}
