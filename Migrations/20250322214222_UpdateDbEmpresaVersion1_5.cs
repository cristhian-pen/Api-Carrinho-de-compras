using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CarrinhoComprasAPI.Migrations
{
    /// <inheritdoc />
    public partial class UpdateDbEmpresaVersion1_5 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "idCliente",
                table: "Endereco",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "idFornecedor",
                table: "Endereco",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Endereco_idCliente",
                table: "Endereco",
                column: "idCliente");

            migrationBuilder.CreateIndex(
                name: "IX_Endereco_idFornecedor",
                table: "Endereco",
                column: "idFornecedor");

            migrationBuilder.AddForeignKey(
                name: "FK_Endereco_Cliente_idCliente",
                table: "Endereco",
                column: "idCliente",
                principalTable: "Cliente",
                principalColumn: "CdUsuario",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Endereco_Fornecedor_idFornecedor",
                table: "Endereco",
                column: "idFornecedor",
                principalTable: "Fornecedor",
                principalColumn: "IDFornecedor",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Endereco_Cliente_idCliente",
                table: "Endereco");

            migrationBuilder.DropForeignKey(
                name: "FK_Endereco_Fornecedor_idFornecedor",
                table: "Endereco");

            migrationBuilder.DropIndex(
                name: "IX_Endereco_idCliente",
                table: "Endereco");

            migrationBuilder.DropIndex(
                name: "IX_Endereco_idFornecedor",
                table: "Endereco");

            migrationBuilder.DropColumn(
                name: "idCliente",
                table: "Endereco");

            migrationBuilder.DropColumn(
                name: "idFornecedor",
                table: "Endereco");
        }
    }
}
