using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Protocols;
using qDocManager.Repository.Models;

public class AppDbContext : DbContext
{
    public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

    public DbSet<Document> Documents { get; set; }
    public DbSet<Category> Categories { get; set; }
    public DbSet<Tag> Tags { get; set; }
}
