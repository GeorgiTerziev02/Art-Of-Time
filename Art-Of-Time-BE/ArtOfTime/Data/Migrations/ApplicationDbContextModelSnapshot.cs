﻿// <auto-generated />
using System;
using ArtOfTime.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace ArtOfTime.Data.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    partial class ApplicationDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.15")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("ArtOfTime.Data.Entities.Image", b =>
                {
                    b.Property<string>("TimeStamp")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("BasedOnText")
                        .HasColumnType("nvarchar(max)");

                    b.Property<byte[]>("ImageBase64")
                        .HasColumnType("varbinary(max)");

                    b.Property<bool>("IsFetched")
                        .HasColumnType("bit");

                    b.Property<bool>("IsMinted")
                        .HasColumnType("bit");

                    b.Property<bool>("IsUploadedImage")
                        .HasColumnType("bit");

                    b.Property<bool>("IsUploadedJson")
                        .HasColumnType("bit");

                    b.Property<string>("JsonMetadata")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("JsonUrl")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UidFilename")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("TimeStamp");

                    b.ToTable("Images");
                });
#pragma warning restore 612, 618
        }
    }
}
