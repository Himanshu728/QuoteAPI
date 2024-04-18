﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using QuoteAPI.DBContext;

#nullable disable

namespace QuoteAPI.Migrations
{
    [DbContext(typeof(QuoteDBContext))]
    [Migration("20240418115055_QuoteMigration1")]
    partial class QuoteMigration1
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "8.0.4");

            modelBuilder.Entity("QuoteAPI.Models.Quote", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("author")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("quote")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("tags")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("id");

                    b.ToTable("Quotes");
                });
#pragma warning restore 612, 618
        }
    }
}