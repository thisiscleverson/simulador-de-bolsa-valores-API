﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using simulador_de_bolsa_valores_API.Models;

#nullable disable

namespace simulador_de_bolsa_valores_API.Migrations
{
    [DbContext(typeof(StockExchangeContext))]
    [Migration("20241111113213_AddGuidColumnToOrdensTable")]
    partial class AddGuidColumnToOrdensTable
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.10")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            MySqlModelBuilderExtensions.AutoIncrementColumns(modelBuilder);

            modelBuilder.Entity("simulador_de_bolsa_valores_API.Models.Client", b =>
                {
                    b.Property<string>("Account")
                        .HasMaxLength(10)
                        .HasColumnType("varchar(10)");

                    b.Property<string>("Name")
                        .HasColumnType("longtext");

                    b.HasKey("Account");

                    b.ToTable("Client");
                });

            modelBuilder.Entity("simulador_de_bolsa_valores_API.Models.Ordens", b =>
                {
                    b.Property<string>("Order_id")
                        .HasMaxLength(36)
                        .HasColumnType("varchar(36)");

                    b.Property<string>("Account")
                        .HasColumnType("varchar(10)");

                    b.Property<DateTime>("Create_order_at")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("datetime(6)");

                    MySqlPropertyBuilderExtensions.UseMySqlIdentityColumn(b.Property<DateTime>("Create_order_at"));

                    b.Property<decimal>("Price")
                        .HasPrecision(6, 2)
                        .HasColumnType("decimal(6,2)");

                    b.Property<int>("Qty")
                        .HasColumnType("int");

                    b.Property<bool>("Side")
                        .HasColumnType("tinyint(1)");

                    b.Property<string>("Symbol")
                        .HasMaxLength(10)
                        .HasColumnType("varchar(10)");

                    b.HasKey("Order_id");

                    b.HasIndex("Account");

                    b.ToTable("Ordens");
                });

            modelBuilder.Entity("simulador_de_bolsa_valores_API.Models.Ordens", b =>
                {
                    b.HasOne("simulador_de_bolsa_valores_API.Models.Client", "Client")
                        .WithMany("Orders")
                        .HasForeignKey("Account");

                    b.Navigation("Client");
                });

            modelBuilder.Entity("simulador_de_bolsa_valores_API.Models.Client", b =>
                {
                    b.Navigation("Orders");
                });
#pragma warning restore 612, 618
        }
    }
}
