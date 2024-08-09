using Control.APIs;
using Control.APIs.Common;
using Control.APIs.Dtos;
using Control.APIs.Errors;
using Control.APIs.Extensions;
using Control.Infrastructure;
using Control.Infrastructure.Models;
using Microsoft.EntityFrameworkCore;

namespace Control.APIs;

public abstract class RequestForCancellationOfTheDetailedDeclarationCustomsItemsServiceBase
    : IRequestForCancellationOfTheDetailedDeclarationCustomsItemsService
{
    protected readonly ControlDbContext _context;

    public RequestForCancellationOfTheDetailedDeclarationCustomsItemsServiceBase(
        ControlDbContext context
    )
    {
        _context = context;
    }

    /// <summary>
    /// Create one REQUEST FOR CANCELLATION OF THE DETAILED DECLARATION (CUSTOMS)
    /// </summary>
    public async Task<RequestForCancellationOfTheDetailedDeclarationCustoms> CreateRequestForCancellationOfTheDetailedDeclarationCustoms(
        RequestForCancellationOfTheDetailedDeclarationCustomsCreateInput createDto
    )
    {
        var requestForCancellationOfTheDetailedDeclarationCustoms =
            new RequestForCancellationOfTheDetailedDeclarationCustomsDbModel
            {
                CancellationContent = createDto.CancellationContent,
                CancellationReasonCode = createDto.CancellationReasonCode,
                CreatedAt = createDto.CreatedAt,
                DateAndTimeOfFinalModification = createDto.DateAndTimeOfFinalModification,
                DateAndTimeOfFirstRegistration = createDto.DateAndTimeOfFirstRegistration,
                DateOfRequestForCancellation = createDto.DateOfRequestForCancellation,
                FinalOn = createDto.FinalOn,
                FirstRegistrantSId = createDto.FirstRegistrantSId,
                IdOfTheAttachedFile = createDto.IdOfTheAttachedFile,
                NumberOfCancellations = createDto.NumberOfCancellations,
                ProcessingStatusCode = createDto.ProcessingStatusCode,
                ReferenceNumber = createDto.ReferenceNumber,
                SuppressionOn = createDto.SuppressionOn,
                UpdatedAt = createDto.UpdatedAt
            };

        if (createDto.Id != null)
        {
            requestForCancellationOfTheDetailedDeclarationCustoms.Id = createDto.Id;
        }

        _context.RequestForCancellationOfTheDetailedDeclarationCustomsItems.Add(
            requestForCancellationOfTheDetailedDeclarationCustoms
        );
        await _context.SaveChangesAsync();

        var result =
            await _context.FindAsync<RequestForCancellationOfTheDetailedDeclarationCustomsDbModel>(
                requestForCancellationOfTheDetailedDeclarationCustoms.Id
            );

        if (result == null)
        {
            throw new NotFoundException();
        }

        return result.ToDto();
    }

    /// <summary>
    /// Delete one REQUEST FOR CANCELLATION OF THE DETAILED DECLARATION (CUSTOMS)
    /// </summary>
    public async Task DeleteRequestForCancellationOfTheDetailedDeclarationCustoms(
        RequestForCancellationOfTheDetailedDeclarationCustomsWhereUniqueInput uniqueId
    )
    {
        var requestForCancellationOfTheDetailedDeclarationCustoms =
            await _context.RequestForCancellationOfTheDetailedDeclarationCustomsItems.FindAsync(
                uniqueId.Id
            );
        if (requestForCancellationOfTheDetailedDeclarationCustoms == null)
        {
            throw new NotFoundException();
        }

        _context.RequestForCancellationOfTheDetailedDeclarationCustomsItems.Remove(
            requestForCancellationOfTheDetailedDeclarationCustoms
        );
        await _context.SaveChangesAsync();
    }

    /// <summary>
    /// Find many REQUEST FOR CANCELLATION OF THE DETAILED DECLARATION (CUSTOMS)s
    /// </summary>
    public async Task<
        List<RequestForCancellationOfTheDetailedDeclarationCustoms>
    > RequestForCancellationOfTheDetailedDeclarationCustomsItems(
        RequestForCancellationOfTheDetailedDeclarationCustomsFindManyArgs findManyArgs
    )
    {
        var requestForCancellationOfTheDetailedDeclarationCustomsItems = await _context
            .RequestForCancellationOfTheDetailedDeclarationCustomsItems.ApplyWhere(
                findManyArgs.Where
            )
            .ApplySkip(findManyArgs.Skip)
            .ApplyTake(findManyArgs.Take)
            .ApplyOrderBy(findManyArgs.SortBy)
            .ToListAsync();
        return requestForCancellationOfTheDetailedDeclarationCustomsItems.ConvertAll(
            requestForCancellationOfTheDetailedDeclarationCustoms =>
                requestForCancellationOfTheDetailedDeclarationCustoms.ToDto()
        );
    }

    /// <summary>
    /// Meta data about REQUEST FOR CANCELLATION OF THE DETAILED DECLARATION (CUSTOMS) records
    /// </summary>
    public async Task<MetadataDto> RequestForCancellationOfTheDetailedDeclarationCustomsItemsMeta(
        RequestForCancellationOfTheDetailedDeclarationCustomsFindManyArgs findManyArgs
    )
    {
        var count = await _context
            .RequestForCancellationOfTheDetailedDeclarationCustomsItems.ApplyWhere(
                findManyArgs.Where
            )
            .CountAsync();

        return new MetadataDto { Count = count };
    }

    /// <summary>
    /// Get one REQUEST FOR CANCELLATION OF THE DETAILED DECLARATION (CUSTOMS)
    /// </summary>
    public async Task<RequestForCancellationOfTheDetailedDeclarationCustoms> RequestForCancellationOfTheDetailedDeclarationCustoms(
        RequestForCancellationOfTheDetailedDeclarationCustomsWhereUniqueInput uniqueId
    )
    {
        var requestForCancellationOfTheDetailedDeclarationCustomsItems =
            await this.RequestForCancellationOfTheDetailedDeclarationCustomsItems(
                new RequestForCancellationOfTheDetailedDeclarationCustomsFindManyArgs
                {
                    Where = new RequestForCancellationOfTheDetailedDeclarationCustomsWhereInput
                    {
                        Id = uniqueId.Id
                    }
                }
            );
        var requestForCancellationOfTheDetailedDeclarationCustoms =
            requestForCancellationOfTheDetailedDeclarationCustomsItems.FirstOrDefault();
        if (requestForCancellationOfTheDetailedDeclarationCustoms == null)
        {
            throw new NotFoundException();
        }

        return requestForCancellationOfTheDetailedDeclarationCustoms;
    }

    /// <summary>
    /// Update one REQUEST FOR CANCELLATION OF THE DETAILED DECLARATION (CUSTOMS)
    /// </summary>
    public async Task UpdateRequestForCancellationOfTheDetailedDeclarationCustoms(
        RequestForCancellationOfTheDetailedDeclarationCustomsWhereUniqueInput uniqueId,
        RequestForCancellationOfTheDetailedDeclarationCustomsUpdateInput updateDto
    )
    {
        var requestForCancellationOfTheDetailedDeclarationCustoms = updateDto.ToModel(uniqueId);

        _context.Entry(requestForCancellationOfTheDetailedDeclarationCustoms).State =
            EntityState.Modified;

        try
        {
            await _context.SaveChangesAsync();
        }
        catch (DbUpdateConcurrencyException)
        {
            if (
                !_context.RequestForCancellationOfTheDetailedDeclarationCustomsItems.Any(e =>
                    e.Id == requestForCancellationOfTheDetailedDeclarationCustoms.Id
                )
            )
            {
                throw new NotFoundException();
            }
            else
            {
                throw;
            }
        }
    }
}
