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
        if (createDto.ArticleCarnetRequests != null)
        {
            commonCarnetRequest.ArticleCarnetRequests = await _context
                .ArticleCarnetRequests.Where(articleCarnetRequest =>
                    createDto
                        .ArticleCarnetRequests.Select(t => t.Id)
                        .Contains(articleCarnetRequest.Id)
                )
                .ToListAsync();
        }

        if (createDto.CarnetControls != null)
        {
            commonCarnetRequest.CarnetControls = await _context
                .CarnetControls.Where(carnetControl =>
                    createDto.CarnetControls.Select(t => t.Id).Contains(carnetControl.Id)
                )
                .ToListAsync();
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

        if (createDto.ImportCarnetRequests != null)
        {
            commonCarnetRequest.ImportCarnetRequests = await _context
                .ImportCarnetRequests.Where(importCarnetRequest =>
                    createDto
                        .ImportCarnetRequests.Select(t => t.Id)
                        .Contains(importCarnetRequest.Id)
                )
                .ToListAsync();
        }

        if (createDto.ReexportCarnetRequests != null)
        {
            commonCarnetRequest.ReexportCarnetRequests = await _context
                .ReexportCarnetRequests.Where(reexportCarnetRequest =>
                    createDto
                        .ReexportCarnetRequests.Select(t => t.Id)
                        .Contains(reexportCarnetRequest.Id)
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
            .Include(x => x.ArticleCarnetRequests)
            .Include(x => x.ImportCarnetRequests)
            .Include(x => x.ReexportCarnetRequests)
            .Include(x => x.CarnetControls)
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

        if (updateDto.ArticleCarnetRequests != null)
        {
            commonCarnetRequest.ArticleCarnetRequests = await _context
                .ArticleCarnetRequests.Where(articleCarnetRequest =>
                    updateDto.ArticleCarnetRequests.Select(t => t).Contains(articleCarnetRequest.Id)
                )
                .ToListAsync();
        }

        if (updateDto.ImportCarnetRequests != null)
        {
            commonCarnetRequest.ImportCarnetRequests = await _context
                .ImportCarnetRequests.Where(importCarnetRequest =>
                    updateDto.ImportCarnetRequests.Select(t => t).Contains(importCarnetRequest.Id)
                )
                .ToListAsync();
        }

        if (updateDto.ReexportCarnetRequests != null)
        {
            commonCarnetRequest.ReexportCarnetRequests = await _context
                .ReexportCarnetRequests.Where(reexportCarnetRequest =>
                    updateDto
                        .ReexportCarnetRequests.Select(t => t)
                        .Contains(reexportCarnetRequest.Id)
                )
                .ToListAsync();
        }

        if (updateDto.CarnetControls != null)
        {
            commonCarnetRequest.CarnetControls = await _context
                .CarnetControls.Where(carnetControl =>
                    updateDto.CarnetControls.Select(t => t).Contains(carnetControl.Id)
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
    /// Connect multiple Article Carnet Requests records to Common Carnet Request
    /// </summary>
    public async Task ConnectArticleCarnetRequests(
        CommonCarnetRequestWhereUniqueInput uniqueId,
        ArticleCarnetRequestWhereUniqueInput[] articleCarnetRequestsId
    )
    {
        var parent = await _context
            .CommonCarnetRequests.Include(x => x.ArticleCarnetRequests)
            .FirstOrDefaultAsync(x => x.Id == uniqueId.Id);
        if (parent == null)
        {
            throw new NotFoundException();
        }

        var articleCarnetRequests = await _context
            .ArticleCarnetRequests.Where(t =>
                articleCarnetRequestsId.Select(x => x.Id).Contains(t.Id)
            )
            .ToListAsync();
        if (articleCarnetRequests.Count == 0)
        {
            throw new NotFoundException();
        }

        var articleCarnetRequestsToConnect = articleCarnetRequests.Except(
            parent.ArticleCarnetRequests
        );

        foreach (var articleCarnetRequest in articleCarnetRequestsToConnect)
        {
            parent.ArticleCarnetRequests.Add(articleCarnetRequest);
        }

        await _context.SaveChangesAsync();
    }

    /// <summary>
    /// Disconnect multiple Article Carnet Requests records from Common Carnet Request
    /// </summary>
    public async Task DisconnectArticleCarnetRequests(
        CommonCarnetRequestWhereUniqueInput uniqueId,
        ArticleCarnetRequestWhereUniqueInput[] articleCarnetRequestsId
    )
    {
        var parent = await _context
            .CommonCarnetRequests.Include(x => x.ArticleCarnetRequests)
            .FirstOrDefaultAsync(x => x.Id == uniqueId.Id);
        if (parent == null)
        {
            throw new NotFoundException();
        }

        var articleCarnetRequests = await _context
            .ArticleCarnetRequests.Where(t =>
                articleCarnetRequestsId.Select(x => x.Id).Contains(t.Id)
            )
            .ToListAsync();

        foreach (var articleCarnetRequest in articleCarnetRequests)
        {
            parent.ArticleCarnetRequests?.Remove(articleCarnetRequest);
        }
        await _context.SaveChangesAsync();
    }

    /// <summary>
    /// Find multiple Article Carnet Requests records for Common Carnet Request
    /// </summary>
    public async Task<List<ArticleCarnetRequest>> FindArticleCarnetRequests(
        CommonCarnetRequestWhereUniqueInput uniqueId,
        ArticleCarnetRequestFindManyArgs commonCarnetRequestFindManyArgs
    )
    {
        var articleCarnetRequests = await _context
            .ArticleCarnetRequests.Where(m => m.CommonCarnetRequestId == uniqueId.Id)
            .ApplyWhere(commonCarnetRequestFindManyArgs.Where)
            .ApplySkip(commonCarnetRequestFindManyArgs.Skip)
            .ApplyTake(commonCarnetRequestFindManyArgs.Take)
            .ApplyOrderBy(commonCarnetRequestFindManyArgs.SortBy)
            .ToListAsync();

        return articleCarnetRequests.Select(x => x.ToDto()).ToList();
    }

    /// <summary>
    /// Update multiple Article Carnet Requests records for Common Carnet Request
    /// </summary>
    public async Task UpdateArticleCarnetRequests(
        CommonCarnetRequestWhereUniqueInput uniqueId,
        ArticleCarnetRequestWhereUniqueInput[] articleCarnetRequestsId
    )
    {
        var commonCarnetRequest = await _context
            .CommonCarnetRequests.Include(t => t.ArticleCarnetRequests)
            .FirstOrDefaultAsync(x => x.Id == uniqueId.Id);
        if (commonCarnetRequest == null)
        {
            throw new NotFoundException();
        }

        var articleCarnetRequests = await _context
            .ArticleCarnetRequests.Where(a =>
                articleCarnetRequestsId.Select(x => x.Id).Contains(a.Id)
            )
            .ToListAsync();

        if (articleCarnetRequests.Count == 0)
        {
            throw new NotFoundException();
        }

        commonCarnetRequest.ArticleCarnetRequests = articleCarnetRequests;
        await _context.SaveChangesAsync();
    }

    /// <summary>
    /// Connect multiple CarnetControls records to Common Carnet Request
    /// </summary>
    public async Task ConnectCarnetControls(
        CommonCarnetRequestWhereUniqueInput uniqueId,
        CarnetControlWhereUniqueInput[] carnetControlsId
    )
    {
        var parent = await _context
            .CommonCarnetRequests.Include(x => x.CarnetControls)
            .FirstOrDefaultAsync(x => x.Id == uniqueId.Id);
        if (parent == null)
        {
            throw new NotFoundException();
        }

        var carnetControls = await _context
            .CarnetControls.Where(t => carnetControlsId.Select(x => x.Id).Contains(t.Id))
            .ToListAsync();
        if (carnetControls.Count == 0)
        {
            throw new NotFoundException();
        }

        var carnetControlsToConnect = carnetControls.Except(parent.CarnetControls);

        foreach (var carnetControl in carnetControlsToConnect)
        {
            parent.CarnetControls.Add(carnetControl);
        }

        await _context.SaveChangesAsync();
    }

    /// <summary>
    /// Disconnect multiple CarnetControls records from Common Carnet Request
    /// </summary>
    public async Task DisconnectCarnetControls(
        CommonCarnetRequestWhereUniqueInput uniqueId,
        CarnetControlWhereUniqueInput[] carnetControlsId
    )
    {
        var parent = await _context
            .CommonCarnetRequests.Include(x => x.CarnetControls)
            .FirstOrDefaultAsync(x => x.Id == uniqueId.Id);
        if (parent == null)
        {
            throw new NotFoundException();
        }

        var carnetControls = await _context
            .CarnetControls.Where(t => carnetControlsId.Select(x => x.Id).Contains(t.Id))
            .ToListAsync();

        foreach (var carnetControl in carnetControls)
        {
            parent.CarnetControls?.Remove(carnetControl);
        }
        await _context.SaveChangesAsync();
    }

    /// <summary>
    /// Find multiple CarnetControls records for Common Carnet Request
    /// </summary>
    public async Task<List<CarnetControl>> FindCarnetControls(
        CommonCarnetRequestWhereUniqueInput uniqueId,
        CarnetControlFindManyArgs commonCarnetRequestFindManyArgs
    )
    {
        var carnetControls = await _context
            .CarnetControls.Where(m => m.CommonCarnetRequestId == uniqueId.Id)
            .ApplyWhere(commonCarnetRequestFindManyArgs.Where)
            .ApplySkip(commonCarnetRequestFindManyArgs.Skip)
            .ApplyTake(commonCarnetRequestFindManyArgs.Take)
            .ApplyOrderBy(commonCarnetRequestFindManyArgs.SortBy)
            .ToListAsync();

        return carnetControls.Select(x => x.ToDto()).ToList();
    }

    /// <summary>
    /// Update multiple CarnetControls records for Common Carnet Request
    /// </summary>
    public async Task UpdateCarnetControls(
        CommonCarnetRequestWhereUniqueInput uniqueId,
        CarnetControlWhereUniqueInput[] carnetControlsId
    )
    {
        var commonCarnetRequest = await _context
            .CommonCarnetRequests.Include(t => t.CarnetControls)
            .FirstOrDefaultAsync(x => x.Id == uniqueId.Id);
        if (commonCarnetRequest == null)
        {
            throw new NotFoundException();
        }

        var carnetControls = await _context
            .CarnetControls.Where(a => carnetControlsId.Select(x => x.Id).Contains(a.Id))
            .ToListAsync();

        if (carnetControls.Count == 0)
        {
            throw new NotFoundException();
        }

        commonCarnetRequest.CarnetControls = carnetControls;
        await _context.SaveChangesAsync();
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
    /// Connect multiple Import Carnet Requests records to Common Carnet Request
    /// </summary>
    public async Task ConnectImportCarnetRequests(
        CommonCarnetRequestWhereUniqueInput uniqueId,
        ImportCarnetRequestWhereUniqueInput[] importCarnetRequestsId
    )
    {
        var parent = await _context
            .CommonCarnetRequests.Include(x => x.ImportCarnetRequests)
            .FirstOrDefaultAsync(x => x.Id == uniqueId.Id);
        if (parent == null)
        {
            throw new NotFoundException();
        }

        var importCarnetRequests = await _context
            .ImportCarnetRequests.Where(t =>
                importCarnetRequestsId.Select(x => x.Id).Contains(t.Id)
            )
            .ToListAsync();
        if (importCarnetRequests.Count == 0)
        {
            throw new NotFoundException();
        }

        var importCarnetRequestsToConnect = importCarnetRequests.Except(
            parent.ImportCarnetRequests
        );

        foreach (var importCarnetRequest in importCarnetRequestsToConnect)
        {
            parent.ImportCarnetRequests.Add(importCarnetRequest);
        }

        await _context.SaveChangesAsync();
    }

    /// <summary>
    /// Disconnect multiple Import Carnet Requests records from Common Carnet Request
    /// </summary>
    public async Task DisconnectImportCarnetRequests(
        CommonCarnetRequestWhereUniqueInput uniqueId,
        ImportCarnetRequestWhereUniqueInput[] importCarnetRequestsId
    )
    {
        var parent = await _context
            .CommonCarnetRequests.Include(x => x.ImportCarnetRequests)
            .FirstOrDefaultAsync(x => x.Id == uniqueId.Id);
        if (parent == null)
        {
            throw new NotFoundException();
        }

        var importCarnetRequests = await _context
            .ImportCarnetRequests.Where(t =>
                importCarnetRequestsId.Select(x => x.Id).Contains(t.Id)
            )
            .ToListAsync();

        foreach (var importCarnetRequest in importCarnetRequests)
        {
            parent.ImportCarnetRequests?.Remove(importCarnetRequest);
        }
        await _context.SaveChangesAsync();
    }

    /// <summary>
    /// Find multiple Import Carnet Requests records for Common Carnet Request
    /// </summary>
    public async Task<List<ImportCarnetRequest>> FindImportCarnetRequests(
        CommonCarnetRequestWhereUniqueInput uniqueId,
        ImportCarnetRequestFindManyArgs commonCarnetRequestFindManyArgs
    )
    {
        var importCarnetRequests = await _context
            .ImportCarnetRequests.Where(m => m.CommonCarnetRequestId == uniqueId.Id)
            .ApplyWhere(commonCarnetRequestFindManyArgs.Where)
            .ApplySkip(commonCarnetRequestFindManyArgs.Skip)
            .ApplyTake(commonCarnetRequestFindManyArgs.Take)
            .ApplyOrderBy(commonCarnetRequestFindManyArgs.SortBy)
            .ToListAsync();

        return importCarnetRequests.Select(x => x.ToDto()).ToList();
    }

    /// <summary>
    /// Update multiple Import Carnet Requests records for Common Carnet Request
    /// </summary>
    public async Task UpdateImportCarnetRequests(
        CommonCarnetRequestWhereUniqueInput uniqueId,
        ImportCarnetRequestWhereUniqueInput[] importCarnetRequestsId
    )
    {
        var commonCarnetRequest = await _context
            .CommonCarnetRequests.Include(t => t.ImportCarnetRequests)
            .FirstOrDefaultAsync(x => x.Id == uniqueId.Id);
        if (commonCarnetRequest == null)
        {
            throw new NotFoundException();
        }

        var importCarnetRequests = await _context
            .ImportCarnetRequests.Where(a =>
                importCarnetRequestsId.Select(x => x.Id).Contains(a.Id)
            )
            .ToListAsync();

        if (importCarnetRequests.Count == 0)
        {
            throw new NotFoundException();
        }

        commonCarnetRequest.ImportCarnetRequests = importCarnetRequests;
        await _context.SaveChangesAsync();
    }

    /// <summary>
    /// Connect multiple Reexport Carnet Requests records to Common Carnet Request
    /// </summary>
    public async Task ConnectReexportCarnetRequests(
        CommonCarnetRequestWhereUniqueInput uniqueId,
        ReexportCarnetRequestWhereUniqueInput[] reexportCarnetRequestsId
    )
    {
        var parent = await _context
            .CommonCarnetRequests.Include(x => x.ReexportCarnetRequests)
            .FirstOrDefaultAsync(x => x.Id == uniqueId.Id);
        if (parent == null)
        {
            throw new NotFoundException();
        }

        var reexportCarnetRequests = await _context
            .ReexportCarnetRequests.Where(t =>
                reexportCarnetRequestsId.Select(x => x.Id).Contains(t.Id)
            )
            .ToListAsync();
        if (reexportCarnetRequests.Count == 0)
        {
            throw new NotFoundException();
        }

        var reexportCarnetRequestsToConnect = reexportCarnetRequests.Except(
            parent.ReexportCarnetRequests
        );

        foreach (var reexportCarnetRequest in reexportCarnetRequestsToConnect)
        {
            parent.ReexportCarnetRequests.Add(reexportCarnetRequest);
        }

        await _context.SaveChangesAsync();
    }

    /// <summary>
    /// Disconnect multiple Reexport Carnet Requests records from Common Carnet Request
    /// </summary>
    public async Task DisconnectReexportCarnetRequests(
        CommonCarnetRequestWhereUniqueInput uniqueId,
        ReexportCarnetRequestWhereUniqueInput[] reexportCarnetRequestsId
    )
    {
        var parent = await _context
            .CommonCarnetRequests.Include(x => x.ReexportCarnetRequests)
            .FirstOrDefaultAsync(x => x.Id == uniqueId.Id);
        if (parent == null)
        {
            throw new NotFoundException();
        }

        var reexportCarnetRequests = await _context
            .ReexportCarnetRequests.Where(t =>
                reexportCarnetRequestsId.Select(x => x.Id).Contains(t.Id)
            )
            .ToListAsync();

        foreach (var reexportCarnetRequest in reexportCarnetRequests)
        {
            parent.ReexportCarnetRequests?.Remove(reexportCarnetRequest);
        }
        await _context.SaveChangesAsync();
    }

    /// <summary>
    /// Find multiple Reexport Carnet Requests records for Common Carnet Request
    /// </summary>
    public async Task<List<ReexportCarnetRequest>> FindReexportCarnetRequests(
        CommonCarnetRequestWhereUniqueInput uniqueId,
        ReexportCarnetRequestFindManyArgs commonCarnetRequestFindManyArgs
    )
    {
        var reexportCarnetRequests = await _context
            .ReexportCarnetRequests.Where(m => m.CommonCarnetRequestId == uniqueId.Id)
            .ApplyWhere(commonCarnetRequestFindManyArgs.Where)
            .ApplySkip(commonCarnetRequestFindManyArgs.Skip)
            .ApplyTake(commonCarnetRequestFindManyArgs.Take)
            .ApplyOrderBy(commonCarnetRequestFindManyArgs.SortBy)
            .ToListAsync();

        return reexportCarnetRequests.Select(x => x.ToDto()).ToList();
    }

    /// <summary>
    /// Update multiple Reexport Carnet Requests records for Common Carnet Request
    /// </summary>
    public async Task UpdateReexportCarnetRequests(
        CommonCarnetRequestWhereUniqueInput uniqueId,
        ReexportCarnetRequestWhereUniqueInput[] reexportCarnetRequestsId
    )
    {
        var commonCarnetRequest = await _context
            .CommonCarnetRequests.Include(t => t.ReexportCarnetRequests)
            .FirstOrDefaultAsync(x => x.Id == uniqueId.Id);
        if (commonCarnetRequest == null)
        {
            throw new NotFoundException();
        }

        var reexportCarnetRequests = await _context
            .ReexportCarnetRequests.Where(a =>
                reexportCarnetRequestsId.Select(x => x.Id).Contains(a.Id)
            )
            .ToListAsync();

        if (reexportCarnetRequests.Count == 0)
        {
            throw new NotFoundException();
        }

        commonCarnetRequest.ReexportCarnetRequests = reexportCarnetRequests;
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
