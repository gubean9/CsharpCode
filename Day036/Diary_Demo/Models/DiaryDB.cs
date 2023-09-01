using Microsoft.EntityFrameworkCore;

namespace WebApplication4.Models
{
    public class DiaryDB : DbContext
    {
        //생성자, DB연결 초기화
        public DiaryDB(DbContextOptions options) : base(options)
        {
        }

        //DB연결 작업 => appsettings.json
        //테이블 만들기
        public DbSet<Diary> Student { get; set; }
    }
}
