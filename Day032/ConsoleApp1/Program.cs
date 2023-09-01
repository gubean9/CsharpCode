using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Reflection.Emit;

namespace ConsoleApp1
{
    public class Person
    {
        [Key]
        public int ID { get; set; }
        public string NAME { get; set; }
        public int AGE { get; set; }
        public int JOB { get; set; }
    }

    //DB Acesse 객체 모델
    public class PersonContext : DbContext
    {
        //테이블
        public DbSet<Person> Persons { get; set; }

        //접속 문자열
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseOracle("User Id=c#scott;Password=tiger;Data Source=127.0.0.1/XE;"); //DB설치 미완
        }

        //테이블 생성 및 제약
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
    internal class Program
    {
        static void Main(string[] args)
        {
            var context = new PersonContext();
            context.Database.EnsureCreated();
            context.SaveChanges();
            Console.WriteLine("데이터베이스 테이블이 생성되었습니다");
        }
    }
}