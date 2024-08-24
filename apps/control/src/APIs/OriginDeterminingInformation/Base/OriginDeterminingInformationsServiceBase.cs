using Control.APIs;
using Control.APIs.Common;
using Control.APIs.Dtos;
using Control.APIs.Errors;
using Control.APIs.Extensions;
using Control.Infrastructure;
using Control.Infrastructure.Models;
using Microsoft.EntityFrameworkCore;

namespace Control.APIs;

public abstract class OriginDeterminingInformationsServiceBase
    : IOriginDeterminingInformationsService
{
    protected readonly ControlDbContext _context;

    public OriginDeterminingInformationsServiceBase(ControlDbContext context)
    {
        _context = context;
    }

    /// <summary>
    /// Create one Origin Determining Information
    /// </summary>
    public async Task<OriginDeterminingInformation> CreateOriginDeterminingInformation(
        OriginDeterminingInformationCreateInput createDto
    )
    {
        var originDeterminingInformation = new OriginDeterminingInformationDbModel
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
            originDeterminingInformation.Id = createDto.Id;
        }

        _context.OriginDeterminingInformations.Add(originDeterminingInformation);
        await _context.SaveChangesAsync();

        var result = await _context.FindAsync<OriginDeterminingInformationDbModel>(
            originDeterminingInformation.Id
        );

        if (result == null)
        {
            throw new NotFoundException();
        }

        return result.ToDto();
    }

    /// <summary>
    /// Delete one Origin Determining Information
    /// </summary>
    public async Task DeleteOriginDeterminingInformation(
        OriginDeterminingInformationWhereUniqueInput uniqueId
    )
    {
        var originDeterminingInformation = await _context.OriginDeterminingInformations.FindAsync(
            uniqueId.Id
        );
        if (originDeterminingInformation == null)
        {
            throw new NotFoundException();
        }

        _context.OriginDeterminingInformations.Remove(originDeterminingInformation);
        await _context.SaveChangesAsync();
    }

    /// <summary>
    /// Find many INFORMATIONS FOR DETERMINING ORIGIN
    /// </summary>
    public async Task<List<OriginDeterminingInformation>> OriginDeterminingInformations(
        OriginDeterminingInformationFindManyArgs findManyArgs
    )
    {
        var originDeterminingInformations = await _context
            .OriginDeterminingInformations.ApplyWhere(findManyArgs.Where)
            .ApplySkip(findManyArgs.Skip)
            .ApplyTake(findManyArgs.Take)
            .ApplyOrderBy(findManyArgs.SortBy)
            .ToListAsync();
        return originDeterminingInformations.ConvertAll(originDeterminingInformation =>
            originDeterminingInformation.ToDto()
        );
    }

    /// <summary>
    /// Meta data about Origin Determining Information records
    /// </summary>
    public async Task<MetadataDto> OriginDeterminingInformationsMeta(
        OriginDeterminingInformationFindManyArgs findManyArgs
    )
    {
        var count = await _context
            .OriginDeterminingInformations.ApplyWhere(findManyArgs.Where)
            .CountAsync();

        return new MetadataDto { Count = count };
    }

    /// <summary>
    /// Get one Origin Determining Information
    /// </summary>
    public async Task<OriginDeterminingInformation> OriginDeterminingInformation(
        OriginDeterminingInformationWhereUniqueInput uniqueId
    )
    {
        var originDeterminingInformations = await this.OriginDeterminingInformations(
            new OriginDeterminingInformationFindManyArgs
            {
                Where = new OriginDeterminingInformationWhereInput { Id = uniqueId.Id }
            }
        );
        var originDeterminingInformation = originDeterminingInformations.FirstOrDefault();
        if (originDeterminingInformation == null)
        {
            throw new NotFoundException();
        }

        return originDeterminingInformation;
    }

    /// <summary>
    /// Update one Origin Determining Information
    /// </summary>
    public async Task UpdateOriginDeterminingInformation(
        OriginDeterminingInformationWhereUniqueInput uniqueId,
        OriginDeterminingInformationUpdateInput updateDto
    )
    {
        var originDeterminingInformation = updateDto.ToModel(uniqueId);

        _context.Entry(originDeterminingInformation).State = EntityState.Modified;

        try
        {
            await _context.SaveChangesAsync();
        }
        catch (DbUpdateConcurrencyException)
        {
            if (
                !_context.OriginDeterminingInformations.Any(e =>
                    e.Id == originDeterminingInformation.Id
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
