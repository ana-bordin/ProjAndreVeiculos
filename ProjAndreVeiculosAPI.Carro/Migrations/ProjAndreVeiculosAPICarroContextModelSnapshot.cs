﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using ProjAndreVeiculosAPICarro.Data;

#nullable disable

namespace ProjAndreVeiculosAPICarro.Migrations
{
    [DbContext(typeof(ProjAndreVeiculosAPICarroContext))]
    partial class ProjAndreVeiculosAPICarroContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.29")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("Models.AceiteTermoUso", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("ClienteDocumento")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.Property<DateTime>("DataAceite")
                        .HasColumnType("datetime2");

                    b.Property<int>("TermoDeUsoId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("ClienteDocumento");

                    b.HasIndex("TermoDeUsoId");

                    b.ToTable("AceiteTermoUso");
                });

            modelBuilder.Entity("Models.Banco", b =>
                {
                    b.Property<string>("CNPJ")
                        .HasColumnType("nvarchar(450)");

                    b.Property<DateTime>("DataFundacao")
                        .HasColumnType("datetime2");

                    b.Property<string>("NomeBanco")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("CNPJ");

                    b.ToTable("Banco");
                });

            modelBuilder.Entity("Models.Boleto", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<DateTime>("DataVencimento")
                        .HasColumnType("datetime2");

                    b.Property<int>("Numero")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Boleto");
                });

            modelBuilder.Entity("Models.Cargo", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Descricao")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Cargo");
                });

            modelBuilder.Entity("Models.Carro", b =>
                {
                    b.Property<string>("Placa")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("AnoFabricacao")
                        .HasColumnType("int");

                    b.Property<int>("AnoModelo")
                        .HasColumnType("int");

                    b.Property<string>("Cor")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("Vendido")
                        .HasColumnType("bit");

                    b.HasKey("Placa");

                    b.ToTable("Carro");
                });

            modelBuilder.Entity("Models.CarroServico", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("CarroPlaca")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("ServicoId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("CarroPlaca");

                    b.HasIndex("ServicoId");

                    b.ToTable("CarroServico");
                });

            modelBuilder.Entity("Models.Cartao", b =>
                {
                    b.Property<string>("NumeroCartao")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("CodigoSeguranca")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("DataValidade")
                        .HasColumnType("datetime2");

                    b.Property<string>("NomeCartao")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("NumeroCartao");

                    b.ToTable("Cartao");
                });

            modelBuilder.Entity("Models.Categoria", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<long>("Id"), 1L, 1);

                    b.Property<string>("Descricao")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Categoria");
                });

            modelBuilder.Entity("Models.CNH", b =>
                {
                    b.Property<long>("CNHNumero")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<long>("CNHNumero"), 1L, 1);

                    b.Property<string>("CPF")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<long>("CategoriaId")
                        .HasColumnType("bigint");

                    b.Property<DateTime>("DataVencimento")
                        .HasColumnType("datetime2");

                    b.Property<string>("NomeMae")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NomePai")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RG")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("CNHNumero");

                    b.HasIndex("CategoriaId");

                    b.ToTable("CNH");
                });

            modelBuilder.Entity("Models.Compra", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("CarroPlaca")
                        .HasColumnType("nvarchar(450)");

                    b.Property<DateTime>("DataCompra")
                        .HasColumnType("datetime2");

                    b.Property<decimal>("Preco")
                        .HasColumnType("decimal(18,2)");

                    b.HasKey("Id");

                    b.HasIndex("CarroPlaca");

                    b.ToTable("Compra");
                });

            modelBuilder.Entity("Models.Endereco", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Bairro")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CEP")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Cidade")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Complemento")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Logradouro")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Numero")
                        .HasColumnType("int");

                    b.Property<string>("TipoLogradouro")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Uf")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Endereco");
                });

            modelBuilder.Entity("Models.Financiamento", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("BancoCNPJ")
                        .HasColumnType("nvarchar(450)");

                    b.Property<DateTime>("DataFinanciamento")
                        .HasColumnType("datetime2");

                    b.Property<int>("VendaId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("BancoCNPJ");

                    b.HasIndex("VendaId");

                    b.ToTable("Finaciamento");
                });

            modelBuilder.Entity("Models.Pagamento", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int?>("BoletoId")
                        .HasColumnType("int");

                    b.Property<string>("CartaoNumeroCartao")
                        .HasColumnType("nvarchar(450)");

                    b.Property<DateTime>("DataPagamento")
                        .HasColumnType("datetime2");

                    b.Property<int?>("PixId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("BoletoId");

                    b.HasIndex("CartaoNumeroCartao");

                    b.HasIndex("PixId");

                    b.ToTable("Pagamento");
                });

            modelBuilder.Entity("Models.PendenciaFinanceira", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("ClienteDocumento")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.Property<DateTime>("DataCobranca")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("DataPendencia")
                        .HasColumnType("datetime2");

                    b.Property<string>("Descricao")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("Status")
                        .HasColumnType("bit");

                    b.Property<decimal>("Valor")
                        .HasColumnType("decimal(18,2)");

                    b.HasKey("Id");

                    b.HasIndex("ClienteDocumento");

                    b.ToTable("PendenciaFinanceira");
                });

            modelBuilder.Entity("Models.Pessoa", b =>
                {
                    b.Property<string>("Documento")
                        .HasColumnType("nvarchar(450)");

                    b.Property<DateTime>("DataNascimento")
                        .HasColumnType("datetime2");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("EnderecoId")
                        .HasColumnType("int");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Telefone")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Documento");

                    b.HasIndex("EnderecoId");

                    b.ToTable("Pessoa");
                });

            modelBuilder.Entity("Models.Pix", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("ChavePix")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("TipoId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("TipoId");

                    b.ToTable("Pix");
                });

            modelBuilder.Entity("Models.Seguro", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("CarroPlaca")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ClienteDocumento")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("CondutorPrincipalDocumento")
                        .HasColumnType("nvarchar(450)");

                    b.Property<decimal>("Franquia")
                        .HasColumnType("decimal(18,2)");

                    b.HasKey("Id");

                    b.HasIndex("CarroPlaca");

                    b.HasIndex("ClienteDocumento");

                    b.HasIndex("CondutorPrincipalDocumento");

                    b.ToTable("Seguro");
                });

            modelBuilder.Entity("Models.Servico", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Descricao")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Servico");
                });

            modelBuilder.Entity("Models.TermoDeUso", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<DateTime>("DataCadastro")
                        .HasColumnType("datetime2");

                    b.Property<bool>("Status")
                        .HasColumnType("bit");

                    b.Property<string>("Texto")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Versao")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("TermoDeUso");
                });

            modelBuilder.Entity("Models.TipoPix", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("TipoPix");
                });

            modelBuilder.Entity("Models.Venda", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("CarroPlaca")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ClienteDocumento")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.Property<DateTime>("DataVenda")
                        .HasColumnType("datetime2");

                    b.Property<string>("FuncionarioDocumento")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("PagamentoId")
                        .HasColumnType("int");

                    b.Property<decimal>("ValorVenda")
                        .HasColumnType("decimal(18,2)");

                    b.HasKey("Id");

                    b.HasIndex("CarroPlaca");

                    b.HasIndex("ClienteDocumento");

                    b.HasIndex("FuncionarioDocumento");

                    b.HasIndex("PagamentoId");

                    b.ToTable("Venda");
                });

            modelBuilder.Entity("Models.Cliente", b =>
                {
                    b.HasBaseType("Models.Pessoa");

                    b.Property<string>("DocumentoPDF")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("Renda")
                        .HasColumnType("decimal(18,2)");

                    b.ToTable("Cliente", (string)null);
                });

            modelBuilder.Entity("Models.Condutor", b =>
                {
                    b.HasBaseType("Models.Pessoa");

                    b.Property<long>("CNHNumero")
                        .HasColumnType("bigint");

                    b.HasIndex("CNHNumero");

                    b.ToTable("Condutor", (string)null);
                });

            modelBuilder.Entity("Models.Dependente", b =>
                {
                    b.HasBaseType("Models.Pessoa");

                    b.Property<string>("ClienteDocumento")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasIndex("ClienteDocumento");

                    b.ToTable("Dependente", (string)null);
                });

            modelBuilder.Entity("Models.Funcionario", b =>
                {
                    b.HasBaseType("Models.Pessoa");

                    b.Property<int>("CargoId")
                        .HasColumnType("int");

                    b.Property<decimal>("Comissao")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal>("ValorComissao")
                        .HasColumnType("decimal(18,2)");

                    b.HasIndex("CargoId");

                    b.ToTable("Funcionario", (string)null);
                });

            modelBuilder.Entity("Models.AceiteTermoUso", b =>
                {
                    b.HasOne("Models.Cliente", "Cliente")
                        .WithMany()
                        .HasForeignKey("ClienteDocumento")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Models.TermoDeUso", "TermoDeUso")
                        .WithMany()
                        .HasForeignKey("TermoDeUsoId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Cliente");

                    b.Navigation("TermoDeUso");
                });

            modelBuilder.Entity("Models.CarroServico", b =>
                {
                    b.HasOne("Models.Carro", "Carro")
                        .WithMany()
                        .HasForeignKey("CarroPlaca");

                    b.HasOne("Models.Servico", "Servico")
                        .WithMany()
                        .HasForeignKey("ServicoId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Carro");

                    b.Navigation("Servico");
                });

            modelBuilder.Entity("Models.CNH", b =>
                {
                    b.HasOne("Models.Categoria", "Categoria")
                        .WithMany()
                        .HasForeignKey("CategoriaId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Categoria");
                });

            modelBuilder.Entity("Models.Compra", b =>
                {
                    b.HasOne("Models.Carro", "Carro")
                        .WithMany()
                        .HasForeignKey("CarroPlaca");

                    b.Navigation("Carro");
                });

            modelBuilder.Entity("Models.Financiamento", b =>
                {
                    b.HasOne("Models.Banco", "Banco")
                        .WithMany()
                        .HasForeignKey("BancoCNPJ");

                    b.HasOne("Models.Venda", "Venda")
                        .WithMany()
                        .HasForeignKey("VendaId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Banco");

                    b.Navigation("Venda");
                });

            modelBuilder.Entity("Models.Pagamento", b =>
                {
                    b.HasOne("Models.Boleto", "Boleto")
                        .WithMany()
                        .HasForeignKey("BoletoId");

                    b.HasOne("Models.Cartao", "Cartao")
                        .WithMany()
                        .HasForeignKey("CartaoNumeroCartao");

                    b.HasOne("Models.Pix", "Pix")
                        .WithMany()
                        .HasForeignKey("PixId");

                    b.Navigation("Boleto");

                    b.Navigation("Cartao");

                    b.Navigation("Pix");
                });

            modelBuilder.Entity("Models.PendenciaFinanceira", b =>
                {
                    b.HasOne("Models.Cliente", "Cliente")
                        .WithMany()
                        .HasForeignKey("ClienteDocumento")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Cliente");
                });

            modelBuilder.Entity("Models.Pessoa", b =>
                {
                    b.HasOne("Models.Endereco", "Endereco")
                        .WithMany()
                        .HasForeignKey("EnderecoId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Endereco");
                });

            modelBuilder.Entity("Models.Pix", b =>
                {
                    b.HasOne("Models.TipoPix", "Tipo")
                        .WithMany()
                        .HasForeignKey("TipoId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Tipo");
                });

            modelBuilder.Entity("Models.Seguro", b =>
                {
                    b.HasOne("Models.Carro", "Carro")
                        .WithMany()
                        .HasForeignKey("CarroPlaca");

                    b.HasOne("Models.Cliente", "Cliente")
                        .WithMany()
                        .HasForeignKey("ClienteDocumento");

                    b.HasOne("Models.Condutor", "CondutorPrincipal")
                        .WithMany()
                        .HasForeignKey("CondutorPrincipalDocumento");

                    b.Navigation("Carro");

                    b.Navigation("Cliente");

                    b.Navigation("CondutorPrincipal");
                });

            modelBuilder.Entity("Models.Venda", b =>
                {
                    b.HasOne("Models.Carro", "Carro")
                        .WithMany()
                        .HasForeignKey("CarroPlaca");

                    b.HasOne("Models.Cliente", "Cliente")
                        .WithMany()
                        .HasForeignKey("ClienteDocumento")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Models.Funcionario", "Funcionario")
                        .WithMany()
                        .HasForeignKey("FuncionarioDocumento")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Models.Pagamento", "Pagamento")
                        .WithMany()
                        .HasForeignKey("PagamentoId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Carro");

                    b.Navigation("Cliente");

                    b.Navigation("Funcionario");

                    b.Navigation("Pagamento");
                });

            modelBuilder.Entity("Models.Cliente", b =>
                {
                    b.HasOne("Models.Pessoa", null)
                        .WithOne()
                        .HasForeignKey("Models.Cliente", "Documento")
                        .OnDelete(DeleteBehavior.ClientCascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Models.Condutor", b =>
                {
                    b.HasOne("Models.CNH", "CNH")
                        .WithMany()
                        .HasForeignKey("CNHNumero")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Models.Pessoa", null)
                        .WithOne()
                        .HasForeignKey("Models.Condutor", "Documento")
                        .OnDelete(DeleteBehavior.ClientCascade)
                        .IsRequired();

                    b.Navigation("CNH");
                });

            modelBuilder.Entity("Models.Dependente", b =>
                {
                    b.HasOne("Models.Cliente", "Cliente")
                        .WithMany()
                        .HasForeignKey("ClienteDocumento")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Models.Pessoa", null)
                        .WithOne()
                        .HasForeignKey("Models.Dependente", "Documento")
                        .OnDelete(DeleteBehavior.ClientCascade)
                        .IsRequired();

                    b.Navigation("Cliente");
                });

            modelBuilder.Entity("Models.Funcionario", b =>
                {
                    b.HasOne("Models.Cargo", "Cargo")
                        .WithMany()
                        .HasForeignKey("CargoId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Models.Pessoa", null)
                        .WithOne()
                        .HasForeignKey("Models.Funcionario", "Documento")
                        .OnDelete(DeleteBehavior.ClientCascade)
                        .IsRequired();

                    b.Navigation("Cargo");
                });
#pragma warning restore 612, 618
        }
    }
}
