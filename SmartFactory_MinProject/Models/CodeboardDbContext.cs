﻿using Microsoft.EntityFrameworkCore;

namespace SmartFactory_MinProject.Models
{
    public class CodeboardDbContext : DbContext
    {
        public CodeboardDbContext(DbContextOptions options) : base(options)
        {
        }
        public DbSet<Codeboard> Codeboard { get; set; }

		public DbSet<Comment> Comments { get; set; } // Comment 모델을 추가
		protected override void OnModelCreating(ModelBuilder modelBuilder)
		{
			// Codeboard와 Comment 간의 관계 설정
			modelBuilder.Entity<Comment>()
				.HasOne(c => c.Codeboard)
				.WithMany(cb => cb.Comments)
				.HasForeignKey(c => c.CodeboardId);
		}
        public DbSet<User> User { get; set; }
    }

}
