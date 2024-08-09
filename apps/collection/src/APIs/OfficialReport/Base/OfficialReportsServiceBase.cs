using Collection.APIs;
using Collection.APIs.Common;
using Collection.APIs.Dtos;
using Collection.APIs.Errors;
using Collection.APIs.Extensions;
using Collection.Infrastructure;
using Collection.Infrastructure.Models;
using Microsoft.EntityFrameworkCore;

namespace Collection.APIs;

public abstract class OfficialReportsServiceBase : IOfficialReportsService
{
    protected readonly CollectionDbContext _context;

    public OfficialReportsServiceBase(CollectionDbContext context)
    {
        _context = context;
    }

    /// <summary>
    /// Create one OFFICIAL REPORT
    /// </summary>
    public async Task<OfficialReport> CreateOfficialReport(OfficialReportCreateInput createDto)
    {
        var officialReport = new OfficialReportDbModel
        {
            AccountingMaterialManagementNumber = createDto.AccountingMaterialManagementNumber,
            Address = createDto.Address,
            AdjudicatorIdentificationNumber = createDto.AdjudicatorIdentificationNumber,
            AdjudicatorIdentificationNumberTypeCode =
                createDto.AdjudicatorIdentificationNumberTypeCode,
            AdjudicatorSName = createDto.AdjudicatorSName,
            AlienationDate = createDto.AlienationDate,
            AttachedFileId = createDto.AttachedFileId,
            CreatedAt = createDto.CreatedAt,
            DecisionOfAssignmentNumber = createDto.DecisionOfAssignmentNumber,
            DeletionFlag = createDto.DeletionFlag,
            FinalModificationDateAndTime = createDto.FinalModificationDateAndTime,
            FinalModifierId = createDto.FinalModifierId,
            FirstRegistrantId = createDto.FirstRegistrantId,
            FirstRegistrationDateAndTime = createDto.FirstRegistrationDateAndTime,
            ItemSequenceNumber = createDto.ItemSequenceNumber,
            MinutesOfDefaultNumber = createDto.MinutesOfDefaultNumber,
            MinutesOfDefaultTypeCode = createDto.MinutesOfDefaultTypeCode,
            OfficeCode = createDto.OfficeCode,
            ReasonsForDefault = createDto.ReasonsForDefault,
            ReceiverId = createDto.ReceiverId,
            ReferenceNumber = createDto.ReferenceNumber,
            ReferenceNumberTypeCode = createDto.ReferenceNumberTypeCode,
            ReferenceNumberTypeName = createDto.ReferenceNumberTypeName,
            RegistrationDate = createDto.RegistrationDate,
            ServiceCode = createDto.ServiceCode,
            UpdatedAt = createDto.UpdatedAt
        };

        if (createDto.Id != null)
        {
            officialReport.Id = createDto.Id;
        }

        _context.OfficialReports.Add(officialReport);
        await _context.SaveChangesAsync();

        var result = await _context.FindAsync<OfficialReportDbModel>(officialReport.Id);

        if (result == null)
        {
            throw new NotFoundException();
        }

        return result.ToDto();
    }

    /// <summary>
    /// Delete one OFFICIAL REPORT
    /// </summary>
    public async Task DeleteOfficialReport(OfficialReportWhereUniqueInput uniqueId)
    {
        var officialReport = await _context.OfficialReports.FindAsync(uniqueId.Id);
        if (officialReport == null)
        {
            throw new NotFoundException();
        }

        _context.OfficialReports.Remove(officialReport);
        await _context.SaveChangesAsync();
    }

    /// <summary>
    /// Find many OFFICIAL REPORTS
    /// </summary>
    public async Task<List<OfficialReport>> OfficialReports(OfficialReportFindManyArgs findManyArgs)
    {
        var officialReports = await _context
            .OfficialReports.ApplyWhere(findManyArgs.Where)
            .ApplySkip(findManyArgs.Skip)
            .ApplyTake(findManyArgs.Take)
            .ApplyOrderBy(findManyArgs.SortBy)
            .ToListAsync();
        return officialReports.ConvertAll(officialReport => officialReport.ToDto());
    }

    /// <summary>
    /// Meta data about OFFICIAL REPORT records
    /// </summary>
    public async Task<MetadataDto> OfficialReportsMeta(OfficialReportFindManyArgs findManyArgs)
    {
        var count = await _context.OfficialReports.ApplyWhere(findManyArgs.Where).CountAsync();

        return new MetadataDto { Count = count };
    }

    /// <summary>
    /// Get one OFFICIAL REPORT
    /// </summary>
    public async Task<OfficialReport> OfficialReport(OfficialReportWhereUniqueInput uniqueId)
    {
        var officialReports = await this.OfficialReports(
            new OfficialReportFindManyArgs
            {
                Where = new OfficialReportWhereInput { Id = uniqueId.Id }
            }
        );
        var officialReport = officialReports.FirstOrDefault();
        if (officialReport == null)
        {
            throw new NotFoundException();
        }

        return officialReport;
    }

    /// <summary>
    /// Update one OFFICIAL REPORT
    /// </summary>
    public async Task UpdateOfficialReport(
        OfficialReportWhereUniqueInput uniqueId,
        OfficialReportUpdateInput updateDto
    )
    {
        var officialReport = updateDto.ToModel(uniqueId);

        _context.Entry(officialReport).State = EntityState.Modified;

        try
        {
            await _context.SaveChangesAsync();
        }
        catch (DbUpdateConcurrencyException)
        {
            if (!_context.OfficialReports.Any(e => e.Id == officialReport.Id))
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
