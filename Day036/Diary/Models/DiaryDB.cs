using Microsoft.EntityFrameworkCore;

namespace Diary.Models
{
    public class DiaryDB : DbContext
    {
        public DiaryDB(DbContextOptions options) : base(options)
        {
        }

        public DbSet<Diary> logs { get; set; }
    }
}
