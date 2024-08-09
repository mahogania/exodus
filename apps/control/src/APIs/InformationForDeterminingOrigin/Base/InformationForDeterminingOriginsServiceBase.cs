using Control.APIs;
using Control.APIs.Common;
using Control.APIs.Dtos;
using Control.APIs.Errors;
using Control.APIs.Extensions;
using Control.Infrastructure;
using Control.Infrastructure.Models;
using Microsoft.EntityFrameworkCore;

namespace Control.APIs;

public abstract class InformationForDeterminingOriginsServiceBase
    : IInformationForDeterminingOriginsService
{
    protected readonly ControlDbContext _context;

    public InformationForDeterminingOriginsServiceBase(ControlDbContext context)
    {
        _context = context;
    }

    /// <summary>
    /// Create one INFORMATION FOR DETERMINING ORIGIN
    /// </summary>
    public async Task<InformationForDeterminingOrigin> CreateInformationForDeterminingOrigin(
        InformationForDeterminingOriginCreateInput createDto
    )
    {
        var informationForDeterminingOrigin = new InformationForDeterminingOriginDbModel
        {
            Amount = createDto.Amount,
            CountryOfOriginCode = createDto.CountryOfOriginCode,
            CreatedAt = createDto.CreatedAt,
            DeletionOn = createDto.DeletionOn,
            FinalModificationDateAndTime = createDto.FinalModificationDateAndTime,
            FinalModifierSId = createDto.FinalModifierSId,
            FirstRecorderSId = createDto.FirstRecorderSId,
            FirstRegistrationDateAndTime = createDto.FirstRegistrationDateAndTime,
            NameOfMaterialsUsed = createDto.NameOfMaterialsUsed,
            OriginDeterminationSeriesNumber = createDto.OriginDeterminationSeriesNumber,
            RcoRequestNumber = createDto.RcoRequestNumber,
            RectificationFrequency = createDto.RectificationFrequency,
            ShCode = createDto.ShCode,
            UpdatedAt = createDto.UpdatedAt,
            Weight = createDto.Weight
        };

        if (createDto.Id != null)
        {
            informationForDeterminingOrigin.Id = createDto.Id;
        }

        _context.InformationForDeterminingOrigins.Add(informationForDeterminingOrigin);
        await _context.SaveChangesAsync();

        var result = await _context.FindAsync<InformationForDeterminingOriginDbModel>(
            informationForDeterminingOrigin.Id
        );

        if (result == null)
        {
            throw new NotFoundException();
        }

        return result.ToDto();
    }

    /// <summary>
    /// Delete one INFORMATION FOR DETERMINING ORIGIN
    /// </summary>
    public async Task DeleteInformationForDeterminingOrigin(
        InformationForDeterminingOriginWhereUniqueInput uniqueId
    )
    {
        var informationForDeterminingOrigin =
            await _context.InformationForDeterminingOrigins.FindAsync(uniqueId.Id);
        if (informationForDeterminingOrigin == null)
        {
            throw new NotFoundException();
        }

        _context.InformationForDeterminingOrigins.Remove(informationForDeterminingOrigin);
        await _context.SaveChangesAsync();
    }

    /// <summary>
    /// Find many INFORMATION FOR DETERMINING ORIGIN | CLRES
    /// </summary>
    public async Task<List<InformationForDeterminingOrigin>> InformationForDeterminingOrigins(
        InformationForDeterminingOriginFindManyArgs findManyArgs
    )
    {
        var informationForDeterminingOrigins = await _context
            .InformationForDeterminingOrigins.ApplyWhere(findManyArgs.Where)
            .ApplySkip(findManyArgs.Skip)
            .ApplyTake(findManyArgs.Take)
            .ApplyOrderBy(findManyArgs.SortBy)
            .ToListAsync();
        return informationForDeterminingOrigins.ConvertAll(informationForDeterminingOrigin =>
            informationForDeterminingOrigin.ToDto()
        );
    }

    /// <summary>
    /// Meta data about INFORMATION FOR DETERMINING ORIGIN records
    /// </summary>
    public async Task<MetadataDto> InformationForDeterminingOriginsMeta(
        InformationForDeterminingOriginFindManyArgs findManyArgs
    )
    {
        var count = await _context
            .InformationForDeterminingOrigins.ApplyWhere(findManyArgs.Where)
            .CountAsync();

        return new MetadataDto { Count = count };
    }

    /// <summary>
    /// Get one INFORMATION FOR DETERMINING ORIGIN
    /// </summary>
    public async Task<InformationForDeterminingOrigin> InformationForDeterminingOrigin(
        InformationForDeterminingOriginWhereUniqueInput uniqueId
    )
    {
        var informationForDeterminingOrigins = await this.InformationForDeterminingOrigins(
            new InformationForDeterminingOriginFindManyArgs
            {
                Where = new InformationForDeterminingOriginWhereInput { Id = uniqueId.Id }
            }
        );
        var informationForDeterminingOrigin = informationForDeterminingOrigins.FirstOrDefault();
        if (informationForDeterminingOrigin == null)
        {
            throw new NotFoundException();
        }

        return informationForDeterminingOrigin;
    }

    /// <summary>
    /// Update one INFORMATION FOR DETERMINING ORIGIN
    /// </summary>
    public async Task UpdateInformationForDeterminingOrigin(
        InformationForDeterminingOriginWhereUniqueInput uniqueId,
        InformationForDeterminingOriginUpdateInput updateDto
    )
    {
        var informationForDeterminingOrigin = updateDto.ToModel(uniqueId);

        _context.Entry(informationForDeterminingOrigin).State = EntityState.Modified;

        try
        {
            await _context.SaveChangesAsync();
        }
        catch (DbUpdateConcurrencyException)
        {
            if (
                !_context.InformationForDeterminingOrigins.Any(e =>
                    e.Id == informationForDeterminingOrigin.Id
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
