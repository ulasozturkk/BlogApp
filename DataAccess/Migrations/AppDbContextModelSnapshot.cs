﻿// <auto-generated />
using System;
using DataAccess.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace DataAccess.Migrations
{
    [DbContext(typeof(AppDbContext))]
    partial class AppDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.22")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.UseIdentityByDefaultColumns(modelBuilder);

            modelBuilder.Entity("Entity.Entities.Article", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<Guid>("CategoryId")
                        .HasColumnType("uuid");

                    b.Property<string>("Content")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("CreatedBy")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("timestamp with time zone");

                    b.Property<string>("DeletedBy")
                        .HasColumnType("text");

                    b.Property<DateTime?>("DeletedDate")
                        .HasColumnType("timestamp with time zone");

                    b.Property<Guid>("ImageId")
                        .HasColumnType("uuid");

                    b.Property<string>("ModifiedBy")
                        .HasColumnType("text");

                    b.Property<DateTime?>("ModifiedDate")
                        .HasColumnType("timestamp with time zone");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<int>("ViewCount")
                        .HasColumnType("integer");

                    b.Property<bool>("isDeleted")
                        .HasColumnType("boolean");

                    b.HasKey("Id");

                    b.HasIndex("CategoryId");

                    b.HasIndex("ImageId");

                    b.ToTable("Articles");

                    b.HasData(
                        new
                        {
                            Id = new Guid("852e041e-4ed4-43a4-8ee4-91832d978db1"),
                            CategoryId = new Guid("77ebf623-09be-411f-9165-04dc3ba68d94"),
                            Content = "lorem ipsum sdfngjksdfgmdfjsgnsdfglsdfngsdflşkgnsdlfkgnklsdifngşlksdfnglkşsdfngsşdlfkgnskldfgşsldfgsfgsdfgsdfg",
                            CreatedBy = "Admin Test",
                            CreatedDate = new DateTime(2024, 3, 19, 7, 19, 19, 159, DateTimeKind.Utc).AddTicks(9130),
                            ImageId = new Guid("bd316f53-95cb-48c9-931b-528d141e4e8e"),
                            Title = "dotnet Deneme makalesi 1",
                            ViewCount = 15,
                            isDeleted = false
                        });
                });

            modelBuilder.Entity("Entity.Entities.Category", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<string>("CreatedBy")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("timestamp with time zone");

                    b.Property<string>("DeletedBy")
                        .HasColumnType("text");

                    b.Property<DateTime?>("DeletedDate")
                        .HasColumnType("timestamp with time zone");

                    b.Property<string>("ModifiedBy")
                        .HasColumnType("text");

                    b.Property<DateTime?>("ModifiedDate")
                        .HasColumnType("timestamp with time zone");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<bool>("isDeleted")
                        .HasColumnType("boolean");

                    b.HasKey("Id");

                    b.ToTable("Categories");

                    b.HasData(
                        new
                        {
                            Id = new Guid("77ebf623-09be-411f-9165-04dc3ba68d94"),
                            CreatedBy = "Admin Test",
                            CreatedDate = new DateTime(2024, 3, 19, 7, 19, 19, 159, DateTimeKind.Utc).AddTicks(9300),
                            Name = "dotnet core",
                            isDeleted = false
                        },
                        new
                        {
                            Id = new Guid("19f32511-de5a-4234-99a5-503417225df4"),
                            CreatedBy = "Admin Test",
                            CreatedDate = new DateTime(2024, 3, 19, 7, 19, 19, 159, DateTimeKind.Utc).AddTicks(9310),
                            Name = "visual studip core",
                            isDeleted = false
                        });
                });

            modelBuilder.Entity("Entity.Entities.Image", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<string>("CreatedBy")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("timestamp with time zone");

                    b.Property<string>("DeletedBy")
                        .HasColumnType("text");

                    b.Property<DateTime?>("DeletedDate")
                        .HasColumnType("timestamp with time zone");

                    b.Property<string>("FileName")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("FileType")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("ModifiedBy")
                        .HasColumnType("text");

                    b.Property<DateTime?>("ModifiedDate")
                        .HasColumnType("timestamp with time zone");

                    b.Property<bool>("isDeleted")
                        .HasColumnType("boolean");

                    b.HasKey("Id");

                    b.ToTable("Images");

                    b.HasData(
                        new
                        {
                            Id = new Guid("bd316f53-95cb-48c9-931b-528d141e4e8e"),
                            CreatedBy = "Admin test",
                            CreatedDate = new DateTime(2024, 3, 19, 7, 19, 19, 159, DateTimeKind.Utc).AddTicks(9370),
                            FileName = "images/testimage",
                            FileType = "jpg",
                            isDeleted = false
                        },
                        new
                        {
                            Id = new Guid("14b15696-c3b9-4f50-b42e-64455b8ef0dc"),
                            CreatedBy = "Admin test",
                            CreatedDate = new DateTime(2024, 3, 19, 7, 19, 19, 159, DateTimeKind.Utc).AddTicks(9370),
                            FileName = "images/vstest",
                            FileType = "jpg",
                            isDeleted = false
                        });
                });

            modelBuilder.Entity("Entity.Entities.Article", b =>
                {
                    b.HasOne("Entity.Entities.Category", "Category")
                        .WithMany("Articles")
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Entity.Entities.Image", "Image")
                        .WithMany("Articles")
                        .HasForeignKey("ImageId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Category");

                    b.Navigation("Image");
                });

            modelBuilder.Entity("Entity.Entities.Category", b =>
                {
                    b.Navigation("Articles");
                });

            modelBuilder.Entity("Entity.Entities.Image", b =>
                {
                    b.Navigation("Articles");
                });
#pragma warning restore 612, 618
        }
    }
}
