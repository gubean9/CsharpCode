using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Reflection.Emit;

namespace Console_02
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
                while (true)
                {
                    Console.WriteLine("1. 도서 목록 조회");
                    Console.WriteLine("2. 도서 추가");
                    Console.WriteLine("3. 도서 수정");
                    Console.WriteLine("4. 도서 삭제");
                    Console.WriteLine("5. 프로그램 종료");
                    Console.Write("숫자를 입력하세요 : ");
                    int a = int.Parse(Console.ReadLine());
                    switch (a)
                    {
                        case 1:
                            Console.WriteLine(" ");
                            Console.WriteLine("========도서 목록========");
                            var books = context.Books.ToList();
                            Console.WriteLine("");
                            foreach (var book in books)
                                Console.WriteLine($"{book.No}," +
                                    $"제목 : {book.TITLE}," +
                                    $"저자 : {book.AUTHOR}," +
                                    $"역자 : {book.TRANSRATOR}," +
                                    $"재고 : {book.INVENTORY}");
                            Console.WriteLine(" ");
                            Console.WriteLine("=====================");
                            Console.WriteLine(" ");
                            break;
                        
                        case 2:
                            Console.WriteLine(" ");
                            Console.WriteLine("========도서 추가========");
                            Console.Write("제목을 입력하세요 : ");
                            string Title = Console.ReadLine();

                            Console.Write("저자를 입력하세요 : ");
                            string Author = Console.ReadLine();

                            Console.Write("역자를 입력하세요 : ");
                            string Transrator = Console.ReadLine();

                            Console.Write("출판사를 입력하세요 : ");
                            string Publisher = Console.ReadLine();

                            Console.Write("ISBN을 입력하세요 : ");
                            string Isbn = Console.ReadLine();
                                
                            Console.Write("페이지를 입력하세요 : ");
                            int Page = int.Parse(Console.ReadLine());

                            Console.Write("수량을 입력하세요 : ");
                            int Inventory = int.Parse(Console.ReadLine());

                            var newB = new Book { TITLE = Title,
                                AUTHOR = Author,
                                TRANSRATOR = Transrator,
                                ISBN = Isbn,
                                PAGE = Page,
                                INVENTORY = Inventory
                            };
                            
                            Console.WriteLine(" ");
                            Console.WriteLine("=====================");
                            Console.WriteLine(" ");
                            break;

                        case 3:
                            Console.WriteLine("도서 수정");
                            break;

                        case 4:
                            Console.WriteLine("도서 삭제");
                            break;

                        case 5:
                            Console.WriteLine("프로그램을 종료합니다.");
                            Environment.Exit(0);
                            break;
                    }
                }
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