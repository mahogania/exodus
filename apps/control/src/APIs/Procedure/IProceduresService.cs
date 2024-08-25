using Control.APIs.Common;
using Control.APIs.Dtos;

namespace Control.APIs;

public interface IProceduresService
{
    /// <summary>
    /// Create one Procedure
    /// </summary>
    public Task<Procedure> CreateProcedure(ProcedureCreateInput procedure);

    /// <summary>
    /// Delete one Procedure
    /// </summary>
    public Task DeleteProcedure(ProcedureWhereUniqueInput uniqueId);

    /// <summary>
    /// Find many Procedures
    /// </summary>
    public Task<List<Procedure>> Procedures(ProcedureFindManyArgs findManyArgs);

    /// <summary>
    /// Meta data about Procedure records
    /// </summary>
    public Task<MetadataDto> ProceduresMeta(ProcedureFindManyArgs findManyArgs);

    /// <summary>
    /// Get one Procedure
    /// </summary>
    public Task<Procedure> Procedure(ProcedureWhereUniqueInput uniqueId);

    /// <summary>
    /// Update one Procedure
    /// </summary>
    public Task UpdateProcedure(ProcedureWhereUniqueInput uniqueId, ProcedureUpdateInput updateDto);

    /// <summary>
    /// Connect multiple Analysis Requests records to Procedure
    /// </summary>
    public Task ConnectAnalysisRequests(
        ProcedureWhereUniqueInput uniqueId,
        AnalysisRequestWhereUniqueInput[] analysisRequestsId
    );

    /// <summary>
    /// Disconnect multiple Analysis Requests records from Procedure
    /// </summary>
    public Task DisconnectAnalysisRequests(
        ProcedureWhereUniqueInput uniqueId,
        AnalysisRequestWhereUniqueInput[] analysisRequestsId
    );

    /// <summary>
    /// Find multiple Analysis Requests records for Procedure
    /// </summary>
    public Task<List<AnalysisRequest>> FindAnalysisRequests(
        ProcedureWhereUniqueInput uniqueId,
        AnalysisRequestFindManyArgs AnalysisRequestFindManyArgs
    );

    /// <summary>
    /// Update multiple Analysis Requests records for Procedure
    /// </summary>
    public Task UpdateAnalysisRequests(
        ProcedureWhereUniqueInput uniqueId,
        AnalysisRequestWhereUniqueInput[] analysisRequestsId
    );

    /// <summary>
    /// Connect multiple Cancellation Requests records to Request
    /// </summary>
    public Task ConnectCancellationRequests(
        ProcedureWhereUniqueInput uniqueId,
        CancellationRequestWhereUniqueInput[] cancellationRequestsId
    );

    /// <summary>
    /// Disconnect multiple Cancellation Requests records from Request
    /// </summary>
    public Task DisconnectCancellationRequests(
        ProcedureWhereUniqueInput uniqueId,
        CancellationRequestWhereUniqueInput[] cancellationRequestsId
    );

    /// <summary>
    /// Find multiple Cancellation Requests records for Request
    /// </summary>
    public Task<List<CancellationRequest>> FindCancellationRequests(
        ProcedureWhereUniqueInput uniqueId,
        CancellationRequestFindManyArgs CancellationRequestFindManyArgs
    );

    /// <summary>
    /// Update multiple Cancellation Requests records for Request
    /// </summary>
    public Task UpdateCancellationRequests(
        ProcedureWhereUniqueInput uniqueId,
        CancellationRequestWhereUniqueInput[] cancellationRequestsId
    );

    /// <summary>
    /// Connect multiple Common Active Goods Requests records to Journal
    /// </summary>
    public Task ConnectCommonActiveGoodsRequests(
        ProcedureWhereUniqueInput uniqueId,
        CommonActiveGoodsRequestWhereUniqueInput[] commonActiveGoodsRequestsId
    );

    /// <summary>
    /// Disconnect multiple Common Active Goods Requests records from Journal
    /// </summary>
    public Task DisconnectCommonActiveGoodsRequests(
        ProcedureWhereUniqueInput uniqueId,
        CommonActiveGoodsRequestWhereUniqueInput[] commonActiveGoodsRequestsId
    );

    /// <summary>
    /// Find multiple Common Active Goods Requests records for Journal
    /// </summary>
    public Task<List<CommonActiveGoodsRequest>> FindCommonActiveGoodsRequests(
        ProcedureWhereUniqueInput uniqueId,
        CommonActiveGoodsRequestFindManyArgs CommonActiveGoodsRequestFindManyArgs
    );

    /// <summary>
    /// Update multiple Common Active Goods Requests records for Journal
    /// </summary>
    public Task UpdateCommonActiveGoodsRequests(
        ProcedureWhereUniqueInput uniqueId,
        CommonActiveGoodsRequestWhereUniqueInput[] commonActiveGoodsRequestsId
    );

    /// <summary>
    /// Get a Common Detailed Declaration record for Request
    /// </summary>
    public Task<CommonDetailedDeclaration> GetCommonDetailedDeclaration(
        ProcedureWhereUniqueInput uniqueId
    );

    /// <summary>
    /// Connect multiple Common Express Clearances records to Procedure
    /// </summary>
    public Task ConnectCommonExpressClearances(
        ProcedureWhereUniqueInput uniqueId,
        CommonExpressClearanceWhereUniqueInput[] commonExpressClearancesId
    );

    /// <summary>
    /// Disconnect multiple Common Express Clearances records from Procedure
    /// </summary>
    public Task DisconnectCommonExpressClearances(
        ProcedureWhereUniqueInput uniqueId,
        CommonExpressClearanceWhereUniqueInput[] commonExpressClearancesId
    );

    /// <summary>
    /// Find multiple Common Express Clearances records for Procedure
    /// </summary>
    public Task<List<CommonExpressClearance>> FindCommonExpressClearances(
        ProcedureWhereUniqueInput uniqueId,
        CommonExpressClearanceFindManyArgs CommonExpressClearanceFindManyArgs
    );

    /// <summary>
    /// Update multiple Common Express Clearances records for Procedure
    /// </summary>
    public Task UpdateCommonExpressClearances(
        ProcedureWhereUniqueInput uniqueId,
        CommonExpressClearanceWhereUniqueInput[] commonExpressClearancesId
    );

    /// <summary>
    /// Connect multiple Common Origin Certificate Requests records to Request
    /// </summary>
    public Task ConnectCommonOriginCertificateRequests(
        ProcedureWhereUniqueInput uniqueId,
        CommonOriginCertificateRequestWhereUniqueInput[] commonOriginCertificateRequestsId
    );

    /// <summary>
    /// Disconnect multiple Common Origin Certificate Requests records from Request
    /// </summary>
    public Task DisconnectCommonOriginCertificateRequests(
        ProcedureWhereUniqueInput uniqueId,
        CommonOriginCertificateRequestWhereUniqueInput[] commonOriginCertificateRequestsId
    );

    /// <summary>
    /// Find multiple Common Origin Certificate Requests records for Request
    /// </summary>
    public Task<List<CommonOriginCertificateRequest>> FindCommonOriginCertificateRequests(
        ProcedureWhereUniqueInput uniqueId,
        CommonOriginCertificateRequestFindManyArgs CommonOriginCertificateRequestFindManyArgs
    );

    /// <summary>
    /// Update multiple Common Origin Certificate Requests records for Request
    /// </summary>
    public Task UpdateCommonOriginCertificateRequests(
        ProcedureWhereUniqueInput uniqueId,
        CommonOriginCertificateRequestWhereUniqueInput[] commonOriginCertificateRequestsId
    );

    /// <summary>
    /// Connect multiple Common Regime Requests records to Journal
    /// </summary>
    public Task ConnectCommonRegimeRequests(
        ProcedureWhereUniqueInput uniqueId,
        CommonRegimeRequestWhereUniqueInput[] commonRegimeRequestsId
    );

    /// <summary>
    /// Disconnect multiple Common Regime Requests records from Journal
    /// </summary>
    public Task DisconnectCommonRegimeRequests(
        ProcedureWhereUniqueInput uniqueId,
        CommonRegimeRequestWhereUniqueInput[] commonRegimeRequestsId
    );

    /// <summary>
    /// Find multiple Common Regime Requests records for Journal
    /// </summary>
    public Task<List<CommonRegimeRequest>> FindCommonRegimeRequests(
        ProcedureWhereUniqueInput uniqueId,
        CommonRegimeRequestFindManyArgs CommonRegimeRequestFindManyArgs
    );

    /// <summary>
    /// Update multiple Common Regime Requests records for Journal
    /// </summary>
    public Task UpdateCommonRegimeRequests(
        ProcedureWhereUniqueInput uniqueId,
        CommonRegimeRequestWhereUniqueInput[] commonRegimeRequestsId
    );

    /// <summary>
    /// Connect multiple Foreign Operator Requests records to Request
    /// </summary>
    public Task ConnectForeignOperatorRequests(
        ProcedureWhereUniqueInput uniqueId,
        ForeignOperatorRequestWhereUniqueInput[] foreignOperatorRequestsId
    );

    /// <summary>
    /// Disconnect multiple Foreign Operator Requests records from Request
    /// </summary>
    public Task DisconnectForeignOperatorRequests(
        ProcedureWhereUniqueInput uniqueId,
        ForeignOperatorRequestWhereUniqueInput[] foreignOperatorRequestsId
    );

    /// <summary>
    /// Find multiple Foreign Operator Requests records for Request
    /// </summary>
    public Task<List<ForeignOperatorRequest>> FindForeignOperatorRequests(
        ProcedureWhereUniqueInput uniqueId,
        ForeignOperatorRequestFindManyArgs ForeignOperatorRequestFindManyArgs
    );

    /// <summary>
    /// Update multiple Foreign Operator Requests records for Request
    /// </summary>
    public Task UpdateForeignOperatorRequests(
        ProcedureWhereUniqueInput uniqueId,
        ForeignOperatorRequestWhereUniqueInput[] foreignOperatorRequestsId
    );

    /// <summary>
    /// Connect multiple Postal Goods Clearances records to Procedure
    /// </summary>
    public Task ConnectPostalGoodsClearances(
        ProcedureWhereUniqueInput uniqueId,
        PostalGoodsClearanceWhereUniqueInput[] postalGoodsClearancesId
    );

    /// <summary>
    /// Disconnect multiple Postal Goods Clearances records from Procedure
    /// </summary>
    public Task DisconnectPostalGoodsClearances(
        ProcedureWhereUniqueInput uniqueId,
        PostalGoodsClearanceWhereUniqueInput[] postalGoodsClearancesId
    );

    /// <summary>
    /// Find multiple Postal Goods Clearances records for Procedure
    /// </summary>
    public Task<List<PostalGoodsClearance>> FindPostalGoodsClearances(
        ProcedureWhereUniqueInput uniqueId,
        PostalGoodsClearanceFindManyArgs PostalGoodsClearanceFindManyArgs
    );

    /// <summary>
    /// Update multiple Postal Goods Clearances records for Procedure
    /// </summary>
    public Task UpdatePostalGoodsClearances(
        ProcedureWhereUniqueInput uniqueId,
        PostalGoodsClearanceWhereUniqueInput[] postalGoodsClearancesId
    );

    /// <summary>
    /// Connect multiple Postal Parcel Simplified Clearances records to Procedure
    /// </summary>
    public Task ConnectPostalParcelSimplifiedClearances(
        ProcedureWhereUniqueInput uniqueId,
        PostalParcelSimplifiedClearanceWhereUniqueInput[] postalParcelSimplifiedClearancesId
    );

    /// <summary>
    /// Disconnect multiple Postal Parcel Simplified Clearances records from Procedure
    /// </summary>
    public Task DisconnectPostalParcelSimplifiedClearances(
        ProcedureWhereUniqueInput uniqueId,
        PostalParcelSimplifiedClearanceWhereUniqueInput[] postalParcelSimplifiedClearancesId
    );

    /// <summary>
    /// Find multiple Postal Parcel Simplified Clearances records for Procedure
    /// </summary>
    public Task<List<PostalParcelSimplifiedClearance>> FindPostalParcelSimplifiedClearances(
        ProcedureWhereUniqueInput uniqueId,
        PostalParcelSimplifiedClearanceFindManyArgs PostalParcelSimplifiedClearanceFindManyArgs
    );

    /// <summary>
    /// Update multiple Postal Parcel Simplified Clearances records for Procedure
    /// </summary>
    public Task UpdatePostalParcelSimplifiedClearances(
        ProcedureWhereUniqueInput uniqueId,
        PostalParcelSimplifiedClearanceWhereUniqueInput[] postalParcelSimplifiedClearancesId
    );

    /// <summary>
    /// Connect multiple Recourse Requests records to Journal
    /// </summary>
    public Task ConnectRecourseRequests(
        ProcedureWhereUniqueInput uniqueId,
        RecourseRequestWhereUniqueInput[] recourseRequestsId
    );

    /// <summary>
    /// Disconnect multiple Recourse Requests records from Journal
    /// </summary>
    public Task DisconnectRecourseRequests(
        ProcedureWhereUniqueInput uniqueId,
        RecourseRequestWhereUniqueInput[] recourseRequestsId
    );

    /// <summary>
    /// Find multiple Recourse Requests records for Journal
    /// </summary>
    public Task<List<RecourseRequest>> FindRecourseRequests(
        ProcedureWhereUniqueInput uniqueId,
        RecourseRequestFindManyArgs RecourseRequestFindManyArgs
    );

    /// <summary>
    /// Update multiple Recourse Requests records for Journal
    /// </summary>
    public Task UpdateRecourseRequests(
        ProcedureWhereUniqueInput uniqueId,
        RecourseRequestWhereUniqueInput[] recourseRequestsId
    );
}
