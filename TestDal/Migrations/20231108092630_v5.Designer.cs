﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using TestDal;

#nullable disable

namespace TestDal.Migrations
{
    [DbContext(typeof(TestDbContext))]
    [Migration("20231108092630_v5")]
    partial class v5
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.24")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("TestDal.one", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("id"), 1L, 1);

                    b.Property<string>("value")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("id");

                    b.ToTable("one");
                });

            modelBuilder.Entity("TestDal.parent", b =>
                {
                    b.Property<int>("ParentKey")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ParentKey"), 1L, 1);

                    b.Property<string>("Discriminator")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("IsActive")
                        .HasColumnType("bit");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("ParentKey");

                    b.ToTable("parents");

                    b.HasDiscriminator<string>("Discriminator").HasValue("parent");
                });

            modelBuilder.Entity("TestDal.toOne", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("id"), 1L, 1);

                    b.Property<int>("relatedtooneid")
                        .HasColumnType("int");

                    b.HasKey("id");

                    b.HasIndex("relatedtooneid");

                    b.ToTable("toones");
                });

            modelBuilder.Entity("TestDal.Child", b =>
                {
                    b.HasBaseType("TestDal.parent");

                    b.Property<int>("age")
                        .HasColumnType("int");

                    b.Property<DateTime>("birthdate")
                        .HasColumnType("datetime2");

                    b.HasDiscriminator().HasValue("Child");
                });

            modelBuilder.Entity("TestDal.child2", b =>
                {
                    b.HasBaseType("TestDal.parent");

                    b.Property<string>("hobbies")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasDiscriminator().HasValue("child2");
                });

            modelBuilder.Entity("TestDal.toOne", b =>
                {
                    b.HasOne("TestDal.one", "relatedtoone")
                        .WithMany()
                        .HasForeignKey("relatedtooneid")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("relatedtoone");
                });
#pragma warning restore 612, 618
        }
    }
}
