﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using RideSaverAPI.Data;

#nullable disable

namespace RideSaverAPI.Data.Migrations
{
    [DbContext(typeof(RiderDbContext))]
    [Migration("20220930185409_UpdatedRiderModel")]
    partial class UpdatedRiderModel
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.9")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("RideSaverAPI.Models.Rider", b =>
                {
                    b.Property<Guid>("RiderID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("RiderEmail")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RiderName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RiderPassword")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RiderPhoneNumber")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RiderUsername")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("RiderID");

                    b.ToTable("Riders");
                });
#pragma warning restore 612, 618
        }
    }
}
