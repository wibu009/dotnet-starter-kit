﻿// <auto-generated />
using System;
using FSH.WebApi.Infrastructure.Multitenancy;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Migrators.MySQL.Migrations.Tenant
{
    [DbContext(typeof(TenantDbContext))]
    [Migration("20240617194138_InitialMigrations")]
    partial class InitialMigrations
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.4")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("FSH.WebApi.Infrastructure.Multitenancy.FSHTenantInfo", b =>
                {
                    b.Property<string>("Id")
                        .HasMaxLength(64)
                        .HasColumnType("varchar(64)");

                    b.Property<string>("AdminEmail")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("ConnectionString")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("DbProvider")
                        .HasColumnType("longtext");

                    b.Property<string>("Identifier")
                        .IsRequired()
                        .HasColumnType("varchar(255)");

                    b.Property<bool>("IsActive")
                        .HasColumnType("tinyint(1)");

                    b.Property<string>("Issuer")
                        .HasColumnType("longtext");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<DateTime>("ValidUpto")
                        .HasColumnType("datetime(6)");

                    b.HasKey("Id");

                    b.HasIndex("Identifier")
                        .IsUnique();

                    b.ToTable("Tenants", "MultiTenancy");
                });
#pragma warning restore 612, 618
        }
    }
}
