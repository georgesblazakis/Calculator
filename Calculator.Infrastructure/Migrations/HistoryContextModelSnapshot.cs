﻿// <auto-generated />
using Calculator.Infrastructure.Database;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Calculator.Infrastructure.Migrations
{
    [DbContext(typeof(HistoryContext))]
    partial class HistoryContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.4");

            modelBuilder.Entity("Calculator.Core.Entities.History", b =>
                {
                    b.Property<int>("HistoryId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("CalcHistory")
                        .HasColumnType("TEXT");

                    b.HasKey("HistoryId");

                    b.ToTable("Histories");
                });
#pragma warning restore 612, 618
        }
    }
}
