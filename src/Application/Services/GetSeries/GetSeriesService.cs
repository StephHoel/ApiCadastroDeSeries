using Domain.DTOs;
using Domain.Entities;
using Domain.Interfaces.Repositories;

namespace Application.Services.GetSeries;

public class GetSeriesService : IGetSeriesService
{
    private readonly ISeriesRepository _repository;

    public GetSeriesService(ISeriesRepository repository)
    {
        _repository = repository;
    }

    public List<SerieDto> Get(int page, int pageSize)
    {
        var series = _repository.Get(page, pageSize);

        return [.. series.Select(s => (SerieDto)s)];
    }

    public List<SerieDto> GetByIds(IEnumerable<Guid> id)
    {
        var series = _repository.GetByIds(id);

        return [.. series.Select(s => (SerieDto)s)];
    }

    public async Task<bool> UpdateAsync(IEnumerable<SerieDto> dto)
    {
        var ids = (IEnumerable<Guid>)dto.Where(d => d.Id != null).Select(i => i.Id);

        var existingList = _repository.GetByIds(ids);

        foreach (var existing in existingList)
        {
            var updated = dto.First(i => i.Id == existing.Id);

            existing.Title = updated.Title;
            existing.Seasons = updated.Seasons;
            existing.Genre = updated.Genre;
            existing.UpdatedAt = DateTime.UtcNow;
        }

        var notFoundIds = ids.Except(existingList.Select(e => e.Id)).ToList();

        await _repository.UpdateAsync(existingList);

        return notFoundIds.Count == 0;
    }

    public async Task<bool> DeleteAsync(IEnumerable<Guid> ids)
    {
        var series = _repository.GetByIds(ids);

        foreach (var serie in series)
        {
            serie.DeletedAt = DateTime.UtcNow;
        }

        await _repository.UpdateAsync(series);

        return ids.Count() == series.Count();
    }

    public async Task CreateAsync(IEnumerable<SerieDto> series)
    {
        await _repository.CreateAsync(series.Select(s => (Serie)s));
    }
}