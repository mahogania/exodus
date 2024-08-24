using Control.APIs;
using Control.APIs.Common;
using Control.APIs.Dtos;
using Control.APIs.Errors;
using Control.APIs.Extensions;
using Control.Infrastructure;
using Control.Infrastructure.Models;
using Microsoft.EntityFrameworkCore;

namespace Control.APIs;

public abstract class JournalsServiceBase : IJournalsService
{
    protected readonly ControlDbContext _context;

    public JournalsServiceBase(ControlDbContext context)
    {
        _context = context;
    }

    /// <summary>
    /// Create one Journal
    /// </summary>
    public async Task<Journal> CreateJournal(JournalCreateInput createDto)
    {
        var journal = new JournalDbModel
        {
            CreatedAt = createDto.CreatedAt,
            UpdatedAt = createDto.UpdatedAt
        };

        if (createDto.Id != null)
        {
            journal.Id = createDto.Id;
        }
        if (createDto.CancellationRequests != null)
        {
            journal.CancellationRequests = await _context
                .CancellationRequests.Where(cancellationRequest =>
                    createDto
                        .CancellationRequests.Select(t => t.Id)
                        .Contains(cancellationRequest.Id)
                )
                .ToListAsync();
        }

        if (createDto.CommonActiveGoodsRequests != null)
        {
            journal.CommonActiveGoodsRequests = await _context
                .CommonActiveGoodsRequests.Where(commonActiveGoodsRequest =>
                    createDto
                        .CommonActiveGoodsRequests.Select(t => t.Id)
                        .Contains(commonActiveGoodsRequest.Id)
                )
                .ToListAsync();
        }

        if (createDto.CommonDetailedDeclaration != null)
        {
            journal.CommonDetailedDeclaration = await _context
                .CommonDetailedDeclarations.Where(commonDetailedDeclaration =>
                    createDto.CommonDetailedDeclaration.Id == commonDetailedDeclaration.Id
                )
                .FirstOrDefaultAsync();
        }

        if (createDto.CommonOriginCertificateRequests != null)
        {
            journal.CommonOriginCertificateRequests = await _context
                .CommonOriginCertificateRequests.Where(commonOriginCertificateRequest =>
                    createDto
                        .CommonOriginCertificateRequests.Select(t => t.Id)
                        .Contains(commonOriginCertificateRequest.Id)
                )
                .ToListAsync();
        }

        if (createDto.CommonRegimeRequests != null)
        {
            journal.CommonRegimeRequests = await _context
                .CommonRegimeRequests.Where(commonRegimeRequest =>
                    createDto
                        .CommonRegimeRequests.Select(t => t.Id)
                        .Contains(commonRegimeRequest.Id)
                )
                .ToListAsync();
        }

        if (createDto.ForeignOperatorRequests != null)
        {
            journal.ForeignOperatorRequests = await _context
                .ForeignOperatorRequests.Where(foreignOperatorRequest =>
                    createDto
                        .ForeignOperatorRequests.Select(t => t.Id)
                        .Contains(foreignOperatorRequest.Id)
                )
                .ToListAsync();
        }

        _context.Journals.Add(journal);
        await _context.SaveChangesAsync();

        var result = await _context.FindAsync<JournalDbModel>(journal.Id);

        if (result == null)
        {
            throw new NotFoundException();
        }

        return result.ToDto();
    }

    /// <summary>
    /// Delete one Journal
    /// </summary>
    public async Task DeleteJournal(JournalWhereUniqueInput uniqueId)
    {
        var journal = await _context.Journals.FindAsync(uniqueId.Id);
        if (journal == null)
        {
            throw new NotFoundException();
        }

        _context.Journals.Remove(journal);
        await _context.SaveChangesAsync();
    }

    /// <summary>
    /// Find many Requests
    /// </summary>
    public async Task<List<Journal>> Journals(JournalFindManyArgs findManyArgs)
    {
        var journals = await _context
            .Journals.Include(x => x.ForeignOperatorRequests)
            .Include(x => x.CommonRegimeRequests)
            .Include(x => x.CommonDetailedDeclaration)
            .Include(x => x.CancellationRequests)
            .Include(x => x.CommonActiveGoodsRequests)
            .Include(x => x.CommonOriginCertificateRequests)
            .ApplyWhere(findManyArgs.Where)
            .ApplySkip(findManyArgs.Skip)
            .ApplyTake(findManyArgs.Take)
            .ApplyOrderBy(findManyArgs.SortBy)
            .ToListAsync();
        return journals.ConvertAll(journal => journal.ToDto());
    }

    /// <summary>
    /// Meta data about Journal records
    /// </summary>
    public async Task<MetadataDto> JournalsMeta(JournalFindManyArgs findManyArgs)
    {
        var count = await _context.Journals.ApplyWhere(findManyArgs.Where).CountAsync();

        return new MetadataDto { Count = count };
    }

    /// <summary>
    /// Get one Journal
    /// </summary>
    public async Task<Journal> Journal(JournalWhereUniqueInput uniqueId)
    {
        var journals = await this.Journals(
            new JournalFindManyArgs { Where = new JournalWhereInput { Id = uniqueId.Id } }
        );
        var journal = journals.FirstOrDefault();
        if (journal == null)
        {
            throw new NotFoundException();
        }

        return journal;
    }

    /// <summary>
    /// Update one Journal
    /// </summary>
    public async Task UpdateJournal(JournalWhereUniqueInput uniqueId, JournalUpdateInput updateDto)
    {
        var journal = updateDto.ToModel(uniqueId);

        if (updateDto.ForeignOperatorRequests != null)
        {
            journal.ForeignOperatorRequests = await _context
                .ForeignOperatorRequests.Where(foreignOperatorRequest =>
                    updateDto
                        .ForeignOperatorRequests.Select(t => t)
                        .Contains(foreignOperatorRequest.Id)
                )
                .ToListAsync();
        }

        if (updateDto.CommonRegimeRequests != null)
        {
            journal.CommonRegimeRequests = await _context
                .CommonRegimeRequests.Where(commonRegimeRequest =>
                    updateDto.CommonRegimeRequests.Select(t => t).Contains(commonRegimeRequest.Id)
                )
                .ToListAsync();
        }

        if (updateDto.CancellationRequests != null)
        {
            journal.CancellationRequests = await _context
                .CancellationRequests.Where(cancellationRequest =>
                    updateDto.CancellationRequests.Select(t => t).Contains(cancellationRequest.Id)
                )
                .ToListAsync();
        }

        if (updateDto.CommonActiveGoodsRequests != null)
        {
            journal.CommonActiveGoodsRequests = await _context
                .CommonActiveGoodsRequests.Where(commonActiveGoodsRequest =>
                    updateDto
                        .CommonActiveGoodsRequests.Select(t => t)
                        .Contains(commonActiveGoodsRequest.Id)
                )
                .ToListAsync();
        }

        if (updateDto.CommonOriginCertificateRequests != null)
        {
            journal.CommonOriginCertificateRequests = await _context
                .CommonOriginCertificateRequests.Where(commonOriginCertificateRequest =>
                    updateDto
                        .CommonOriginCertificateRequests.Select(t => t)
                        .Contains(commonOriginCertificateRequest.Id)
                )
                .ToListAsync();
        }

        _context.Entry(journal).State = EntityState.Modified;

        try
        {
            await _context.SaveChangesAsync();
        }
        catch (DbUpdateConcurrencyException)
        {
            if (!_context.Journals.Any(e => e.Id == journal.Id))
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
    /// Connect multiple Cancellation Requests records to Request
    /// </summary>
    public async Task ConnectCancellationRequests(
        JournalWhereUniqueInput uniqueId,
        CancellationRequestWhereUniqueInput[] cancellationRequestsId
    )
    {
        var parent = await _context
            .Journals.Include(x => x.CancellationRequests)
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
        JournalWhereUniqueInput uniqueId,
        CancellationRequestWhereUniqueInput[] cancellationRequestsId
    )
    {
        var parent = await _context
            .Journals.Include(x => x.CancellationRequests)
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
        JournalWhereUniqueInput uniqueId,
        CancellationRequestFindManyArgs journalFindManyArgs
    )
    {
        var cancellationRequests = await _context
            .CancellationRequests.Where(m => m.RequestId == uniqueId.Id)
            .ApplyWhere(journalFindManyArgs.Where)
            .ApplySkip(journalFindManyArgs.Skip)
            .ApplyTake(journalFindManyArgs.Take)
            .ApplyOrderBy(journalFindManyArgs.SortBy)
            .ToListAsync();

        return cancellationRequests.Select(x => x.ToDto()).ToList();
    }

    /// <summary>
    /// Update multiple Cancellation Requests records for Request
    /// </summary>
    public async Task UpdateCancellationRequests(
        JournalWhereUniqueInput uniqueId,
        CancellationRequestWhereUniqueInput[] cancellationRequestsId
    )
    {
        var journal = await _context
            .Journals.Include(t => t.CancellationRequests)
            .FirstOrDefaultAsync(x => x.Id == uniqueId.Id);
        if (journal == null)
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

        journal.CancellationRequests = cancellationRequests;
        await _context.SaveChangesAsync();
    }

    /// <summary>
    /// Connect multiple Common Active Goods Requests records to Journal
    /// </summary>
    public async Task ConnectCommonActiveGoodsRequests(
        JournalWhereUniqueInput uniqueId,
        CommonActiveGoodsRequestWhereUniqueInput[] commonActiveGoodsRequestsId
    )
    {
        var parent = await _context
            .Journals.Include(x => x.CommonActiveGoodsRequests)
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
        JournalWhereUniqueInput uniqueId,
        CommonActiveGoodsRequestWhereUniqueInput[] commonActiveGoodsRequestsId
    )
    {
        var parent = await _context
            .Journals.Include(x => x.CommonActiveGoodsRequests)
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
        JournalWhereUniqueInput uniqueId,
        CommonActiveGoodsRequestFindManyArgs journalFindManyArgs
    )
    {
        var commonActiveGoodsRequests = await _context
            .CommonActiveGoodsRequests.Where(m => m.JournalId == uniqueId.Id)
            .ApplyWhere(journalFindManyArgs.Where)
            .ApplySkip(journalFindManyArgs.Skip)
            .ApplyTake(journalFindManyArgs.Take)
            .ApplyOrderBy(journalFindManyArgs.SortBy)
            .ToListAsync();

        return commonActiveGoodsRequests.Select(x => x.ToDto()).ToList();
    }

    /// <summary>
    /// Update multiple Common Active Goods Requests records for Journal
    /// </summary>
    public async Task UpdateCommonActiveGoodsRequests(
        JournalWhereUniqueInput uniqueId,
        CommonActiveGoodsRequestWhereUniqueInput[] commonActiveGoodsRequestsId
    )
    {
        var journal = await _context
            .Journals.Include(t => t.CommonActiveGoodsRequests)
            .FirstOrDefaultAsync(x => x.Id == uniqueId.Id);
        if (journal == null)
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

        journal.CommonActiveGoodsRequests = commonActiveGoodsRequests;
        await _context.SaveChangesAsync();
    }

    /// <summary>
    /// Get a Common Detailed Declaration record for Request
    /// </summary>
    public async Task<CommonDetailedDeclaration> GetCommonDetailedDeclaration(
        JournalWhereUniqueInput uniqueId
    )
    {
        var journal = await _context
            .Journals.Where(journal => journal.Id == uniqueId.Id)
            .Include(journal => journal.CommonDetailedDeclaration)
            .FirstOrDefaultAsync();
        if (journal == null)
        {
            throw new NotFoundException();
        }
        return journal.CommonDetailedDeclaration.ToDto();
    }

    /// <summary>
    /// Connect multiple Common Origin Certificate Requests records to Request
    /// </summary>
    public async Task ConnectCommonOriginCertificateRequests(
        JournalWhereUniqueInput uniqueId,
        CommonOriginCertificateRequestWhereUniqueInput[] commonOriginCertificateRequestsId
    )
    {
        var parent = await _context
            .Journals.Include(x => x.CommonOriginCertificateRequests)
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
        JournalWhereUniqueInput uniqueId,
        CommonOriginCertificateRequestWhereUniqueInput[] commonOriginCertificateRequestsId
    )
    {
        var parent = await _context
            .Journals.Include(x => x.CommonOriginCertificateRequests)
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
        JournalWhereUniqueInput uniqueId,
        CommonOriginCertificateRequestFindManyArgs journalFindManyArgs
    )
    {
        var commonOriginCertificateRequests = await _context
            .CommonOriginCertificateRequests.Where(m => m.RequestId == uniqueId.Id)
            .ApplyWhere(journalFindManyArgs.Where)
            .ApplySkip(journalFindManyArgs.Skip)
            .ApplyTake(journalFindManyArgs.Take)
            .ApplyOrderBy(journalFindManyArgs.SortBy)
            .ToListAsync();

        return commonOriginCertificateRequests.Select(x => x.ToDto()).ToList();
    }

    /// <summary>
    /// Update multiple Common Origin Certificate Requests records for Request
    /// </summary>
    public async Task UpdateCommonOriginCertificateRequests(
        JournalWhereUniqueInput uniqueId,
        CommonOriginCertificateRequestWhereUniqueInput[] commonOriginCertificateRequestsId
    )
    {
        var journal = await _context
            .Journals.Include(t => t.CommonOriginCertificateRequests)
            .FirstOrDefaultAsync(x => x.Id == uniqueId.Id);
        if (journal == null)
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

        journal.CommonOriginCertificateRequests = commonOriginCertificateRequests;
        await _context.SaveChangesAsync();
    }

    /// <summary>
    /// Connect multiple Common Regime Requests records to Journal
    /// </summary>
    public async Task ConnectCommonRegimeRequests(
        JournalWhereUniqueInput uniqueId,
        CommonRegimeRequestWhereUniqueInput[] commonRegimeRequestsId
    )
    {
        var parent = await _context
            .Journals.Include(x => x.CommonRegimeRequests)
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
        JournalWhereUniqueInput uniqueId,
        CommonRegimeRequestWhereUniqueInput[] commonRegimeRequestsId
    )
    {
        var parent = await _context
            .Journals.Include(x => x.CommonRegimeRequests)
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
        JournalWhereUniqueInput uniqueId,
        CommonRegimeRequestFindManyArgs journalFindManyArgs
    )
    {
        var commonRegimeRequests = await _context
            .CommonRegimeRequests.Where(m => m.JournalId == uniqueId.Id)
            .ApplyWhere(journalFindManyArgs.Where)
            .ApplySkip(journalFindManyArgs.Skip)
            .ApplyTake(journalFindManyArgs.Take)
            .ApplyOrderBy(journalFindManyArgs.SortBy)
            .ToListAsync();

        return commonRegimeRequests.Select(x => x.ToDto()).ToList();
    }

    /// <summary>
    /// Update multiple Common Regime Requests records for Journal
    /// </summary>
    public async Task UpdateCommonRegimeRequests(
        JournalWhereUniqueInput uniqueId,
        CommonRegimeRequestWhereUniqueInput[] commonRegimeRequestsId
    )
    {
        var journal = await _context
            .Journals.Include(t => t.CommonRegimeRequests)
            .FirstOrDefaultAsync(x => x.Id == uniqueId.Id);
        if (journal == null)
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

        journal.CommonRegimeRequests = commonRegimeRequests;
        await _context.SaveChangesAsync();
    }

    /// <summary>
    /// Connect multiple Foreign Operator Requests records to Request
    /// </summary>
    public async Task ConnectForeignOperatorRequests(
        JournalWhereUniqueInput uniqueId,
        ForeignOperatorRequestWhereUniqueInput[] foreignOperatorRequestsId
    )
    {
        var parent = await _context
            .Journals.Include(x => x.ForeignOperatorRequests)
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
        JournalWhereUniqueInput uniqueId,
        ForeignOperatorRequestWhereUniqueInput[] foreignOperatorRequestsId
    )
    {
        var parent = await _context
            .Journals.Include(x => x.ForeignOperatorRequests)
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
        JournalWhereUniqueInput uniqueId,
        ForeignOperatorRequestFindManyArgs journalFindManyArgs
    )
    {
        var foreignOperatorRequests = await _context
            .ForeignOperatorRequests.Where(m => m.RequestId == uniqueId.Id)
            .ApplyWhere(journalFindManyArgs.Where)
            .ApplySkip(journalFindManyArgs.Skip)
            .ApplyTake(journalFindManyArgs.Take)
            .ApplyOrderBy(journalFindManyArgs.SortBy)
            .ToListAsync();

        return foreignOperatorRequests.Select(x => x.ToDto()).ToList();
    }

    /// <summary>
    /// Update multiple Foreign Operator Requests records for Request
    /// </summary>
    public async Task UpdateForeignOperatorRequests(
        JournalWhereUniqueInput uniqueId,
        ForeignOperatorRequestWhereUniqueInput[] foreignOperatorRequestsId
    )
    {
        var journal = await _context
            .Journals.Include(t => t.ForeignOperatorRequests)
            .FirstOrDefaultAsync(x => x.Id == uniqueId.Id);
        if (journal == null)
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

        journal.ForeignOperatorRequests = foreignOperatorRequests;
        await _context.SaveChangesAsync();
    }
}
