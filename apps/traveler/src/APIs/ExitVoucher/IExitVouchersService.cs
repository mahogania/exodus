using Traveler.APIs.Common;
using Traveler.APIs.Dtos;

namespace Traveler.APIs;

public interface IExitVouchersService
{
    /// <summary>
    /// Create one ExitVoucher
    /// </summary>
    public Task<ExitVoucher> CreateExitVoucher(ExitVoucherCreateInput exitvoucher);

    /// <summary>
    /// Delete one ExitVoucher
    /// </summary>
    public Task DeleteExitVoucher(ExitVoucherWhereUniqueInput uniqueId);

    /// <summary>
    /// Find many ExitVouchers
    /// </summary>
    public Task<List<ExitVoucher>> ExitVouchers(ExitVoucherFindManyArgs findManyArgs);

    /// <summary>
    /// Meta data about ExitVoucher records
    /// </summary>
    public Task<MetadataDto> ExitVouchersMeta(ExitVoucherFindManyArgs findManyArgs);

    /// <summary>
    /// Get one ExitVoucher
    /// </summary>
    public Task<ExitVoucher> ExitVoucher(ExitVoucherWhereUniqueInput uniqueId);

    /// <summary>
    /// Update one ExitVoucher
    /// </summary>
    public Task UpdateExitVoucher(
        ExitVoucherWhereUniqueInput uniqueId,
        ExitVoucherUpdateInput updateDto
    );

    /// <summary>
    /// Connect multiple GeneralTravelerInformationTpds records to ExitVoucher
    /// </summary>
    public Task ConnectGeneralTravelerInformationTpds(
        ExitVoucherWhereUniqueInput uniqueId,
        GeneralTravelerInformationTpdWhereUniqueInput[] generalTravelerInformationTpdsId
    );

    /// <summary>
    /// Disconnect multiple GeneralTravelerInformationTpds records from ExitVoucher
    /// </summary>
    public Task DisconnectGeneralTravelerInformationTpds(
        ExitVoucherWhereUniqueInput uniqueId,
        GeneralTravelerInformationTpdWhereUniqueInput[] generalTravelerInformationTpdsId
    );

    /// <summary>
    /// Find multiple GeneralTravelerInformationTpds records for ExitVoucher
    /// </summary>
    public Task<List<GeneralTravelerInformationTpd>> FindGeneralTravelerInformationTpds(
        ExitVoucherWhereUniqueInput uniqueId,
        GeneralTravelerInformationTpdFindManyArgs GeneralTravelerInformationTpdFindManyArgs
    );

    /// <summary>
    /// Update multiple GeneralTravelerInformationTpds records for ExitVoucher
    /// </summary>
    public Task UpdateGeneralTravelerInformationTpds(
        ExitVoucherWhereUniqueInput uniqueId,
        GeneralTravelerInformationTpdWhereUniqueInput[] generalTravelerInformationTpdsId
    );
}
