using Collection.APIs.Common;
using Collection.APIs.Dtos;

namespace Collection.APIs;

public interface IOfficialReportsService
{
    /// <summary>
    /// Create one OFFICIAL REPORT
    /// </summary>
    public Task<OfficialReport> CreateOfficialReport(OfficialReportCreateInput officialreport);

    /// <summary>
    /// Delete one OFFICIAL REPORT
    /// </summary>
    public Task DeleteOfficialReport(OfficialReportWhereUniqueInput uniqueId);

    /// <summary>
    /// Find many OFFICIAL REPORTS
    /// </summary>
    public Task<List<OfficialReport>> OfficialReports(OfficialReportFindManyArgs findManyArgs);

    /// <summary>
    /// Meta data about OFFICIAL REPORT records
    /// </summary>
    public Task<MetadataDto> OfficialReportsMeta(OfficialReportFindManyArgs findManyArgs);

    /// <summary>
    /// Get one OFFICIAL REPORT
    /// </summary>
    public Task<OfficialReport> OfficialReport(OfficialReportWhereUniqueInput uniqueId);

    /// <summary>
    /// Update one OFFICIAL REPORT
    /// </summary>
    public Task UpdateOfficialReport(
        OfficialReportWhereUniqueInput uniqueId,
        OfficialReportUpdateInput updateDto
    );
}
