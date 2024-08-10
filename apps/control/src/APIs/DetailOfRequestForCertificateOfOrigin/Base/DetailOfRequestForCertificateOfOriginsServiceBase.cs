using Control.APIs.Common;
using Control.APIs.Dtos;
using Control.APIs.Errors;
using Control.APIs.Extensions;
using Control.Infrastructure;
using Control.Infrastructure.Models;
using Microsoft.EntityFrameworkCore;

namespace Control.APIs;

public abstract class DetailOfRequestForCertificateOfOriginsServiceBase
    : IDetailOfRequestForCertificateOfOriginsService
{
    protected readonly ControlDbContext _context;

    public DetailOfRequestForCertificateOfOriginsServiceBase(ControlDbContext context)
    {
        _context = context;
    }

    /// <summary>
    ///     Create one DETAIL OF REQUEST FOR CERTIFICATE OF ORIGIN
    /// </summary>
    public async Task<DetailOfRequestForCertificateOfOrigin> CreateDetailOfRequestForCertificateOfOrigin(
        DetailOfRequestForCertificateOfOriginCreateInput createDto
    )
    {
        var detailOfRequestForCertificateOfOrigin = new DetailOfRequestForCertificateOfOriginDbModel
        {
            BrandName = createDto.BrandName,
            CertificateOfOriginRequestNumber = createDto.CertificateOfOriginRequestNumber,
            CreatedAt = createDto.CreatedAt,
            Crn = createDto.Crn,
            DateAndTimeOfFinalModification = createDto.DateAndTimeOfFinalModification,
            DateAndTimeOfFirstRegistration = createDto.DateAndTimeOfFirstRegistration,
            DescriptionOfTheMerchandise = createDto.DescriptionOfTheMerchandise,
            FinalModifierSId = createDto.FinalModifierSId,
            FirstRegistrantSId = createDto.FirstRegistrantSId,
            InvoiceRefInvoice = createDto.InvoiceRefInvoice,
            Quantity = createDto.Quantity,
            QuantityOfThePackage = createDto.QuantityOfThePackage,
            QuantityUnitCode = createDto.QuantityUnitCode,
            RectificationFrequency = createDto.RectificationFrequency,
            SequenceNumber = createDto.SequenceNumber,
            ShCode = createDto.ShCode,
            Standards = createDto.Standards,
            SuppressionOn = createDto.SuppressionOn,
            TradeName = createDto.TradeName,
            TypeOfPackagingCode = createDto.TypeOfPackagingCode,
            UpdatedAt = createDto.UpdatedAt,
            Weight = createDto.Weight,
            WeightUnit = createDto.WeightUnit
        };

        if (createDto.Id != null) detailOfRequestForCertificateOfOrigin.Id = createDto.Id;

        _context.DetailOfRequestForCertificateOfOrigins.Add(detailOfRequestForCertificateOfOrigin);
        await _context.SaveChangesAsync();

        var result = await _context.FindAsync<DetailOfRequestForCertificateOfOriginDbModel>(
            detailOfRequestForCertificateOfOrigin.Id
        );

        if (result == null) throw new NotFoundException();

        return result.ToDto();
    }

    /// <summary>
    ///     Delete one DETAIL OF REQUEST FOR CERTIFICATE OF ORIGIN
    /// </summary>
    public async Task DeleteDetailOfRequestForCertificateOfOrigin(
        DetailOfRequestForCertificateOfOriginWhereUniqueInput uniqueId
    )
    {
        var detailOfRequestForCertificateOfOrigin =
            await _context.DetailOfRequestForCertificateOfOrigins.FindAsync(uniqueId.Id);
        if (detailOfRequestForCertificateOfOrigin == null) throw new NotFoundException();

        _context.DetailOfRequestForCertificateOfOrigins.Remove(
            detailOfRequestForCertificateOfOrigin
        );
        await _context.SaveChangesAsync();
    }

    /// <summary>
    ///     Find many DETAIL OF REQUEST FOR CERTIFICATE OF ORIGINS
    /// </summary>
    public async Task<
        List<DetailOfRequestForCertificateOfOrigin>
    > DetailOfRequestForCertificateOfOrigins(
        DetailOfRequestForCertificateOfOriginFindManyArgs findManyArgs
    )
    {
        var detailOfRequestForCertificateOfOrigins = await _context
            .DetailOfRequestForCertificateOfOrigins.ApplyWhere(findManyArgs.Where)
            .ApplySkip(findManyArgs.Skip)
            .ApplyTake(findManyArgs.Take)
            .ApplyOrderBy(findManyArgs.SortBy)
            .ToListAsync();
        return detailOfRequestForCertificateOfOrigins.ConvertAll(
            detailOfRequestForCertificateOfOrigin => detailOfRequestForCertificateOfOrigin.ToDto()
        );
    }

    /// <summary>
    ///     Meta data about DETAIL OF REQUEST FOR CERTIFICATE OF ORIGIN records
    /// </summary>
    public async Task<MetadataDto> DetailOfRequestForCertificateOfOriginsMeta(
        DetailOfRequestForCertificateOfOriginFindManyArgs findManyArgs
    )
    {
        var count = await _context
            .DetailOfRequestForCertificateOfOrigins.ApplyWhere(findManyArgs.Where)
            .CountAsync();

        return new MetadataDto { Count = count };
    }

    /// <summary>
    ///     Get one DETAIL OF REQUEST FOR CERTIFICATE OF ORIGIN
    /// </summary>
    public async Task<DetailOfRequestForCertificateOfOrigin> DetailOfRequestForCertificateOfOrigin(
        DetailOfRequestForCertificateOfOriginWhereUniqueInput uniqueId
    )
    {
        var detailOfRequestForCertificateOfOrigins =
            await DetailOfRequestForCertificateOfOrigins(
                new DetailOfRequestForCertificateOfOriginFindManyArgs
                {
                    Where = new DetailOfRequestForCertificateOfOriginWhereInput { Id = uniqueId.Id }
                }
            );
        var detailOfRequestForCertificateOfOrigin =
            detailOfRequestForCertificateOfOrigins.FirstOrDefault();
        if (detailOfRequestForCertificateOfOrigin == null) throw new NotFoundException();

        return detailOfRequestForCertificateOfOrigin;
    }

    /// <summary>
    ///     Update one DETAIL OF REQUEST FOR CERTIFICATE OF ORIGIN
    /// </summary>
    public async Task UpdateDetailOfRequestForCertificateOfOrigin(
        DetailOfRequestForCertificateOfOriginWhereUniqueInput uniqueId,
        DetailOfRequestForCertificateOfOriginUpdateInput updateDto
    )
    {
        var detailOfRequestForCertificateOfOrigin = updateDto.ToModel(uniqueId);

        _context.Entry(detailOfRequestForCertificateOfOrigin).State = EntityState.Modified;

        try
        {
            await _context.SaveChangesAsync();
        }
        catch (DbUpdateConcurrencyException)
        {
            if (
                !_context.DetailOfRequestForCertificateOfOrigins.Any(e =>
                    e.Id == detailOfRequestForCertificateOfOrigin.Id
                )
            )
                throw new NotFoundException();
            throw;
        }
    }
}
