﻿// <auto-generated />
using System;
using KiranAssesment.DataContext;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace KiranAssesment.Migrations
{
    [DbContext(typeof(CollectionContex))]
    partial class CollectionContexModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("KiranAssesment.Models.Student", b =>
                {
                    b.Property<string>("Email")
                        .HasColumnType("varchar(300)")
                        .HasColumnName("Email");

                    b.Property<DateOnly>("DateOfBirth")
                        .HasColumnType("date")
                        .HasColumnName("DateOfBirth");

                    b.Property<string>("Gender")
                        .IsRequired()
                        .HasColumnType("varchar(300)")
                        .HasColumnName("Gender");

                    b.Property<string>("Language")
                        .IsRequired()
                        .HasColumnType("varchar(300)")
                        .HasColumnName("Language");

                    b.Property<string>("StudentName")
                        .IsRequired()
                        .HasColumnType("varchar(300)")
                        .HasColumnName("StudentName");

                    b.HasKey("Email");

                    b.ToTable("students");
                });
#pragma warning restore 612, 618
        }
    }
}
