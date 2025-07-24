using Domain.Entities;

namespace Domain.Interfaces.Repositories;

public interface ISeriesRepository
{
    IEnumerable<Serie> Get(int page, int pageSize);

    IEnumerable<Serie> GetByIds(IEnumerable<Guid> ids);

    Task UpdateAsync(IEnumerable<Serie> series);

    Task CreateAsync(IEnumerable<Serie> series);
}