using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CarrinhoComprasAPI.Migrations
{
    /// <inheritdoc />
    public partial class DumpDbVer1_6 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Active",
                table: "Cliente",
                newName: "ClienteActive");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "ClienteActive",
                table: "Cliente",
                newName: "Active");
        }
    }
}
