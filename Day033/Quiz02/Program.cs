using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Reflection.Emit;

namespace Quiz02
{
    internal class Program
    {
        public class Student
        {
            public int No { get; set; }
            public string Name { get; set; }
            public String Major { get; set; }
            public string Hometown { get; set; }
        }

        public class PersonContext : DbContext
        {
            public DbSet<Student> Students { get; set; }

            protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
            {
                optionsBuilder.UseOracle("User Id=c##scott;Password=tiger;Data Source=127.0.0.1/XE;");
            }

            protected override void OnModelCreating(ModelBuilder modelBuilder)
            {
                modelBuilder.Entity<Student>()
                .HasKey(p => p.No);

                modelBuilder.Entity<Student>()
                    .Property(p => p.Name)
                    .HasMaxLength(30);

                modelBuilder.Entity<Student>()
                    .Property(p => p.Major)
                    .HasMaxLength(30);

                modelBuilder.Entity<Student>()
                    .Property(p => p.Hometown)
                    .HasMaxLength(30);
            }
        }
        static void Main(string[] args)
        {
            using (var context = new PersonContext())
            {
                var studentToEdit = context.Students.FirstOrDefault(p => p.No == 100);

            }
        }
    }
}