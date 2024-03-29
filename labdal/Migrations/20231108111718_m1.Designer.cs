﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using labdal;

#nullable disable

namespace labdal.Migrations
{
    [DbContext(typeof(snehadbcontext))]
    [Migration("20231108111718_m1")]
    partial class m1
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.24")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("coursestudent", b =>
                {
                    b.Property<int>("applycourseId")
                        .HasColumnType("int");

                    b.Property<int>("courseid")
                        .HasColumnType("int");

                    b.HasKey("applycourseId", "courseid");

                    b.HasIndex("courseid");

                    b.ToTable("coursestudent");
                });

            modelBuilder.Entity("labdal.course", b =>
                {
                    b.Property<int>("courseid")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("courseid"), 1L, 1);

                    b.Property<string>("courseName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("courseid");

                    b.ToTable("course");
                });

            modelBuilder.Entity("labdal.student", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("stuName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("student");
                });

            modelBuilder.Entity("coursestudent", b =>
                {
                    b.HasOne("labdal.student", null)
                        .WithMany()
                        .HasForeignKey("applycourseId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("labdal.course", null)
                        .WithMany()
                        .HasForeignKey("courseid")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
