using Control.APIs;
using Control.APIs.Common;
using Control.APIs.Dtos;
using Control.APIs.Errors;
using Control.APIs.Extensions;
using Control.Infrastructure;
using Control.Infrastructure.Models;
using Microsoft.EntityFrameworkCore;

namespace Control.APIs;

public abstract class DetailOfRequestForOriginCertificatesServiceBase
    : IDetailOfRequestForOriginCertificatesService
{
    protected readonly ControlDbContext _context;

    public DetailOfRequestForOriginCertificatesServiceBase(ControlDbContext context)
    {
        _context = context;
    }

    /// <summary>
    /// Create one Detail of Request for Origin Certificate
    /// </summary>
    public async Task<DetailOfRequestForOriginCertificate> CreateDetailOfRequestForOriginCertificate(
        DetailOfRequestForOriginCertificateCreateInput createDto
    )
    {
        var detailOfRequestForOriginCertificate = new DetailOfRequestForOriginCertificateDbModel
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

        if (createDto.Id != null)
        {
            detailOfRequestForOriginCertificate.Id = createDto.Id;
        }
        if (createDto.CommonOriginCertificateRequest != null)
        {
            detailOfRequestForOriginCertificate.CommonOriginCertificateRequest = await _context
                .CommonOriginCertificateRequests.Where(commonOriginCertificateRequest =>
                    createDto.CommonOriginCertificateRequest.Id == commonOriginCertificateRequest.Id
                )
                .FirstOrDefaultAsync();
        }

        _context.DetailOfRequestForOriginCertificates.Add(detailOfRequestForOriginCertificate);
        await _context.SaveChangesAsync();

        var result = await _context.FindAsync<DetailOfRequestForOriginCertificateDbModel>(
            detailOfRequestForOriginCertificate.Id
        );

        if (result == null)
        {
            throw new NotFoundException();
        }

        return result.ToDto();
    }

    /// <summary>
    /// Delete one Detail of Request for Origin Certificate
    /// </summary>
    public async Task DeleteDetailOfRequestForOriginCertificate(
        DetailOfRequestForOriginCertificateWhereUniqueInput uniqueId
    )
    {
        var detailOfRequestForOriginCertificate =
            await _context.DetailOfRequestForOriginCertificates.FindAsync(uniqueId.Id);
        if (detailOfRequestForOriginCertificate == null)
        {
            throw new NotFoundException();
        }

        _context.DetailOfRequestForOriginCertificates.Remove(detailOfRequestForOriginCertificate);
        await _context.SaveChangesAsync();
    }

    /// <summary>
    /// Find many DETAIL OF REQUEST FOR CERTIFICATE OF ORIGINS
    /// </summary>
    public async Task<
        List<DetailOfRequestForOriginCertificate>
    > DetailOfRequestForOriginCertificates(
        DetailOfRequestForOriginCertificateFindManyArgs findManyArgs
    )
    {
        var detailOfRequestForOriginCertificates = await _context
            .DetailOfRequestForOriginCertificates.Include(x => x.CommonOriginCertificateRequest)
            .ApplyWhere(findManyArgs.Where)
            .ApplySkip(findManyArgs.Skip)
            .ApplyTake(findManyArgs.Take)
            .ApplyOrderBy(findManyArgs.SortBy)
            .ToListAsync();
        return detailOfRequestForOriginCertificates.ConvertAll(
            detailOfRequestForOriginCertificate => detailOfRequestForOriginCertificate.ToDto()
        );
    }

    /// <summary>
    /// Meta data about Detail of Request for Origin Certificate records
    /// </summary>
    public async Task<MetadataDto> DetailOfRequestForOriginCertificatesMeta(
        DetailOfRequestForOriginCertificateFindManyArgs findManyArgs
    )
    {
        var count = await _context
            .DetailOfRequestForOriginCertificates.ApplyWhere(findManyArgs.Where)
            .CountAsync();

        return new MetadataDto { Count = count };
    }

    /// <summary>
    /// Get one Detail of Request for Origin Certificate
    /// </summary>
    public async Task<DetailOfRequestForOriginCertificate> DetailOfRequestForOriginCertificate(
        DetailOfRequestForOriginCertificateWhereUniqueInput uniqueId
    )
    {
        var detailOfRequestForOriginCertificates = await this.DetailOfRequestForOriginCertificates(
            new DetailOfRequestForOriginCertificateFindManyArgs
            {
                Where = new DetailOfRequestForOriginCertificateWhereInput { Id = uniqueId.Id }
            }
        );
        var detailOfRequestForOriginCertificate =
            detailOfRequestForOriginCertificates.FirstOrDefault();
        if (detailOfRequestForOriginCertificate == null)
        {
            throw new NotFoundException();
        }

        return detailOfRequestForOriginCertificate;
    }

    /// <summary>
    /// Update one Detail of Request for Origin Certificate
    /// </summary>
    public async Task UpdateDetailOfRequestForOriginCertificate(
        DetailOfRequestForOriginCertificateWhereUniqueInput uniqueId,
        DetailOfRequestForOriginCertificateUpdateInput updateDto
    )
    {
        var detailOfRequestForOriginCertificate = updateDto.ToModel(uniqueId);

        _context.Entry(detailOfRequestForOriginCertificate).State = EntityState.Modified;

        try
        {
            await _context.SaveChangesAsync();
        }
        catch (DbUpdateConcurrencyException)
        {
            if (
                !_context.DetailOfRequestForOriginCertificates.Any(e =>
                    e.Id == detailOfRequestForOriginCertificate.Id
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

    /// <summary>
    /// Get a Common Origin Certificate Request record for Detail of Request for Origin Certificate
    /// </summary>
    public async Task<CommonOriginCertificateRequest> GetCommonOriginCertificateRequest(
        DetailOfRequestForOriginCertificateWhereUniqueInput uniqueId
    )
    {
        var detailOfRequestForOriginCertificate = await _context
            .DetailOfRequestForOriginCertificates.Where(detailOfRequestForOriginCertificate =>
                detailOfRequestForOriginCertificate.Id == uniqueId.Id
            )
            .Include(detailOfRequestForOriginCertificate =>
                detailOfRequestForOriginCertificate.CommonOriginCertificateRequest
            )
            .FirstOrDefaultAsync();
        if (detailOfRequestForOriginCertificate == null)
        {
            throw new NotFoundException();
        }
        return detailOfRequestForOriginCertificate.CommonOriginCertificateRequest.ToDto();
    }
}
