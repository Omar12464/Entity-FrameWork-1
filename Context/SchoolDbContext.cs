using Entity_FrameWork_1.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity_FrameWork_1.Context
{
    internal class SchoolDbContext:DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=LAPTOP-6FHT0HLA ; Database = SchoolC42 ; Trusted_Connection = True ; Encrypt=False ");
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<StudCourse>().HasNoKey();
            modelBuilder.Entity<Course_Inst>().HasNoKey();

        }

        public DbSet<Student> Student { get; set; }
        public DbSet<Instructor> Instructor { get; set; }
        public DbSet<Course> Course { get; set; }
        public DbSet<Topic> Topic { get; set; }
        public DbSet<Department> Department { get; set; }
        public DbSet<StudCourse> StudCourse { get; set; }
        public DbSet<Course_Inst> Course_Inst { get; set; }

    }
}
