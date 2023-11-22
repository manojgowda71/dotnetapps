using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace DbFirstEF.Models
{
    public partial class TestDbContext : DbContext
    {
        public TestDbContext()
        {
        }

        public TestDbContext(DbContextOptions<TestDbContext> options)
            : base(options)
        {
        }

        public virtual DbSet<One> Ones { get; set; } = null!;
        public virtual DbSet<Parent> Parents { get; set; } = null!;
        public virtual DbSet<Toone> Toones { get; set; } = null!;
        public virtual DbSet<Twomany> Twomanys { get; set; } = null!;
        public virtual DbSet<Twomany2> Twomany2s { get; set; } = null!;
        public virtual DbSet<Twomany3> Twomany3s { get; set; } = null!;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Server=(localdb)\\MSSQLLocalDB;Database=TestDb;Trusted_Connection=true");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<One>(entity =>
            {
                entity.ToTable("one");

                entity.HasIndex(e => e.Twomanyid, "IX_one_twomanyid");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Twomanyid).HasColumnName("twomanyid");

                entity.Property(e => e.Value).HasColumnName("value");

                entity.HasOne(d => d.Twomany)
                    .WithMany(p => p.Ones)
                    .HasForeignKey(d => d.Twomanyid);
            });

            modelBuilder.Entity<Parent>(entity =>
            {
                entity.HasKey(e => e.ParentKey);

                entity.ToTable("parents");

                entity.Property(e => e.Age).HasColumnName("age");

                entity.Property(e => e.Birthdate).HasColumnName("birthdate");

                entity.Property(e => e.Hobbies).HasColumnName("hobbies");

                entity.Property(e => e.Name).HasMaxLength(50);
            });

            modelBuilder.Entity<Toone>(entity =>
            {
                entity.ToTable("toones");

                entity.HasIndex(e => e.Relatedtooneid, "IX_toones_relatedtooneid");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Relatedtooneid).HasColumnName("relatedtooneid");

                entity.HasOne(d => d.Relatedtoone)
                    .WithMany(p => p.Toones)
                    .HasForeignKey(d => d.Relatedtooneid);
            });

            modelBuilder.Entity<Twomany>(entity =>
            {
                entity.ToTable("twomanys");

                entity.Property(e => e.Id).HasColumnName("id");
            });

            modelBuilder.Entity<Twomany2>(entity =>
            {
                entity.ToTable("twomany2s");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.HasMany(d => d.Tomany2s)
                    .WithMany(p => p.Manys)
                    .UsingEntity<Dictionary<string, object>>(
                        "Manytomany2",
                        l => l.HasOne<Twomany3>().WithMany().HasForeignKey("Tomany2sid"),
                        r => r.HasOne<Twomany2>().WithMany().HasForeignKey("Manysid"),
                        j =>
                        {
                            j.HasKey("Manysid", "Tomany2sid");

                            j.ToTable("manytomany2");

                            j.HasIndex(new[] { "Tomany2sid" }, "IX_manytomany2_tomany2sid");

                            j.IndexerProperty<int>("Manysid").HasColumnName("manysid");

                            j.IndexerProperty<int>("Tomany2sid").HasColumnName("tomany2sid");
                        });
            });

            modelBuilder.Entity<Twomany3>(entity =>
            {
                entity.ToTable("twomany3s");

                entity.Property(e => e.Id).HasColumnName("id");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
