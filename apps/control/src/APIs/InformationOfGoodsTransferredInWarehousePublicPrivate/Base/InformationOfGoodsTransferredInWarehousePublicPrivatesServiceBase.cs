using Control.APIs;
using Control.APIs.Common;
using Control.APIs.Dtos;
using Control.APIs.Errors;
using Control.APIs.Extensions;
using Control.Infrastructure;
using Control.Infrastructure.Models;
using Microsoft.EntityFrameworkCore;

namespace Control.APIs;

public abstract class InformationOfGoodsTransferredInWarehousePublicPrivatesServiceBase
    : IInformationOfGoodsTransferredInWarehousePublicPrivatesService
{
    protected readonly ControlDbContext _context;

    public InformationOfGoodsTransferredInWarehousePublicPrivatesServiceBase(
        ControlDbContext context
    )
    {
        _context = context;
    }

    /// <summary>
    /// Create one INFORMATION OF GOODS TRANSFERRED IN WAREHOUSE (PUBLIC, PRIVATE)
    /// </summary>
    public async Task<InformationOfGoodsTransferredInWarehousePublicPrivate> CreateInformationOfGoodsTransferredInWarehousePublicPrivate(
        InformationOfGoodsTransferredInWarehousePublicPrivateCreateInput createDto
    )
    {
        var informationOfGoodsTransferredInWarehousePublicPrivate =
            new InformationOfGoodsTransferredInWarehousePublicPrivateDbModel
            {
                CommercialDesignationOfGoods = createDto.CommercialDesignationOfGoods,
                CreatedAt = createDto.CreatedAt,
                DateAndTimeOfFinalModification = createDto.DateAndTimeOfFinalModification,
                DateAndTimeOfFirstRegistration = createDto.DateAndTimeOfFirstRegistration,
                FinalModifierSId = createDto.FinalModifierSId,
                FirstRegistrantSId = createDto.FirstRegistrantSId,
                NumberOfTheConcernedArticle = createDto.NumberOfTheConcernedArticle,
                Origin = createDto.Origin,
                Quantity = createDto.Quantity,
                RectificationFrequency = createDto.RectificationFrequency,
                ReferencesOfTheConcernedArticleModelS =
                    createDto.ReferencesOfTheConcernedArticleModelS,
                RegimeRequestNumber = createDto.RegimeRequestNumber,
                SequenceNumber = createDto.SequenceNumber,
                SptNumber = createDto.SptNumber,
                SuppressionOn = createDto.SuppressionOn,
                TechnicalDesignationOfGoods = createDto.TechnicalDesignationOfGoods,
                UpdatedAt = createDto.UpdatedAt,
                Value = createDto.Value
            };

        if (createDto.Id != null)
        {
            informationOfGoodsTransferredInWarehousePublicPrivate.Id = createDto.Id;
        }

        _context.InformationOfGoodsTransferredInWarehousePublicPrivates.Add(
            informationOfGoodsTransferredInWarehousePublicPrivate
        );
        await _context.SaveChangesAsync();

        var result =
            await _context.FindAsync<InformationOfGoodsTransferredInWarehousePublicPrivateDbModel>(
                informationOfGoodsTransferredInWarehousePublicPrivate.Id
            );

        if (result == null)
        {
            throw new NotFoundException();
        }

        return result.ToDto();
    }

    /// <summary>
    /// Delete one INFORMATION OF GOODS TRANSFERRED IN WAREHOUSE (PUBLIC, PRIVATE)
    /// </summary>
    public async Task DeleteInformationOfGoodsTransferredInWarehousePublicPrivate(
        InformationOfGoodsTransferredInWarehousePublicPrivateWhereUniqueInput uniqueId
    )
    {
        var informationOfGoodsTransferredInWarehousePublicPrivate =
            await _context.InformationOfGoodsTransferredInWarehousePublicPrivates.FindAsync(
                uniqueId.Id
            );
        if (informationOfGoodsTransferredInWarehousePublicPrivate == null)
        {
            throw new NotFoundException();
        }

        _context.InformationOfGoodsTransferredInWarehousePublicPrivates.Remove(
            informationOfGoodsTransferredInWarehousePublicPrivate
        );
        await _context.SaveChangesAsync();
    }

    /// <summary>
    /// Find many INFORMATION OF GOODS TRANSFERRED IN WAREHOUSE (PUBLIC, PRIVATE)s
    /// </summary>
    public async Task<
        List<InformationOfGoodsTransferredInWarehousePublicPrivate>
    > InformationOfGoodsTransferredInWarehousePublicPrivates(
        InformationOfGoodsTransferredInWarehousePublicPrivateFindManyArgs findManyArgs
    )
    {
        var informationOfGoodsTransferredInWarehousePublicPrivates = await _context
            .InformationOfGoodsTransferredInWarehousePublicPrivates.ApplyWhere(findManyArgs.Where)
            .ApplySkip(findManyArgs.Skip)
            .ApplyTake(findManyArgs.Take)
            .ApplyOrderBy(findManyArgs.SortBy)
            .ToListAsync();
        return informationOfGoodsTransferredInWarehousePublicPrivates.ConvertAll(
            informationOfGoodsTransferredInWarehousePublicPrivate =>
                informationOfGoodsTransferredInWarehousePublicPrivate.ToDto()
        );
    }

    /// <summary>
    /// Meta data about INFORMATION OF GOODS TRANSFERRED IN WAREHOUSE (PUBLIC, PRIVATE) records
    /// </summary>
    public async Task<MetadataDto> InformationOfGoodsTransferredInWarehousePublicPrivatesMeta(
        InformationOfGoodsTransferredInWarehousePublicPrivateFindManyArgs findManyArgs
    )
    {
        var count = await _context
            .InformationOfGoodsTransferredInWarehousePublicPrivates.ApplyWhere(findManyArgs.Where)
            .CountAsync();

        return new MetadataDto { Count = count };
    }

    /// <summary>
    /// Get one INFORMATION OF GOODS TRANSFERRED IN WAREHOUSE (PUBLIC, PRIVATE)
    /// </summary>
    public async Task<InformationOfGoodsTransferredInWarehousePublicPrivate> InformationOfGoodsTransferredInWarehousePublicPrivate(
        InformationOfGoodsTransferredInWarehousePublicPrivateWhereUniqueInput uniqueId
    )
    {
        var informationOfGoodsTransferredInWarehousePublicPrivates =
            await this.InformationOfGoodsTransferredInWarehousePublicPrivates(
                new InformationOfGoodsTransferredInWarehousePublicPrivateFindManyArgs
                {
                    Where = new InformationOfGoodsTransferredInWarehousePublicPrivateWhereInput
                    {
                        Id = uniqueId.Id
                    }
                }
            );
        var informationOfGoodsTransferredInWarehousePublicPrivate =
            informationOfGoodsTransferredInWarehousePublicPrivates.FirstOrDefault();
        if (informationOfGoodsTransferredInWarehousePublicPrivate == null)
        {
            throw new NotFoundException();
        }

        return informationOfGoodsTransferredInWarehousePublicPrivate;
    }

    /// <summary>
    /// Update one INFORMATION OF GOODS TRANSFERRED IN WAREHOUSE (PUBLIC, PRIVATE)
    /// </summary>
    public async Task UpdateInformationOfGoodsTransferredInWarehousePublicPrivate(
        InformationOfGoodsTransferredInWarehousePublicPrivateWhereUniqueInput uniqueId,
        InformationOfGoodsTransferredInWarehousePublicPrivateUpdateInput updateDto
    )
    {
        var informationOfGoodsTransferredInWarehousePublicPrivate = updateDto.ToModel(uniqueId);

        _context.Entry(informationOfGoodsTransferredInWarehousePublicPrivate).State =
            EntityState.Modified;

        try
        {
            await _context.SaveChangesAsync();
        }
        catch (DbUpdateConcurrencyException)
        {
            if (
                !_context.InformationOfGoodsTransferredInWarehousePublicPrivates.Any(e =>
                    e.Id == informationOfGoodsTransferredInWarehousePublicPrivate.Id
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
