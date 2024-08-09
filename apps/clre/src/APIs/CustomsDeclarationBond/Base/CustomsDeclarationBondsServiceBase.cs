using Clre.APIs;
using Clre.APIs.Common;
using Clre.APIs.Dtos;
using Clre.APIs.Errors;
using Clre.APIs.Extensions;
using Clre.Infrastructure;
using Clre.Infrastructure.Models;
using Microsoft.EntityFrameworkCore;

namespace Clre.APIs;

public abstract class CustomsDeclarationBondsServiceBase : ICustomsDeclarationBondsService
{
    protected readonly ClreDbContext _context;

    public CustomsDeclarationBondsServiceBase(ClreDbContext context)
    {
        _context = context;
    }

    /// <summary>
    /// Create one CUSTOMS DECLARATION BOND
    /// </summary>
    public async Task<CustomsDeclarationBond> CreateCustomsDeclarationBond(
        CustomsDeclarationBondCreateInput createDto
    )
    {
        var customsDeclarationBond = new CustomsDeclarationBondDbModel
        {
            BondAccountNumber = createDto.BondAccountNumber,
            CreatedAt = createDto.CreatedAt,
            DateAndTimeOfFinalModification = createDto.DateAndTimeOfFinalModification,
            DateAndTimeOfFirstRegistration = createDto.DateAndTimeOfFirstRegistration,
            FinalModifierSId = createDto.FinalModifierSId,
            FirstRecorderSId = createDto.FirstRecorderSId,
            RectificationFrequency = createDto.RectificationFrequency,
            ReferenceNumber = createDto.ReferenceNumber,
            SuppressionOn = createDto.SuppressionOn,
            TypeOfBondCode = createDto.TypeOfBondCode,
            UpdatedAt = createDto.UpdatedAt
        };

        if (createDto.Id != null)
        {
            customsDeclarationBond.Id = createDto.Id;
        }

        _context.CustomsDeclarationBonds.Add(customsDeclarationBond);
        await _context.SaveChangesAsync();

        var result = await _context.FindAsync<CustomsDeclarationBondDbModel>(
            customsDeclarationBond.Id
        );

        if (result == null)
        {
            throw new NotFoundException();
        }

        return result.ToDto();
    }

    /// <summary>
    /// Delete one CUSTOMS DECLARATION BOND
    /// </summary>
    public async Task DeleteCustomsDeclarationBond(CustomsDeclarationBondWhereUniqueInput uniqueId)
    {
        var customsDeclarationBond = await _context.CustomsDeclarationBonds.FindAsync(uniqueId.Id);
        if (customsDeclarationBond == null)
        {
            throw new NotFoundException();
        }

        _context.CustomsDeclarationBonds.Remove(customsDeclarationBond);
        await _context.SaveChangesAsync();
    }

    /// <summary>
    /// Find many CUSTOMS DECLARATION BONDS
    /// </summary>
    public async Task<List<CustomsDeclarationBond>> CustomsDeclarationBonds(
        CustomsDeclarationBondFindManyArgs findManyArgs
    )
    {
        var customsDeclarationBonds = await _context
            .CustomsDeclarationBonds.ApplyWhere(findManyArgs.Where)
            .ApplySkip(findManyArgs.Skip)
            .ApplyTake(findManyArgs.Take)
            .ApplyOrderBy(findManyArgs.SortBy)
            .ToListAsync();
        return customsDeclarationBonds.ConvertAll(customsDeclarationBond =>
            customsDeclarationBond.ToDto()
        );
    }

    /// <summary>
    /// Meta data about CUSTOMS DECLARATION BOND records
    /// </summary>
    public async Task<MetadataDto> CustomsDeclarationBondsMeta(
        CustomsDeclarationBondFindManyArgs findManyArgs
    )
    {
        var count = await _context
            .CustomsDeclarationBonds.ApplyWhere(findManyArgs.Where)
            .CountAsync();

        return new MetadataDto { Count = count };
    }

    /// <summary>
    /// Get one CUSTOMS DECLARATION BOND
    /// </summary>
    public async Task<CustomsDeclarationBond> CustomsDeclarationBond(
        CustomsDeclarationBondWhereUniqueInput uniqueId
    )
    {
        var customsDeclarationBonds = await this.CustomsDeclarationBonds(
            new CustomsDeclarationBondFindManyArgs
            {
                Where = new CustomsDeclarationBondWhereInput { Id = uniqueId.Id }
            }
        );
        var customsDeclarationBond = customsDeclarationBonds.FirstOrDefault();
        if (customsDeclarationBond == null)
        {
            throw new NotFoundException();
        }

        return customsDeclarationBond;
    }

    /// <summary>
    /// Update one CUSTOMS DECLARATION BOND
    /// </summary>
    public async Task UpdateCustomsDeclarationBond(
        CustomsDeclarationBondWhereUniqueInput uniqueId,
        CustomsDeclarationBondUpdateInput updateDto
    )
    {
        var customsDeclarationBond = updateDto.ToModel(uniqueId);

        _context.Entry(customsDeclarationBond).State = EntityState.Modified;

        try
        {
            await _context.SaveChangesAsync();
        }
        catch (DbUpdateConcurrencyException)
        {
            if (!_context.CustomsDeclarationBonds.Any(e => e.Id == customsDeclarationBond.Id))
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
