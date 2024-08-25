using Control.APIs;
using Control.APIs.Common;
using Control.APIs.Dtos;
using Control.APIs.Errors;
using Control.APIs.Extensions;
using Control.Infrastructure;
using Control.Infrastructure.Models;
using Microsoft.EntityFrameworkCore;

namespace Control.APIs;

public abstract class CommonOriginCertificateRequestsServiceBase
    : ICommonOriginCertificateRequestsService
{
    protected readonly ControlDbContext _context;

    public CommonOriginCertificateRequestsServiceBase(ControlDbContext context)
    {
        _context = context;
    }

    /// <summary>
    /// Create one Common Origin Certificate Request
    /// </summary>
    public async Task<CommonOriginCertificateRequest> CreateCommonOriginCertificateRequest(
        CommonOriginCertificateRequestCreateInput createDto
    )
    {
        var commonOriginCertificateRequest = new CommonOriginCertificateRequestDbModel
        {
            AttachedFileId = createDto.AttachedFileId,
            AuthorizedExporterSAuthorizationNumber =
                createDto.AuthorizedExporterSAuthorizationNumber,
            CertificateOfOriginNumber = createDto.CertificateOfOriginNumber,
            CertificateOfOriginRequestNumber = createDto.CertificateOfOriginRequestNumber,
            CodeOfTheGrossWeightUnit = createDto.CodeOfTheGrossWeightUnit,
            CreatedAt = createDto.CreatedAt,
            CustomsOfficeCode = createDto.CustomsOfficeCode,
            DateAndTimeOfFinalModification = createDto.DateAndTimeOfFinalModification,
            DateAndTimeOfFirstRegistration = createDto.DateAndTimeOfFirstRegistration,
            DeclarantSAddress = createDto.DeclarantSAddress,
            DeclarantSCode = createDto.DeclarantSCode,
            DeclarantSName = createDto.DeclarantSName,
            DepartureDate = createDto.DepartureDate,
            DestinationCountryCode = createDto.DestinationCountryCode,
            ExporterSAddress = createDto.ExporterSAddress,
            ExporterSCountryCode = createDto.ExporterSCountryCode,
            ExporterSName = createDto.ExporterSName,
            ExporterSTin = createDto.ExporterSTin,
            FinalModifierSId = createDto.FinalModifierSId,
            FirstRegistrantSId = createDto.FirstRegistrantSId,
            FreeTextReservedForTheDeclarant = createDto.FreeTextReservedForTheDeclarant,
            GrossWeight = createDto.GrossWeight,
            IssuanceDate = createDto.IssuanceDate,
            IssuingOrganizationOfTheCertificateOfOrigin =
                createDto.IssuingOrganizationOfTheCertificateOfOrigin,
            MeansOfTransportNumber = createDto.MeansOfTransportNumber,
            MeansOfTransportTypeCode = createDto.MeansOfTransportTypeCode,
            OriginCountryCode = createDto.OriginCountryCode,
            PreferentialCode = createDto.PreferentialCode,
            ProcessingStatusCode = createDto.ProcessingStatusCode,
            RecipientSAddress = createDto.RecipientSAddress,
            RecipientSName = createDto.RecipientSName,
            RectificationFrequency = createDto.RectificationFrequency,
            RemarkContent = createDto.RemarkContent,
            RequestDate = createDto.RequestDate,
            SuppressionOn = createDto.SuppressionOn,
            TinOfTheDestination = createDto.TinOfTheDestination,
            UpdatedAt = createDto.UpdatedAt
        };

        if (createDto.Id != null)
        {
            commonOriginCertificateRequest.Id = createDto.Id;
        }
        if (createDto.Details != null)
        {
            commonOriginCertificateRequest.Details = await _context
                .DetailOfRequestForOriginCertificates.Where(detailOfRequestForOriginCertificate =>
                    createDto
                        .Details.Select(t => t.Id)
                        .Contains(detailOfRequestForOriginCertificate.Id)
                )
                .ToListAsync();
        }

        if (createDto.Request != null)
        {
            commonOriginCertificateRequest.Request = await _context
                .Procedures.Where(procedure => createDto.Request.Id == procedure.Id)
                .FirstOrDefaultAsync();
        }

        _context.CommonOriginCertificateRequests.Add(commonOriginCertificateRequest);
        await _context.SaveChangesAsync();

        var result = await _context.FindAsync<CommonOriginCertificateRequestDbModel>(
            commonOriginCertificateRequest.Id
        );

        if (result == null)
        {
            throw new NotFoundException();
        }

        return result.ToDto();
    }

    /// <summary>
    /// Delete one Common Origin Certificate Request
    /// </summary>
    public async Task DeleteCommonOriginCertificateRequest(
        CommonOriginCertificateRequestWhereUniqueInput uniqueId
    )
    {
        var commonOriginCertificateRequest =
            await _context.CommonOriginCertificateRequests.FindAsync(uniqueId.Id);
        if (commonOriginCertificateRequest == null)
        {
            throw new NotFoundException();
        }

        _context.CommonOriginCertificateRequests.Remove(commonOriginCertificateRequest);
        await _context.SaveChangesAsync();
    }

    /// <summary>
    /// Find many COMMON ORIGIN CERTIFICATE REQUESTS
    /// </summary>
    public async Task<List<CommonOriginCertificateRequest>> CommonOriginCertificateRequests(
        CommonOriginCertificateRequestFindManyArgs findManyArgs
    )
    {
        var commonOriginCertificateRequests = await _context
            .CommonOriginCertificateRequests.Include(x => x.Details)
            .Include(x => x.Request)
            .ApplyWhere(findManyArgs.Where)
            .ApplySkip(findManyArgs.Skip)
            .ApplyTake(findManyArgs.Take)
            .ApplyOrderBy(findManyArgs.SortBy)
            .ToListAsync();
        return commonOriginCertificateRequests.ConvertAll(commonOriginCertificateRequest =>
            commonOriginCertificateRequest.ToDto()
        );
    }

    /// <summary>
    /// Meta data about Common Origin Certificate Request records
    /// </summary>
    public async Task<MetadataDto> CommonOriginCertificateRequestsMeta(
        CommonOriginCertificateRequestFindManyArgs findManyArgs
    )
    {
        var count = await _context
            .CommonOriginCertificateRequests.ApplyWhere(findManyArgs.Where)
            .CountAsync();

        return new MetadataDto { Count = count };
    }

    /// <summary>
    /// Get one Common Origin Certificate Request
    /// </summary>
    public async Task<CommonOriginCertificateRequest> CommonOriginCertificateRequest(
        CommonOriginCertificateRequestWhereUniqueInput uniqueId
    )
    {
        var commonOriginCertificateRequests = await this.CommonOriginCertificateRequests(
            new CommonOriginCertificateRequestFindManyArgs
            {
                Where = new CommonOriginCertificateRequestWhereInput { Id = uniqueId.Id }
            }
        );
        var commonOriginCertificateRequest = commonOriginCertificateRequests.FirstOrDefault();
        if (commonOriginCertificateRequest == null)
        {
            throw new NotFoundException();
        }

        return commonOriginCertificateRequest;
    }

    /// <summary>
    /// Update one Common Origin Certificate Request
    /// </summary>
    public async Task UpdateCommonOriginCertificateRequest(
        CommonOriginCertificateRequestWhereUniqueInput uniqueId,
        CommonOriginCertificateRequestUpdateInput updateDto
    )
    {
        var commonOriginCertificateRequest = updateDto.ToModel(uniqueId);

        if (updateDto.Details != null)
        {
            commonOriginCertificateRequest.Details = await _context
                .DetailOfRequestForOriginCertificates.Where(detailOfRequestForOriginCertificate =>
                    updateDto
                        .Details.Select(t => t)
                        .Contains(detailOfRequestForOriginCertificate.Id)
                )
                .ToListAsync();
        }

        _context.Entry(commonOriginCertificateRequest).State = EntityState.Modified;

        try
        {
            await _context.SaveChangesAsync();
        }
        catch (DbUpdateConcurrencyException)
        {
            if (
                !_context.CommonOriginCertificateRequests.Any(e =>
                    e.Id == commonOriginCertificateRequest.Id
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
    /// Get a Request record for Common Origin Certificate Request
    /// </summary>
    public async Task<Procedure> GetRequest(CommonOriginCertificateRequestWhereUniqueInput uniqueId)
    {
        var commonOriginCertificateRequest = await _context
            .CommonOriginCertificateRequests.Where(commonOriginCertificateRequest =>
                commonOriginCertificateRequest.Id == uniqueId.Id
            )
            .Include(commonOriginCertificateRequest => commonOriginCertificateRequest.Request)
            .FirstOrDefaultAsync();
        if (commonOriginCertificateRequest == null)
        {
            throw new NotFoundException();
        }
        return commonOriginCertificateRequest.Request.ToDto();
    }
}
