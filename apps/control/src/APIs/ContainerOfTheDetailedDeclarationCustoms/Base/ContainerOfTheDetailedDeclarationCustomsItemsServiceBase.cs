using Clre.APIs;
using Clre.APIs.Common;
using Clre.APIs.Dtos;
using Clre.APIs.Errors;
using Clre.APIs.Extensions;
using Clre.Infrastructure;
using Clre.Infrastructure.Models;
using Microsoft.EntityFrameworkCore;

namespace Clre.APIs;

public abstract class ContainerOfTheDetailedDeclarationCustomsItemsServiceBase
    : IContainerOfTheDetailedDeclarationCustomsItemsService
{
    protected readonly ClreDbContext _context;

    public ContainerOfTheDetailedDeclarationCustomsItemsServiceBase(ClreDbContext context)
    {
        _context = context;
    }

    /// <summary>
    /// Create one CONTAINER OF THE DETAILED DECLARATION (CUSTOMS)
    /// </summary>
    public async Task<ContainerOfTheDetailedDeclarationCustoms> CreateContainerOfTheDetailedDeclarationCustoms(
        ContainerOfTheDetailedDeclarationCustomsCreateInput createDto
    )
    {
        var containerOfTheDetailedDeclarationCustoms =
            new ContainerOfTheDetailedDeclarationCustomsDbModel
            {
                ContainerNumber = createDto.ContainerNumber,
                ContainerPackingStateCode = createDto.ContainerPackingStateCode,
                ContainerSequenceNumber = createDto.ContainerSequenceNumber,
                ContainerTypeCode = createDto.ContainerTypeCode,
                CreatedAt = createDto.CreatedAt,
                DateAndTimeOfFinalModification = createDto.DateAndTimeOfFinalModification,
                DateAndTimeOfFirstRegistration = createDto.DateAndTimeOfFirstRegistration,
                FinalModifierSId = createDto.FinalModifierSId,
                FirstRegistrantSId = createDto.FirstRegistrantSId,
                GoodsVerified = createDto.GoodsVerified,
                RectificationFrequency = createDto.RectificationFrequency,
                ReferenceNumber = createDto.ReferenceNumber,
                SealNumber_1 = createDto.SealNumber_1,
                SealNumber_2 = createDto.SealNumber_2,
                SealNumber_3 = createDto.SealNumber_3,
                Sealer_1 = createDto.Sealer_1,
                Sealer_2 = createDto.Sealer_2,
                Sealer_3 = createDto.Sealer_3,
                SealingPersonCode = createDto.SealingPersonCode,
                SuppressionOn = createDto.SuppressionOn,
                UpdatedAt = createDto.UpdatedAt
            };

        if (createDto.Id != null)
        {
            containerOfTheDetailedDeclarationCustoms.Id = createDto.Id;
        }

        _context.ContainerOfTheDetailedDeclarationCustomsItems.Add(
            containerOfTheDetailedDeclarationCustoms
        );
        await _context.SaveChangesAsync();

        var result = await _context.FindAsync<ContainerOfTheDetailedDeclarationCustomsDbModel>(
            containerOfTheDetailedDeclarationCustoms.Id
        );

        if (result == null)
        {
            throw new NotFoundException();
        }

        return result.ToDto();
    }

    /// <summary>
    /// Delete one CONTAINER OF THE DETAILED DECLARATION (CUSTOMS)
    /// </summary>
    public async Task DeleteContainerOfTheDetailedDeclarationCustoms(
        ContainerOfTheDetailedDeclarationCustomsWhereUniqueInput uniqueId
    )
    {
        var containerOfTheDetailedDeclarationCustoms =
            await _context.ContainerOfTheDetailedDeclarationCustomsItems.FindAsync(uniqueId.Id);
        if (containerOfTheDetailedDeclarationCustoms == null)
        {
            throw new NotFoundException();
        }

        _context.ContainerOfTheDetailedDeclarationCustomsItems.Remove(
            containerOfTheDetailedDeclarationCustoms
        );
        await _context.SaveChangesAsync();
    }

    /// <summary>
    /// Find many CONTAINER OF THE DETAILED DECLARATION (CUSTOMS)s
    /// </summary>
    public async Task<
        List<ContainerOfTheDetailedDeclarationCustoms>
    > ContainerOfTheDetailedDeclarationCustomsItems(
        ContainerOfTheDetailedDeclarationCustomsFindManyArgs findManyArgs
    )
    {
        var containerOfTheDetailedDeclarationCustomsItems = await _context
            .ContainerOfTheDetailedDeclarationCustomsItems.ApplyWhere(findManyArgs.Where)
            .ApplySkip(findManyArgs.Skip)
            .ApplyTake(findManyArgs.Take)
            .ApplyOrderBy(findManyArgs.SortBy)
            .ToListAsync();
        return containerOfTheDetailedDeclarationCustomsItems.ConvertAll(
            containerOfTheDetailedDeclarationCustoms =>
                containerOfTheDetailedDeclarationCustoms.ToDto()
        );
    }

    /// <summary>
    /// Meta data about CONTAINER OF THE DETAILED DECLARATION (CUSTOMS) records
    /// </summary>
    public async Task<MetadataDto> ContainerOfTheDetailedDeclarationCustomsItemsMeta(
        ContainerOfTheDetailedDeclarationCustomsFindManyArgs findManyArgs
    )
    {
        var count = await _context
            .ContainerOfTheDetailedDeclarationCustomsItems.ApplyWhere(findManyArgs.Where)
            .CountAsync();

        return new MetadataDto { Count = count };
    }

    /// <summary>
    /// Get one CONTAINER OF THE DETAILED DECLARATION (CUSTOMS)
    /// </summary>
    public async Task<ContainerOfTheDetailedDeclarationCustoms> ContainerOfTheDetailedDeclarationCustoms(
        ContainerOfTheDetailedDeclarationCustomsWhereUniqueInput uniqueId
    )
    {
        var containerOfTheDetailedDeclarationCustomsItems =
            await this.ContainerOfTheDetailedDeclarationCustomsItems(
                new ContainerOfTheDetailedDeclarationCustomsFindManyArgs
                {
                    Where = new ContainerOfTheDetailedDeclarationCustomsWhereInput
                    {
                        Id = uniqueId.Id
                    }
                }
            );
        var containerOfTheDetailedDeclarationCustoms =
            containerOfTheDetailedDeclarationCustomsItems.FirstOrDefault();
        if (containerOfTheDetailedDeclarationCustoms == null)
        {
            throw new NotFoundException();
        }

        return containerOfTheDetailedDeclarationCustoms;
    }

    /// <summary>
    /// Update one CONTAINER OF THE DETAILED DECLARATION (CUSTOMS)
    /// </summary>
    public async Task UpdateContainerOfTheDetailedDeclarationCustoms(
        ContainerOfTheDetailedDeclarationCustomsWhereUniqueInput uniqueId,
        ContainerOfTheDetailedDeclarationCustomsUpdateInput updateDto
    )
    {
        var containerOfTheDetailedDeclarationCustoms = updateDto.ToModel(uniqueId);

        _context.Entry(containerOfTheDetailedDeclarationCustoms).State = EntityState.Modified;

        try
        {
            await _context.SaveChangesAsync();
        }
        catch (DbUpdateConcurrencyException)
        {
            if (
                !_context.ContainerOfTheDetailedDeclarationCustomsItems.Any(e =>
                    e.Id == containerOfTheDetailedDeclarationCustoms.Id
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
