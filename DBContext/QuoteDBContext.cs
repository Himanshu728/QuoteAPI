using Microsoft.EntityFrameworkCore;
using QuoteAPI.Models;

namespace QuoteAPI.DBContext
{
    public class QuoteDBContext : DbContext
    {
        public string DbPath { get; }
        public DbSet<Quote> Quotes { get; set; }
        public QuoteDBContext()
        {
            var folder = Environment.SpecialFolder.LocalApplicationData;
            var path = Environment.GetFolderPath(folder);
            DbPath = System.IO.Path.Join(path, "Quotes.db");
        }

        protected override void OnConfiguring(DbContextOptionsBuilder options)
            => options.UseSqlite($"Data Source={DbPath}");
    }
}
