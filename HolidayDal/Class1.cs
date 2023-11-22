using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HolidayDal
{
    public class Holidayemployee
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int empId { get; set; }
        [Required]
        [StringLength(50)]
        public string empName { get; set; }
        public bool isactive { get; set; }
        public DateTime DOJ { get; set; }
      
      
    }
    public class designation
    {
        [Key]
        public int designationId { get; set; }
        [Required]
        [StringLength(50)]
        public string desigantionName { get; set; }
        public double salary { get; set; }
         public int experience { get; set; }
        public Holidayemployee role { get; set; }
    }
    public class manojdbcontext : DbContext
    {
        public DbSet<Holidayemployee> Holiemployee { get; set; }
        public DbSet<designation> designation { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=(localdb)\MSSQLLocalDB;Database=ManojDB;Trusted_Connection=true");
        }
    }


}