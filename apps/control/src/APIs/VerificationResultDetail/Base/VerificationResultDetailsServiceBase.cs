using Control.APIs;
using Control.APIs.Common;
using Control.APIs.Dtos;
using Control.APIs.Errors;
using Control.APIs.Extensions;
using Control.Infrastructure;
using Control.Infrastructure.Models;
using Microsoft.EntityFrameworkCore;

namespace Control.APIs;

public abstract class VerificationResultDetailsServiceBase : IVerificationResultDetailsService
{
    protected readonly ControlDbContext _context;

    public VerificationResultDetailsServiceBase(ControlDbContext context)
    {
        _context = context;
    }

    /// <summary>
    /// Create one Verification Result Detail
    /// </summary>
    public async Task<VerificationResultDetail> CreateVerificationResultDetail(
        VerificationResultDetailCreateInput createDto
    )
    {
        var verificationResultDetail = new VerificationResultDetailDbModel
        {
            AlignmentOrder = createDto.AlignmentOrder,
            CreatedAt = createDto.CreatedAt,
            DateAndTimeOfFinalModification = createDto.DateAndTimeOfFinalModification,
            DateAndTimeOfInitialRecord = createDto.DateAndTimeOfInitialRecord,
            DeletedOn = createDto.DeletedOn,
            FinalModifierId = createDto.FinalModifierId,
            InitialRecorderId = createDto.InitialRecorderId,
            UpdatedAt = createDto.UpdatedAt,
            VerificationResultCode = createDto.VerificationResultCode
        };

        if (createDto.Id != null)
        {
            verificationResultDetail.Id = createDto.Id;
        }
        if (createDto.VerificationResult != null)
        {
            verificationResultDetail.VerificationResult = await _context
                .VerificationResults.Where(verificationResult =>
                    createDto.VerificationResult.Id == verificationResult.Id
                )
                .FirstOrDefaultAsync();
        }

        _context.VerificationResultDetails.Add(verificationResultDetail);
        await _context.SaveChangesAsync();

        var result = await _context.FindAsync<VerificationResultDetailDbModel>(
            verificationResultDetail.Id
        );

        if (result == null)
        {
            throw new NotFoundException();
        }

        return result.ToDto();
    }

    /// <summary>
    /// Delete one Verification Result Detail
    /// </summary>
    public async Task DeleteVerificationResultDetail(
        VerificationResultDetailWhereUniqueInput uniqueId
    )
    {
        var verificationResultDetail = await _context.VerificationResultDetails.FindAsync(
            uniqueId.Id
        );
        if (verificationResultDetail == null)
        {
            throw new NotFoundException();
        }

        _context.VerificationResultDetails.Remove(verificationResultDetail);
        await _context.SaveChangesAsync();
    }

    /// <summary>
    /// Find many Verification Result Details
    /// </summary>
    public async Task<List<VerificationResultDetail>> VerificationResultDetails(
        VerificationResultDetailFindManyArgs findManyArgs
    )
    {
        var verificationResultDetails = await _context
            .VerificationResultDetails.Include(x => x.VerificationResult)
            .ApplyWhere(findManyArgs.Where)
            .ApplySkip(findManyArgs.Skip)
            .ApplyTake(findManyArgs.Take)
            .ApplyOrderBy(findManyArgs.SortBy)
            .ToListAsync();
        return verificationResultDetails.ConvertAll(verificationResultDetail =>
            verificationResultDetail.ToDto()
        );
    }

    /// <summary>
    /// Meta data about Verification Result Detail records
    /// </summary>
    public async Task<MetadataDto> VerificationResultDetailsMeta(
        VerificationResultDetailFindManyArgs findManyArgs
    )
    {
        var count = await _context
            .VerificationResultDetails.ApplyWhere(findManyArgs.Where)
            .CountAsync();

        return new MetadataDto { Count = count };
    }

    /// <summary>
    /// Get one Verification Result Detail
    /// </summary>
    public async Task<VerificationResultDetail> VerificationResultDetail(
        VerificationResultDetailWhereUniqueInput uniqueId
    )
    {
        var verificationResultDetails = await this.VerificationResultDetails(
            new VerificationResultDetailFindManyArgs
            {
                Where = new VerificationResultDetailWhereInput { Id = uniqueId.Id }
            }
        );
        var verificationResultDetail = verificationResultDetails.FirstOrDefault();
        if (verificationResultDetail == null)
        {
            throw new NotFoundException();
        }

        return verificationResultDetail;
    }

    /// <summary>
    /// Update one Verification Result Detail
    /// </summary>
    public async Task UpdateVerificationResultDetail(
        VerificationResultDetailWhereUniqueInput uniqueId,
        VerificationResultDetailUpdateInput updateDto
    )
    {
        var verificationResultDetail = updateDto.ToModel(uniqueId);

        _context.Entry(verificationResultDetail).State = EntityState.Modified;

        try
        {
            await _context.SaveChangesAsync();
        }
        catch (DbUpdateConcurrencyException)
        {
            if (!_context.VerificationResultDetails.Any(e => e.Id == verificationResultDetail.Id))
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
    /// Get a Verification Result record for Verification Result Detail
    /// </summary>
    public async Task<VerificationResult> GetVerificationResult(
        VerificationResultDetailWhereUniqueInput uniqueId
    )
    {
        var verificationResultDetail = await _context
            .VerificationResultDetails.Where(verificationResultDetail =>
                verificationResultDetail.Id == uniqueId.Id
            )
            .Include(verificationResultDetail => verificationResultDetail.VerificationResult)
            .FirstOrDefaultAsync();
        if (verificationResultDetail == null)
        {
            throw new NotFoundException();
        }
        return verificationResultDetail.VerificationResult.ToDto();
    }
}
