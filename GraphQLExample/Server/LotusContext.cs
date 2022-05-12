using GraphQLExample.Shared;
using Microsoft.EntityFrameworkCore;

namespace GraphQLExample.Server;

public class LotusContext : DbContext
{
    private readonly IConfiguration _configuration;
    public DbSet<Opdracht> Opdrachten { get; set; }
    public DbSet<Lotus> Lotussen { get; set; }
    
    
    public LotusContext(IConfiguration configuration)
    {
        _configuration = configuration;
    }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlite(_configuration.GetConnectionString("Default"));
    }
}