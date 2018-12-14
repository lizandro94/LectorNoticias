using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace NewsReader.Models
{
    public class NewsModel : DbContext
    {
        public NewsModel() : base("NewsDB")
        {
            //Initializer to seed News
            Database.SetInitializer(new NewsDBInitializer());
        }

        public DbSet<News> News { get; set; }

        
        //Fluent Api Configurations
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<News>().HasKey(s => s.Id);

            modelBuilder.Entity<News>()
                .Property(p => p.PublicationDate)
                .IsRequired();

            modelBuilder.Entity<News>()
                .Property(p => p.Title)
                .IsRequired()
                .HasMaxLength(150);
            
            modelBuilder.Entity<News>()
                .Property(p => p.Content)
                .IsRequired();

            modelBuilder.Entity<News>()
                .Property(p => p.Image)
                .IsOptional();
        }
    }
}