using Control.APIs;
using Control.APIs.Common;
using Control.APIs.Dtos;
using Control.APIs.Errors;
using Control.APIs.Extensions;
using Control.Infrastructure;
using Control.Infrastructure.Models;
using Microsoft.EntityFrameworkCore;

namespace Control.APIs;

public abstract class ProceduresServiceBase : IProceduresService
{
    protected readonly ControlDbContext _context;

    public ProceduresServiceBase(ControlDbContext context)
    {
        _context = context;
    }

    /// <summary>
    /// Create one Procedure
    /// </summary>
    public async Task<Procedure> CreateProcedure(ProcedureCreateInput createDto)
    {
        var procedure = new ProcedureDbModel
        {
            CreatedAt = createDto.CreatedAt,
            UpdatedAt = createDto.UpdatedAt
        };

        if (createDto.Id != null)
        {
            procedure.Id = createDto.Id;
        }
        if (createDto.AnalysisRequests != null)
        {
            procedure.AnalysisRequests = await _context
                .AnalysisRequests.Where(analysisRequest =>
                    createDto.AnalysisRequests.Select(t => t.Id).Contains(analysisRequest.Id)
                )
                .ToListAsync();
        }

        if (createDto.CancellationRequests != null)
        {
            procedure.CancellationRequests = await _context
                .CancellationRequests.Where(cancellationRequest =>
                    createDto
                        .CancellationRequests.Select(t => t.Id)
                        .Contains(cancellationRequest.Id)
                )
                .ToListAsync();
        }

        if (createDto.CommonActiveGoodsRequests != null)
        {
            procedure.CommonActiveGoodsRequests = await _context
                .CommonActiveGoodsRequests.Where(commonActiveGoodsRequest =>
                    createDto
                        .CommonActiveGoodsRequests.Select(t => t.Id)
                        .Contains(commonActiveGoodsRequest.Id)
                )
                .ToListAsync();
        }

        if (createDto.CommonDetailedDeclaration != null)
        {
            procedure.CommonDetailedDeclaration = await _context
                .CommonDetailedDeclarations.Where(commonDetailedDeclaration =>
                    createDto.CommonDetailedDeclaration.Id == commonDetailedDeclaration.Id
                )
                .FirstOrDefaultAsync();
        }

        if (createDto.CommonExpressClearances != null)
        {
            procedure.CommonExpressClearances = await _context
                .CommonExpressClearances.Where(commonExpressClearance =>
                    createDto
                        .CommonExpressClearances.Select(t => t.Id)
                        .Contains(commonExpressClearance.Id)
                )
                .ToListAsync();
        }

        if (createDto.CommonOriginCertificateRequests != null)
        {
            procedure.CommonOriginCertificateRequests = await _context
                .CommonOriginCertificateRequests.Where(commonOriginCertificateRequest =>
                    createDto
                        .CommonOriginCertificateRequests.Select(t => t.Id)
                        .Contains(commonOriginCertificateRequest.Id)
                )
                .ToListAsync();
        }

        if (createDto.CommonRegimeRequests != null)
        {
            procedure.CommonRegimeRequests = await _context
                .CommonRegimeRequests.Where(commonRegimeRequest =>
                    createDto
                        .CommonRegimeRequests.Select(t => t.Id)
                        .Contains(commonRegimeRequest.Id)
                )
                .ToListAsync();
        }

        if (createDto.ForeignOperatorRequests != null)
        {
            procedure.ForeignOperatorRequests = await _context
                .ForeignOperatorRequests.Where(foreignOperatorRequest =>
                    createDto
                        .ForeignOperatorRequests.Select(t => t.Id)
                        .Contains(foreignOperatorRequest.Id)
                )
                .ToListAsync();
        }

        if (createDto.PostalGoodsClearances != null)
        {
            procedure.PostalGoodsClearances = await _context
                .PostalGoodsClearances.Where(postalGoodsClearance =>
                    createDto
                        .PostalGoodsClearances.Select(t => t.Id)
                        .Contains(postalGoodsClearance.Id)
                )
                .ToListAsync();
        }

        if (createDto.PostalParcelSimplifiedClearances != null)
        {
            procedure.PostalParcelSimplifiedClearances = await _context
                .PostalParcelSimplifiedClearances.Where(postalParcelSimplifiedClearance =>
                    createDto
                        .PostalParcelSimplifiedClearances.Select(t => t.Id)
                        .Contains(postalParcelSimplifiedClearance.Id)
                )
                .ToListAsync();
        }

        if (createDto.RecourseRequests != null)
        {
            procedure.RecourseRequests = await _context
                .RecourseRequests.Where(recourseRequest =>
                    createDto.RecourseRequests.Select(t => t.Id).Contains(recourseRequest.Id)
                )
                .ToListAsync();
        }

        _context.Procedures.Add(procedure);
        await _context.SaveChangesAsync();

        var result = await _context.FindAsync<ProcedureDbModel>(procedure.Id);

        if (result == null)
        {
            throw new NotFoundException();
        }

        return result.ToDto();
    }

    /// <summary>
    /// Delete one Procedure
    /// </summary>
    public async Task DeleteProcedure(ProcedureWhereUniqueInput uniqueId)
    {
        var procedure = await _context.Procedures.FindAsync(uniqueId.Id);
        if (procedure == null)
        {
            throw new NotFoundException();
        }

        _context.Procedures.Remove(procedure);
        await _context.SaveChangesAsync();
    }

    /// <summary>
    /// Find many Procedures
    /// </summary>
    public async Task<List<Procedure>> Procedures(ProcedureFindManyArgs findManyArgs)
    {
        var procedures = await _context
            .Procedures.Include(x => x.CommonExpressClearances)
            .Include(x => x.PostalGoodsClearances)
            .Include(x => x.ForeignOperatorRequests)
            .Include(x => x.CommonRegimeRequests)
            .Include(x => x.PostalParcelSimplifiedClearances)
            .Include(x => x.CommonDetailedDeclaration)
            .Include(x => x.CancellationRequests)
            .Include(x => x.CommonActiveGoodsRequests)
            .Include(x => x.RecourseRequests)
            .Include(x => x.CommonOriginCertificateRequests)
            .Include(x => x.AnalysisRequests)
            .ApplyWhere(findManyArgs.Where)
            .ApplySkip(findManyArgs.Skip)
            .ApplyTake(findManyArgs.Take)
            .ApplyOrderBy(findManyArgs.SortBy)
            .ToListAsync();
        return procedures.ConvertAll(procedure => procedure.ToDto());
    }

    /// <summary>
    /// Meta data about Procedure records
    /// </summary>
    public async Task<MetadataDto> ProceduresMeta(ProcedureFindManyArgs findManyArgs)
    {
        var count = await _context.Procedures.ApplyWhere(findManyArgs.Where).CountAsync();

        return new MetadataDto { Count = count };
    }

    /// <summary>
    /// Get one Procedure
    /// </summary>
    public async Task<Procedure> Procedure(ProcedureWhereUniqueInput uniqueId)
    {
        var procedures = await this.Procedures(
            new ProcedureFindManyArgs { Where = new ProcedureWhereInput { Id = uniqueId.Id } }
        );
        var procedure = procedures.FirstOrDefault();
        if (procedure == null)
        {
            throw new NotFoundException();
        }

        return procedure;
    }

    /// <summary>
    /// Update one Procedure
    /// </summary>
    public async Task UpdateProcedure(
        ProcedureWhereUniqueInput uniqueId,
        ProcedureUpdateInput updateDto
    )
    {
        var procedure = updateDto.ToModel(uniqueId);

        if (updateDto.CommonExpressClearances != null)
        {
            procedure.CommonExpressClearances = await _context
                .CommonExpressClearances.Where(commonExpressClearance =>
                    updateDto
                        .CommonExpressClearances.Select(t => t)
                        .Contains(commonExpressClearance.Id)
                )
                .ToListAsync();
        }

        if (updateDto.PostalGoodsClearances != null)
        {
            procedure.PostalGoodsClearances = await _context
                .PostalGoodsClearances.Where(postalGoodsClearance =>
                    updateDto.PostalGoodsClearances.Select(t => t).Contains(postalGoodsClearance.Id)
                )
                .ToListAsync();
        }

        if (updateDto.ForeignOperatorRequests != null)
        {
            procedure.ForeignOperatorRequests = await _context
                .ForeignOperatorRequests.Where(foreignOperatorRequest =>
                    updateDto
                        .ForeignOperatorRequests.Select(t => t)
                        .Contains(foreignOperatorRequest.Id)
                )
                .ToListAsync();
        }

        if (updateDto.CommonRegimeRequests != null)
        {
            procedure.CommonRegimeRequests = await _context
                .CommonRegimeRequests.Where(commonRegimeRequest =>
                    updateDto.CommonRegimeRequests.Select(t => t).Contains(commonRegimeRequest.Id)
                )
                .ToListAsync();
        }

        if (updateDto.PostalParcelSimplifiedClearances != null)
        {
            procedure.PostalParcelSimplifiedClearances = await _context
                .PostalParcelSimplifiedClearances.Where(postalParcelSimplifiedClearance =>
                    updateDto
                        .PostalParcelSimplifiedClearances.Select(t => t)
                        .Contains(postalParcelSimplifiedClearance.Id)
                )
                .ToListAsync();
        }

        if (updateDto.CancellationRequests != null)
        {
            procedure.CancellationRequests = await _context
                .CancellationRequests.Where(cancellationRequest =>
                    updateDto.CancellationRequests.Select(t => t).Contains(cancellationRequest.Id)
                )
                .ToListAsync();
        }

        if (updateDto.CommonActiveGoodsRequests != null)
        {
            procedure.CommonActiveGoodsRequests = await _context
                .CommonActiveGoodsRequests.Where(commonActiveGoodsRequest =>
                    updateDto
                        .CommonActiveGoodsRequests.Select(t => t)
                        .Contains(commonActiveGoodsRequest.Id)
                )
                .ToListAsync();
        }

        if (updateDto.RecourseRequests != null)
        {
            procedure.RecourseRequests = await _context
                .RecourseRequests.Where(recourseRequest =>
                    updateDto.RecourseRequests.Select(t => t).Contains(recourseRequest.Id)
                )
                .ToListAsync();
        }

        if (updateDto.CommonOriginCertificateRequests != null)
        {
            procedure.CommonOriginCertificateRequests = await _context
                .CommonOriginCertificateRequests.Where(commonOriginCertificateRequest =>
                    updateDto
                        .CommonOriginCertificateRequests.Select(t => t)
                        .Contains(commonOriginCertificateRequest.Id)
                )
                .ToListAsync();
        }

        if (updateDto.AnalysisRequests != null)
        {
            procedure.AnalysisRequests = await _context
                .AnalysisRequests.Where(analysisRequest =>
                    updateDto.AnalysisRequests.Select(t => t).Contains(analysisRequest.Id)
                )
                .ToListAsync();
        }

        _context.Entry(procedure).State = EntityState.Modified;

        try
        {
            await _context.SaveChangesAsync();
        }
        catch (DbUpdateConcurrencyException)
        {
            if (!_context.Procedures.Any(e => e.Id == procedure.Id))
            {
                throw new NotFoundException();
            }
            else
            {
                throw;
            }
        }
    }

    /// <summary>
    /// Connect multiple Analysis Requests records to Procedure
    /// </summary>
    public async Task ConnectAnalysisRequests(
        ProcedureWhereUniqueInput uniqueId,
        AnalysisRequestWhereUniqueInput[] analysisRequestsId
    )
    {
        var parent = await _context
            .Procedures.Include(x => x.AnalysisRequests)
            .FirstOrDefaultAsync(x => x.Id == uniqueId.Id);
        if (parent == null)
        {
            throw new NotFoundException();
        }

        var analysisRequests = await _context
            .AnalysisRequests.Where(t => analysisRequestsId.Select(x => x.Id).Contains(t.Id))
            .ToListAsync();
        if (analysisRequests.Count == 0)
        {
            throw new NotFoundException();
        }

        var analysisRequestsToConnect = analysisRequests.Except(parent.AnalysisRequests);

        foreach (var analysisRequest in analysisRequestsToConnect)
        {
            parent.AnalysisRequests.Add(analysisRequest);
        }

        await _context.SaveChangesAsync();
    }

    /// <summary>
    /// Disconnect multiple Analysis Requests records from Procedure
    /// </summary>
    public async Task DisconnectAnalysisRequests(
        ProcedureWhereUniqueInput uniqueId,
        AnalysisRequestWhereUniqueInput[] analysisRequestsId
    )
    {
        var parent = await _context
            .Procedures.Include(x => x.AnalysisRequests)
            .FirstOrDefaultAsync(x => x.Id == uniqueId.Id);
        if (parent == null)
        {
            throw new NotFoundException();
        }

        var analysisRequests = await _context
            .AnalysisRequests.Where(t => analysisRequestsId.Select(x => x.Id).Contains(t.Id))
            .ToListAsync();

        foreach (var analysisRequest in analysisRequests)
        {
            parent.AnalysisRequests?.Remove(analysisRequest);
        }
        await _context.SaveChangesAsync();
    }

    /// <summary>
    /// Find multiple Analysis Requests records for Procedure
    /// </summary>
    public async Task<List<AnalysisRequest>> FindAnalysisRequests(
        ProcedureWhereUniqueInput uniqueId,
        AnalysisRequestFindManyArgs procedureFindManyArgs
    )
    {
        var analysisRequests = await _context
            .AnalysisRequests.Where(m => m.ProcedureId == uniqueId.Id)
            .ApplyWhere(procedureFindManyArgs.Where)
            .ApplySkip(procedureFindManyArgs.Skip)
            .ApplyTake(procedureFindManyArgs.Take)
            .ApplyOrderBy(procedureFindManyArgs.SortBy)
            .ToListAsync();

        return analysisRequests.Select(x => x.ToDto()).ToList();
    }

    /// <summary>
    /// Update multiple Analysis Requests records for Procedure
    /// </summary>
    public async Task UpdateAnalysisRequests(
        ProcedureWhereUniqueInput uniqueId,
        AnalysisRequestWhereUniqueInput[] analysisRequestsId
    )
    {
        var procedure = await _context
            .Procedures.Include(t => t.AnalysisRequests)
            .FirstOrDefaultAsync(x => x.Id == uniqueId.Id);
        if (procedure == null)
        {
            throw new NotFoundException();
        }

        var analysisRequests = await _context
            .AnalysisRequests.Where(a => analysisRequestsId.Select(x => x.Id).Contains(a.Id))
            .ToListAsync();

        if (analysisRequests.Count == 0)
        {
            throw new NotFoundException();
        }

        procedure.AnalysisRequests = analysisRequests;
        await _context.SaveChangesAsync();
    }

    /// <summary>
    /// Connect multiple Cancellation Requests records to Request
    /// </summary>
    public async Task ConnectCancellationRequests(
        ProcedureWhereUniqueInput uniqueId,
        CancellationRequestWhereUniqueInput[] cancellationRequestsId
    )
    {
        var parent = await _context
            .Procedures.Include(x => x.CancellationRequests)
            .FirstOrDefaultAsync(x => x.Id == uniqueId.Id);
        if (parent == null)
        {
            throw new NotFoundException();
        }

        var cancellationRequests = await _context
            .CancellationRequests.Where(t =>
                cancellationRequestsId.Select(x => x.Id).Contains(t.Id)
            )
            .ToListAsync();
        if (cancellationRequests.Count == 0)
        {
            throw new NotFoundException();
        }

        var cancellationRequestsToConnect = cancellationRequests.Except(
            parent.CancellationRequests
        );

        foreach (var cancellationRequest in cancellationRequestsToConnect)
        {
            parent.CancellationRequests.Add(cancellationRequest);
        }

        await _context.SaveChangesAsync();
    }

    /// <summary>
    /// Disconnect multiple Cancellation Requests records from Request
    /// </summary>
    public async Task DisconnectCancellationRequests(
        ProcedureWhereUniqueInput uniqueId,
        CancellationRequestWhereUniqueInput[] cancellationRequestsId
    )
    {
        var parent = await _context
            .Procedures.Include(x => x.CancellationRequests)
            .FirstOrDefaultAsync(x => x.Id == uniqueId.Id);
        if (parent == null)
        {
            throw new NotFoundException();
        }

        var cancellationRequests = await _context
            .CancellationRequests.Where(t =>
                cancellationRequestsId.Select(x => x.Id).Contains(t.Id)
            )
            .ToListAsync();

        foreach (var cancellationRequest in cancellationRequests)
        {
            parent.CancellationRequests?.Remove(cancellationRequest);
        }
        await _context.SaveChangesAsync();
    }

    /// <summary>
    /// Find multiple Cancellation Requests records for Request
    /// </summary>
    public async Task<List<CancellationRequest>> FindCancellationRequests(
        ProcedureWhereUniqueInput uniqueId,
        CancellationRequestFindManyArgs procedureFindManyArgs
    )
    {
        var cancellationRequests = await _context
            .CancellationRequests.Where(m => m.RequestId == uniqueId.Id)
            .ApplyWhere(procedureFindManyArgs.Where)
            .ApplySkip(procedureFindManyArgs.Skip)
            .ApplyTake(procedureFindManyArgs.Take)
            .ApplyOrderBy(procedureFindManyArgs.SortBy)
            .ToListAsync();

        return cancellationRequests.Select(x => x.ToDto()).ToList();
    }

    /// <summary>
    /// Update multiple Cancellation Requests records for Request
    /// </summary>
    public async Task UpdateCancellationRequests(
        ProcedureWhereUniqueInput uniqueId,
        CancellationRequestWhereUniqueInput[] cancellationRequestsId
    )
    {
        var procedure = await _context
            .Procedures.Include(t => t.CancellationRequests)
            .FirstOrDefaultAsync(x => x.Id == uniqueId.Id);
        if (procedure == null)
        {
            throw new NotFoundException();
        }

        var cancellationRequests = await _context
            .CancellationRequests.Where(a =>
                cancellationRequestsId.Select(x => x.Id).Contains(a.Id)
            )
            .ToListAsync();

        if (cancellationRequests.Count == 0)
        {
            throw new NotFoundException();
        }

        procedure.CancellationRequests = cancellationRequests;
        await _context.SaveChangesAsync();
    }

    /// <summary>
    /// Connect multiple Common Active Goods Requests records to Journal
    /// </summary>
    public async Task ConnectCommonActiveGoodsRequests(
        ProcedureWhereUniqueInput uniqueId,
        CommonActiveGoodsRequestWhereUniqueInput[] commonActiveGoodsRequestsId
    )
    {
        var parent = await _context
            .Procedures.Include(x => x.CommonActiveGoodsRequests)
            .FirstOrDefaultAsync(x => x.Id == uniqueId.Id);
        if (parent == null)
        {
            throw new NotFoundException();
        }

        var commonActiveGoodsRequests = await _context
            .CommonActiveGoodsRequests.Where(t =>
                commonActiveGoodsRequestsId.Select(x => x.Id).Contains(t.Id)
            )
            .ToListAsync();
        if (commonActiveGoodsRequests.Count == 0)
        {
            throw new NotFoundException();
        }

        var commonActiveGoodsRequestsToConnect = commonActiveGoodsRequests.Except(
            parent.CommonActiveGoodsRequests
        );

        foreach (var commonActiveGoodsRequest in commonActiveGoodsRequestsToConnect)
        {
            parent.CommonActiveGoodsRequests.Add(commonActiveGoodsRequest);
        }

        await _context.SaveChangesAsync();
    }

    /// <summary>
    /// Disconnect multiple Common Active Goods Requests records from Journal
    /// </summary>
    public async Task DisconnectCommonActiveGoodsRequests(
        ProcedureWhereUniqueInput uniqueId,
        CommonActiveGoodsRequestWhereUniqueInput[] commonActiveGoodsRequestsId
    )
    {
        var parent = await _context
            .Procedures.Include(x => x.CommonActiveGoodsRequests)
            .FirstOrDefaultAsync(x => x.Id == uniqueId.Id);
        if (parent == null)
        {
            throw new NotFoundException();
        }

        var commonActiveGoodsRequests = await _context
            .CommonActiveGoodsRequests.Where(t =>
                commonActiveGoodsRequestsId.Select(x => x.Id).Contains(t.Id)
            )
            .ToListAsync();

        foreach (var commonActiveGoodsRequest in commonActiveGoodsRequests)
        {
            parent.CommonActiveGoodsRequests?.Remove(commonActiveGoodsRequest);
        }
        await _context.SaveChangesAsync();
    }

    /// <summary>
    /// Find multiple Common Active Goods Requests records for Journal
    /// </summary>
    public async Task<List<CommonActiveGoodsRequest>> FindCommonActiveGoodsRequests(
        ProcedureWhereUniqueInput uniqueId,
        CommonActiveGoodsRequestFindManyArgs procedureFindManyArgs
    )
    {
        var commonActiveGoodsRequests = await _context
            .CommonActiveGoodsRequests.Where(m => m.JournalId == uniqueId.Id)
            .ApplyWhere(procedureFindManyArgs.Where)
            .ApplySkip(procedureFindManyArgs.Skip)
            .ApplyTake(procedureFindManyArgs.Take)
            .ApplyOrderBy(procedureFindManyArgs.SortBy)
            .ToListAsync();

        return commonActiveGoodsRequests.Select(x => x.ToDto()).ToList();
    }

    /// <summary>
    /// Update multiple Common Active Goods Requests records for Journal
    /// </summary>
    public async Task UpdateCommonActiveGoodsRequests(
        ProcedureWhereUniqueInput uniqueId,
        CommonActiveGoodsRequestWhereUniqueInput[] commonActiveGoodsRequestsId
    )
    {
        var procedure = await _context
            .Procedures.Include(t => t.CommonActiveGoodsRequests)
            .FirstOrDefaultAsync(x => x.Id == uniqueId.Id);
        if (procedure == null)
        {
            throw new NotFoundException();
        }

        var commonActiveGoodsRequests = await _context
            .CommonActiveGoodsRequests.Where(a =>
                commonActiveGoodsRequestsId.Select(x => x.Id).Contains(a.Id)
            )
            .ToListAsync();

        if (commonActiveGoodsRequests.Count == 0)
        {
            throw new NotFoundException();
        }

        procedure.CommonActiveGoodsRequests = commonActiveGoodsRequests;
        await _context.SaveChangesAsync();
    }

    /// <summary>
    /// Get a Common Detailed Declaration record for Request
    /// </summary>
    public async Task<CommonDetailedDeclaration> GetCommonDetailedDeclaration(
        ProcedureWhereUniqueInput uniqueId
    )
    {
        var procedure = await _context
            .Procedures.Where(procedure => procedure.Id == uniqueId.Id)
            .Include(procedure => procedure.CommonDetailedDeclaration)
            .FirstOrDefaultAsync();
        if (procedure == null)
        {
            throw new NotFoundException();
        }
        return procedure.CommonDetailedDeclaration.ToDto();
    }

    /// <summary>
    /// Connect multiple Common Express Clearances records to Procedure
    /// </summary>
    public async Task ConnectCommonExpressClearances(
        ProcedureWhereUniqueInput uniqueId,
        CommonExpressClearanceWhereUniqueInput[] commonExpressClearancesId
    )
    {
        var parent = await _context
            .Procedures.Include(x => x.CommonExpressClearances)
            .FirstOrDefaultAsync(x => x.Id == uniqueId.Id);
        if (parent == null)
        {
            throw new NotFoundException();
        }

        var commonExpressClearances = await _context
            .CommonExpressClearances.Where(t =>
                commonExpressClearancesId.Select(x => x.Id).Contains(t.Id)
            )
            .ToListAsync();
        if (commonExpressClearances.Count == 0)
        {
            throw new NotFoundException();
        }

        var commonExpressClearancesToConnect = commonExpressClearances.Except(
            parent.CommonExpressClearances
        );

        foreach (var commonExpressClearance in commonExpressClearancesToConnect)
        {
            parent.CommonExpressClearances.Add(commonExpressClearance);
        }

        await _context.SaveChangesAsync();
    }

    /// <summary>
    /// Disconnect multiple Common Express Clearances records from Procedure
    /// </summary>
    public async Task DisconnectCommonExpressClearances(
        ProcedureWhereUniqueInput uniqueId,
        CommonExpressClearanceWhereUniqueInput[] commonExpressClearancesId
    )
    {
        var parent = await _context
            .Procedures.Include(x => x.CommonExpressClearances)
            .FirstOrDefaultAsync(x => x.Id == uniqueId.Id);
        if (parent == null)
        {
            throw new NotFoundException();
        }

        var commonExpressClearances = await _context
            .CommonExpressClearances.Where(t =>
                commonExpressClearancesId.Select(x => x.Id).Contains(t.Id)
            )
            .ToListAsync();

        foreach (var commonExpressClearance in commonExpressClearances)
        {
            parent.CommonExpressClearances?.Remove(commonExpressClearance);
        }
        await _context.SaveChangesAsync();
    }

    /// <summary>
    /// Find multiple Common Express Clearances records for Procedure
    /// </summary>
    public async Task<List<CommonExpressClearance>> FindCommonExpressClearances(
        ProcedureWhereUniqueInput uniqueId,
        CommonExpressClearanceFindManyArgs procedureFindManyArgs
    )
    {
        var commonExpressClearances = await _context
            .CommonExpressClearances.Where(m => m.ProcedureId == uniqueId.Id)
            .ApplyWhere(procedureFindManyArgs.Where)
            .ApplySkip(procedureFindManyArgs.Skip)
            .ApplyTake(procedureFindManyArgs.Take)
            .ApplyOrderBy(procedureFindManyArgs.SortBy)
            .ToListAsync();

        return commonExpressClearances.Select(x => x.ToDto()).ToList();
    }

    /// <summary>
    /// Update multiple Common Express Clearances records for Procedure
    /// </summary>
    public async Task UpdateCommonExpressClearances(
        ProcedureWhereUniqueInput uniqueId,
        CommonExpressClearanceWhereUniqueInput[] commonExpressClearancesId
    )
    {
        var procedure = await _context
            .Procedures.Include(t => t.CommonExpressClearances)
            .FirstOrDefaultAsync(x => x.Id == uniqueId.Id);
        if (procedure == null)
        {
            throw new NotFoundException();
        }

        var commonExpressClearances = await _context
            .CommonExpressClearances.Where(a =>
                commonExpressClearancesId.Select(x => x.Id).Contains(a.Id)
            )
            .ToListAsync();

        if (commonExpressClearances.Count == 0)
        {
            throw new NotFoundException();
        }

        procedure.CommonExpressClearances = commonExpressClearances;
        await _context.SaveChangesAsync();
    }

    /// <summary>
    /// Connect multiple Common Origin Certificate Requests records to Request
    /// </summary>
    public async Task ConnectCommonOriginCertificateRequests(
        ProcedureWhereUniqueInput uniqueId,
        CommonOriginCertificateRequestWhereUniqueInput[] commonOriginCertificateRequestsId
    )
    {
        var parent = await _context
            .Procedures.Include(x => x.CommonOriginCertificateRequests)
            .FirstOrDefaultAsync(x => x.Id == uniqueId.Id);
        if (parent == null)
        {
            throw new NotFoundException();
        }

        var commonOriginCertificateRequests = await _context
            .CommonOriginCertificateRequests.Where(t =>
                commonOriginCertificateRequestsId.Select(x => x.Id).Contains(t.Id)
            )
            .ToListAsync();
        if (commonOriginCertificateRequests.Count == 0)
        {
            throw new NotFoundException();
        }

        var commonOriginCertificateRequestsToConnect = commonOriginCertificateRequests.Except(
            parent.CommonOriginCertificateRequests
        );

        foreach (var commonOriginCertificateRequest in commonOriginCertificateRequestsToConnect)
        {
            parent.CommonOriginCertificateRequests.Add(commonOriginCertificateRequest);
        }

        await _context.SaveChangesAsync();
    }

    /// <summary>
    /// Disconnect multiple Common Origin Certificate Requests records from Request
    /// </summary>
    public async Task DisconnectCommonOriginCertificateRequests(
        ProcedureWhereUniqueInput uniqueId,
        CommonOriginCertificateRequestWhereUniqueInput[] commonOriginCertificateRequestsId
    )
    {
        var parent = await _context
            .Procedures.Include(x => x.CommonOriginCertificateRequests)
            .FirstOrDefaultAsync(x => x.Id == uniqueId.Id);
        if (parent == null)
        {
            throw new NotFoundException();
        }

        var commonOriginCertificateRequests = await _context
            .CommonOriginCertificateRequests.Where(t =>
                commonOriginCertificateRequestsId.Select(x => x.Id).Contains(t.Id)
            )
            .ToListAsync();

        foreach (var commonOriginCertificateRequest in commonOriginCertificateRequests)
        {
            parent.CommonOriginCertificateRequests?.Remove(commonOriginCertificateRequest);
        }
        await _context.SaveChangesAsync();
    }

    /// <summary>
    /// Find multiple Common Origin Certificate Requests records for Request
    /// </summary>
    public async Task<List<CommonOriginCertificateRequest>> FindCommonOriginCertificateRequests(
        ProcedureWhereUniqueInput uniqueId,
        CommonOriginCertificateRequestFindManyArgs procedureFindManyArgs
    )
    {
        var commonOriginCertificateRequests = await _context
            .CommonOriginCertificateRequests.Where(m => m.RequestId == uniqueId.Id)
            .ApplyWhere(procedureFindManyArgs.Where)
            .ApplySkip(procedureFindManyArgs.Skip)
            .ApplyTake(procedureFindManyArgs.Take)
            .ApplyOrderBy(procedureFindManyArgs.SortBy)
            .ToListAsync();

        return commonOriginCertificateRequests.Select(x => x.ToDto()).ToList();
    }

    /// <summary>
    /// Update multiple Common Origin Certificate Requests records for Request
    /// </summary>
    public async Task UpdateCommonOriginCertificateRequests(
        ProcedureWhereUniqueInput uniqueId,
        CommonOriginCertificateRequestWhereUniqueInput[] commonOriginCertificateRequestsId
    )
    {
        var procedure = await _context
            .Procedures.Include(t => t.CommonOriginCertificateRequests)
            .FirstOrDefaultAsync(x => x.Id == uniqueId.Id);
        if (procedure == null)
        {
            throw new NotFoundException();
        }

        var commonOriginCertificateRequests = await _context
            .CommonOriginCertificateRequests.Where(a =>
                commonOriginCertificateRequestsId.Select(x => x.Id).Contains(a.Id)
            )
            .ToListAsync();

        if (commonOriginCertificateRequests.Count == 0)
        {
            throw new NotFoundException();
        }

        procedure.CommonOriginCertificateRequests = commonOriginCertificateRequests;
        await _context.SaveChangesAsync();
    }

    /// <summary>
    /// Connect multiple Common Regime Requests records to Journal
    /// </summary>
    public async Task ConnectCommonRegimeRequests(
        ProcedureWhereUniqueInput uniqueId,
        CommonRegimeRequestWhereUniqueInput[] commonRegimeRequestsId
    )
    {
        var parent = await _context
            .Procedures.Include(x => x.CommonRegimeRequests)
            .FirstOrDefaultAsync(x => x.Id == uniqueId.Id);
        if (parent == null)
        {
            throw new NotFoundException();
        }

        var commonRegimeRequests = await _context
            .CommonRegimeRequests.Where(t =>
                commonRegimeRequestsId.Select(x => x.Id).Contains(t.Id)
            )
            .ToListAsync();
        if (commonRegimeRequests.Count == 0)
        {
            throw new NotFoundException();
        }

        var commonRegimeRequestsToConnect = commonRegimeRequests.Except(
            parent.CommonRegimeRequests
        );

        foreach (var commonRegimeRequest in commonRegimeRequestsToConnect)
        {
            parent.CommonRegimeRequests.Add(commonRegimeRequest);
        }

        await _context.SaveChangesAsync();
    }

    /// <summary>
    /// Disconnect multiple Common Regime Requests records from Journal
    /// </summary>
    public async Task DisconnectCommonRegimeRequests(
        ProcedureWhereUniqueInput uniqueId,
        CommonRegimeRequestWhereUniqueInput[] commonRegimeRequestsId
    )
    {
        var parent = await _context
            .Procedures.Include(x => x.CommonRegimeRequests)
            .FirstOrDefaultAsync(x => x.Id == uniqueId.Id);
        if (parent == null)
        {
            throw new NotFoundException();
        }

        var commonRegimeRequests = await _context
            .CommonRegimeRequests.Where(t =>
                commonRegimeRequestsId.Select(x => x.Id).Contains(t.Id)
            )
            .ToListAsync();

        foreach (var commonRegimeRequest in commonRegimeRequests)
        {
            parent.CommonRegimeRequests?.Remove(commonRegimeRequest);
        }
        await _context.SaveChangesAsync();
    }

    /// <summary>
    /// Find multiple Common Regime Requests records for Journal
    /// </summary>
    public async Task<List<CommonRegimeRequest>> FindCommonRegimeRequests(
        ProcedureWhereUniqueInput uniqueId,
        CommonRegimeRequestFindManyArgs procedureFindManyArgs
    )
    {
        var commonRegimeRequests = await _context
            .CommonRegimeRequests.Where(m => m.JournalId == uniqueId.Id)
            .ApplyWhere(procedureFindManyArgs.Where)
            .ApplySkip(procedureFindManyArgs.Skip)
            .ApplyTake(procedureFindManyArgs.Take)
            .ApplyOrderBy(procedureFindManyArgs.SortBy)
            .ToListAsync();

        return commonRegimeRequests.Select(x => x.ToDto()).ToList();
    }

    /// <summary>
    /// Update multiple Common Regime Requests records for Journal
    /// </summary>
    public async Task UpdateCommonRegimeRequests(
        ProcedureWhereUniqueInput uniqueId,
        CommonRegimeRequestWhereUniqueInput[] commonRegimeRequestsId
    )
    {
        var procedure = await _context
            .Procedures.Include(t => t.CommonRegimeRequests)
            .FirstOrDefaultAsync(x => x.Id == uniqueId.Id);
        if (procedure == null)
        {
            throw new NotFoundException();
        }

        var commonRegimeRequests = await _context
            .CommonRegimeRequests.Where(a =>
                commonRegimeRequestsId.Select(x => x.Id).Contains(a.Id)
            )
            .ToListAsync();

        if (commonRegimeRequests.Count == 0)
        {
            throw new NotFoundException();
        }

        procedure.CommonRegimeRequests = commonRegimeRequests;
        await _context.SaveChangesAsync();
    }

    /// <summary>
    /// Connect multiple Foreign Operator Requests records to Request
    /// </summary>
    public async Task ConnectForeignOperatorRequests(
        ProcedureWhereUniqueInput uniqueId,
        ForeignOperatorRequestWhereUniqueInput[] foreignOperatorRequestsId
    )
    {
        var parent = await _context
            .Procedures.Include(x => x.ForeignOperatorRequests)
            .FirstOrDefaultAsync(x => x.Id == uniqueId.Id);
        if (parent == null)
        {
            throw new NotFoundException();
        }

        var foreignOperatorRequests = await _context
            .ForeignOperatorRequests.Where(t =>
                foreignOperatorRequestsId.Select(x => x.Id).Contains(t.Id)
            )
            .ToListAsync();
        if (foreignOperatorRequests.Count == 0)
        {
            throw new NotFoundException();
        }

        var foreignOperatorRequestsToConnect = foreignOperatorRequests.Except(
            parent.ForeignOperatorRequests
        );

        foreach (var foreignOperatorRequest in foreignOperatorRequestsToConnect)
        {
            parent.ForeignOperatorRequests.Add(foreignOperatorRequest);
        }

        await _context.SaveChangesAsync();
    }

    /// <summary>
    /// Disconnect multiple Foreign Operator Requests records from Request
    /// </summary>
    public async Task DisconnectForeignOperatorRequests(
        ProcedureWhereUniqueInput uniqueId,
        ForeignOperatorRequestWhereUniqueInput[] foreignOperatorRequestsId
    )
    {
        var parent = await _context
            .Procedures.Include(x => x.ForeignOperatorRequests)
            .FirstOrDefaultAsync(x => x.Id == uniqueId.Id);
        if (parent == null)
        {
            throw new NotFoundException();
        }

        var foreignOperatorRequests = await _context
            .ForeignOperatorRequests.Where(t =>
                foreignOperatorRequestsId.Select(x => x.Id).Contains(t.Id)
            )
            .ToListAsync();

        foreach (var foreignOperatorRequest in foreignOperatorRequests)
        {
            parent.ForeignOperatorRequests?.Remove(foreignOperatorRequest);
        }
        await _context.SaveChangesAsync();
    }

    /// <summary>
    /// Find multiple Foreign Operator Requests records for Request
    /// </summary>
    public async Task<List<ForeignOperatorRequest>> FindForeignOperatorRequests(
        ProcedureWhereUniqueInput uniqueId,
        ForeignOperatorRequestFindManyArgs procedureFindManyArgs
    )
    {
        var foreignOperatorRequests = await _context
            .ForeignOperatorRequests.Where(m => m.RequestId == uniqueId.Id)
            .ApplyWhere(procedureFindManyArgs.Where)
            .ApplySkip(procedureFindManyArgs.Skip)
            .ApplyTake(procedureFindManyArgs.Take)
            .ApplyOrderBy(procedureFindManyArgs.SortBy)
            .ToListAsync();

        return foreignOperatorRequests.Select(x => x.ToDto()).ToList();
    }

    /// <summary>
    /// Update multiple Foreign Operator Requests records for Request
    /// </summary>
    public async Task UpdateForeignOperatorRequests(
        ProcedureWhereUniqueInput uniqueId,
        ForeignOperatorRequestWhereUniqueInput[] foreignOperatorRequestsId
    )
    {
        var procedure = await _context
            .Procedures.Include(t => t.ForeignOperatorRequests)
            .FirstOrDefaultAsync(x => x.Id == uniqueId.Id);
        if (procedure == null)
        {
            throw new NotFoundException();
        }

        var foreignOperatorRequests = await _context
            .ForeignOperatorRequests.Where(a =>
                foreignOperatorRequestsId.Select(x => x.Id).Contains(a.Id)
            )
            .ToListAsync();

        if (foreignOperatorRequests.Count == 0)
        {
            throw new NotFoundException();
        }

        procedure.ForeignOperatorRequests = foreignOperatorRequests;
        await _context.SaveChangesAsync();
    }

    /// <summary>
    /// Connect multiple Postal Goods Clearances records to Procedure
    /// </summary>
    public async Task ConnectPostalGoodsClearances(
        ProcedureWhereUniqueInput uniqueId,
        PostalGoodsClearanceWhereUniqueInput[] postalGoodsClearancesId
    )
    {
        var parent = await _context
            .Procedures.Include(x => x.PostalGoodsClearances)
            .FirstOrDefaultAsync(x => x.Id == uniqueId.Id);
        if (parent == null)
        {
            throw new NotFoundException();
        }

        var postalGoodsClearances = await _context
            .PostalGoodsClearances.Where(t =>
                postalGoodsClearancesId.Select(x => x.Id).Contains(t.Id)
            )
            .ToListAsync();
        if (postalGoodsClearances.Count == 0)
        {
            throw new NotFoundException();
        }

        var postalGoodsClearancesToConnect = postalGoodsClearances.Except(
            parent.PostalGoodsClearances
        );

        foreach (var postalGoodsClearance in postalGoodsClearancesToConnect)
        {
            parent.PostalGoodsClearances.Add(postalGoodsClearance);
        }

        await _context.SaveChangesAsync();
    }

    /// <summary>
    /// Disconnect multiple Postal Goods Clearances records from Procedure
    /// </summary>
    public async Task DisconnectPostalGoodsClearances(
        ProcedureWhereUniqueInput uniqueId,
        PostalGoodsClearanceWhereUniqueInput[] postalGoodsClearancesId
    )
    {
        var parent = await _context
            .Procedures.Include(x => x.PostalGoodsClearances)
            .FirstOrDefaultAsync(x => x.Id == uniqueId.Id);
        if (parent == null)
        {
            throw new NotFoundException();
        }

        var postalGoodsClearances = await _context
            .PostalGoodsClearances.Where(t =>
                postalGoodsClearancesId.Select(x => x.Id).Contains(t.Id)
            )
            .ToListAsync();

        foreach (var postalGoodsClearance in postalGoodsClearances)
        {
            parent.PostalGoodsClearances?.Remove(postalGoodsClearance);
        }
        await _context.SaveChangesAsync();
    }

    /// <summary>
    /// Find multiple Postal Goods Clearances records for Procedure
    /// </summary>
    public async Task<List<PostalGoodsClearance>> FindPostalGoodsClearances(
        ProcedureWhereUniqueInput uniqueId,
        PostalGoodsClearanceFindManyArgs procedureFindManyArgs
    )
    {
        var postalGoodsClearances = await _context
            .PostalGoodsClearances.Where(m => m.ProcedureId == uniqueId.Id)
            .ApplyWhere(procedureFindManyArgs.Where)
            .ApplySkip(procedureFindManyArgs.Skip)
            .ApplyTake(procedureFindManyArgs.Take)
            .ApplyOrderBy(procedureFindManyArgs.SortBy)
            .ToListAsync();

        return postalGoodsClearances.Select(x => x.ToDto()).ToList();
    }

    /// <summary>
    /// Update multiple Postal Goods Clearances records for Procedure
    /// </summary>
    public async Task UpdatePostalGoodsClearances(
        ProcedureWhereUniqueInput uniqueId,
        PostalGoodsClearanceWhereUniqueInput[] postalGoodsClearancesId
    )
    {
        var procedure = await _context
            .Procedures.Include(t => t.PostalGoodsClearances)
            .FirstOrDefaultAsync(x => x.Id == uniqueId.Id);
        if (procedure == null)
        {
            throw new NotFoundException();
        }

        var postalGoodsClearances = await _context
            .PostalGoodsClearances.Where(a =>
                postalGoodsClearancesId.Select(x => x.Id).Contains(a.Id)
            )
            .ToListAsync();

        if (postalGoodsClearances.Count == 0)
        {
            throw new NotFoundException();
        }

        procedure.PostalGoodsClearances = postalGoodsClearances;
        await _context.SaveChangesAsync();
    }

    /// <summary>
    /// Connect multiple Postal Parcel Simplified Clearances records to Procedure
    /// </summary>
    public async Task ConnectPostalParcelSimplifiedClearances(
        ProcedureWhereUniqueInput uniqueId,
        PostalParcelSimplifiedClearanceWhereUniqueInput[] postalParcelSimplifiedClearancesId
    )
    {
        var parent = await _context
            .Procedures.Include(x => x.PostalParcelSimplifiedClearances)
            .FirstOrDefaultAsync(x => x.Id == uniqueId.Id);
        if (parent == null)
        {
            throw new NotFoundException();
        }

        var postalParcelSimplifiedClearances = await _context
            .PostalParcelSimplifiedClearances.Where(t =>
                postalParcelSimplifiedClearancesId.Select(x => x.Id).Contains(t.Id)
            )
            .ToListAsync();
        if (postalParcelSimplifiedClearances.Count == 0)
        {
            throw new NotFoundException();
        }

        var postalParcelSimplifiedClearancesToConnect = postalParcelSimplifiedClearances.Except(
            parent.PostalParcelSimplifiedClearances
        );

        foreach (var postalParcelSimplifiedClearance in postalParcelSimplifiedClearancesToConnect)
        {
            parent.PostalParcelSimplifiedClearances.Add(postalParcelSimplifiedClearance);
        }

        await _context.SaveChangesAsync();
    }

    /// <summary>
    /// Disconnect multiple Postal Parcel Simplified Clearances records from Procedure
    /// </summary>
    public async Task DisconnectPostalParcelSimplifiedClearances(
        ProcedureWhereUniqueInput uniqueId,
        PostalParcelSimplifiedClearanceWhereUniqueInput[] postalParcelSimplifiedClearancesId
    )
    {
        var parent = await _context
            .Procedures.Include(x => x.PostalParcelSimplifiedClearances)
            .FirstOrDefaultAsync(x => x.Id == uniqueId.Id);
        if (parent == null)
        {
            throw new NotFoundException();
        }

        var postalParcelSimplifiedClearances = await _context
            .PostalParcelSimplifiedClearances.Where(t =>
                postalParcelSimplifiedClearancesId.Select(x => x.Id).Contains(t.Id)
            )
            .ToListAsync();

        foreach (var postalParcelSimplifiedClearance in postalParcelSimplifiedClearances)
        {
            parent.PostalParcelSimplifiedClearances?.Remove(postalParcelSimplifiedClearance);
        }
        await _context.SaveChangesAsync();
    }

    /// <summary>
    /// Find multiple Postal Parcel Simplified Clearances records for Procedure
    /// </summary>
    public async Task<List<PostalParcelSimplifiedClearance>> FindPostalParcelSimplifiedClearances(
        ProcedureWhereUniqueInput uniqueId,
        PostalParcelSimplifiedClearanceFindManyArgs procedureFindManyArgs
    )
    {
        var postalParcelSimplifiedClearances = await _context
            .PostalParcelSimplifiedClearances.Where(m => m.ProcedureId == uniqueId.Id)
            .ApplyWhere(procedureFindManyArgs.Where)
            .ApplySkip(procedureFindManyArgs.Skip)
            .ApplyTake(procedureFindManyArgs.Take)
            .ApplyOrderBy(procedureFindManyArgs.SortBy)
            .ToListAsync();

        return postalParcelSimplifiedClearances.Select(x => x.ToDto()).ToList();
    }

    /// <summary>
    /// Update multiple Postal Parcel Simplified Clearances records for Procedure
    /// </summary>
    public async Task UpdatePostalParcelSimplifiedClearances(
        ProcedureWhereUniqueInput uniqueId,
        PostalParcelSimplifiedClearanceWhereUniqueInput[] postalParcelSimplifiedClearancesId
    )
    {
        var procedure = await _context
            .Procedures.Include(t => t.PostalParcelSimplifiedClearances)
            .FirstOrDefaultAsync(x => x.Id == uniqueId.Id);
        if (procedure == null)
        {
            throw new NotFoundException();
        }

        var postalParcelSimplifiedClearances = await _context
            .PostalParcelSimplifiedClearances.Where(a =>
                postalParcelSimplifiedClearancesId.Select(x => x.Id).Contains(a.Id)
            )
            .ToListAsync();

        if (postalParcelSimplifiedClearances.Count == 0)
        {
            throw new NotFoundException();
        }

        procedure.PostalParcelSimplifiedClearances = postalParcelSimplifiedClearances;
        await _context.SaveChangesAsync();
    }

    /// <summary>
    /// Connect multiple Recourse Requests records to Journal
    /// </summary>
    public async Task ConnectRecourseRequests(
        ProcedureWhereUniqueInput uniqueId,
        RecourseRequestWhereUniqueInput[] recourseRequestsId
    )
    {
        var parent = await _context
            .Procedures.Include(x => x.RecourseRequests)
            .FirstOrDefaultAsync(x => x.Id == uniqueId.Id);
        if (parent == null)
        {
            throw new NotFoundException();
        }

        var recourseRequests = await _context
            .RecourseRequests.Where(t => recourseRequestsId.Select(x => x.Id).Contains(t.Id))
            .ToListAsync();
        if (recourseRequests.Count == 0)
        {
            throw new NotFoundException();
        }

        var recourseRequestsToConnect = recourseRequests.Except(parent.RecourseRequests);

        foreach (var recourseRequest in recourseRequestsToConnect)
        {
            parent.RecourseRequests.Add(recourseRequest);
        }

        await _context.SaveChangesAsync();
    }

    /// <summary>
    /// Disconnect multiple Recourse Requests records from Journal
    /// </summary>
    public async Task DisconnectRecourseRequests(
        ProcedureWhereUniqueInput uniqueId,
        RecourseRequestWhereUniqueInput[] recourseRequestsId
    )
    {
        var parent = await _context
            .Procedures.Include(x => x.RecourseRequests)
            .FirstOrDefaultAsync(x => x.Id == uniqueId.Id);
        if (parent == null)
        {
            throw new NotFoundException();
        }

        var recourseRequests = await _context
            .RecourseRequests.Where(t => recourseRequestsId.Select(x => x.Id).Contains(t.Id))
            .ToListAsync();

        foreach (var recourseRequest in recourseRequests)
        {
            parent.RecourseRequests?.Remove(recourseRequest);
        }
        await _context.SaveChangesAsync();
    }

    /// <summary>
    /// Find multiple Recourse Requests records for Journal
    /// </summary>
    public async Task<List<RecourseRequest>> FindRecourseRequests(
        ProcedureWhereUniqueInput uniqueId,
        RecourseRequestFindManyArgs procedureFindManyArgs
    )
    {
        var recourseRequests = await _context
            .RecourseRequests.Where(m => m.JournalId == uniqueId.Id)
            .ApplyWhere(procedureFindManyArgs.Where)
            .ApplySkip(procedureFindManyArgs.Skip)
            .ApplyTake(procedureFindManyArgs.Take)
            .ApplyOrderBy(procedureFindManyArgs.SortBy)
            .ToListAsync();

        return recourseRequests.Select(x => x.ToDto()).ToList();
    }

    /// <summary>
    /// Update multiple Recourse Requests records for Journal
    /// </summary>
    public async Task UpdateRecourseRequests(
        ProcedureWhereUniqueInput uniqueId,
        RecourseRequestWhereUniqueInput[] recourseRequestsId
    )
    {
        var procedure = await _context
            .Procedures.Include(t => t.RecourseRequests)
            .FirstOrDefaultAsync(x => x.Id == uniqueId.Id);
        if (procedure == null)
        {
            throw new NotFoundException();
        }

        var recourseRequests = await _context
            .RecourseRequests.Where(a => recourseRequestsId.Select(x => x.Id).Contains(a.Id))
            .ToListAsync();

        if (recourseRequests.Count == 0)
        {
            throw new NotFoundException();
        }

        procedure.RecourseRequests = recourseRequests;
        await _context.SaveChangesAsync();
    }
}
