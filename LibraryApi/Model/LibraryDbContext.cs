using Microsoft.EntityFrameworkCore;

namespace LibraryApi.Model
{
    public class LibraryDbContext : DbContext
    {
        public LibraryDbContext(DbContextOptions<LibraryDbContext> options): base(options) { }

        public DbSet<Book> Books { get; set; } = null!;
        public DbSet<Member> Members { get; set; } = null!;
    }
}