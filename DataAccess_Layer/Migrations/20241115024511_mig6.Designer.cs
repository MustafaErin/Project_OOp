﻿// <auto-generated />
using DataAccess_Layer.Concrate;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace DataAccess_Layer.Migrations
{
    [DbContext(typeof(Context))]
    [Migration("20241115024511_mig6")]
    partial class mig6
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Entity_Layer.Concrate.Category", b =>
                {
                    b.Property<int>("CategoryId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("CategoryId"));

                    b.Property<string>("CategoryName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("CategoryId");

                    b.ToTable("categories");
                });

            modelBuilder.Entity("Entity_Layer.Concrate.Customer", b =>
                {
                    b.Property<int>("CustomerId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("CustomerId"));

                    b.Property<string>("CustomerCity")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CustomerName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("JoobId")
                        .HasColumnType("int");

                    b.Property<int>("joopJoobId")
                        .HasColumnType("int");

                    b.HasKey("CustomerId");

                    b.HasIndex("joopJoobId");

                    b.ToTable("customers");
                });

            modelBuilder.Entity("Entity_Layer.Concrate.Joop", b =>
                {
                    b.Property<int>("JoobId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("JoobId"));

                    b.Property<string>("JoobName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("JoobId");

                    b.ToTable("joops");
                });

            modelBuilder.Entity("Entity_Layer.Concrate.Product", b =>
                {
                    b.Property<int>("ProductId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ProductId"));

                    b.Property<string>("ProductName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("ProductPrice")
                        .HasColumnType("decimal(18,2)");

                    b.Property<int>("ProductStock")
                        .HasColumnType("int");

                    b.HasKey("ProductId");

                    b.ToTable("products");
                });

            modelBuilder.Entity("Entity_Layer.Concrate.Customer", b =>
                {
                    b.HasOne("Entity_Layer.Concrate.Joop", "joop")
                        .WithMany("customers")
                        .HasForeignKey("joopJoobId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("joop");
                });

            modelBuilder.Entity("Entity_Layer.Concrate.Joop", b =>
                {
                    b.Navigation("customers");
                });
#pragma warning restore 612, 618
        }
    }
}
