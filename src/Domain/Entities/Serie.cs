using Domain.DTOs;

namespace Domain.Entities;

public class Serie
{
    public Guid Id { get; set; }
    public string Title { get; set; }
    public int Seasons { get; set; }
    public List<string> Genre { get; set; }
    public string Description { get; set; }
    public int ReleaseYear { get; set; }

    public DateTime CreatedAt { get; set; }
    public DateTime UpdatedAt { get; set; }
    public DateTime? DeletedAt { get; set; }

    public Serie()
    {
    }

    public Serie(string title,
                 int seasons,
                 List<string> genre,
                 string description,
                 int releaseYear)
    {
        Id = Guid.NewGuid();
        Title = title;
        Seasons = seasons;
        Genre = genre;
        Description = description;
        ReleaseYear = releaseYear;
        CreatedAt = DateTime.UtcNow;
        UpdatedAt = DateTime.UtcNow;
        DeletedAt = null;
    }

    public static implicit operator Serie(SerieDto dto)
    {
        return new Serie()
        {
            Id = dto.Id ?? Guid.NewGuid(),
            Title = dto.Title,
            Seasons = dto.Seasons,
            Genre = dto.Genre ?? [],
            Description = dto.Description,
            ReleaseYear = dto.ReleaseYear,

            CreatedAt = DateTime.UtcNow,
            UpdatedAt = DateTime.UtcNow,
            DeletedAt = null,
        };
    }
}