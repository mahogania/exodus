using Control.APIs;
using Control.APIs.Common;
using Control.APIs.Dtos;
using Control.APIs.Errors;
using Control.APIs.Extensions;
using Control.Infrastructure;
using Control.Infrastructure.Models;
using Microsoft.EntityFrameworkCore;

namespace Control.APIs;

public abstract class InformationOfGoodsAtAndStandardExchangesServiceBase
    : IInformationOfGoodsAtAndStandardExchangesService
{
    protected readonly ControlDbContext _context;

    public InformationOfGoodsAtAndStandardExchangesServiceBase(ControlDbContext context)
    {
        _context = context;
    }

    /// <summary>
    /// Create one INFORMATION OF GOODS AT AND STANDARD EXCHANGE
    /// </summary>
    public async Task<InformationOfGoodsAtAndStandardExchange> CreateInformationOfGoodsAtAndStandardExchange(
        InformationOfGoodsAtAndStandardExchangeCreateInput createDto
    )
    {
        var informationOfGoodsAtAndStandardExchange =
            new InformationOfGoodsAtAndStandardExchangeDbModel
            {
                AddressOfTheSupplierRecipientOfTheGoods =
                    createDto.AddressOfTheSupplierRecipientOfTheGoods,
                CommercialDesignationOfMaterials = createDto.CommercialDesignationOfMaterials,
                CreatedAt = createDto.CreatedAt,
                CurrencyCode = createDto.CurrencyCode,
                DateAndTimeOfFinalModification = createDto.DateAndTimeOfFinalModification,
                DateAndTimeOfFirstRegistration = createDto.DateAndTimeOfFirstRegistration,
                FinalModifierSId = createDto.FinalModifierSId,
                FirstRegistrantSId = createDto.FirstRegistrantSId,
                Identification = createDto.Identification,
                NameAndBusinessNameOfTheSupplierRecipientOfTheGoods =
                    createDto.NameAndBusinessNameOfTheSupplierRecipientOfTheGoods,
                Origin = createDto.Origin,
                ProvenanceDestination = createDto.ProvenanceDestination,
                Quantity = createDto.Quantity,
                RectificationFrequency = createDto.RectificationFrequency,
                RegimeRequestNumber = createDto.RegimeRequestNumber,
                SequenceNumber = createDto.SequenceNumber,
                SptNumber = createDto.SptNumber,
                SuppressionOn = createDto.SuppressionOn,
                TechnicalDesignationOfMaterials = createDto.TechnicalDesignationOfMaterials,
                UpdatedAt = createDto.UpdatedAt,
                Value = createDto.Value
            };

        if (createDto.Id != null)
        {
            informationOfGoodsAtAndStandardExchange.Id = createDto.Id;
        }

        _context.InformationOfGoodsAtAndStandardExchanges.Add(
            informationOfGoodsAtAndStandardExchange
        );
        await _context.SaveChangesAsync();

        var result = await _context.FindAsync<InformationOfGoodsAtAndStandardExchangeDbModel>(
            informationOfGoodsAtAndStandardExchange.Id
        );

        if (result == null)
        {
            throw new NotFoundException();
        }

        return result.ToDto();
    }

    /// <summary>
    /// Delete one INFORMATION OF GOODS AT AND STANDARD EXCHANGE
    /// </summary>
    public async Task DeleteInformationOfGoodsAtAndStandardExchange(
        InformationOfGoodsAtAndStandardExchangeWhereUniqueInput uniqueId
    )
    {
        var informationOfGoodsAtAndStandardExchange =
            await _context.InformationOfGoodsAtAndStandardExchanges.FindAsync(uniqueId.Id);
        if (informationOfGoodsAtAndStandardExchange == null)
        {
            throw new NotFoundException();
        }

        _context.InformationOfGoodsAtAndStandardExchanges.Remove(
            informationOfGoodsAtAndStandardExchange
        );
        await _context.SaveChangesAsync();
    }

    /// <summary>
    /// Find many INFORMATION OF GOODS AT AND STANDARD EXCHANGES
    /// </summary>
    public async Task<
        List<InformationOfGoodsAtAndStandardExchange>
    > InformationOfGoodsAtAndStandardExchanges(
        InformationOfGoodsAtAndStandardExchangeFindManyArgs findManyArgs
    )
    {
        var informationOfGoodsAtAndStandardExchanges = await _context
            .InformationOfGoodsAtAndStandardExchanges.ApplyWhere(findManyArgs.Where)
            .ApplySkip(findManyArgs.Skip)
            .ApplyTake(findManyArgs.Take)
            .ApplyOrderBy(findManyArgs.SortBy)
            .ToListAsync();
        return informationOfGoodsAtAndStandardExchanges.ConvertAll(
            informationOfGoodsAtAndStandardExchange =>
                informationOfGoodsAtAndStandardExchange.ToDto()
        );
    }

    /// <summary>
    /// Meta data about INFORMATION OF GOODS AT AND STANDARD EXCHANGE records
    /// </summary>
    public async Task<MetadataDto> InformationOfGoodsAtAndStandardExchangesMeta(
        InformationOfGoodsAtAndStandardExchangeFindManyArgs findManyArgs
    )
    {
        var count = await _context
            .InformationOfGoodsAtAndStandardExchanges.ApplyWhere(findManyArgs.Where)
            .CountAsync();

        return new MetadataDto { Count = count };
    }

    /// <summary>
    /// Get one INFORMATION OF GOODS AT AND STANDARD EXCHANGE
    /// </summary>
    public async Task<InformationOfGoodsAtAndStandardExchange> InformationOfGoodsAtAndStandardExchange(
        InformationOfGoodsAtAndStandardExchangeWhereUniqueInput uniqueId
    )
    {
        var informationOfGoodsAtAndStandardExchanges =
            await this.InformationOfGoodsAtAndStandardExchanges(
                new InformationOfGoodsAtAndStandardExchangeFindManyArgs
                {
                    Where = new InformationOfGoodsAtAndStandardExchangeWhereInput
                    {
                        Id = uniqueId.Id
                    }
                }
            );
        var informationOfGoodsAtAndStandardExchange =
            informationOfGoodsAtAndStandardExchanges.FirstOrDefault();
        if (informationOfGoodsAtAndStandardExchange == null)
        {
            throw new NotFoundException();
        }

        return informationOfGoodsAtAndStandardExchange;
    }

    /// <summary>
    /// Update one INFORMATION OF GOODS AT AND STANDARD EXCHANGE
    /// </summary>
    public async Task UpdateInformationOfGoodsAtAndStandardExchange(
        InformationOfGoodsAtAndStandardExchangeWhereUniqueInput uniqueId,
        InformationOfGoodsAtAndStandardExchangeUpdateInput updateDto
    )
    {
        var informationOfGoodsAtAndStandardExchange = updateDto.ToModel(uniqueId);

        _context.Entry(informationOfGoodsAtAndStandardExchange).State = EntityState.Modified;

        try
        {
            await _context.SaveChangesAsync();
        }
        catch (DbUpdateConcurrencyException)
        {
            if (
                !_context.InformationOfGoodsAtAndStandardExchanges.Any(e =>
                    e.Id == informationOfGoodsAtAndStandardExchange.Id
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
