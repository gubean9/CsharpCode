using Microsoft.EntityFrameworkCore;

namespace Console_01
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
            using (var context = new BookContext())
            {
                context.Database.EnsureDeleted();
                context.Database.EnsureCreated();

                // 데이터 삽입
                var BOOKLIST = new List<Book>
                {
                    new Book
                    {
                        No = 1,
                        TITLE = "못 먹는 남자",
                        AUTHOR = "정해연",
                        TRANSRATOR = " ",
                        PUBLISHER = "엘릭시르",
                        ISBN = "9788954699235",
                        PAGE = 356,
                        INVENTORY = 1
                    },

                    new Book
                    {
                        No = 2,
                        TITLE = "아메리칸 프로메테우스",
                        AUTHOR = "카이 버드, 마틴 셔윈",
                        TRANSRATOR = "최형섭",
                        PUBLISHER = "사이언스북스",
                        ISBN = "9791192908236",
                        PAGE = 1056,
                        INVENTORY = 5
                    }
                };

                context.Books.AddRange(BOOKLIST);
                context.SaveChanges();
                Console.WriteLine("데이터 삽입 성공!");
            }
        }
    }
}