using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Reflection.Metadata;

namespace TestDal
{
    //domain classes
    #region inheritance
    public class parent 
    { 
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]

    public int ParentKey { get; set;}
        [Required]
        [StringLength(50)]
    public string Name { get; set; }
    public bool IsActive { get; set; }
}
     public class Child : parent 
{
      [NotMapped]
    public int chlidid { get; set; }
    public DateTime birthdate { get; set; }
        [Range(18,110)]
    public int age { get; set; }
}
    public class child2 : parent
    { 
        public string hobbies { get; set; }
    }
    #endregion inheritance

    #region one2one and one2many
    public class one
    {
        [Key]
        public int id { get; set; }
        public string value { get; set; }

    }
    public class toOne
    {
        public int id { get; set; }
        public one relatedtoone { get; set; }
    }
    public class twomany
    {
        [Key]
        public int id { get; set; }
        public List<one> tomany1 { get; set; }

    }
    #endregion one2one and one2many

    public class many 
    {
        [Key]
        public int id { get; set; }
        public List<tomany2> tomany2s { get; set; } 
    }
    public class tomany2
    {
        [Key]
        public int id { get; set; }
        public List<many> manys { get; set; }
    }
    //mapping layer
    public class TestDbContext:DbContext

    {
        public DbSet<parent> parents { get; set; }
        public DbSet<Child> children { get; set; }
        public DbSet<child2> children2 { get; set; }
        public DbSet<one> one { get; set; }
        public DbSet<toOne> toones { get; set; }
        public DbSet<twomany> twomanys { get; set; }

        public DbSet<many> twomany2s { get; set; }

        public DbSet<tomany2> twomany3s { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=(localdb)\MSSQLLocalDB;Database=TestDb;Trusted_Connection=true");
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<parent>().Property(p => p.ParentKey).UseIdentityColumn();
            modelBuilder.Entity<parent>().HasOne<Child>();
            modelBuilder.Entity<one>().HasMany<many>();
        }

    }
}