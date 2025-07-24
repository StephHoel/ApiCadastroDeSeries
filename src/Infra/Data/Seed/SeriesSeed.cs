using Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace Infra.Data.Seed;

public static class SeriesSeed
{
    public static void Seed(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Serie>().HasData(
            new Serie
            {
                Id = Guid.Parse("a1111111-1111-1111-1111-111111111111"),
                Title = "Game of Thrones",
                Seasons = 8,
                Genre = ["Fantasy"],
                Description = "A series of power struggles among noble families in the fictional land of Westeros.",
                ReleaseYear = 2011,

                CreatedAt = DateTime.Parse("2025-07-23"),
                UpdatedAt = DateTime.Parse("2025-07-23"),
            }
        );
    }
}