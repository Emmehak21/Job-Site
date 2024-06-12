﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using jobHunt.Data;

#nullable disable

namespace jobHunt.Migrations
{
    [DbContext(typeof(DbContextClass))]
    [Migration("20240612081306_init6")]
    partial class init6
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.6")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("jobHunt.Models.Registeruser", b =>
                {
                    b.Property<string>("uemail")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("gender")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ucity")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ucountry")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("upass")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("upassc")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("uphone")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("uemail");

                    b.ToTable("reg");
                });
#pragma warning restore 612, 618
        }
    }
}
