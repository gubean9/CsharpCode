using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Reflection.Emit;

namespace Test
{
    public class Book
    {
        public int No { get; set; }
        public string TITLE { get; set; }
        public string AUTHOR { get; set; }
        public string TRANSRATOR { get; set; }
        public string PUBLISHER { get; set; }
        public string ISBN { get; set; }
        public int PAGE { get; set; }
        public int INVENTORY { get; set; }
    }
    public class BookContext : DbContext
    {
        public DbSet<Book> Books { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseOracle("User Id=c##scott;Password=tiger;Data Source=127.0.0.1/XE;");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Book>()   //Primary key 지정
                .HasKey(p => p.No);

            modelBuilder.Entity<Book>()   //Varchar2(30) 30크기를 정할 때
                .Property(p => p.TITLE)
                .HasMaxLength(30);

            modelBuilder.Entity<Book>()
                .Property(p => p.AUTHOR)
                .HasMaxLength(30);

            modelBuilder.Entity<Book>()
                .Property(p => p.TRANSRATOR)
                .HasMaxLength(30);

            modelBuilder.Entity<Book>()
                .Property(p => p.PUBLISHER)
                .HasMaxLength(30);

            modelBuilder.Entity<Book>()
                .Property(p => p.ISBN)
                .HasMaxLength(30);

            modelBuilder.Entity<Book>()
                .Property(p => p.PAGE)
                .HasColumnType("number");

            modelBuilder.Entity<Book>()
                .Property(p => p.INVENTORY)
                .HasColumnType("number");
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            while(true)
            {
                Console.WriteLine(1. )
            }

            /*
            using (var context = new BookContext())
            {
                //context.Database.EnsureDeleted();
                //context.Database.EnsureCreated();


                context.Books.AddRange(BOOKLIST);
                context.SaveChanges();
                Console.WriteLine("데이터 삽입 성공!");
            }
            */
        }
    }
}