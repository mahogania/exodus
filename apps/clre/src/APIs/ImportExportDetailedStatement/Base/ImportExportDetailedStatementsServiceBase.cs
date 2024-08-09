using Clre.APIs;
using Clre.APIs.Common;
using Clre.APIs.Dtos;
using Clre.APIs.Errors;
using Clre.APIs.Extensions;
using Clre.Infrastructure;
using Clre.Infrastructure.Models;
using Microsoft.EntityFrameworkCore;

namespace Clre.APIs;

public abstract class ImportExportDetailedStatementsServiceBase
    : IImportExportDetailedStatementsService
{
    protected readonly ClreDbContext _context;

    public ImportExportDetailedStatementsServiceBase(ClreDbContext context)
    {
        _context = context;
    }

    /// <summary>
    /// Create one IMPORT/EXPORT DETAILED STATEMENT
    /// </summary>
    public async Task<ImportExportDetailedStatement> CreateImportExportDetailedStatement(
        ImportExportDetailedStatementCreateInput createDto
    )
    {
        var importExportDetailedStatement = new ImportExportDetailedStatementDbModel
        {
            Amount = createDto.Amount,
            BrandName = createDto.BrandName,
            CreatedAt = createDto.CreatedAt,
            DateAndTimeOfFinalModification = createDto.DateAndTimeOfFinalModification,
            DateAndTimeOfFirstRegistration = createDto.DateAndTimeOfFirstRegistration,
            DocumentCode = createDto.DocumentCode,
            FinalModifierSId = createDto.FinalModifierSId,
            FirstRegistrantSId = createDto.FirstRegistrantSId,
            ImportExportTypeCode = createDto.ImportExportTypeCode,
            OriginCountryCode = createDto.OriginCountryCode,
            Quantity = createDto.Quantity,
            QuantityUnitCode = createDto.QuantityUnitCode,
            RectificationFrequency = createDto.RectificationFrequency,
            RegimeRequestNumber = createDto.RegimeRequestNumber,
            SequenceNumber = createDto.SequenceNumber,
            ShCode = createDto.ShCode,
            SuppressionOn = createDto.SuppressionOn,
            TechniqueName = createDto.TechniqueName,
            UpdatedAt = createDto.UpdatedAt
        };

        if (createDto.Id != null)
        {
            importExportDetailedStatement.Id = createDto.Id;
        }

        _context.ImportExportDetailedStatements.Add(importExportDetailedStatement);
        await _context.SaveChangesAsync();

        var result = await _context.FindAsync<ImportExportDetailedStatementDbModel>(
            importExportDetailedStatement.Id
        );

        if (result == null)
        {
            throw new NotFoundException();
        }

        return result.ToDto();
    }

    /// <summary>
    /// Delete one IMPORT/EXPORT DETAILED STATEMENT
    /// </summary>
    public async Task DeleteImportExportDetailedStatement(
        ImportExportDetailedStatementWhereUniqueInput uniqueId
    )
    {
        var importExportDetailedStatement = await _context.ImportExportDetailedStatements.FindAsync(
            uniqueId.Id
        );
        if (importExportDetailedStatement == null)
        {
            throw new NotFoundException();
        }

        _context.ImportExportDetailedStatements.Remove(importExportDetailedStatement);
        await _context.SaveChangesAsync();
    }

    /// <summary>
    /// Find many IMPORT/EXPORT DETAILED STATEMENTS
    /// </summary>
    public async Task<List<ImportExportDetailedStatement>> ImportExportDetailedStatements(
        ImportExportDetailedStatementFindManyArgs findManyArgs
    )
    {
        var importExportDetailedStatements = await _context
            .ImportExportDetailedStatements.ApplyWhere(findManyArgs.Where)
            .ApplySkip(findManyArgs.Skip)
            .ApplyTake(findManyArgs.Take)
            .ApplyOrderBy(findManyArgs.SortBy)
            .ToListAsync();
        return importExportDetailedStatements.ConvertAll(importExportDetailedStatement =>
            importExportDetailedStatement.ToDto()
        );
    }

    /// <summary>
    /// Meta data about IMPORT/EXPORT DETAILED STATEMENT records
    /// </summary>
    public async Task<MetadataDto> ImportExportDetailedStatementsMeta(
        ImportExportDetailedStatementFindManyArgs findManyArgs
    )
    {
        var count = await _context
            .ImportExportDetailedStatements.ApplyWhere(findManyArgs.Where)
            .CountAsync();

        return new MetadataDto { Count = count };
    }

    /// <summary>
    /// Get one IMPORT/EXPORT DETAILED STATEMENT
    /// </summary>
    public async Task<ImportExportDetailedStatement> ImportExportDetailedStatement(
        ImportExportDetailedStatementWhereUniqueInput uniqueId
    )
    {
        var importExportDetailedStatements = await this.ImportExportDetailedStatements(
            new ImportExportDetailedStatementFindManyArgs
            {
                Where = new ImportExportDetailedStatementWhereInput { Id = uniqueId.Id }
            }
        );
        var importExportDetailedStatement = importExportDetailedStatements.FirstOrDefault();
        if (importExportDetailedStatement == null)
        {
            throw new NotFoundException();
        }

        return importExportDetailedStatement;
    }

    /// <summary>
    /// Update one IMPORT/EXPORT DETAILED STATEMENT
    /// </summary>
    public async Task UpdateImportExportDetailedStatement(
        ImportExportDetailedStatementWhereUniqueInput uniqueId,
        ImportExportDetailedStatementUpdateInput updateDto
    )
    {
        var importExportDetailedStatement = updateDto.ToModel(uniqueId);

        _context.Entry(importExportDetailedStatement).State = EntityState.Modified;

        try
        {
            await _context.SaveChangesAsync();
        }
        catch (DbUpdateConcurrencyException)
        {
            if (
                !_context.ImportExportDetailedStatements.Any(e =>
                    e.Id == importExportDetailedStatement.Id
                )
            )
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
