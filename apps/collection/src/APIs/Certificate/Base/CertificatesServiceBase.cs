using Collection.APIs.Common;
using Collection.APIs.Dtos;
using Collection.APIs.Errors;
using Collection.APIs.Extensions;
using Collection.Infrastructure;
using Collection.Infrastructure.Models;
using Microsoft.EntityFrameworkCore;

namespace Collection.APIs;

public abstract class CertificatesServiceBase : ICertificatesService
{
    protected readonly CollectionDbContext _context;

    public CertificatesServiceBase(CollectionDbContext context)
    {
        _context = context;
    }

    /// <summary>
    ///     Create one CERTIFICATE
    /// </summary>
    public async Task<Certificate> CreateCertificate(CertificateCreateInput createDto)
    {
        var certificate = new CertificateDbModel
        {
            AttachmentId = createDto.AttachmentId,
            BatchNo = createDto.BatchNo,
            ChassisNo = createDto.ChassisNo,
            CreatedAt = createDto.CreatedAt,
            DeletionOn = createDto.DeletionOn,
            FinalModificationDateAndTime = createDto.FinalModificationDateAndTime,
            FinalModifierId = createDto.FinalModifierId,
            FirstRegistrantId = createDto.FirstRegistrantId,
            FirstRegistrationDate = createDto.FirstRegistrationDate,
            FirstRegistrationDateAndTime = createDto.FirstRegistrationDateAndTime,
            GrossWeight = createDto.GrossWeight,
            MaximumLoad = createDto.MaximumLoad,
            NumberOfSeats = createDto.NumberOfSeats,
            OfficeCode = createDto.OfficeCode,
            RegistrationNo = createDto.RegistrationNo,
            RemarkContent = createDto.RemarkContent,
            SaleCertificateNo = createDto.SaleCertificateNo,
            SalePvNo = createDto.SalePvNo,
            ServiceCode = createDto.ServiceCode,
            TransferDecisionNo = createDto.TransferDecisionNo,
            UpdatedAt = createDto.UpdatedAt,
            VehicleBrandName = createDto.VehicleBrandName,
            VehicleCylinder = createDto.VehicleCylinder,
            VehicleEnergy = createDto.VehicleEnergy,
            VehicleModelName = createDto.VehicleModelName,
            VehiclePower = createDto.VehiclePower,
            VehicleType = createDto.VehicleType
        };

        if (createDto.Id != null) certificate.Id = createDto.Id;

        _context.Certificates.Add(certificate);
        await _context.SaveChangesAsync();

        var result = await _context.FindAsync<CertificateDbModel>(certificate.Id);

        if (result == null) throw new NotFoundException();

        return result.ToDto();
    }

    /// <summary>
    ///     Delete one CERTIFICATE
    /// </summary>
    public async Task DeleteCertificate(CertificateWhereUniqueInput uniqueId)
    {
        var certificate = await _context.Certificates.FindAsync(uniqueId.Id);
        if (certificate == null) throw new NotFoundException();

        _context.Certificates.Remove(certificate);
        await _context.SaveChangesAsync();
    }

    /// <summary>
    ///     Find many CERTIFICATES
    /// </summary>
    public async Task<List<Certificate>> Certificates(CertificateFindManyArgs findManyArgs)
    {
        var certificates = await _context
            .Certificates.ApplyWhere(findManyArgs.Where)
            .ApplySkip(findManyArgs.Skip)
            .ApplyTake(findManyArgs.Take)
            .ApplyOrderBy(findManyArgs.SortBy)
            .ToListAsync();
        return certificates.ConvertAll(certificate => certificate.ToDto());
    }

    /// <summary>
    ///     Meta data about CERTIFICATE records
    /// </summary>
    public async Task<MetadataDto> CertificatesMeta(CertificateFindManyArgs findManyArgs)
    {
        var count = await _context.Certificates.ApplyWhere(findManyArgs.Where).CountAsync();

        return new MetadataDto { Count = count };
    }

    /// <summary>
    ///     Get one CERTIFICATE
    /// </summary>
    public async Task<Certificate> Certificate(CertificateWhereUniqueInput uniqueId)
    {
        var certificates = await Certificates(
            new CertificateFindManyArgs { Where = new CertificateWhereInput { Id = uniqueId.Id } }
        );
        var certificate = certificates.FirstOrDefault();
        if (certificate == null) throw new NotFoundException();

        return certificate;
    }

    /// <summary>
    ///     Update one CERTIFICATE
    /// </summary>
    public async Task UpdateCertificate(
        CertificateWhereUniqueInput uniqueId,
        CertificateUpdateInput updateDto
    )
    {
        var certificate = updateDto.ToModel(uniqueId);

        _context.Entry(certificate).State = EntityState.Modified;

        try
        {
            await _context.SaveChangesAsync();
        }
        catch (DbUpdateConcurrencyException)
        {
            if (!_context.Certificates.Any(e => e.Id == certificate.Id))
                throw new NotFoundException();
            throw;
        }
    }
}
