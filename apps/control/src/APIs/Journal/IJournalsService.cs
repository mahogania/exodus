using Control.APIs.Common;
using Control.APIs.Dtos;

namespace Control.APIs;

public interface IJournalsService
{
    /// <summary>
    /// Create one Journal
    /// </summary>
    public Task<Journal> CreateJournal(JournalCreateInput journal);

    /// <summary>
    /// Delete one Journal
    /// </summary>
    public Task DeleteJournal(JournalWhereUniqueInput uniqueId);

    /// <summary>
    /// Find many Requests
    /// </summary>
    public Task<List<Journal>> Journals(JournalFindManyArgs findManyArgs);

    /// <summary>
    /// Meta data about Journal records
    /// </summary>
    public Task<MetadataDto> JournalsMeta(JournalFindManyArgs findManyArgs);

    /// <summary>
    /// Get one Journal
    /// </summary>
    public Task<Journal> Journal(JournalWhereUniqueInput uniqueId);

    /// <summary>
    /// Update one Journal
    /// </summary>
    public Task UpdateJournal(JournalWhereUniqueInput uniqueId, JournalUpdateInput updateDto);

    /// <summary>
    /// Connect multiple Cancellation Requests records to Request
    /// </summary>
    public Task ConnectCancellationRequests(
        JournalWhereUniqueInput uniqueId,
        CancellationRequestWhereUniqueInput[] cancellationRequestsId
    );

    /// <summary>
    /// Disconnect multiple Cancellation Requests records from Request
    /// </summary>
    public Task DisconnectCancellationRequests(
        JournalWhereUniqueInput uniqueId,
        CancellationRequestWhereUniqueInput[] cancellationRequestsId
    );

    /// <summary>
    /// Find multiple Cancellation Requests records for Request
    /// </summary>
    public Task<List<CancellationRequest>> FindCancellationRequests(
        JournalWhereUniqueInput uniqueId,
        CancellationRequestFindManyArgs CancellationRequestFindManyArgs
    );

    /// <summary>
    /// Update multiple Cancellation Requests records for Request
    /// </summary>
    public Task UpdateCancellationRequests(
        JournalWhereUniqueInput uniqueId,
        CancellationRequestWhereUniqueInput[] cancellationRequestsId
    );

    /// <summary>
    /// Connect multiple Common Active Goods Requests records to Journal
    /// </summary>
    public Task ConnectCommonActiveGoodsRequests(
        JournalWhereUniqueInput uniqueId,
        CommonActiveGoodsRequestWhereUniqueInput[] commonActiveGoodsRequestsId
    );

    /// <summary>
    /// Disconnect multiple Common Active Goods Requests records from Journal
    /// </summary>
    public Task DisconnectCommonActiveGoodsRequests(
        JournalWhereUniqueInput uniqueId,
        CommonActiveGoodsRequestWhereUniqueInput[] commonActiveGoodsRequestsId
    );

    /// <summary>
    /// Find multiple Common Active Goods Requests records for Journal
    /// </summary>
    public Task<List<CommonActiveGoodsRequest>> FindCommonActiveGoodsRequests(
        JournalWhereUniqueInput uniqueId,
        CommonActiveGoodsRequestFindManyArgs CommonActiveGoodsRequestFindManyArgs
    );

    /// <summary>
    /// Update multiple Common Active Goods Requests records for Journal
    /// </summary>
    public Task UpdateCommonActiveGoodsRequests(
        JournalWhereUniqueInput uniqueId,
        CommonActiveGoodsRequestWhereUniqueInput[] commonActiveGoodsRequestsId
    );

    /// <summary>
    /// Get a Common Detailed Declaration record for Request
    /// </summary>
    public Task<CommonDetailedDeclaration> GetCommonDetailedDeclaration(
        JournalWhereUniqueInput uniqueId
    );

    /// <summary>
    /// Connect multiple Common Origin Certificate Requests records to Request
    /// </summary>
    public Task ConnectCommonOriginCertificateRequests(
        JournalWhereUniqueInput uniqueId,
        CommonOriginCertificateRequestWhereUniqueInput[] commonOriginCertificateRequestsId
    );

    /// <summary>
    /// Disconnect multiple Common Origin Certificate Requests records from Request
    /// </summary>
    public Task DisconnectCommonOriginCertificateRequests(
        JournalWhereUniqueInput uniqueId,
        CommonOriginCertificateRequestWhereUniqueInput[] commonOriginCertificateRequestsId
    );

    /// <summary>
    /// Find multiple Common Origin Certificate Requests records for Request
    /// </summary>
    public Task<List<CommonOriginCertificateRequest>> FindCommonOriginCertificateRequests(
        JournalWhereUniqueInput uniqueId,
        CommonOriginCertificateRequestFindManyArgs CommonOriginCertificateRequestFindManyArgs
    );

    /// <summary>
    /// Update multiple Common Origin Certificate Requests records for Request
    /// </summary>
    public Task UpdateCommonOriginCertificateRequests(
        JournalWhereUniqueInput uniqueId,
        CommonOriginCertificateRequestWhereUniqueInput[] commonOriginCertificateRequestsId
    );

    /// <summary>
    /// Connect multiple Common Regime Requests records to Journal
    /// </summary>
    public Task ConnectCommonRegimeRequests(
        JournalWhereUniqueInput uniqueId,
        CommonRegimeRequestWhereUniqueInput[] commonRegimeRequestsId
    );

    /// <summary>
    /// Disconnect multiple Common Regime Requests records from Journal
    /// </summary>
    public Task DisconnectCommonRegimeRequests(
        JournalWhereUniqueInput uniqueId,
        CommonRegimeRequestWhereUniqueInput[] commonRegimeRequestsId
    );

    /// <summary>
    /// Find multiple Common Regime Requests records for Journal
    /// </summary>
    public Task<List<CommonRegimeRequest>> FindCommonRegimeRequests(
        JournalWhereUniqueInput uniqueId,
        CommonRegimeRequestFindManyArgs CommonRegimeRequestFindManyArgs
    );

    /// <summary>
    /// Update multiple Common Regime Requests records for Journal
    /// </summary>
    public Task UpdateCommonRegimeRequests(
        JournalWhereUniqueInput uniqueId,
        CommonRegimeRequestWhereUniqueInput[] commonRegimeRequestsId
    );

    /// <summary>
    /// Connect multiple Foreign Operator Requests records to Request
    /// </summary>
    public Task ConnectForeignOperatorRequests(
        JournalWhereUniqueInput uniqueId,
        ForeignOperatorRequestWhereUniqueInput[] foreignOperatorRequestsId
    );

    /// <summary>
    /// Disconnect multiple Foreign Operator Requests records from Request
    /// </summary>
    public Task DisconnectForeignOperatorRequests(
        JournalWhereUniqueInput uniqueId,
        ForeignOperatorRequestWhereUniqueInput[] foreignOperatorRequestsId
    );

    /// <summary>
    /// Find multiple Foreign Operator Requests records for Request
    /// </summary>
    public Task<List<ForeignOperatorRequest>> FindForeignOperatorRequests(
        JournalWhereUniqueInput uniqueId,
        ForeignOperatorRequestFindManyArgs ForeignOperatorRequestFindManyArgs
    );

    /// <summary>
    /// Update multiple Foreign Operator Requests records for Request
    /// </summary>
    public Task UpdateForeignOperatorRequests(
        JournalWhereUniqueInput uniqueId,
        ForeignOperatorRequestWhereUniqueInput[] foreignOperatorRequestsId
    );
}
