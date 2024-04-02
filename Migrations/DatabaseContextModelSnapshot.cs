﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using finalPOCService.database;

#nullable disable

namespace CapstoneService.Migrations
{
    [DbContext(typeof(DatabaseContext))]
    partial class DatabaseContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.3")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("finalPOCService.models.Alumni", b =>
                {
                    b.Property<int>("rollno")
                        .HasColumnType("int");

                    b.Property<int>("age")
                        .HasColumnType("int");

                    b.Property<int>("batchYear")
                        .HasColumnType("int");

                    b.Property<string>("branch")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("rollno");

                    b.ToTable("alumnis");
                });

            modelBuilder.Entity("finalPOCService.models.User", b =>
                {
                    b.Property<string>("userName")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("country")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("gender")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("password")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("phoneNumber")
                        .HasColumnType("int");

                    b.HasKey("userName");

                    b.ToTable("users");
                });
#pragma warning restore 612, 618
        }
    }
}
