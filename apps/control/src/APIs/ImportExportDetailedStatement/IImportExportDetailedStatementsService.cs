using Control.APIs.Common;
using Control.APIs.Dtos;

namespace Control.APIs;

public interface IImportExportDetailedStatementsService
{
    /// <summary>
    /// Create one IMPORT/EXPORT DETAILED STATEMENT
    /// </summary>
    public Task<ImportExportDetailedStatement> CreateImportExportDetailedStatement(
        ImportExportDetailedStatementCreateInput importexportdetailedstatement
    );

    /// <summary>
    /// Delete one IMPORT/EXPORT DETAILED STATEMENT
    /// </summary>
    public Task DeleteImportExportDetailedStatement(
        ImportExportDetailedStatementWhereUniqueInput uniqueId
    );

    /// <summary>
    /// Find many IMPORT/EXPORT DETAILED STATEMENTS
    /// </summary>
    public Task<List<ImportExportDetailedStatement>> ImportExportDetailedStatements(
        ImportExportDetailedStatementFindManyArgs findManyArgs
    );

    /// <summary>
    /// Meta data about IMPORT/EXPORT DETAILED STATEMENT records
    /// </summary>
    public Task<MetadataDto> ImportExportDetailedStatementsMeta(
        ImportExportDetailedStatementFindManyArgs findManyArgs
    );

    /// <summary>
    /// Get one IMPORT/EXPORT DETAILED STATEMENT
    /// </summary>
    public Task<ImportExportDetailedStatement> ImportExportDetailedStatement(
        ImportExportDetailedStatementWhereUniqueInput uniqueId
    );

    /// <summary>
    /// Update one IMPORT/EXPORT DETAILED STATEMENT
    /// </summary>
    public Task UpdateImportExportDetailedStatement(
        ImportExportDetailedStatementWhereUniqueInput uniqueId,
        ImportExportDetailedStatementUpdateInput updateDto
    );
}
