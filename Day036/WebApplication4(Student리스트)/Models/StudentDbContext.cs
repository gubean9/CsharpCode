using Microsoft.EntityFrameworkCore;

namespace WebApplication4.Models
{
    public class StudentDbContext : DbContext
    {
        //생성자, DB연결 초기화
        public StudentDbContext(DbContextOptions options) : base(options)
        {
        }

        //DB연결 작업 => appsettings.json
        //테이블 만들기
        public DbSet<Student> Diary { get; set; }
    }
}
