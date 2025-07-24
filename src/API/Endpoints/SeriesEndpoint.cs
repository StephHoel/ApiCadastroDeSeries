using Application.Services.GetSeries;
using Domain.Common;
using Domain.DTOs;
using Domain.Entities;
using Microsoft.AspNetCore.Mvc;

namespace API.Endpoints;

public static class SeriesEndpoint
{
    private static readonly string _endpoint = "/api/series";

    public static void SeriesEndpoints(this WebApplication app)
    {
        app.MapGet($"{_endpoint}", (IGetSeriesService service,
                                    [FromBody] List<Guid>? ids,
                                    [FromQuery] int pageSize = 10,
                                    [FromQuery] int page = 1) =>
        {
            var series = ids.Count != 0
            ? service.GetByIds(ids)
            : service.Get(page, pageSize);

            var messageError = ids.Count != 0
            ? ErrorMessages.SeriesEndpoints.IdsNotFound
            : ErrorMessages.SeriesEndpoints.NotFoundWithFilter;

            return (series is null || series.Count == 0)
            ? Results.NotFound(messageError)
            : Results.Ok(series);
        })
            .Produces<List<SerieDto>>(StatusCodes.Status200OK)
            .Produces<string>(StatusCodes.Status404NotFound);

        app.MapPut($"{_endpoint}", async (IGetSeriesService service,
                                          [FromBody] List<SerieDto> dtos) =>
        {
            var allUpdated = await service.UpdateAsync(dtos);

            return allUpdated ? Results.NoContent()
                              : Results.BadRequest(ErrorMessages.SeriesEndpoints.UpdatedFailed);
        })
            .Produces(StatusCodes.Status204NoContent)
            .Produces<string>(StatusCodes.Status400BadRequest);

        app.MapDelete(_endpoint, async (IGetSeriesService service,
                                        [FromBody] List<Guid> ids) =>
        {
            var allDeleted = await service.DeleteAsync(ids);

            return allDeleted ? Results.NoContent()
                              : Results.BadRequest(ErrorMessages.SeriesEndpoints.DeleteFailed);
        })
            .Produces(StatusCodes.Status204NoContent)
            .Produces<string>(StatusCodes.Status400BadRequest);

        app.MapPost($"{_endpoint}", async (IGetSeriesService service,
                                           [FromBody] List<SerieDto> series) =>

        {
            await service.CreateAsync(series);

            return Results.Created(_endpoint, series);
        })
            .Produces<List<SerieDto>>(StatusCodes.Status201Created);
    }
}