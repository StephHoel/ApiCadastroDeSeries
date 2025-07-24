using Domain.DTOs;

namespace Application.Services.GetSeries;

public interface IGetSeriesService
{
    List<SerieDto> Get(int page, int pageSize);

    List<SerieDto> GetByIds(IEnumerable<Guid> id);

    Task<bool> UpdateAsync(IEnumerable<SerieDto> dto);

    Task<bool> DeleteAsync(IEnumerable<Guid> ids);

    Task CreateAsync(IEnumerable<SerieDto> series);
}