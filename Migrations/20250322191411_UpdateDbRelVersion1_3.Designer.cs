﻿// <auto-generated />
using System;
using CarrinhoComprasAPI.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace CarrinhoComprasAPI.Migrations
{
    [DbContext(typeof(Db))]
    [Migration("20250322191411_UpdateDbRelVersion1_3")]
    partial class UpdateDbRelVersion1_3
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.14")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            MySqlModelBuilderExtensions.AutoIncrementColumns(modelBuilder);

            modelBuilder.Entity("CarrinhoComprasAPI.Models.CarrinhoCompra", b =>
                {
                    b.Property<int>("IdTransacao")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    MySqlPropertyBuilderExtensions.UseMySqlIdentityColumn(b.Property<int>("IdTransacao"));

                    b.Property<string>("CdEmpresa")
                        .HasColumnType("longtext");

                    b.Property<int?>("ClienteCdUsuario")
                        .HasColumnType("int");

                    b.Property<string>("NmCartao")
                        .HasColumnType("longtext");

                    b.Property<string>("QtdProduto")
                        .HasColumnType("longtext");

                    b.Property<string>("TipPagamento")
                        .HasColumnType("longtext");

                    b.Property<string>("VlTotal")
                        .HasColumnType("longtext");

                    b.HasKey("IdTransacao");

                    b.HasIndex("ClienteCdUsuario");

                    b.ToTable("CarrinhoCompra");
                });

            modelBuilder.Entity("CarrinhoComprasAPI.Models.Cliente", b =>
                {
                    b.Property<int>("CdUsuario")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    MySqlPropertyBuilderExtensions.UseMySqlIdentityColumn(b.Property<int>("CdUsuario"));

                    b.Property<string>("CNPJ")
                        .HasColumnType("longtext");

                    b.Property<string>("CPF")
                        .HasColumnType("longtext");

                    b.Property<string>("DtCadastro")
                        .HasColumnType("longtext");

                    b.Property<string>("DtNascimento")
                        .HasColumnType("longtext");

                    b.Property<string>("Email")
                        .HasColumnType("longtext");

                    b.Property<int?>("IdEndereco")
                        .HasColumnType("int");

                    b.Property<string>("NmUsuario")
                        .HasColumnType("longtext");

                    b.Property<string>("PassWd")
                        .HasColumnType("longtext");

                    b.Property<string>("Telefone")
                        .HasColumnType("longtext");

                    b.Property<string>("TipCliente")
                        .HasColumnType("longtext");

                    b.Property<string>("TipUsuario")
                        .HasColumnType("longtext");

                    b.HasKey("CdUsuario");

                    b.HasIndex("IdEndereco");

                    b.ToTable("Cliente");
                });

            modelBuilder.Entity("CarrinhoComprasAPI.Models.DadosPagamento", b =>
                {
                    b.Property<int>("CdCard")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    MySqlPropertyBuilderExtensions.UseMySqlIdentityColumn(b.Property<int>("CdCard"));

                    b.Property<string>("ApelidoCartao")
                        .HasColumnType("longtext");

                    b.Property<string>("CVV")
                        .HasColumnType("longtext");

                    b.Property<int?>("ClienteCdUsuario")
                        .HasColumnType("int");

                    b.Property<string>("DtValidade")
                        .HasColumnType("longtext");

                    b.Property<string>("NmCartao")
                        .HasColumnType("longtext");

                    b.Property<string>("NumCard")
                        .HasColumnType("longtext");

                    b.HasKey("CdCard");

                    b.HasIndex("ClienteCdUsuario");

                    b.ToTable("DadosPagamento");
                });

            modelBuilder.Entity("CarrinhoComprasAPI.Models.Endereco", b =>
                {
                    b.Property<int>("IdEndereco")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    MySqlPropertyBuilderExtensions.UseMySqlIdentityColumn(b.Property<int>("IdEndereco"));

                    b.Property<string>("CEP")
                        .HasColumnType("longtext");

                    b.Property<string>("NmBairro")
                        .HasColumnType("longtext");

                    b.Property<string>("NmCidade")
                        .HasColumnType("longtext");

                    b.Property<string>("NmEndereco")
                        .HasColumnType("longtext");

                    b.Property<string>("NumCasa")
                        .HasColumnType("longtext");

                    b.Property<string>("Uf")
                        .HasColumnType("longtext");

                    b.HasKey("IdEndereco");

                    b.ToTable("Endereco");
                });

            modelBuilder.Entity("CarrinhoComprasAPI.Models.Fornecedor", b =>
                {
                    b.Property<int>("IDFornecedor")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    MySqlPropertyBuilderExtensions.UseMySqlIdentityColumn(b.Property<int>("IDFornecedor"));

                    b.Property<string>("CNPJ")
                        .HasColumnType("longtext");

                    b.Property<string>("CtoFornecedor")
                        .HasColumnType("longtext");

                    b.Property<string>("DtCadastro")
                        .HasColumnType("longtext");

                    b.Property<int?>("IdEndereco")
                        .HasColumnType("int");

                    b.Property<string>("NmFornecedor")
                        .HasColumnType("longtext");

                    b.Property<string>("TipFornecedor")
                        .HasColumnType("longtext");

                    b.HasKey("IDFornecedor");

                    b.HasIndex("IdEndereco");

                    b.ToTable("Fornecedor");
                });

            modelBuilder.Entity("CarrinhoComprasAPI.Models.Logs", b =>
                {
                    b.Property<int>("IdLog")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    MySqlPropertyBuilderExtensions.UseMySqlIdentityColumn(b.Property<int>("IdLog"));

                    b.Property<int?>("CarrinhoCompraIdTransacao")
                        .HasColumnType("int");

                    b.Property<string>("Description")
                        .HasColumnType("longtext");

                    b.Property<string>("DtLog")
                        .HasColumnType("longtext");

                    b.Property<string>("HrLog")
                        .HasColumnType("longtext");

                    b.HasKey("IdLog");

                    b.HasIndex("CarrinhoCompraIdTransacao");

                    b.ToTable("Logs");
                });

            modelBuilder.Entity("CarrinhoComprasAPI.Models.Produtos", b =>
                {
                    b.Property<int>("IdProduto")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    MySqlPropertyBuilderExtensions.UseMySqlIdentityColumn(b.Property<int>("IdProduto"));

                    b.Property<int>("AnoProduto")
                        .HasColumnType("int");

                    b.Property<int?>("CarrinhoCompraIdTransacao")
                        .HasColumnType("int");

                    b.Property<int?>("ClienteCdUsuario")
                        .HasColumnType("int");

                    b.Property<string>("DtCadastro")
                        .HasColumnType("longtext");

                    b.Property<int?>("FornecedorIDFornecedor")
                        .HasColumnType("int");

                    b.Property<string>("MarcaProduto")
                        .HasColumnType("longtext");

                    b.Property<string>("ModeloProduto")
                        .HasColumnType("longtext");

                    b.Property<string>("NmProduto")
                        .HasColumnType("longtext");

                    b.Property<double>("PrecoProduto")
                        .HasColumnType("double");

                    b.Property<int?>("ProdutoIdProduto")
                        .HasColumnType("int");

                    b.Property<double>("QntEstoque")
                        .HasColumnType("double");

                    b.Property<string>("TipPeça")
                        .HasColumnType("longtext");

                    b.HasKey("IdProduto");

                    b.HasIndex("CarrinhoCompraIdTransacao");

                    b.HasIndex("ClienteCdUsuario");

                    b.HasIndex("FornecedorIDFornecedor");

                    b.HasIndex("ProdutoIdProduto");

                    b.ToTable("Produtos");
                });

            modelBuilder.Entity("CarrinhoComprasAPI.Models.CarrinhoCompra", b =>
                {
                    b.HasOne("CarrinhoComprasAPI.Models.Cliente", "Cliente")
                        .WithMany()
                        .HasForeignKey("ClienteCdUsuario");

                    b.Navigation("Cliente");
                });

            modelBuilder.Entity("CarrinhoComprasAPI.Models.Cliente", b =>
                {
                    b.HasOne("CarrinhoComprasAPI.Models.Endereco", "Endereco")
                        .WithMany()
                        .HasForeignKey("IdEndereco");

                    b.Navigation("Endereco");
                });

            modelBuilder.Entity("CarrinhoComprasAPI.Models.DadosPagamento", b =>
                {
                    b.HasOne("CarrinhoComprasAPI.Models.Cliente", "Cliente")
                        .WithMany("DataCard")
                        .HasForeignKey("ClienteCdUsuario");

                    b.Navigation("Cliente");
                });

            modelBuilder.Entity("CarrinhoComprasAPI.Models.Fornecedor", b =>
                {
                    b.HasOne("CarrinhoComprasAPI.Models.Endereco", "Endereco")
                        .WithMany()
                        .HasForeignKey("IdEndereco");

                    b.Navigation("Endereco");
                });

            modelBuilder.Entity("CarrinhoComprasAPI.Models.Logs", b =>
                {
                    b.HasOne("CarrinhoComprasAPI.Models.CarrinhoCompra", "CarrinhoCompra")
                        .WithMany("Logs")
                        .HasForeignKey("CarrinhoCompraIdTransacao");

                    b.Navigation("CarrinhoCompra");
                });

            modelBuilder.Entity("CarrinhoComprasAPI.Models.Produtos", b =>
                {
                    b.HasOne("CarrinhoComprasAPI.Models.CarrinhoCompra", null)
                        .WithMany("Produtos")
                        .HasForeignKey("CarrinhoCompraIdTransacao");

                    b.HasOne("CarrinhoComprasAPI.Models.Cliente", "Cliente")
                        .WithMany()
                        .HasForeignKey("ClienteCdUsuario");

                    b.HasOne("CarrinhoComprasAPI.Models.Fornecedor", null)
                        .WithMany("Produtos")
                        .HasForeignKey("FornecedorIDFornecedor");

                    b.HasOne("CarrinhoComprasAPI.Models.Produtos", "Produto")
                        .WithMany("CarrinhoCompra")
                        .HasForeignKey("ProdutoIdProduto");

                    b.Navigation("Cliente");

                    b.Navigation("Produto");
                });

            modelBuilder.Entity("CarrinhoComprasAPI.Models.CarrinhoCompra", b =>
                {
                    b.Navigation("Logs");

                    b.Navigation("Produtos");
                });

            modelBuilder.Entity("CarrinhoComprasAPI.Models.Cliente", b =>
                {
                    b.Navigation("DataCard");
                });

            modelBuilder.Entity("CarrinhoComprasAPI.Models.Fornecedor", b =>
                {
                    b.Navigation("Produtos");
                });

            modelBuilder.Entity("CarrinhoComprasAPI.Models.Produtos", b =>
                {
                    b.Navigation("CarrinhoCompra");
                });
#pragma warning restore 612, 618
        }
    }
}
