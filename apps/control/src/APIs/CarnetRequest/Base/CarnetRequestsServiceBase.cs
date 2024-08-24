using Control.APIs;
using Control.APIs.Common;
using Control.APIs.Dtos;
using Control.APIs.Errors;
using Control.APIs.Extensions;
using Control.Infrastructure;
using Control.Infrastructure.Models;
using Microsoft.EntityFrameworkCore;

namespace Control.APIs;

public abstract class CarnetRequestsServiceBase : ICarnetRequestsService
{
    protected readonly ControlDbContext _context;

    public CarnetRequestsServiceBase(ControlDbContext context)
    {
        _context = context;
    }

    /// <summary>
    /// Create one Carnet Request
    /// </summary>
    public async Task<CarnetRequest> CreateCarnetRequest(CarnetRequestCreateInput createDto)
    {
        var carnetRequest = new CarnetRequestDbModel
        {
            CarnetTypeCode = createDto.CarnetTypeCode,
            CreatedAt = createDto.CreatedAt,
            ManagementNumberOfCarnet = createDto.ManagementNumberOfCarnet,
            UpdatedAt = createDto.UpdatedAt
        };

        if (createDto.Id != null)
        {
            carnetRequest.Id = createDto.Id;
        }
        if (createDto.ArticleCarnetRequests != null)
        {
            carnetRequest.ArticleCarnetRequests = await _context
                .ArticleCarnetRequests.Where(articleCarnetRequest =>
                    createDto
                        .ArticleCarnetRequests.Select(t => t.Id)
                        .Contains(articleCarnetRequest.Id)
                )
                .ToListAsync();
        }

        if (createDto.CommonCarnetRequest != null)
        {
            carnetRequest.CommonCarnetRequest = await _context
                .CommonCarnetRequests.Where(commonCarnetRequest =>
                    createDto.CommonCarnetRequest.Id == commonCarnetRequest.Id
                )
                .FirstOrDefaultAsync();
        }

        if (createDto.ExtendedPeriodCarnetRequests != null)
        {
            carnetRequest.ExtendedPeriodCarnetRequests = await _context
                .ExtendedPeriodCarnetRequests.Where(extendedPeriodCarnetRequest =>
                    createDto.ExtendedPeriodCarnetRequests.Id == extendedPeriodCarnetRequest.Id
                )
                .FirstOrDefaultAsync();
        }

        if (createDto.ImportCarnetRequests != null)
        {
            carnetRequest.ImportCarnetRequests = await _context
                .ImportCarnetRequests.Where(importCarnetRequest =>
                    createDto
                        .ImportCarnetRequests.Select(t => t.Id)
                        .Contains(importCarnetRequest.Id)
                )
                .ToListAsync();
        }

        if (createDto.ReexportCarnetRequests != null)
        {
            carnetRequest.ReexportCarnetRequests = await _context
                .ReexportCarnetRequests.Where(reexportCarnetRequest =>
                    createDto
                        .ReexportCarnetRequests.Select(t => t.Id)
                        .Contains(reexportCarnetRequest.Id)
                )
                .ToListAsync();
        }

        if (createDto.TransitCarnetRequests != null)
        {
            carnetRequest.TransitCarnetRequests = await _context
                .TransitCarnetRequests.Where(transitCarnetRequest =>
                    createDto
                        .TransitCarnetRequests.Select(t => t.Id)
                        .Contains(transitCarnetRequest.Id)
                )
                .ToListAsync();
        }

        _context.CarnetRequests.Add(carnetRequest);
        await _context.SaveChangesAsync();

        var result = await _context.FindAsync<CarnetRequestDbModel>(carnetRequest.Id);

        if (result == null)
        {
            throw new NotFoundException();
        }

        return result.ToDto();
    }

    /// <summary>
    /// Delete one Carnet Request
    /// </summary>
    public async Task DeleteCarnetRequest(CarnetRequestWhereUniqueInput uniqueId)
    {
        var carnetRequest = await _context.CarnetRequests.FindAsync(uniqueId.Id);
        if (carnetRequest == null)
        {
            throw new NotFoundException();
        }

        _context.CarnetRequests.Remove(carnetRequest);
        await _context.SaveChangesAsync();
    }

    /// <summary>
    /// Find many Carnet Requests
    /// </summary>
    public async Task<List<CarnetRequest>> CarnetRequests(CarnetRequestFindManyArgs findManyArgs)
    {
        var carnetRequests = await _context
            .CarnetRequests.Include(x => x.CommonCarnetRequest)
            .Include(x => x.ExtendedPeriodCarnetRequests)
            .Include(x => x.TransitCarnetRequests)
            .Include(x => x.ArticleCarnetRequests)
            .Include(x => x.ImportCarnetRequests)
            .Include(x => x.ReexportCarnetRequests)
            .ApplyWhere(findManyArgs.Where)
            .ApplySkip(findManyArgs.Skip)
            .ApplyTake(findManyArgs.Take)
            .ApplyOrderBy(findManyArgs.SortBy)
            .ToListAsync();
        return carnetRequests.ConvertAll(carnetRequest => carnetRequest.ToDto());
    }

    /// <summary>
    /// Meta data about Carnet Request records
    /// </summary>
    public async Task<MetadataDto> CarnetRequestsMeta(CarnetRequestFindManyArgs findManyArgs)
    {
        var count = await _context.CarnetRequests.ApplyWhere(findManyArgs.Where).CountAsync();

        return new MetadataDto { Count = count };
    }

    /// <summary>
    /// Get one Carnet Request
    /// </summary>
    public async Task<CarnetRequest> CarnetRequest(CarnetRequestWhereUniqueInput uniqueId)
    {
        var carnetRequests = await this.CarnetRequests(
            new CarnetRequestFindManyArgs
            {
                Where = new CarnetRequestWhereInput { Id = uniqueId.Id }
            }
        );
        var carnetRequest = carnetRequests.FirstOrDefault();
        if (carnetRequest == null)
        {
            throw new NotFoundException();
        }

        return carnetRequest;
    }

    /// <summary>
    /// Update one Carnet Request
    /// </summary>
    public async Task UpdateCarnetRequest(
        CarnetRequestWhereUniqueInput uniqueId,
        CarnetRequestUpdateInput updateDto
    )
    {
        var carnetRequest = updateDto.ToModel(uniqueId);

        if (updateDto.TransitCarnetRequests != null)
        {
            carnetRequest.TransitCarnetRequests = await _context
                .TransitCarnetRequests.Where(transitCarnetRequest =>
                    updateDto.TransitCarnetRequests.Select(t => t).Contains(transitCarnetRequest.Id)
                )
                .ToListAsync();
        }

        if (updateDto.ArticleCarnetRequests != null)
        {
            carnetRequest.ArticleCarnetRequests = await _context
                .ArticleCarnetRequests.Where(articleCarnetRequest =>
                    updateDto.ArticleCarnetRequests.Select(t => t).Contains(articleCarnetRequest.Id)
                )
                .ToListAsync();
        }

        if (updateDto.ImportCarnetRequests != null)
        {
            carnetRequest.ImportCarnetRequests = await _context
                .ImportCarnetRequests.Where(importCarnetRequest =>
                    updateDto.ImportCarnetRequests.Select(t => t).Contains(importCarnetRequest.Id)
                )
                .ToListAsync();
        }

        if (updateDto.ReexportCarnetRequests != null)
        {
            carnetRequest.ReexportCarnetRequests = await _context
                .ReexportCarnetRequests.Where(reexportCarnetRequest =>
                    updateDto
                        .ReexportCarnetRequests.Select(t => t)
                        .Contains(reexportCarnetRequest.Id)
                )
                .ToListAsync();
        }

        _context.Entry(carnetRequest).State = EntityState.Modified;

        try
        {
            await _context.SaveChangesAsync();
        }
        catch (DbUpdateConcurrencyException)
        {
            if (!_context.CarnetRequests.Any(e => e.Id == carnetRequest.Id))
            {
                throw new NotFoundException();
            }
            else
            {
                throw;
            }
        }
    }

    /// <summary>
    /// Connect multiple Article Carnet Requests records to Carnet Request
    /// </summary>
    public async Task ConnectArticleCarnetRequests(
        CarnetRequestWhereUniqueInput uniqueId,
        ArticleCarnetRequestWhereUniqueInput[] articleCarnetRequestsId
    )
    {
        var parent = await _context
            .CarnetRequests.Include(x => x.ArticleCarnetRequests)
            .FirstOrDefaultAsync(x => x.Id == uniqueId.Id);
        if (parent == null)
        {
            throw new NotFoundException();
        }

        var articleCarnetRequests = await _context
            .ArticleCarnetRequests.Where(t =>
                articleCarnetRequestsId.Select(x => x.Id).Contains(t.Id)
            )
            .ToListAsync();
        if (articleCarnetRequests.Count == 0)
        {
            throw new NotFoundException();
        }

        var articleCarnetRequestsToConnect = articleCarnetRequests.Except(
            parent.ArticleCarnetRequests
        );

        foreach (var articleCarnetRequest in articleCarnetRequestsToConnect)
        {
            parent.ArticleCarnetRequests.Add(articleCarnetRequest);
        }

        await _context.SaveChangesAsync();
    }

    /// <summary>
    /// Disconnect multiple Article Carnet Requests records from Carnet Request
    /// </summary>
    public async Task DisconnectArticleCarnetRequests(
        CarnetRequestWhereUniqueInput uniqueId,
        ArticleCarnetRequestWhereUniqueInput[] articleCarnetRequestsId
    )
    {
        var parent = await _context
            .CarnetRequests.Include(x => x.ArticleCarnetRequests)
            .FirstOrDefaultAsync(x => x.Id == uniqueId.Id);
        if (parent == null)
        {
            throw new NotFoundException();
        }

        var articleCarnetRequests = await _context
            .ArticleCarnetRequests.Where(t =>
                articleCarnetRequestsId.Select(x => x.Id).Contains(t.Id)
            )
            .ToListAsync();

        foreach (var articleCarnetRequest in articleCarnetRequests)
        {
            parent.ArticleCarnetRequests?.Remove(articleCarnetRequest);
        }
        await _context.SaveChangesAsync();
    }

    /// <summary>
    /// Find multiple Article Carnet Requests records for Carnet Request
    /// </summary>
    public async Task<List<ArticleCarnetRequest>> FindArticleCarnetRequests(
        CarnetRequestWhereUniqueInput uniqueId,
        ArticleCarnetRequestFindManyArgs carnetRequestFindManyArgs
    )
    {
        var articleCarnetRequests = await _context
            .ArticleCarnetRequests.Where(m => m.CarnetRequestId == uniqueId.Id)
            .ApplyWhere(carnetRequestFindManyArgs.Where)
            .ApplySkip(carnetRequestFindManyArgs.Skip)
            .ApplyTake(carnetRequestFindManyArgs.Take)
            .ApplyOrderBy(carnetRequestFindManyArgs.SortBy)
            .ToListAsync();

        return articleCarnetRequests.Select(x => x.ToDto()).ToList();
    }

    /// <summary>
    /// Update multiple Article Carnet Requests records for Carnet Request
    /// </summary>
    public async Task UpdateArticleCarnetRequests(
        CarnetRequestWhereUniqueInput uniqueId,
        ArticleCarnetRequestWhereUniqueInput[] articleCarnetRequestsId
    )
    {
        var carnetRequest = await _context
            .CarnetRequests.Include(t => t.ArticleCarnetRequests)
            .FirstOrDefaultAsync(x => x.Id == uniqueId.Id);
        if (carnetRequest == null)
        {
            throw new NotFoundException();
        }

        var articleCarnetRequests = await _context
            .ArticleCarnetRequests.Where(a =>
                articleCarnetRequestsId.Select(x => x.Id).Contains(a.Id)
            )
            .ToListAsync();

        if (articleCarnetRequests.Count == 0)
        {
            throw new NotFoundException();
        }

        carnetRequest.ArticleCarnetRequests = articleCarnetRequests;
        await _context.SaveChangesAsync();
    }

    /// <summary>
    /// Get a Common Carnet Request record for Carnet Request
    /// </summary>
    public async Task<CommonCarnetRequest> GetCommonCarnetRequest(
        CarnetRequestWhereUniqueInput uniqueId
    )
    {
        var carnetRequest = await _context
            .CarnetRequests.Where(carnetRequest => carnetRequest.Id == uniqueId.Id)
            .Include(carnetRequest => carnetRequest.CommonCarnetRequest)
            .FirstOrDefaultAsync();
        if (carnetRequest == null)
        {
            throw new NotFoundException();
        }
        return carnetRequest.CommonCarnetRequest.ToDto();
    }

    /// <summary>
    /// Get a Extended Period Carnet Requests record for Carnet Request
    /// </summary>
    public async Task<ExtendedPeriodCarnetRequest> GetExtendedPeriodCarnetRequests(
        CarnetRequestWhereUniqueInput uniqueId
    )
    {
        var carnetRequest = await _context
            .CarnetRequests.Where(carnetRequest => carnetRequest.Id == uniqueId.Id)
            .Include(carnetRequest => carnetRequest.ExtendedPeriodCarnetRequests)
            .FirstOrDefaultAsync();
        if (carnetRequest == null)
        {
            throw new NotFoundException();
        }
        return carnetRequest.ExtendedPeriodCarnetRequests.ToDto();
    }

    /// <summary>
    /// Connect multiple Import Carnet Requests records to Carnet Request
    /// </summary>
    public async Task ConnectImportCarnetRequests(
        CarnetRequestWhereUniqueInput uniqueId,
        ImportCarnetRequestWhereUniqueInput[] importCarnetRequestsId
    )
    {
        var parent = await _context
            .CarnetRequests.Include(x => x.ImportCarnetRequests)
            .FirstOrDefaultAsync(x => x.Id == uniqueId.Id);
        if (parent == null)
        {
            throw new NotFoundException();
        }

        var importCarnetRequests = await _context
            .ImportCarnetRequests.Where(t =>
                importCarnetRequestsId.Select(x => x.Id).Contains(t.Id)
            )
            .ToListAsync();
        if (importCarnetRequests.Count == 0)
        {
            throw new NotFoundException();
        }

        var importCarnetRequestsToConnect = importCarnetRequests.Except(
            parent.ImportCarnetRequests
        );

        foreach (var importCarnetRequest in importCarnetRequestsToConnect)
        {
            parent.ImportCarnetRequests.Add(importCarnetRequest);
        }

        await _context.SaveChangesAsync();
    }

    /// <summary>
    /// Disconnect multiple Import Carnet Requests records from Carnet Request
    /// </summary>
    public async Task DisconnectImportCarnetRequests(
        CarnetRequestWhereUniqueInput uniqueId,
        ImportCarnetRequestWhereUniqueInput[] importCarnetRequestsId
    )
    {
        var parent = await _context
            .CarnetRequests.Include(x => x.ImportCarnetRequests)
            .FirstOrDefaultAsync(x => x.Id == uniqueId.Id);
        if (parent == null)
        {
            throw new NotFoundException();
        }

        var importCarnetRequests = await _context
            .ImportCarnetRequests.Where(t =>
                importCarnetRequestsId.Select(x => x.Id).Contains(t.Id)
            )
            .ToListAsync();

        foreach (var importCarnetRequest in importCarnetRequests)
        {
            parent.ImportCarnetRequests?.Remove(importCarnetRequest);
        }
        await _context.SaveChangesAsync();
    }

    /// <summary>
    /// Find multiple Import Carnet Requests records for Carnet Request
    /// </summary>
    public async Task<List<ImportCarnetRequest>> FindImportCarnetRequests(
        CarnetRequestWhereUniqueInput uniqueId,
        ImportCarnetRequestFindManyArgs carnetRequestFindManyArgs
    )
    {
        var importCarnetRequests = await _context
            .ImportCarnetRequests.Where(m => m.CarnetRequestId == uniqueId.Id)
            .ApplyWhere(carnetRequestFindManyArgs.Where)
            .ApplySkip(carnetRequestFindManyArgs.Skip)
            .ApplyTake(carnetRequestFindManyArgs.Take)
            .ApplyOrderBy(carnetRequestFindManyArgs.SortBy)
            .ToListAsync();

        return importCarnetRequests.Select(x => x.ToDto()).ToList();
    }

    /// <summary>
    /// Update multiple Import Carnet Requests records for Carnet Request
    /// </summary>
    public async Task UpdateImportCarnetRequests(
        CarnetRequestWhereUniqueInput uniqueId,
        ImportCarnetRequestWhereUniqueInput[] importCarnetRequestsId
    )
    {
        var carnetRequest = await _context
            .CarnetRequests.Include(t => t.ImportCarnetRequests)
            .FirstOrDefaultAsync(x => x.Id == uniqueId.Id);
        if (carnetRequest == null)
        {
            throw new NotFoundException();
        }

        var importCarnetRequests = await _context
            .ImportCarnetRequests.Where(a =>
                importCarnetRequestsId.Select(x => x.Id).Contains(a.Id)
            )
            .ToListAsync();

        if (importCarnetRequests.Count == 0)
        {
            throw new NotFoundException();
        }

        carnetRequest.ImportCarnetRequests = importCarnetRequests;
        await _context.SaveChangesAsync();
    }

    /// <summary>
    /// Connect multiple Reexport Carnet Requests records to Carnet Request
    /// </summary>
    public async Task ConnectReexportCarnetRequests(
        CarnetRequestWhereUniqueInput uniqueId,
        ReexportCarnetRequestWhereUniqueInput[] reexportCarnetRequestsId
    )
    {
        var parent = await _context
            .CarnetRequests.Include(x => x.ReexportCarnetRequests)
            .FirstOrDefaultAsync(x => x.Id == uniqueId.Id);
        if (parent == null)
        {
            throw new NotFoundException();
        }

        var reexportCarnetRequests = await _context
            .ReexportCarnetRequests.Where(t =>
                reexportCarnetRequestsId.Select(x => x.Id).Contains(t.Id)
            )
            .ToListAsync();
        if (reexportCarnetRequests.Count == 0)
        {
            throw new NotFoundException();
        }

        var reexportCarnetRequestsToConnect = reexportCarnetRequests.Except(
            parent.ReexportCarnetRequests
        );

        foreach (var reexportCarnetRequest in reexportCarnetRequestsToConnect)
        {
            parent.ReexportCarnetRequests.Add(reexportCarnetRequest);
        }

        await _context.SaveChangesAsync();
    }

    /// <summary>
    /// Disconnect multiple Reexport Carnet Requests records from Carnet Request
    /// </summary>
    public async Task DisconnectReexportCarnetRequests(
        CarnetRequestWhereUniqueInput uniqueId,
        ReexportCarnetRequestWhereUniqueInput[] reexportCarnetRequestsId
    )
    {
        var parent = await _context
            .CarnetRequests.Include(x => x.ReexportCarnetRequests)
            .FirstOrDefaultAsync(x => x.Id == uniqueId.Id);
        if (parent == null)
        {
            throw new NotFoundException();
        }

        var reexportCarnetRequests = await _context
            .ReexportCarnetRequests.Where(t =>
                reexportCarnetRequestsId.Select(x => x.Id).Contains(t.Id)
            )
            .ToListAsync();

        foreach (var reexportCarnetRequest in reexportCarnetRequests)
        {
            parent.ReexportCarnetRequests?.Remove(reexportCarnetRequest);
        }
        await _context.SaveChangesAsync();
    }

    /// <summary>
    /// Find multiple Reexport Carnet Requests records for Carnet Request
    /// </summary>
    public async Task<List<ReexportCarnetRequest>> FindReexportCarnetRequests(
        CarnetRequestWhereUniqueInput uniqueId,
        ReexportCarnetRequestFindManyArgs carnetRequestFindManyArgs
    )
    {
        var reexportCarnetRequests = await _context
            .ReexportCarnetRequests.Where(m => m.CarnetRequestId == uniqueId.Id)
            .ApplyWhere(carnetRequestFindManyArgs.Where)
            .ApplySkip(carnetRequestFindManyArgs.Skip)
            .ApplyTake(carnetRequestFindManyArgs.Take)
            .ApplyOrderBy(carnetRequestFindManyArgs.SortBy)
            .ToListAsync();

        return reexportCarnetRequests.Select(x => x.ToDto()).ToList();
    }

    /// <summary>
    /// Update multiple Reexport Carnet Requests records for Carnet Request
    /// </summary>
    public async Task UpdateReexportCarnetRequests(
        CarnetRequestWhereUniqueInput uniqueId,
        ReexportCarnetRequestWhereUniqueInput[] reexportCarnetRequestsId
    )
    {
        var carnetRequest = await _context
            .CarnetRequests.Include(t => t.ReexportCarnetRequests)
            .FirstOrDefaultAsync(x => x.Id == uniqueId.Id);
        if (carnetRequest == null)
        {
            throw new NotFoundException();
        }

        var reexportCarnetRequests = await _context
            .ReexportCarnetRequests.Where(a =>
                reexportCarnetRequestsId.Select(x => x.Id).Contains(a.Id)
            )
            .ToListAsync();

        if (reexportCarnetRequests.Count == 0)
        {
            throw new NotFoundException();
        }

        carnetRequest.ReexportCarnetRequests = reexportCarnetRequests;
        await _context.SaveChangesAsync();
    }

    /// <summary>
    /// Connect multiple Transit Carnet Requests records to Carnet Request
    /// </summary>
    public async Task ConnectTransitCarnetRequests(
        CarnetRequestWhereUniqueInput uniqueId,
        TransitCarnetRequestWhereUniqueInput[] transitCarnetRequestsId
    )
    {
        var parent = await _context
            .CarnetRequests.Include(x => x.TransitCarnetRequests)
            .FirstOrDefaultAsync(x => x.Id == uniqueId.Id);
        if (parent == null)
        {
            throw new NotFoundException();
        }

        var transitCarnetRequests = await _context
            .TransitCarnetRequests.Where(t =>
                transitCarnetRequestsId.Select(x => x.Id).Contains(t.Id)
            )
            .ToListAsync();
        if (transitCarnetRequests.Count == 0)
        {
            throw new NotFoundException();
        }

        var transitCarnetRequestsToConnect = transitCarnetRequests.Except(
            parent.TransitCarnetRequests
        );

        foreach (var transitCarnetRequest in transitCarnetRequestsToConnect)
        {
            parent.TransitCarnetRequests.Add(transitCarnetRequest);
        }

        await _context.SaveChangesAsync();
    }

    /// <summary>
    /// Disconnect multiple Transit Carnet Requests records from Carnet Request
    /// </summary>
    public async Task DisconnectTransitCarnetRequests(
        CarnetRequestWhereUniqueInput uniqueId,
        TransitCarnetRequestWhereUniqueInput[] transitCarnetRequestsId
    )
    {
        var parent = await _context
            .CarnetRequests.Include(x => x.TransitCarnetRequests)
            .FirstOrDefaultAsync(x => x.Id == uniqueId.Id);
        if (parent == null)
        {
            throw new NotFoundException();
        }

        var transitCarnetRequests = await _context
            .TransitCarnetRequests.Where(t =>
                transitCarnetRequestsId.Select(x => x.Id).Contains(t.Id)
            )
            .ToListAsync();

        foreach (var transitCarnetRequest in transitCarnetRequests)
        {
            parent.TransitCarnetRequests?.Remove(transitCarnetRequest);
        }
        await _context.SaveChangesAsync();
    }

    /// <summary>
    /// Find multiple Transit Carnet Requests records for Carnet Request
    /// </summary>
    public async Task<List<TransitCarnetRequest>> FindTransitCarnetRequests(
        CarnetRequestWhereUniqueInput uniqueId,
        TransitCarnetRequestFindManyArgs carnetRequestFindManyArgs
    )
    {
        var transitCarnetRequests = await _context
            .TransitCarnetRequests.Where(m => m.CarnetRequestId == uniqueId.Id)
            .ApplyWhere(carnetRequestFindManyArgs.Where)
            .ApplySkip(carnetRequestFindManyArgs.Skip)
            .ApplyTake(carnetRequestFindManyArgs.Take)
            .ApplyOrderBy(carnetRequestFindManyArgs.SortBy)
            .ToListAsync();

        return transitCarnetRequests.Select(x => x.ToDto()).ToList();
    }

    /// <summary>
    /// Update multiple Transit Carnet Requests records for Carnet Request
    /// </summary>
    public async Task UpdateTransitCarnetRequests(
        CarnetRequestWhereUniqueInput uniqueId,
        TransitCarnetRequestWhereUniqueInput[] transitCarnetRequestsId
    )
    {
        var carnetRequest = await _context
            .CarnetRequests.Include(t => t.TransitCarnetRequests)
            .FirstOrDefaultAsync(x => x.Id == uniqueId.Id);
        if (carnetRequest == null)
        {
            throw new NotFoundException();
        }

        var transitCarnetRequests = await _context
            .TransitCarnetRequests.Where(a =>
                transitCarnetRequestsId.Select(x => x.Id).Contains(a.Id)
            )
            .ToListAsync();

        if (transitCarnetRequests.Count == 0)
        {
            throw new NotFoundException();
        }

        carnetRequest.TransitCarnetRequests = transitCarnetRequests;
        await _context.SaveChangesAsync();
    }
}
