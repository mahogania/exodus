using Control.APIs;
using Control.APIs.Common;
using Control.APIs.Dtos;
using Control.APIs.Errors;
using Control.APIs.Extensions;
using Control.Infrastructure;
using Control.Infrastructure.Models;
using Microsoft.EntityFrameworkCore;

namespace Control.APIs;

public abstract class VerificationResultsServiceBase : IVerificationResultsService
{
    protected readonly ControlDbContext _context;

    public VerificationResultsServiceBase(ControlDbContext context)
    {
        _context = context;
    }

    /// <summary>
    /// Create one Verification Result
    /// </summary>
    public async Task<VerificationResult> CreateVerificationResult(
        VerificationResultCreateInput createDto
    )
    {
        var verificationResult = new VerificationResultDbModel
        {
            CreatedAt = createDto.CreatedAt,
            DateAndTimeOfFinalModification = createDto.DateAndTimeOfFinalModification,
            DateAndTimeOfInitialRecord = createDto.DateAndTimeOfInitialRecord,
            DeletedOn = createDto.DeletedOn,
            FinalModifierId = createDto.FinalModifierId,
            InitialRecorderId = createDto.InitialRecorderId,
            InspectorId = createDto.InspectorId,
            UpdatedAt = createDto.UpdatedAt,
            VerificationCompletedOn = createDto.VerificationCompletedOn,
            VerificationResultContent = createDto.VerificationResultContent,
            VerificationResultRecordDate = createDto.VerificationResultRecordDate
        };

        if (createDto.Id != null)
        {
            verificationResult.Id = createDto.Id;
        }
        if (createDto.CommonVerification != null)
        {
            verificationResult.CommonVerification = await _context
                .CommonVerifications.Where(commonVerification =>
                    createDto.CommonVerification.Id == commonVerification.Id
                )
                .FirstOrDefaultAsync();
        }

        if (createDto.VerificationResultDetails != null)
        {
            verificationResult.VerificationResultDetails = await _context
                .VerificationResultDetails.Where(verificationResultDetail =>
                    createDto
                        .VerificationResultDetails.Select(t => t.Id)
                        .Contains(verificationResultDetail.Id)
                )
                .ToListAsync();
        }

        _context.VerificationResults.Add(verificationResult);
        await _context.SaveChangesAsync();

        var result = await _context.FindAsync<VerificationResultDbModel>(verificationResult.Id);

        if (result == null)
        {
            throw new NotFoundException();
        }

        return result.ToDto();
    }

    /// <summary>
    /// Delete one Verification Result
    /// </summary>
    public async Task DeleteVerificationResult(VerificationResultWhereUniqueInput uniqueId)
    {
        var verificationResult = await _context.VerificationResults.FindAsync(uniqueId.Id);
        if (verificationResult == null)
        {
            throw new NotFoundException();
        }

        _context.VerificationResults.Remove(verificationResult);
        await _context.SaveChangesAsync();
    }

    /// <summary>
    /// Find many Verification Results
    /// </summary>
    public async Task<List<VerificationResult>> VerificationResults(
        VerificationResultFindManyArgs findManyArgs
    )
    {
        var verificationResults = await _context
            .VerificationResults.Include(x => x.CommonVerification)
            .Include(x => x.VerificationResultDetails)
            .ApplyWhere(findManyArgs.Where)
            .ApplySkip(findManyArgs.Skip)
            .ApplyTake(findManyArgs.Take)
            .ApplyOrderBy(findManyArgs.SortBy)
            .ToListAsync();
        return verificationResults.ConvertAll(verificationResult => verificationResult.ToDto());
    }

    /// <summary>
    /// Meta data about Verification Result records
    /// </summary>
    public async Task<MetadataDto> VerificationResultsMeta(
        VerificationResultFindManyArgs findManyArgs
    )
    {
        var count = await _context.VerificationResults.ApplyWhere(findManyArgs.Where).CountAsync();

        return new MetadataDto { Count = count };
    }

    /// <summary>
    /// Get one Verification Result
    /// </summary>
    public async Task<VerificationResult> VerificationResult(
        VerificationResultWhereUniqueInput uniqueId
    )
    {
        var verificationResults = await this.VerificationResults(
            new VerificationResultFindManyArgs
            {
                Where = new VerificationResultWhereInput { Id = uniqueId.Id }
            }
        );
        var verificationResult = verificationResults.FirstOrDefault();
        if (verificationResult == null)
        {
            throw new NotFoundException();
        }

        return verificationResult;
    }

    /// <summary>
    /// Update one Verification Result
    /// </summary>
    public async Task UpdateVerificationResult(
        VerificationResultWhereUniqueInput uniqueId,
        VerificationResultUpdateInput updateDto
    )
    {
        var verificationResult = updateDto.ToModel(uniqueId);

        if (updateDto.VerificationResultDetails != null)
        {
            verificationResult.VerificationResultDetails = await _context
                .VerificationResultDetails.Where(verificationResultDetail =>
                    updateDto
                        .VerificationResultDetails.Select(t => t)
                        .Contains(verificationResultDetail.Id)
                )
                .ToListAsync();
        }

        _context.Entry(verificationResult).State = EntityState.Modified;

        try
        {
            await _context.SaveChangesAsync();
        }
        catch (DbUpdateConcurrencyException)
        {
            if (!_context.VerificationResults.Any(e => e.Id == verificationResult.Id))
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
    /// Get a Common Verification record for Verification Result
    /// </summary>
    public async Task<CommonVerification> GetCommonVerification(
        VerificationResultWhereUniqueInput uniqueId
    )
    {
        var verificationResult = await _context
            .VerificationResults.Where(verificationResult => verificationResult.Id == uniqueId.Id)
            .Include(verificationResult => verificationResult.CommonVerification)
            .FirstOrDefaultAsync();
        if (verificationResult == null)
        {
            throw new NotFoundException();
        }
        return verificationResult.CommonVerification.ToDto();
    }

    /// <summary>
    /// Connect multiple Verification Result Details records to Verification Result
    /// </summary>
    public async Task ConnectVerificationResultDetails(
        VerificationResultWhereUniqueInput uniqueId,
        VerificationResultDetailWhereUniqueInput[] verificationResultDetailsId
    )
    {
        var parent = await _context
            .VerificationResults.Include(x => x.VerificationResultDetails)
            .FirstOrDefaultAsync(x => x.Id == uniqueId.Id);
        if (parent == null)
        {
            throw new NotFoundException();
        }

        var verificationResultDetails = await _context
            .VerificationResultDetails.Where(t =>
                verificationResultDetailsId.Select(x => x.Id).Contains(t.Id)
            )
            .ToListAsync();
        if (verificationResultDetails.Count == 0)
        {
            throw new NotFoundException();
        }

        var verificationResultDetailsToConnect = verificationResultDetails.Except(
            parent.VerificationResultDetails
        );

        foreach (var verificationResultDetail in verificationResultDetailsToConnect)
        {
            parent.VerificationResultDetails.Add(verificationResultDetail);
        }

        await _context.SaveChangesAsync();
    }

    /// <summary>
    /// Disconnect multiple Verification Result Details records from Verification Result
    /// </summary>
    public async Task DisconnectVerificationResultDetails(
        VerificationResultWhereUniqueInput uniqueId,
        VerificationResultDetailWhereUniqueInput[] verificationResultDetailsId
    )
    {
        var parent = await _context
            .VerificationResults.Include(x => x.VerificationResultDetails)
            .FirstOrDefaultAsync(x => x.Id == uniqueId.Id);
        if (parent == null)
        {
            throw new NotFoundException();
        }

        var verificationResultDetails = await _context
            .VerificationResultDetails.Where(t =>
                verificationResultDetailsId.Select(x => x.Id).Contains(t.Id)
            )
            .ToListAsync();

        foreach (var verificationResultDetail in verificationResultDetails)
        {
            parent.VerificationResultDetails?.Remove(verificationResultDetail);
        }
        await _context.SaveChangesAsync();
    }

    /// <summary>
    /// Find multiple Verification Result Details records for Verification Result
    /// </summary>
    public async Task<List<VerificationResultDetail>> FindVerificationResultDetails(
        VerificationResultWhereUniqueInput uniqueId,
        VerificationResultDetailFindManyArgs verificationResultFindManyArgs
    )
    {
        var verificationResultDetails = await _context
            .VerificationResultDetails.Where(m => m.VerificationResultId == uniqueId.Id)
            .ApplyWhere(verificationResultFindManyArgs.Where)
            .ApplySkip(verificationResultFindManyArgs.Skip)
            .ApplyTake(verificationResultFindManyArgs.Take)
            .ApplyOrderBy(verificationResultFindManyArgs.SortBy)
            .ToListAsync();

        return verificationResultDetails.Select(x => x.ToDto()).ToList();
    }

    /// <summary>
    /// Update multiple Verification Result Details records for Verification Result
    /// </summary>
    public async Task UpdateVerificationResultDetails(
        VerificationResultWhereUniqueInput uniqueId,
        VerificationResultDetailWhereUniqueInput[] verificationResultDetailsId
    )
    {
        var verificationResult = await _context
            .VerificationResults.Include(t => t.VerificationResultDetails)
            .FirstOrDefaultAsync(x => x.Id == uniqueId.Id);
        if (verificationResult == null)
        {
            throw new NotFoundException();
        }

        var verificationResultDetails = await _context
            .VerificationResultDetails.Where(a =>
                verificationResultDetailsId.Select(x => x.Id).Contains(a.Id)
            )
            .ToListAsync();

        if (verificationResultDetails.Count == 0)
        {
            throw new NotFoundException();
        }

        verificationResult.VerificationResultDetails = verificationResultDetails;
        await _context.SaveChangesAsync();
    }
}
