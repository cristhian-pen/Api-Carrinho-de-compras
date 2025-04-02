using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CarrinhoComprasAPI.Migrations
{
    /// <inheritdoc />
    public partial class UpdateDbRelVersion1_2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "CarrinhoCompraIdTransacao",
                table: "Produtos",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "ClienteCdUsuario",
                table: "Produtos",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "FornecedorIDFornecedor",
                table: "Produtos",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "ProdutoIdProduto",
                table: "Produtos",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "CarrinhoCompraIdTransacao",
                table: "Logs",
                type: "int",
                nullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "IdEndereco",
                table: "Endereco",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int")
                .OldAnnotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn);

            migrationBuilder.AddColumn<int>(
                name: "ClienteCdUsuario",
                table: "DadosPagamento",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "ClienteCdUsuario",
                table: "CarrinhoCompra",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Produtos_CarrinhoCompraIdTransacao",
                table: "Produtos",
                column: "CarrinhoCompraIdTransacao");

            migrationBuilder.CreateIndex(
                name: "IX_Produtos_ClienteCdUsuario",
                table: "Produtos",
                column: "ClienteCdUsuario");

            migrationBuilder.CreateIndex(
                name: "IX_Produtos_FornecedorIDFornecedor",
                table: "Produtos",
                column: "FornecedorIDFornecedor");

            migrationBuilder.CreateIndex(
                name: "IX_Produtos_ProdutoIdProduto",
                table: "Produtos",
                column: "ProdutoIdProduto");

            migrationBuilder.CreateIndex(
                name: "IX_Logs_CarrinhoCompraIdTransacao",
                table: "Logs",
                column: "CarrinhoCompraIdTransacao");

            migrationBuilder.CreateIndex(
                name: "IX_DadosPagamento_ClienteCdUsuario",
                table: "DadosPagamento",
                column: "ClienteCdUsuario");

            migrationBuilder.CreateIndex(
                name: "IX_CarrinhoCompra_ClienteCdUsuario",
                table: "CarrinhoCompra",
                column: "ClienteCdUsuario");

            migrationBuilder.AddForeignKey(
                name: "FK_CarrinhoCompra_Cliente_ClienteCdUsuario",
                table: "CarrinhoCompra",
                column: "ClienteCdUsuario",
                principalTable: "Cliente",
                principalColumn: "CdUsuario");

            migrationBuilder.AddForeignKey(
                name: "FK_DadosPagamento_Cliente_ClienteCdUsuario",
                table: "DadosPagamento",
                column: "ClienteCdUsuario",
                principalTable: "Cliente",
                principalColumn: "CdUsuario");

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

            migrationBuilder.AddForeignKey(
                name: "FK_Logs_CarrinhoCompra_CarrinhoCompraIdTransacao",
                table: "Logs",
                column: "CarrinhoCompraIdTransacao",
                principalTable: "CarrinhoCompra",
                principalColumn: "IdTransacao");

            migrationBuilder.AddForeignKey(
                name: "FK_Produtos_CarrinhoCompra_CarrinhoCompraIdTransacao",
                table: "Produtos",
                column: "CarrinhoCompraIdTransacao",
                principalTable: "CarrinhoCompra",
                principalColumn: "IdTransacao");

            migrationBuilder.AddForeignKey(
                name: "FK_Produtos_Cliente_ClienteCdUsuario",
                table: "Produtos",
                column: "ClienteCdUsuario",
                principalTable: "Cliente",
                principalColumn: "CdUsuario");

            migrationBuilder.AddForeignKey(
                name: "FK_Produtos_Fornecedor_FornecedorIDFornecedor",
                table: "Produtos",
                column: "FornecedorIDFornecedor",
                principalTable: "Fornecedor",
                principalColumn: "IDFornecedor");

            migrationBuilder.AddForeignKey(
                name: "FK_Produtos_Produtos_ProdutoIdProduto",
                table: "Produtos",
                column: "ProdutoIdProduto",
                principalTable: "Produtos",
                principalColumn: "IdProduto");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CarrinhoCompra_Cliente_ClienteCdUsuario",
                table: "CarrinhoCompra");

            migrationBuilder.DropForeignKey(
                name: "FK_DadosPagamento_Cliente_ClienteCdUsuario",
                table: "DadosPagamento");

            migrationBuilder.DropForeignKey(
                name: "FK_Endereco_Cliente_IdEndereco",
                table: "Endereco");

            migrationBuilder.DropForeignKey(
                name: "FK_Endereco_Fornecedor_IdEndereco",
                table: "Endereco");

            migrationBuilder.DropForeignKey(
                name: "FK_Logs_CarrinhoCompra_CarrinhoCompraIdTransacao",
                table: "Logs");

            migrationBuilder.DropForeignKey(
                name: "FK_Produtos_CarrinhoCompra_CarrinhoCompraIdTransacao",
                table: "Produtos");

            migrationBuilder.DropForeignKey(
                name: "FK_Produtos_Cliente_ClienteCdUsuario",
                table: "Produtos");

            migrationBuilder.DropForeignKey(
                name: "FK_Produtos_Fornecedor_FornecedorIDFornecedor",
                table: "Produtos");

            migrationBuilder.DropForeignKey(
                name: "FK_Produtos_Produtos_ProdutoIdProduto",
                table: "Produtos");

            migrationBuilder.DropIndex(
                name: "IX_Produtos_CarrinhoCompraIdTransacao",
                table: "Produtos");

            migrationBuilder.DropIndex(
                name: "IX_Produtos_ClienteCdUsuario",
                table: "Produtos");

            migrationBuilder.DropIndex(
                name: "IX_Produtos_FornecedorIDFornecedor",
                table: "Produtos");

            migrationBuilder.DropIndex(
                name: "IX_Produtos_ProdutoIdProduto",
                table: "Produtos");

            migrationBuilder.DropIndex(
                name: "IX_Logs_CarrinhoCompraIdTransacao",
                table: "Logs");

            migrationBuilder.DropIndex(
                name: "IX_DadosPagamento_ClienteCdUsuario",
                table: "DadosPagamento");

            migrationBuilder.DropIndex(
                name: "IX_CarrinhoCompra_ClienteCdUsuario",
                table: "CarrinhoCompra");

            migrationBuilder.DropColumn(
                name: "CarrinhoCompraIdTransacao",
                table: "Produtos");

            migrationBuilder.DropColumn(
                name: "ClienteCdUsuario",
                table: "Produtos");

            migrationBuilder.DropColumn(
                name: "FornecedorIDFornecedor",
                table: "Produtos");

            migrationBuilder.DropColumn(
                name: "ProdutoIdProduto",
                table: "Produtos");

            migrationBuilder.DropColumn(
                name: "CarrinhoCompraIdTransacao",
                table: "Logs");

            migrationBuilder.DropColumn(
                name: "ClienteCdUsuario",
                table: "DadosPagamento");

            migrationBuilder.DropColumn(
                name: "ClienteCdUsuario",
                table: "CarrinhoCompra");

            migrationBuilder.AlterColumn<int>(
                name: "IdEndereco",
                table: "Endereco",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int")
                .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn);
        }
    }
}
