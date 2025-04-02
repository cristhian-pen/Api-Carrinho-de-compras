using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CarrinhoComprasAPI.Migrations
{
    /// <inheritdoc />
    public partial class UpdateDbEmpresaVersion1_4 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Fornecedor_Endereco_IdEndereco",
                table: "Fornecedor");

            migrationBuilder.RenameColumn(
                name: "IdEndereco",
                table: "Fornecedor",
                newName: "IdEnderecos");

            migrationBuilder.RenameIndex(
                name: "IX_Fornecedor_IdEndereco",
                table: "Fornecedor",
                newName: "IX_Fornecedor_IdEnderecos");

            migrationBuilder.CreateTable(
                name: "Empresa",
                columns: table => new
                {
                    CdEmpresa = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    NmEmpresa = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    CNPJ = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    DtCadastro = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Empresa", x => x.CdEmpresa);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AddForeignKey(
                name: "FK_Fornecedor_Endereco_IdEnderecos",
                table: "Fornecedor",
                column: "IdEnderecos",
                principalTable: "Endereco",
                principalColumn: "IdEndereco");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Fornecedor_Endereco_IdEnderecos",
                table: "Fornecedor");

            migrationBuilder.DropTable(
                name: "Empresa");

            migrationBuilder.RenameColumn(
                name: "IdEnderecos",
                table: "Fornecedor",
                newName: "IdEndereco");

            migrationBuilder.RenameIndex(
                name: "IX_Fornecedor_IdEnderecos",
                table: "Fornecedor",
                newName: "IX_Fornecedor_IdEndereco");

            migrationBuilder.AddForeignKey(
                name: "FK_Fornecedor_Endereco_IdEndereco",
                table: "Fornecedor",
                column: "IdEndereco",
                principalTable: "Endereco",
                principalColumn: "IdEndereco");
        }
    }
}
