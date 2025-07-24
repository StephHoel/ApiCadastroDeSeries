using Domain.Common;
using Domain.Entities;

namespace Domain.DTOs;

public class SerieDto : SerieBase
{
    public Guid? Id { get; set; }

    private SerieDto()
    {
    }

    public static implicit operator SerieDto(Serie entity)
    {
        return new SerieDto
        {
            Id = entity.Id,
            Title = entity.Title,
            Seasons = entity.Seasons,
            Genre = entity.Genre ?? [],
            Description = entity.Description,
            ReleaseYear = entity.ReleaseYear,
        };
    }
}