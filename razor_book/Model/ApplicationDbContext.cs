using System;
using Microsoft.EntityFrameworkCore;

namespace razor_book.Model
{
    public class ApplicationDbContext: DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
                
        }

        public DbSet<Book> Book { get; set; }
    }
}
