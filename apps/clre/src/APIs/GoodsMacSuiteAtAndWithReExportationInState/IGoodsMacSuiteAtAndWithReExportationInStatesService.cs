using Clre.APIs.Common;
using Clre.APIs.Dtos;

namespace Clre.APIs;

public interface IGoodsMacSuiteAtAndWithReExportationInStatesService
{
    /// <summary>
    /// Create one GOODS MAC SUITE AT AND WITH RE-EXPORTATION IN STATE
    /// </summary>
    public Task<GoodsMacSuiteAtAndWithReExportationInState> CreateGoodsMacSuiteAtAndWithReExportationInState(
        GoodsMacSuiteAtAndWithReExportationInStateCreateInput goodsmacsuiteatandwithreexportationinstate
    );

    /// <summary>
    /// Delete one GOODS MAC SUITE AT AND WITH RE-EXPORTATION IN STATE
    /// </summary>
    public Task DeleteGoodsMacSuiteAtAndWithReExportationInState(
        GoodsMacSuiteAtAndWithReExportationInStateWhereUniqueInput uniqueId
    );

    /// <summary>
    /// Find many GOODS MAC SUITE AT AND WITH RE-EXPORTATION IN STATES
    /// </summary>
    public Task<
        List<GoodsMacSuiteAtAndWithReExportationInState>
    > GoodsMacSuiteAtAndWithReExportationInStates(
        GoodsMacSuiteAtAndWithReExportationInStateFindManyArgs findManyArgs
    );

    /// <summary>
    /// Meta data about GOODS MAC SUITE AT AND WITH RE-EXPORTATION IN STATE records
    /// </summary>
    public Task<MetadataDto> GoodsMacSuiteAtAndWithReExportationInStatesMeta(
        GoodsMacSuiteAtAndWithReExportationInStateFindManyArgs findManyArgs
    );

    /// <summary>
    /// Get one GOODS MAC SUITE AT AND WITH RE-EXPORTATION IN STATE
    /// </summary>
    public Task<GoodsMacSuiteAtAndWithReExportationInState> GoodsMacSuiteAtAndWithReExportationInState(
        GoodsMacSuiteAtAndWithReExportationInStateWhereUniqueInput uniqueId
    );

    /// <summary>
    /// Update one GOODS MAC SUITE AT AND WITH RE-EXPORTATION IN STATE
    /// </summary>
    public Task UpdateGoodsMacSuiteAtAndWithReExportationInState(
        GoodsMacSuiteAtAndWithReExportationInStateWhereUniqueInput uniqueId,
        GoodsMacSuiteAtAndWithReExportationInStateUpdateInput updateDto
    );
}
