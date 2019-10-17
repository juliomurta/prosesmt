﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Prosesmt.Api.Models;

namespace Prosesmt.Api.Migrations
{
    [DbContext(typeof(ProsesmtContext))]
    [Migration("20191016180301_FirstMigration")]
    partial class FirstMigration
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.11-servicing-32099");

            modelBuilder.Entity("Prosesmt.Api.Models.Chamado", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("Abertura")
                        .HasColumnName("DataHora_Abertura")
                        .HasColumnType("datetime");

                    b.Property<long?>("ClienteId");

                    b.Property<DateTime>("Fechamento")
                        .HasColumnName("DataHora_Fechamento")
                        .HasColumnType("datetime");

                    b.Property<bool>("IsFechado")
                        .HasColumnName("Fechado")
                        .HasColumnType("bit");

                    b.HasKey("Id");

                    b.HasIndex("ClienteId");

                    b.ToTable("Chamados");
                });

            modelBuilder.Entity("Prosesmt.Api.Models.Cliente", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Bairro")
                        .IsRequired()
                        .HasColumnName("Logradouro_Bairro")
                        .HasColumnType("varchar(60)");

                    b.Property<string>("CEP")
                        .IsRequired()
                        .HasColumnName("CEP")
                        .HasColumnType("varchar(8)");

                    b.Property<string>("Cidade")
                        .IsRequired()
                        .HasColumnName("Logradouro_Cidade")
                        .HasColumnType("varchar(60)");

                    b.Property<string>("CnpjCpf")
                        .IsRequired()
                        .HasColumnName("CNPJ_CPF")
                        .HasColumnType("varchar(14)");

                    b.Property<string>("Complemento")
                        .IsRequired()
                        .HasColumnName("Logradouro_Complemento")
                        .HasColumnType("varchar(60)");

                    b.Property<string>("Logradouro")
                        .IsRequired()
                        .HasColumnName("Logradouro")
                        .HasColumnType("varchar(60)");

                    b.Property<string>("Numero")
                        .IsRequired()
                        .HasColumnName("Logradouro_Numero")
                        .HasColumnType("varchar(10)");

                    b.Property<string>("RazaoSocial")
                        .IsRequired()
                        .HasColumnName("RazaoSocial_Nome")
                        .HasColumnType("varchar(60)");

                    b.Property<int>("SLARespostaTempo")
                        .HasColumnName("SLA_RespostaTempo")
                        .HasColumnType("int");

                    b.Property<string>("Telefone")
                        .HasColumnName("Telefone")
                        .HasColumnType("varchar(12)");

                    b.Property<string>("UF")
                        .IsRequired()
                        .HasColumnName("Logradouro_UF")
                        .HasColumnType("varchar(2)");

                    b.HasKey("Id");

                    b.ToTable("Clientes");
                });

            modelBuilder.Entity("Prosesmt.Api.Models.Chamado", b =>
                {
                    b.HasOne("Prosesmt.Api.Models.Cliente", "Cliente")
                        .WithMany()
                        .HasForeignKey("ClienteId");
                });
#pragma warning restore 612, 618
        }
    }
}
