using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CarrinhoComprasAPI.Migrations
{
    /// <inheritdoc />
    public partial class UpdateDbRelVersion1_3 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Endereco_Cliente_IdEndereco",
                table: "Endereco");

            migrationBuilder.DropForeignKey(
                name: "FK_Endereco_Fornecedor_IdEndereco",
                table: "Endereco");

            migrationBuilder.AddColumn<int>(
                name: "IdEndereco",
                table: "Fornecedor",
                type: "int",
                nullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "IdEndereco",
                table: "Endereco",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int")
                .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn);

            migrationBuilder.AddColumn<int>(
                name: "IdEndereco",
                table: "Cliente",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Fornecedor_IdEndereco",
                table: "Fornecedor",
                column: "IdEndereco");

            migrationBuilder.CreateIndex(
                name: "IX_Cliente_IdEndereco",
                table: "Cliente",
                column: "IdEndereco");

            migrationBuilder.AddForeignKey(
                name: "FK_Cliente_Endereco_IdEndereco",
                table: "Cliente",
                column: "IdEndereco",
                principalTable: "Endereco",
                principalColumn: "IdEndereco");

            migrationBuilder.AddForeignKey(
                name: "FK_Fornecedor_Endereco_IdEndereco",
                table: "Fornecedor",
                column: "IdEndereco",
                principalTable: "Endereco",
                principalColumn: "IdEndereco");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Cliente_Endereco_IdEndereco",
                table: "Cliente");

            migrationBuilder.DropForeignKey(
                name: "FK_Fornecedor_Endereco_IdEndereco",
                table: "Fornecedor");

            migrationBuilder.DropIndex(
                name: "IX_Fornecedor_IdEndereco",
                table: "Fornecedor");

            migrationBuilder.DropIndex(
                name: "IX_Cliente_IdEndereco",
                table: "Cliente");

            migrationBuilder.DropColumn(
                name: "IdEndereco",
                table: "Fornecedor");

            migrationBuilder.DropColumn(
                name: "IdEndereco",
                table: "Cliente");

            migrationBuilder.AlterColumn<int>(
                name: "IdEndereco",
                table: "Endereco",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int")
                .OldAnnotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn);

            migrationBuilder.AddForeignKey(
                name: "FK_Endereco_Cliente_IdEndereco",
                table: "Endereco",
                column: "IdEndereco",
                principalTable: "Cliente",
                principalColumn: "CdUsuario",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Endereco_Fornecedor_IdEndereco",
                table: "Endereco",
                column: "IdEndereco",
                principalTable: "Fornecedor",
                principalColumn: "IDFornecedor",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
