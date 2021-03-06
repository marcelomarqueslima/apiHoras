﻿// <auto-generated />
using System;
using ApiHorasInfraData.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace ApiHorasInfraData.Migrations
{
    [DbContext(typeof(ApiHorasContext))]
    [Migration("20200930103023_Inicial")]
    partial class Inicial
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.8")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("ApiHorasDomain.Entities.Lancamento", b =>
                {
                    b.Property<byte[]>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("varbinary(16)");

                    b.Property<DateTime>("DataLancamento")
                        .HasColumnType("datetime");

                    b.Property<string>("Descricao")
                        .HasColumnType("varchar(80)");

                    b.Property<DateTime>("Horario")
                        .HasColumnType("datetime");

                    b.Property<string>("TipoRegistro")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<byte[]>("UsuarioId")
                        .IsRequired()
                        .HasColumnType("varbinary(16)");

                    b.HasKey("Id");

                    b.HasIndex("UsuarioId");

                    b.ToTable("Lancamento");
                });

            modelBuilder.Entity("ApiHorasDomain.Entities.Usuario", b =>
                {
                    b.Property<byte[]>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("varbinary(16)");

                    b.Property<DateTime>("DataInicio")
                        .HasColumnType("datetime");

                    b.Property<DateTime>("DataRegistro")
                        .HasColumnType("datetime");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasColumnType("varchar(80)");

                    b.Property<string>("TipoUsuario")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("Usuario");
                });

            modelBuilder.Entity("ApiHorasDomain.Entities.Lancamento", b =>
                {
                    b.HasOne("ApiHorasDomain.Entities.Usuario", "Usuario")
                        .WithMany()
                        .HasForeignKey("UsuarioId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
