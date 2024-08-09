using Control.APIs;
using Control.APIs.Common;
using Control.APIs.Dtos;
using Control.APIs.Errors;
using Control.APIs.Extensions;
using Control.Infrastructure;
using Control.Infrastructure.Models;
using Microsoft.EntityFrameworkCore;

namespace Control.APIs;

public abstract class GoodsSubjectToAuthorizationsServiceBase : IGoodsSubjectToAuthorizationsService
{
    protected readonly ControlDbContext _context;

    public GoodsSubjectToAuthorizationsServiceBase(ControlDbContext context)
    {
        _context = context;
    }

    /// <summary>
    /// Create one GOODS SUBJECT TO AUTHORIZATION
    /// </summary>
    public async Task<GoodsSubjectToAuthorization> CreateGoodsSubjectToAuthorization(
        GoodsSubjectToAuthorizationCreateInput createDto
    )
    {
        var goodsSubjectToAuthorization = new GoodsSubjectToAuthorizationDbModel
        {
            CommercialDesignationOfMaterials = createDto.CommercialDesignationOfMaterials,
            CreatedAt = createDto.CreatedAt,
            CurrencyCode = createDto.CurrencyCode,
            DateAndTimeOfFinalModification = createDto.DateAndTimeOfFinalModification,
            DateAndTimeOfFirstRegistration = createDto.DateAndTimeOfFirstRegistration,
            DeletionOn = createDto.DeletionOn,
            FinalModifierSId = createDto.FinalModifierSId,
            FirstRecorderSId = createDto.FirstRecorderSId,
            Identification = createDto.Identification,
            NumberOfTheArticleConcerned = createDto.NumberOfTheArticleConcerned,
            Origin = createDto.Origin,
            Quantity = createDto.Quantity,
            RectificationFrequency = createDto.RectificationFrequency,
            ReferenceSOfTheModelSOfTheArticleConcerned =
                createDto.ReferenceSOfTheModelSOfTheArticleConcerned,
            RegimeRequestNumber = createDto.RegimeRequestNumber,
            SequenceNumber = createDto.SequenceNumber,
            SptNumber = createDto.SptNumber,
            TechnicalDesignationOfMaterials = createDto.TechnicalDesignationOfMaterials,
            UpdatedAt = createDto.UpdatedAt,
            Value = createDto.Value
        };

        if (createDto.Id != null)
        {
            goodsSubjectToAuthorization.Id = createDto.Id;
        }

        _context.GoodsSubjectToAuthorizations.Add(goodsSubjectToAuthorization);
        await _context.SaveChangesAsync();

        var result = await _context.FindAsync<GoodsSubjectToAuthorizationDbModel>(
            goodsSubjectToAuthorization.Id
        );

        if (result == null)
        {
            throw new NotFoundException();
        }

        return result.ToDto();
    }

    /// <summary>
    /// Delete one GOODS SUBJECT TO AUTHORIZATION
    /// </summary>
    public async Task DeleteGoodsSubjectToAuthorization(
        GoodsSubjectToAuthorizationWhereUniqueInput uniqueId
    )
    {
        var goodsSubjectToAuthorization = await _context.GoodsSubjectToAuthorizations.FindAsync(
            uniqueId.Id
        );
        if (goodsSubjectToAuthorization == null)
        {
            throw new NotFoundException();
        }

        _context.GoodsSubjectToAuthorizations.Remove(goodsSubjectToAuthorization);
        await _context.SaveChangesAsync();
    }

    /// <summary>
    /// Find many GOODS SUBJECT TO AUTHORIZATIONS
    /// </summary>
    public async Task<List<GoodsSubjectToAuthorization>> GoodsSubjectToAuthorizations(
        GoodsSubjectToAuthorizationFindManyArgs findManyArgs
    )
    {
        var goodsSubjectToAuthorizations = await _context
            .GoodsSubjectToAuthorizations.ApplyWhere(findManyArgs.Where)
            .ApplySkip(findManyArgs.Skip)
            .ApplyTake(findManyArgs.Take)
            .ApplyOrderBy(findManyArgs.SortBy)
            .ToListAsync();
        return goodsSubjectToAuthorizations.ConvertAll(goodsSubjectToAuthorization =>
            goodsSubjectToAuthorization.ToDto()
        );
    }

    /// <summary>
    /// Meta data about GOODS SUBJECT TO AUTHORIZATION records
    /// </summary>
    public async Task<MetadataDto> GoodsSubjectToAuthorizationsMeta(
        GoodsSubjectToAuthorizationFindManyArgs findManyArgs
    )
    {
        var count = await _context
            .GoodsSubjectToAuthorizations.ApplyWhere(findManyArgs.Where)
            .CountAsync();

        return new MetadataDto { Count = count };
    }

    /// <summary>
    /// Get one GOODS SUBJECT TO AUTHORIZATION
    /// </summary>
    public async Task<GoodsSubjectToAuthorization> GoodsSubjectToAuthorization(
        GoodsSubjectToAuthorizationWhereUniqueInput uniqueId
    )
    {
        var goodsSubjectToAuthorizations = await this.GoodsSubjectToAuthorizations(
            new GoodsSubjectToAuthorizationFindManyArgs
            {
                Where = new GoodsSubjectToAuthorizationWhereInput { Id = uniqueId.Id }
            }
        );
        var goodsSubjectToAuthorization = goodsSubjectToAuthorizations.FirstOrDefault();
        if (goodsSubjectToAuthorization == null)
        {
            throw new NotFoundException();
        }

        return goodsSubjectToAuthorization;
    }

    /// <summary>
    /// Update one GOODS SUBJECT TO AUTHORIZATION
    /// </summary>
    public async Task UpdateGoodsSubjectToAuthorization(
        GoodsSubjectToAuthorizationWhereUniqueInput uniqueId,
        GoodsSubjectToAuthorizationUpdateInput updateDto
    )
    {
        var goodsSubjectToAuthorization = updateDto.ToModel(uniqueId);

        _context.Entry(goodsSubjectToAuthorization).State = EntityState.Modified;

        try
        {
            await _context.SaveChangesAsync();
        }
        catch (DbUpdateConcurrencyException)
        {
            if (
                !_context.GoodsSubjectToAuthorizations.Any(e =>
                    e.Id == goodsSubjectToAuthorization.Id
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
