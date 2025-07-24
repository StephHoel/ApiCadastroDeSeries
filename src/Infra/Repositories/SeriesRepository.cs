using Domain.Entities;
using Domain.Interfaces.Repositories;
using Infra.Context;

namespace Infra.Repositories;

public class SeriesRepository : ISeriesRepository
{
    private readonly SeriesCatalogDbContext _context;

    public SeriesRepository(SeriesCatalogDbContext context)
    {
        _context = context;
    }

    public IEnumerable<Serie> Get(int page, int pageSize)
        => _context.Series.Where(s => s.DeletedAt == null)
                          .Skip((page - 1) * pageSize)
                          .Take(pageSize);

    public IEnumerable<Serie> GetByIds(IEnumerable<Guid> ids)
        => _context.Series.Where(serie => serie.DeletedAt == null && ids.Contains(serie.Id));

    public async Task UpdateAsync(IEnumerable<Serie> series)
    {
        _context.Series.UpdateRange(series);
        await _context.SaveChangesAsync();
    }

    public async Task CreateAsync(IEnumerable<Serie> series)
    {
        await _context.Series.AddRangeAsync(series);
        await _context.SaveChangesAsync();
    }
}