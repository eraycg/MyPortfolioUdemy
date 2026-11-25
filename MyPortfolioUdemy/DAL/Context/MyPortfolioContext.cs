using Microsoft.EntityFrameworkCore;
using MyPortfolioUdemy.DAL.Entities;

namespace MyPortfolioUdemy.DAL.Context
{
    public class MyPortfolioContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(
                @"Server=.\SQLEXPRESS;Database=MyPortfolioDb;Integrated Security=True;TrustServerCertificate=True;Encrypt=True;"
            );
        }
        public DbSet<About> Abouts1 { get; set; }
        public DbSet<Contact> Contacts1 { get; set; }
        public DbSet<Experience> Experiences1 { get; set; }
        public DbSet<Feature> Features1 { get; set; }
        public DbSet<Message> Messages1 { get; set; }
        public DbSet<Portfolio> Portfolios1 { get; set; }
        public DbSet<Skill>  Skills1 { get; set; }
        public DbSet<SocialMedia> SocialMedias1  { get; set; }
        public DbSet<Testimonial> Testimonials1  { get; set; }
        public DbSet<ToDoList> ToDoLists1  { get; set; }
    }
}
