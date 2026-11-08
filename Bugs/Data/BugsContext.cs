
using System.IO;
using Bugs.Models;
using Microsoft.EntityFrameworkCore;

namespace Bugs.Data;

public class BugsContext : DbContext
{
    public DbSet<Purchaser> Purchasers { get; set; }
    public DbSet<Contract> Contracts { get; set; }

    public BugsContext() {}

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        // Use SQLite database
        // string appData = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData);
        optionsBuilder.UseSqlite($"Data Source=Bugs.db");
    }
}