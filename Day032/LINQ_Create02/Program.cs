using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Reflection.Emit;

namespace LINQ_Create02
{
    internal class Program
    {
        public class Person
        {
            public int ID { get; set; }
            public string NAME { get; set; }
            public int AGE { get; set; }
            public string JOB { get; set; }
        }
        public class PersonContext : DbContext
        {
            public DbSet<Person> Person { get; set; }

            protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
            {
                optionsBuilder.UseOracle("User Id=c##scott;Password=1234;Data Source=127.0.0.1/XE;");
            }

            protected override void OnModelCreating(ModelBuilder modelBuilder)
            {
                modelBuilder.Entity<Person>()   //Primary key 지정
                    .HasKey(p => p.ID);

                modelBuilder.Entity<Person>()   //Varchar2(30) 30크기를 정할 때
                    .Property(p => p.NAME)
                    .HasMaxLength(30);

                modelBuilder.Entity<Person>()
                    .Property(p => p.JOB)
                    .HasMaxLength(30);
            }
        }
        static void Main(string[] args)
        {
            using (var context = new PersonContext())
            {
                // 데이터베이스와 테이블 생성
                context.Database.EnsureDeleted();
                context.Database.EnsureCreated();
                Console.WriteLine("데이터베이스 테이블이 생성되었습니다.");
            }
        }
}