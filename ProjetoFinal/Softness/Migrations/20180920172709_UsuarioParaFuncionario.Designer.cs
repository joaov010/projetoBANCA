﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Softness.DAO;

namespace Softness.Migrations
{
    [DbContext(typeof(SoftnessContext))]
    [Migration("20180920172709_UsuarioParaFuncionario")]
    partial class UsuarioParaFuncionario
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.0-preview1-35029")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Softness.Models.Endereco", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Bairro");

                    b.Property<string>("Cep");

                    b.Property<string>("Cidade");

                    b.Property<string>("Complemento");

                    b.Property<string>("Estado");

                    b.Property<string>("Numero");

                    b.Property<string>("Rua");

                    b.HasKey("Id");

                    b.ToTable("Enderecos");
                });

            modelBuilder.Entity("Softness.Models.Funcionario", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Cargo");

                    b.Property<string>("NomeDeUsuario");

                    b.Property<int>("PessoaId");

                    b.Property<string>("Senha");

                    b.Property<string>("TipoDeAcesso");

                    b.HasKey("Id");

                    b.HasIndex("PessoaId");

                    b.ToTable("Funcionarios");
                });

            modelBuilder.Entity("Softness.Models.Pessoa", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Cpf");

                    b.Property<DateTime>("DataNascimento");

                    b.Property<string>("Email");

                    b.Property<int>("EnderecoId");

                    b.Property<string>("EstadoCivil");

                    b.Property<string>("Fone");

                    b.Property<string>("Fone2");

                    b.Property<string>("Genero")
                        .IsRequired()
                        .HasConversion(new ValueConverter<string, string>(v => default(string), v => default(string), new ConverterMappingHints(size: 1)));

                    b.Property<string>("Nome");

                    b.Property<string>("Rg");

                    b.HasKey("Id");

                    b.HasIndex("EnderecoId");

                    b.ToTable("Pessoas");
                });

            modelBuilder.Entity("Softness.Models.Funcionario", b =>
                {
                    b.HasOne("Softness.Models.Pessoa", "Pessoa")
                        .WithMany()
                        .HasForeignKey("PessoaId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Softness.Models.Pessoa", b =>
                {
                    b.HasOne("Softness.Models.Endereco", "Endereco")
                        .WithMany()
                        .HasForeignKey("EnderecoId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
