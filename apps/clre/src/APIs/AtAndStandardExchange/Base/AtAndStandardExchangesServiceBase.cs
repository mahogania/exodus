using Clre.APIs;
using Clre.APIs.Common;
using Clre.APIs.Dtos;
using Clre.APIs.Errors;
using Clre.APIs.Extensions;
using Clre.Infrastructure;
using Clre.Infrastructure.Models;
using Microsoft.EntityFrameworkCore;

namespace Clre.APIs;

public abstract class AtAndStandardExchangesServiceBase : IAtAndStandardExchangesService
{
    protected readonly ClreDbContext _context;

    public AtAndStandardExchangesServiceBase(ClreDbContext context)
    {
        _context = context;
    }

    /// <summary>
    /// Create one AT? AND STANDARD EXCHANGE
    /// </summary>
    public async Task<AtAndStandardExchange> CreateAtAndStandardExchange(
        AtAndStandardExchangeCreateInput createDto
    )
    {
        var atAndStandardExchange = new AtAndStandardExchangeDbModel
        {
            CreatedAt = createDto.CreatedAt,
            CustomsClearanceOfficeForAtEt = createDto.CustomsClearanceOfficeForAtEt,
            DateAndTimeOfFinalModification = createDto.DateAndTimeOfFinalModification,
            DateAndTimeOfFirstRegistration = createDto.DateAndTimeOfFirstRegistration,
            DateOfTheImportationDeclaration = createDto.DateOfTheImportationDeclaration,
            DeclarationNumber = createDto.DeclarationNumber,
            FinalModifierSId = createDto.FinalModifierSId,
            FirstRegistrantSId = createDto.FirstRegistrantSId,
            ImportationDeclarationCode = createDto.ImportationDeclarationCode,
            ReasonForTheRequest = createDto.ReasonForTheRequest,
            RectificationFrequency = createDto.RectificationFrequency,
            RegimeRequestNumber = createDto.RegimeRequestNumber,
            RequestStatus = createDto.RequestStatus,
            RequestedEndDate = createDto.RequestedEndDate,
            RequestedStartDate = createDto.RequestedStartDate,
            SuppressionOn = createDto.SuppressionOn,
            UpdatedAt = createDto.UpdatedAt,
            WarrantyEndDate = createDto.WarrantyEndDate,
            WarrantyFrame = createDto.WarrantyFrame
        };

        if (createDto.Id != null)
        {
            atAndStandardExchange.Id = createDto.Id;
        }

        _context.AtAndStandardExchanges.Add(atAndStandardExchange);
        await _context.SaveChangesAsync();

        var result = await _context.FindAsync<AtAndStandardExchangeDbModel>(
            atAndStandardExchange.Id
        );

        if (result == null)
        {
            throw new NotFoundException();
        }

        return result.ToDto();
    }

    /// <summary>
    /// Delete one AT? AND STANDARD EXCHANGE
    /// </summary>
    public async Task DeleteAtAndStandardExchange(AtAndStandardExchangeWhereUniqueInput uniqueId)
    {
        var atAndStandardExchange = await _context.AtAndStandardExchanges.FindAsync(uniqueId.Id);
        if (atAndStandardExchange == null)
        {
            throw new NotFoundException();
        }

        _context.AtAndStandardExchanges.Remove(atAndStandardExchange);
        await _context.SaveChangesAsync();
    }

    /// <summary>
    /// Find many AT? AND STANDARD EXCHANGES
    /// </summary>
    public async Task<List<AtAndStandardExchange>> AtAndStandardExchanges(
        AtAndStandardExchangeFindManyArgs findManyArgs
    )
    {
        var atAndStandardExchanges = await _context
            .AtAndStandardExchanges.ApplyWhere(findManyArgs.Where)
            .ApplySkip(findManyArgs.Skip)
            .ApplyTake(findManyArgs.Take)
            .ApplyOrderBy(findManyArgs.SortBy)
            .ToListAsync();
        return atAndStandardExchanges.ConvertAll(atAndStandardExchange =>
            atAndStandardExchange.ToDto()
        );
    }

    /// <summary>
    /// Meta data about AT? AND STANDARD EXCHANGE records
    /// </summary>
    public async Task<MetadataDto> AtAndStandardExchangesMeta(
        AtAndStandardExchangeFindManyArgs findManyArgs
    )
    {
        var count = await _context
            .AtAndStandardExchanges.ApplyWhere(findManyArgs.Where)
            .CountAsync();

        return new MetadataDto { Count = count };
    }

    /// <summary>
    /// Get one AT? AND STANDARD EXCHANGE
    /// </summary>
    public async Task<AtAndStandardExchange> AtAndStandardExchange(
        AtAndStandardExchangeWhereUniqueInput uniqueId
    )
    {
        var atAndStandardExchanges = await this.AtAndStandardExchanges(
            new AtAndStandardExchangeFindManyArgs
            {
                Where = new AtAndStandardExchangeWhereInput { Id = uniqueId.Id }
            }
        );
        var atAndStandardExchange = atAndStandardExchanges.FirstOrDefault();
        if (atAndStandardExchange == null)
        {
            throw new NotFoundException();
        }

        return atAndStandardExchange;
    }

    /// <summary>
    /// Update one AT? AND STANDARD EXCHANGE
    /// </summary>
    public async Task UpdateAtAndStandardExchange(
        AtAndStandardExchangeWhereUniqueInput uniqueId,
        AtAndStandardExchangeUpdateInput updateDto
    )
    {
        var atAndStandardExchange = updateDto.ToModel(uniqueId);

        _context.Entry(atAndStandardExchange).State = EntityState.Modified;

        try
        {
            await _context.SaveChangesAsync();
        }
        catch (DbUpdateConcurrencyException)
        {
            if (!_context.AtAndStandardExchanges.Any(e => e.Id == atAndStandardExchange.Id))
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
