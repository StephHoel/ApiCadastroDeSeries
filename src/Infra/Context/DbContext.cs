using Domain.Entities;
using Infra.Data.Seed;
using Microsoft.EntityFrameworkCore;

namespace Infra.Context;

public class SeriesCatalogDbContext(DbContextOptions<SeriesCatalogDbContext> options)
        : DbContext(options)
{
    public DbSet<Serie> Series { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);

        SeriesSeed.Seed(modelBuilder);
    }
}