using Control.APIs;
using Control.APIs.Common;
using Control.APIs.Dtos;
using Control.APIs.Errors;
using Control.APIs.Extensions;
using Control.Infrastructure;
using Control.Infrastructure.Models;
using Microsoft.EntityFrameworkCore;

namespace Control.APIs;

public abstract class RequestForCommonCarnetsServiceBase : IRequestForCommonCarnetsService
{
    protected readonly ControlDbContext _context;

    public RequestForCommonCarnetsServiceBase(ControlDbContext context)
    {
        _context = context;
    }

    /// <summary>
    /// Create one REQUEST FOR COMMON CARNET
    /// </summary>
    public async Task<RequestForCommonCarnet> CreateRequestForCommonCarnet(
        RequestForCommonCarnetCreateInput createDto
    )
    {
        var requestForCommonCarnet = new RequestForCommonCarnetDbModel
        {
            AttachedFileId = createDto.AttachedFileId,
            CertificationOrganization = createDto.CertificationOrganization,
            CreatedAt = createDto.CreatedAt,
            CustomsOfficeCode = createDto.CustomsOfficeCode,
            DateAndTimeOfFinalModification = createDto.DateAndTimeOfFinalModification,
            DateAndTimeOfFirstRegistration = createDto.DateAndTimeOfFirstRegistration,
            DeletionOn = createDto.DeletionOn,
            DepartureCountryCode = createDto.DepartureCountryCode,
            DepartureCountryCode_1 = createDto.DepartureCountryCode_1,
            DepartureCountryCode_2 = createDto.DepartureCountryCode_2,
            DepartureCountryCode_3 = createDto.DepartureCountryCode_3,
            DepartureOfficeCode_2 = createDto.DepartureOfficeCode_2,
            DepartureOfficeCode_3 = createDto.DepartureOfficeCode_3,
            DepartureOffice_1 = createDto.DepartureOffice_1,
            DepartureOffice_2 = createDto.DepartureOffice_2,
            DepartureOffice_3 = createDto.DepartureOffice_3,
            DestinationCountryCode = createDto.DestinationCountryCode,
            DestinationCountryCode_1 = createDto.DestinationCountryCode_1,
            DestinationCountryCode_2 = createDto.DestinationCountryCode_2,
            DestinationCountryCode_3 = createDto.DestinationCountryCode_3,
            DestinationOfficeCode_1 = createDto.DestinationOfficeCode_1,
            DestinationOfficeCode_2 = createDto.DestinationOfficeCode_2,
            DestinationOfficeCode_3 = createDto.DestinationOfficeCode_3,
            DestinationOffice_1 = createDto.DestinationOffice_1,
            DestinationOffice_2 = createDto.DestinationOffice_2,
            DestinationOffice_3 = createDto.DestinationOffice_3,
            Destination_1TransportQuantity = createDto.Destination_1TransportQuantity,
            Destination_2TransportQuantity = createDto.Destination_2TransportQuantity,
            Destination_3TransportQuantity = createDto.Destination_3TransportQuantity,
            FinalModifierSId = createDto.FinalModifierSId,
            FirstRecorderSId = createDto.FirstRecorderSId,
            HolderSAddress = createDto.HolderSAddress,
            HolderSIdentificationNumber = createDto.HolderSIdentificationNumber,
            HolderSName = createDto.HolderSName,
            HolderSZipcode = createDto.HolderSZipcode,
            InternationalOrganizationName = createDto.InternationalOrganizationName,
            IssueDate = createDto.IssueDate,
            IssuedBy = createDto.IssuedBy,
            NumberOfContainerConcerned = createDto.NumberOfContainerConcerned,
            Observations = createDto.Observations,
            OfficialUse = createDto.OfficialUse,
            RegistrationDate = createDto.RegistrationDate,
            RegistrationNumber = createDto.RegistrationNumber,
            SealNumber = createDto.SealNumber,
            StatusProcessingCode = createDto.StatusProcessingCode,
            TirNumber = createDto.TirNumber,
            TirRegistrationNumber = createDto.TirRegistrationNumber,
            TotalNumberOfGoods = createDto.TotalNumberOfGoods,
            UpdatedAt = createDto.UpdatedAt,
            ValidUntil = createDto.ValidUntil,
            VehicleCertificationNoAndDate = createDto.VehicleCertificationNoAndDate
        };

        if (createDto.Id != null)
        {
            requestForCommonCarnet.Id = createDto.Id;
        }

        _context.RequestForCommonCarnets.Add(requestForCommonCarnet);
        await _context.SaveChangesAsync();

        var result = await _context.FindAsync<RequestForCommonCarnetDbModel>(
            requestForCommonCarnet.Id
        );

        if (result == null)
        {
            throw new NotFoundException();
        }

        return result.ToDto();
    }

    /// <summary>
    /// Delete one REQUEST FOR COMMON CARNET
    /// </summary>
    public async Task DeleteRequestForCommonCarnet(RequestForCommonCarnetWhereUniqueInput uniqueId)
    {
        var requestForCommonCarnet = await _context.RequestForCommonCarnets.FindAsync(uniqueId.Id);
        if (requestForCommonCarnet == null)
        {
            throw new NotFoundException();
        }

        _context.RequestForCommonCarnets.Remove(requestForCommonCarnet);
        await _context.SaveChangesAsync();
    }

    /// <summary>
    /// Find many REQUEST FOR COMMON CARNETS
    /// </summary>
    public async Task<List<RequestForCommonCarnet>> RequestForCommonCarnets(
        RequestForCommonCarnetFindManyArgs findManyArgs
    )
    {
        var requestForCommonCarnets = await _context
            .RequestForCommonCarnets.ApplyWhere(findManyArgs.Where)
            .ApplySkip(findManyArgs.Skip)
            .ApplyTake(findManyArgs.Take)
            .ApplyOrderBy(findManyArgs.SortBy)
            .ToListAsync();
        return requestForCommonCarnets.ConvertAll(requestForCommonCarnet =>
            requestForCommonCarnet.ToDto()
        );
    }

    /// <summary>
    /// Meta data about REQUEST FOR COMMON CARNET records
    /// </summary>
    public async Task<MetadataDto> RequestForCommonCarnetsMeta(
        RequestForCommonCarnetFindManyArgs findManyArgs
    )
    {
        var count = await _context
            .RequestForCommonCarnets.ApplyWhere(findManyArgs.Where)
            .CountAsync();

        return new MetadataDto { Count = count };
    }

    /// <summary>
    /// Get one REQUEST FOR COMMON CARNET
    /// </summary>
    public async Task<RequestForCommonCarnet> RequestForCommonCarnet(
        RequestForCommonCarnetWhereUniqueInput uniqueId
    )
    {
        var requestForCommonCarnets = await this.RequestForCommonCarnets(
            new RequestForCommonCarnetFindManyArgs
            {
                Where = new RequestForCommonCarnetWhereInput { Id = uniqueId.Id }
            }
        );
        var requestForCommonCarnet = requestForCommonCarnets.FirstOrDefault();
        if (requestForCommonCarnet == null)
        {
            throw new NotFoundException();
        }

        return requestForCommonCarnet;
    }

    /// <summary>
    /// Update one REQUEST FOR COMMON CARNET
    /// </summary>
    public async Task UpdateRequestForCommonCarnet(
        RequestForCommonCarnetWhereUniqueInput uniqueId,
        RequestForCommonCarnetUpdateInput updateDto
    )
    {
        var requestForCommonCarnet = updateDto.ToModel(uniqueId);

        _context.Entry(requestForCommonCarnet).State = EntityState.Modified;

        try
        {
            await _context.SaveChangesAsync();
        }
        catch (DbUpdateConcurrencyException)
        {
            if (!_context.RequestForCommonCarnets.Any(e => e.Id == requestForCommonCarnet.Id))
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
