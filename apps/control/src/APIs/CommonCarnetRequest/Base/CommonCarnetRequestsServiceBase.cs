using Control.APIs;
using Control.APIs.Common;
using Control.APIs.Dtos;
using Control.APIs.Errors;
using Control.APIs.Extensions;
using Control.Infrastructure;
using Control.Infrastructure.Models;
using Microsoft.EntityFrameworkCore;

namespace Control.APIs;

public abstract class CommonCarnetRequestsServiceBase : ICommonCarnetRequestsService
{
    protected readonly ControlDbContext _context;

    public CommonCarnetRequestsServiceBase(ControlDbContext context)
    {
        _context = context;
    }

    /// <summary>
    /// Create one Common Carnet Request
    /// </summary>
    public async Task<CommonCarnetRequest> CreateCommonCarnetRequest(
        CommonCarnetRequestCreateInput createDto
    )
    {
        var commonCarnetRequest = new CommonCarnetRequestDbModel
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
            commonCarnetRequest.Id = createDto.Id;
        }
        if (createDto.CarnetRequests != null)
        {
            commonCarnetRequest.CarnetRequests = await _context
                .CarnetRequests.Where(carnetRequest =>
                    createDto.CarnetRequests.Select(t => t.Id).Contains(carnetRequest.Id)
                )
                .ToListAsync();
        }

        _context.CommonCarnetRequests.Add(commonCarnetRequest);
        await _context.SaveChangesAsync();

        var result = await _context.FindAsync<CommonCarnetRequestDbModel>(commonCarnetRequest.Id);

        if (result == null)
        {
            throw new NotFoundException();
        }

        return result.ToDto();
    }

    /// <summary>
    /// Delete one Common Carnet Request
    /// </summary>
    public async Task DeleteCommonCarnetRequest(CommonCarnetRequestWhereUniqueInput uniqueId)
    {
        var commonCarnetRequest = await _context.CommonCarnetRequests.FindAsync(uniqueId.Id);
        if (commonCarnetRequest == null)
        {
            throw new NotFoundException();
        }

        _context.CommonCarnetRequests.Remove(commonCarnetRequest);
        await _context.SaveChangesAsync();
    }

    /// <summary>
    /// Find many Common Carnet Requests
    /// </summary>
    public async Task<List<CommonCarnetRequest>> CommonCarnetRequests(
        CommonCarnetRequestFindManyArgs findManyArgs
    )
    {
        var commonCarnetRequests = await _context
            .CommonCarnetRequests.Include(x => x.CarnetRequests)
            .ApplyWhere(findManyArgs.Where)
            .ApplySkip(findManyArgs.Skip)
            .ApplyTake(findManyArgs.Take)
            .ApplyOrderBy(findManyArgs.SortBy)
            .ToListAsync();
        return commonCarnetRequests.ConvertAll(commonCarnetRequest => commonCarnetRequest.ToDto());
    }

    /// <summary>
    /// Meta data about Common Carnet Request records
    /// </summary>
    public async Task<MetadataDto> CommonCarnetRequestsMeta(
        CommonCarnetRequestFindManyArgs findManyArgs
    )
    {
        var count = await _context.CommonCarnetRequests.ApplyWhere(findManyArgs.Where).CountAsync();

        return new MetadataDto { Count = count };
    }

    /// <summary>
    /// Get one Common Carnet Request
    /// </summary>
    public async Task<CommonCarnetRequest> CommonCarnetRequest(
        CommonCarnetRequestWhereUniqueInput uniqueId
    )
    {
        var commonCarnetRequests = await this.CommonCarnetRequests(
            new CommonCarnetRequestFindManyArgs
            {
                Where = new CommonCarnetRequestWhereInput { Id = uniqueId.Id }
            }
        );
        var commonCarnetRequest = commonCarnetRequests.FirstOrDefault();
        if (commonCarnetRequest == null)
        {
            throw new NotFoundException();
        }

        return commonCarnetRequest;
    }

    /// <summary>
    /// Update one Common Carnet Request
    /// </summary>
    public async Task UpdateCommonCarnetRequest(
        CommonCarnetRequestWhereUniqueInput uniqueId,
        CommonCarnetRequestUpdateInput updateDto
    )
    {
        var commonCarnetRequest = updateDto.ToModel(uniqueId);

        if (updateDto.CarnetRequests != null)
        {
            commonCarnetRequest.CarnetRequests = await _context
                .CarnetRequests.Where(carnetRequest =>
                    updateDto.CarnetRequests.Select(t => t).Contains(carnetRequest.Id)
                )
                .ToListAsync();
        }

        _context.Entry(commonCarnetRequest).State = EntityState.Modified;

        try
        {
            await _context.SaveChangesAsync();
        }
        catch (DbUpdateConcurrencyException)
        {
            if (!_context.CommonCarnetRequests.Any(e => e.Id == commonCarnetRequest.Id))
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
    /// Connect multiple Carnet Requests records to Common Carnet Request
    /// </summary>
    public async Task ConnectCarnetRequests(
        CommonCarnetRequestWhereUniqueInput uniqueId,
        CarnetRequestWhereUniqueInput[] carnetRequestsId
    )
    {
        var parent = await _context
            .CommonCarnetRequests.Include(x => x.CarnetRequests)
            .FirstOrDefaultAsync(x => x.Id == uniqueId.Id);
        if (parent == null)
        {
            throw new NotFoundException();
        }

        var carnetRequests = await _context
            .CarnetRequests.Where(t => carnetRequestsId.Select(x => x.Id).Contains(t.Id))
            .ToListAsync();
        if (carnetRequests.Count == 0)
        {
            throw new NotFoundException();
        }

        var carnetRequestsToConnect = carnetRequests.Except(parent.CarnetRequests);

        foreach (var carnetRequest in carnetRequestsToConnect)
        {
            parent.CarnetRequests.Add(carnetRequest);
        }

        await _context.SaveChangesAsync();
    }

    /// <summary>
    /// Disconnect multiple Carnet Requests records from Common Carnet Request
    /// </summary>
    public async Task DisconnectCarnetRequests(
        CommonCarnetRequestWhereUniqueInput uniqueId,
        CarnetRequestWhereUniqueInput[] carnetRequestsId
    )
    {
        var parent = await _context
            .CommonCarnetRequests.Include(x => x.CarnetRequests)
            .FirstOrDefaultAsync(x => x.Id == uniqueId.Id);
        if (parent == null)
        {
            throw new NotFoundException();
        }

        var carnetRequests = await _context
            .CarnetRequests.Where(t => carnetRequestsId.Select(x => x.Id).Contains(t.Id))
            .ToListAsync();

        foreach (var carnetRequest in carnetRequests)
        {
            parent.CarnetRequests?.Remove(carnetRequest);
        }
        await _context.SaveChangesAsync();
    }

    /// <summary>
    /// Find multiple Carnet Requests records for Common Carnet Request
    /// </summary>
    public async Task<List<CarnetRequest>> FindCarnetRequests(
        CommonCarnetRequestWhereUniqueInput uniqueId,
        CarnetRequestFindManyArgs commonCarnetRequestFindManyArgs
    )
    {
        var carnetRequests = await _context
            .CarnetRequests.Where(m => m.CommonCarnetRequestId == uniqueId.Id)
            .ApplyWhere(commonCarnetRequestFindManyArgs.Where)
            .ApplySkip(commonCarnetRequestFindManyArgs.Skip)
            .ApplyTake(commonCarnetRequestFindManyArgs.Take)
            .ApplyOrderBy(commonCarnetRequestFindManyArgs.SortBy)
            .ToListAsync();

        return carnetRequests.Select(x => x.ToDto()).ToList();
    }

    /// <summary>
    /// Update multiple Carnet Requests records for Common Carnet Request
    /// </summary>
    public async Task UpdateCarnetRequests(
        CommonCarnetRequestWhereUniqueInput uniqueId,
        CarnetRequestWhereUniqueInput[] carnetRequestsId
    )
    {
        var commonCarnetRequest = await _context
            .CommonCarnetRequests.Include(t => t.CarnetRequests)
            .FirstOrDefaultAsync(x => x.Id == uniqueId.Id);
        if (commonCarnetRequest == null)
        {
            throw new NotFoundException();
        }

        var carnetRequests = await _context
            .CarnetRequests.Where(a => carnetRequestsId.Select(x => x.Id).Contains(a.Id))
            .ToListAsync();

        if (carnetRequests.Count == 0)
        {
            throw new NotFoundException();
        }

        commonCarnetRequest.CarnetRequests = carnetRequests;
        await _context.SaveChangesAsync();
    }
}
