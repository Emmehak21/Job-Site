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
    [Migration("20240612051323_init")]
    partial class init
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.6")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("jobHunt.Models.Login", b =>
                {
                    b.Property<string>("uemail")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("upass")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("uemail");

                    b.ToTable("Login");
                });
#pragma warning restore 612, 618
        }
    }
}
