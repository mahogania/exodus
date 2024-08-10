using Collection.APIs.Common;
using Collection.APIs.Dtos;

namespace Collection.APIs;

public interface IAuctionReportsService
{
    /// <summary>
    ///     Create one AUCTION REPORT
    /// </summary>
    public Task<AuctionReport> CreateAuctionReport(AuctionReportCreateInput auctionreport);

    /// <summary>
    ///     Delete one AUCTION REPORT
    /// </summary>
    public Task DeleteAuctionReport(AuctionReportWhereUniqueInput uniqueId);

    /// <summary>
    ///     Find many AUCTION REPORTS
    /// </summary>
    public Task<List<AuctionReport>> AuctionReports(AuctionReportFindManyArgs findManyArgs);

    /// <summary>
    ///     Meta data about AUCTION REPORT records
    /// </summary>
    public Task<MetadataDto> AuctionReportsMeta(AuctionReportFindManyArgs findManyArgs);

    /// <summary>
    ///     Get one AUCTION REPORT
    /// </summary>
    public Task<AuctionReport> AuctionReport(AuctionReportWhereUniqueInput uniqueId);

    /// <summary>
    ///     Update one AUCTION REPORT
    /// </summary>
    public Task UpdateAuctionReport(
        AuctionReportWhereUniqueInput uniqueId,
        AuctionReportUpdateInput updateDto
    );
}
