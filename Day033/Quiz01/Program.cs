using System.Collections.Generic;
using System.Reflection.Emit;
using System;
using Microsoft.EntityFrameworkCore;

namespace Quiz01
{
    public class Student
    {
        public int ID { get; set; }
        public string NAME { get; set; }
        public string MAJOR { get; set; }
        public string HOMETOWN { get; set; }
    }

    public class StudentContext : DbContext
    {
        public DbSet<Student> Students { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseOracle("User Id=c#scott;Password=tiger;Data Source=127.0.0.1/XE;"); //DB설치 미완
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Student>()
                .Property(p => p.ID);

            modelBuilder.Entity<Student>()
                .Property(p => p.NAME)
                .HasMaxLength(30);

            modelBuilder.Entity<Student>()
                .Property(p => p.MAJOR)
                .HasMaxLength(30);

            modelBuilder.Entity<Student>()
                .Property(p => p.HOMETOWN)
                .HasMaxLength(30);
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            using (var context = new StudentContext())
            {
                context.Database.EnsureDeleted();
                context.Database.EnsureCreated();

                var Students = new List<Student>
                {
                    new Student { ID = 100, NAME = "홍길동", MAJOR = "컴공", HOMETOWN = "안동" },

                    new Student { ID = 200, NAME = "이순신", MAJOR = "정통", HOMETOWN = "통영" },

                    new Student { ID = 300, NAME = "강감찬", MAJOR = "기계", HOMETOWN = "개성" },

                    new Student { ID = 400, NAME = "을지문덕", MAJOR = "멀티", HOMETOWN = "서울" }
                };

                context.Students.AddRange(Students);
                context.SaveChanges();
                Console.WriteLine("데이터 삽입 성공");
            }
        }
    }
}