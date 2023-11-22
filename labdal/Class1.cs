using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace labdal
{
    public class student 
    {
        [Key]
        public int Id { get; set; }
        public string stuName { get; set; }
        public List<course> courses { get; set; }
        
    }
    public class course
    {
        [Key]
        public int courseid { get; set; }
        public string courseName { get; set; }
        public List<student> manystudents { get; set; }
    }
    public class company
    {
        [Key]
        public int companyid { get; set; }
        public string companyName { get; set; }
        public student joinedcmpnyy { get; set; }
    }

    public class snehadbcontext:DbContext
    {
        public DbSet<student> student { get; set; }
        public DbSet<course> course { get; set; }

        public DbSet<company> companies { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=(localdb)\MSSQLLocalDB;Database=snehaDb;Trusted_Connection=true");
        }

    }
}