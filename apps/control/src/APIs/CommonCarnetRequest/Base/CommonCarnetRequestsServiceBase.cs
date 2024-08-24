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
        if (createDto.ExtendedPeriodCarnetRequests != null)
        {
            commonCarnetRequest.ExtendedPeriodCarnetRequests = await _context
                .ExtendedPeriodCarnetRequests.Where(extendedPeriodCarnetRequest =>
                    createDto
                        .ExtendedPeriodCarnetRequests.Select(t => t.Id)
                        .Contains(extendedPeriodCarnetRequest.Id)
                )
                .ToListAsync();
        }

        if (createDto.TransitCarnetRequests != null)
        {
            commonCarnetRequest.TransitCarnetRequests = await _context
                .TransitCarnetRequests.Where(transitCarnetRequest =>
                    createDto
                        .TransitCarnetRequests.Select(t => t.Id)
                        .Contains(transitCarnetRequest.Id)
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
            .CommonCarnetRequests.Include(x => x.ExtendedPeriodCarnetRequests)
            .Include(x => x.TransitCarnetRequests)
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

        if (updateDto.ExtendedPeriodCarnetRequests != null)
        {
            commonCarnetRequest.ExtendedPeriodCarnetRequests = await _context
                .ExtendedPeriodCarnetRequests.Where(extendedPeriodCarnetRequest =>
                    updateDto
                        .ExtendedPeriodCarnetRequests.Select(t => t)
                        .Contains(extendedPeriodCarnetRequest.Id)
                )
                .ToListAsync();
        }

        if (updateDto.TransitCarnetRequests != null)
        {
            commonCarnetRequest.TransitCarnetRequests = await _context
                .TransitCarnetRequests.Where(transitCarnetRequest =>
                    updateDto.TransitCarnetRequests.Select(t => t).Contains(transitCarnetRequest.Id)
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
    /// Connect multiple Extended Period Carnet Requests records to Common Carnet Request
    /// </summary>
    public async Task ConnectExtendedPeriodCarnetRequests(
        CommonCarnetRequestWhereUniqueInput uniqueId,
        ExtendedPeriodCarnetRequestWhereUniqueInput[] extendedPeriodCarnetRequestsId
    )
    {
        var parent = await _context
            .CommonCarnetRequests.Include(x => x.ExtendedPeriodCarnetRequests)
            .FirstOrDefaultAsync(x => x.Id == uniqueId.Id);
        if (parent == null)
        {
            throw new NotFoundException();
        }

        var extendedPeriodCarnetRequests = await _context
            .ExtendedPeriodCarnetRequests.Where(t =>
                extendedPeriodCarnetRequestsId.Select(x => x.Id).Contains(t.Id)
            )
            .ToListAsync();
        if (extendedPeriodCarnetRequests.Count == 0)
        {
            throw new NotFoundException();
        }

        var extendedPeriodCarnetRequestsToConnect = extendedPeriodCarnetRequests.Except(
            parent.ExtendedPeriodCarnetRequests
        );

        foreach (var extendedPeriodCarnetRequest in extendedPeriodCarnetRequestsToConnect)
        {
            parent.ExtendedPeriodCarnetRequests.Add(extendedPeriodCarnetRequest);
        }

        await _context.SaveChangesAsync();
    }

    /// <summary>
    /// Disconnect multiple Extended Period Carnet Requests records from Common Carnet Request
    /// </summary>
    public async Task DisconnectExtendedPeriodCarnetRequests(
        CommonCarnetRequestWhereUniqueInput uniqueId,
        ExtendedPeriodCarnetRequestWhereUniqueInput[] extendedPeriodCarnetRequestsId
    )
    {
        var parent = await _context
            .CommonCarnetRequests.Include(x => x.ExtendedPeriodCarnetRequests)
            .FirstOrDefaultAsync(x => x.Id == uniqueId.Id);
        if (parent == null)
        {
            throw new NotFoundException();
        }

        var extendedPeriodCarnetRequests = await _context
            .ExtendedPeriodCarnetRequests.Where(t =>
                extendedPeriodCarnetRequestsId.Select(x => x.Id).Contains(t.Id)
            )
            .ToListAsync();

        foreach (var extendedPeriodCarnetRequest in extendedPeriodCarnetRequests)
        {
            parent.ExtendedPeriodCarnetRequests?.Remove(extendedPeriodCarnetRequest);
        }
        await _context.SaveChangesAsync();
    }

    /// <summary>
    /// Find multiple Extended Period Carnet Requests records for Common Carnet Request
    /// </summary>
    public async Task<List<ExtendedPeriodCarnetRequest>> FindExtendedPeriodCarnetRequests(
        CommonCarnetRequestWhereUniqueInput uniqueId,
        ExtendedPeriodCarnetRequestFindManyArgs commonCarnetRequestFindManyArgs
    )
    {
        var extendedPeriodCarnetRequests = await _context
            .ExtendedPeriodCarnetRequests.Where(m => m.CommonCarnetRequestId == uniqueId.Id)
            .ApplyWhere(commonCarnetRequestFindManyArgs.Where)
            .ApplySkip(commonCarnetRequestFindManyArgs.Skip)
            .ApplyTake(commonCarnetRequestFindManyArgs.Take)
            .ApplyOrderBy(commonCarnetRequestFindManyArgs.SortBy)
            .ToListAsync();

        return extendedPeriodCarnetRequests.Select(x => x.ToDto()).ToList();
    }

    /// <summary>
    /// Update multiple Extended Period Carnet Requests records for Common Carnet Request
    /// </summary>
    public async Task UpdateExtendedPeriodCarnetRequests(
        CommonCarnetRequestWhereUniqueInput uniqueId,
        ExtendedPeriodCarnetRequestWhereUniqueInput[] extendedPeriodCarnetRequestsId
    )
    {
        var commonCarnetRequest = await _context
            .CommonCarnetRequests.Include(t => t.ExtendedPeriodCarnetRequests)
            .FirstOrDefaultAsync(x => x.Id == uniqueId.Id);
        if (commonCarnetRequest == null)
        {
            throw new NotFoundException();
        }

        var extendedPeriodCarnetRequests = await _context
            .ExtendedPeriodCarnetRequests.Where(a =>
                extendedPeriodCarnetRequestsId.Select(x => x.Id).Contains(a.Id)
            )
            .ToListAsync();

        if (extendedPeriodCarnetRequests.Count == 0)
        {
            throw new NotFoundException();
        }

        commonCarnetRequest.ExtendedPeriodCarnetRequests = extendedPeriodCarnetRequests;
        await _context.SaveChangesAsync();
    }

    /// <summary>
    /// Connect multiple Transit Carnet Requests records to Common Carnet Request
    /// </summary>
    public async Task ConnectTransitCarnetRequests(
        CommonCarnetRequestWhereUniqueInput uniqueId,
        TransitCarnetRequestWhereUniqueInput[] transitCarnetRequestsId
    )
    {
        var parent = await _context
            .CommonCarnetRequests.Include(x => x.TransitCarnetRequests)
            .FirstOrDefaultAsync(x => x.Id == uniqueId.Id);
        if (parent == null)
        {
            throw new NotFoundException();
        }

        var transitCarnetRequests = await _context
            .TransitCarnetRequests.Where(t =>
                transitCarnetRequestsId.Select(x => x.Id).Contains(t.Id)
            )
            .ToListAsync();
        if (transitCarnetRequests.Count == 0)
        {
            throw new NotFoundException();
        }

        var transitCarnetRequestsToConnect = transitCarnetRequests.Except(
            parent.TransitCarnetRequests
        );

        foreach (var transitCarnetRequest in transitCarnetRequestsToConnect)
        {
            parent.TransitCarnetRequests.Add(transitCarnetRequest);
        }

        await _context.SaveChangesAsync();
    }

    /// <summary>
    /// Disconnect multiple Transit Carnet Requests records from Common Carnet Request
    /// </summary>
    public async Task DisconnectTransitCarnetRequests(
        CommonCarnetRequestWhereUniqueInput uniqueId,
        TransitCarnetRequestWhereUniqueInput[] transitCarnetRequestsId
    )
    {
        var parent = await _context
            .CommonCarnetRequests.Include(x => x.TransitCarnetRequests)
            .FirstOrDefaultAsync(x => x.Id == uniqueId.Id);
        if (parent == null)
        {
            throw new NotFoundException();
        }

        var transitCarnetRequests = await _context
            .TransitCarnetRequests.Where(t =>
                transitCarnetRequestsId.Select(x => x.Id).Contains(t.Id)
            )
            .ToListAsync();

        foreach (var transitCarnetRequest in transitCarnetRequests)
        {
            parent.TransitCarnetRequests?.Remove(transitCarnetRequest);
        }
        await _context.SaveChangesAsync();
    }

    /// <summary>
    /// Find multiple Transit Carnet Requests records for Common Carnet Request
    /// </summary>
    public async Task<List<TransitCarnetRequest>> FindTransitCarnetRequests(
        CommonCarnetRequestWhereUniqueInput uniqueId,
        TransitCarnetRequestFindManyArgs commonCarnetRequestFindManyArgs
    )
    {
        var transitCarnetRequests = await _context
            .TransitCarnetRequests.Where(m => m.CommonCarnetRequestId == uniqueId.Id)
            .ApplyWhere(commonCarnetRequestFindManyArgs.Where)
            .ApplySkip(commonCarnetRequestFindManyArgs.Skip)
            .ApplyTake(commonCarnetRequestFindManyArgs.Take)
            .ApplyOrderBy(commonCarnetRequestFindManyArgs.SortBy)
            .ToListAsync();

        return transitCarnetRequests.Select(x => x.ToDto()).ToList();
    }

    /// <summary>
    /// Update multiple Transit Carnet Requests records for Common Carnet Request
    /// </summary>
    public async Task UpdateTransitCarnetRequests(
        CommonCarnetRequestWhereUniqueInput uniqueId,
        TransitCarnetRequestWhereUniqueInput[] transitCarnetRequestsId
    )
    {
        var commonCarnetRequest = await _context
            .CommonCarnetRequests.Include(t => t.TransitCarnetRequests)
            .FirstOrDefaultAsync(x => x.Id == uniqueId.Id);
        if (commonCarnetRequest == null)
        {
            throw new NotFoundException();
        }

        var transitCarnetRequests = await _context
            .TransitCarnetRequests.Where(a =>
                transitCarnetRequestsId.Select(x => x.Id).Contains(a.Id)
            )
            .ToListAsync();

        if (transitCarnetRequests.Count == 0)
        {
            throw new NotFoundException();
        }

        commonCarnetRequest.TransitCarnetRequests = transitCarnetRequests;
        await _context.SaveChangesAsync();
    }
}
