using Collection.APIs;
using Collection.APIs.Common;
using Collection.APIs.Dtos;
using Collection.APIs.Errors;
using Collection.APIs.Extensions;
using Collection.Infrastructure;
using Collection.Infrastructure.Models;
using Microsoft.EntityFrameworkCore;

namespace Collection.APIs;

public abstract class AuctionReportsServiceBase : IAuctionReportsService
{
    protected readonly CollectionDbContext _context;

    public AuctionReportsServiceBase(CollectionDbContext context)
    {
        _context = context;
    }

    /// <summary>
    /// Create one AUCTION REPORT
    /// </summary>
    public async Task<AuctionReport> CreateAuctionReport(AuctionReportCreateInput createDto)
    {
        var auctionReport = new AuctionReportDbModel
        {
            Address = createDto.Address,
            AmountInWords = createDto.AmountInWords,
            AttachedFileId = createDto.AttachedFileId,
            AuctionDate = createDto.AuctionDate,
            AuctionDateAndTime = createDto.AuctionDateAndTime,
            AuctionLocation = createDto.AuctionLocation,
            AuctionValidationOfficerId = createDto.AuctionValidationOfficerId,
            BuyerIdentificationNumber = createDto.BuyerIdentificationNumber,
            BuyerIdentificationTypeCode = createDto.BuyerIdentificationTypeCode,
            BuyerName = createDto.BuyerName,
            CommercialRegisterNumber = createDto.CommercialRegisterNumber,
            ContainerNumber = createDto.ContainerNumber,
            CreatedAt = createDto.CreatedAt,
            DeletionFlag = createDto.DeletionFlag,
            FinalModificationDateAndTime = createDto.FinalModificationDateAndTime,
            FinalModifierId = createDto.FinalModifierId,
            FirstRegistrantId = createDto.FirstRegistrantId,
            FirstRegistrationDateAndTime = createDto.FirstRegistrationDateAndTime,
            InventoryManagementNumber = createDto.InventoryManagementNumber,
            ItemSequenceNumber = createDto.ItemSequenceNumber,
            LotNumber = createDto.LotNumber,
            MerchandiseDescription = createDto.MerchandiseDescription,
            NetProceeds = createDto.NetProceeds,
            OfficeCode = createDto.OfficeCode,
            Quantity = createDto.Quantity,
            ReceiptDate = createDto.ReceiptDate,
            ReceiptNumber = createDto.ReceiptNumber,
            RegistrationDate = createDto.RegistrationDate,
            RegistrationFee = createDto.RegistrationFee,
            RemarksContent = createDto.RemarksContent,
            SaleReportNumber = createDto.SaleReportNumber,
            ServiceCode = createDto.ServiceCode,
            TotalAmount = createDto.TotalAmount,
            UpdatedAt = createDto.UpdatedAt
        };

        if (createDto.Id != null)
        {
            auctionReport.Id = createDto.Id;
        }

        _context.AuctionReports.Add(auctionReport);
        await _context.SaveChangesAsync();

        var result = await _context.FindAsync<AuctionReportDbModel>(auctionReport.Id);

        if (result == null)
        {
            throw new NotFoundException();
        }

        return result.ToDto();
    }

    /// <summary>
    /// Delete one AUCTION REPORT
    /// </summary>
    public async Task DeleteAuctionReport(AuctionReportWhereUniqueInput uniqueId)
    {
        var auctionReport = await _context.AuctionReports.FindAsync(uniqueId.Id);
        if (auctionReport == null)
        {
            throw new NotFoundException();
        }

        _context.AuctionReports.Remove(auctionReport);
        await _context.SaveChangesAsync();
    }

    /// <summary>
    /// Find many AUCTION REPORTS
    /// </summary>
    public async Task<List<AuctionReport>> AuctionReports(AuctionReportFindManyArgs findManyArgs)
    {
        var auctionReports = await _context
            .AuctionReports.ApplyWhere(findManyArgs.Where)
            .ApplySkip(findManyArgs.Skip)
            .ApplyTake(findManyArgs.Take)
            .ApplyOrderBy(findManyArgs.SortBy)
            .ToListAsync();
        return auctionReports.ConvertAll(auctionReport => auctionReport.ToDto());
    }

    /// <summary>
    /// Meta data about AUCTION REPORT records
    /// </summary>
    public async Task<MetadataDto> AuctionReportsMeta(AuctionReportFindManyArgs findManyArgs)
    {
        var count = await _context.AuctionReports.ApplyWhere(findManyArgs.Where).CountAsync();

        return new MetadataDto { Count = count };
    }

    /// <summary>
    /// Get one AUCTION REPORT
    /// </summary>
    public async Task<AuctionReport> AuctionReport(AuctionReportWhereUniqueInput uniqueId)
    {
        var auctionReports = await this.AuctionReports(
            new AuctionReportFindManyArgs
            {
                Where = new AuctionReportWhereInput { Id = uniqueId.Id }
            }
        );
        var auctionReport = auctionReports.FirstOrDefault();
        if (auctionReport == null)
        {
            throw new NotFoundException();
        }

        return auctionReport;
    }

    /// <summary>
    /// Update one AUCTION REPORT
    /// </summary>
    public async Task UpdateAuctionReport(
        AuctionReportWhereUniqueInput uniqueId,
        AuctionReportUpdateInput updateDto
    )
    {
        var auctionReport = updateDto.ToModel(uniqueId);

        _context.Entry(auctionReport).State = EntityState.Modified;

        try
        {
            await _context.SaveChangesAsync();
        }
        catch (DbUpdateConcurrencyException)
        {
            if (!_context.AuctionReports.Any(e => e.Id == auctionReport.Id))
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
