using Collection.APIs;
using Collection.APIs.Common;
using Collection.APIs.Dtos;
using Collection.APIs.Errors;
using Collection.APIs.Extensions;
using Collection.Infrastructure;
using Collection.Infrastructure.Models;
using Microsoft.EntityFrameworkCore;

namespace Collection.APIs;

public abstract class BondReleasesServiceBase : IBondReleasesService
{
    protected readonly CollectionDbContext _context;

    public BondReleasesServiceBase(CollectionDbContext context)
    {
        _context = context;
    }

    /// <summary>
    /// Create one BOND RELEASE
    /// </summary>
    public async Task<BondRelease> CreateBondRelease(BondReleaseCreateInput createDto)
    {
        var bondRelease = new BondReleaseDbModel
        {
            AmountReturnedAfterRelease = createDto.AmountReturnedAfterRelease,
            BondReleaseMoment = createDto.BondReleaseMoment,
            CreatedAt = createDto.CreatedAt,
            DeletionOn = createDto.DeletionOn,
            FinalModificationDateAndTime = createDto.FinalModificationDateAndTime,
            FinalModifierId = createDto.FinalModifierId,
            FinalReleaseYn = createDto.FinalReleaseYn,
            FirstRegistrantId = createDto.FirstRegistrantId,
            FirstRegistrationDateAndTime = createDto.FirstRegistrationDateAndTime,
            NumberOfBondReleases = createDto.NumberOfBondReleases,
            ReferenceNo = createDto.ReferenceNo,
            ReferenceNumberTypeCode = createDto.ReferenceNumberTypeCode,
            ReferenceNumberUsed = createDto.ReferenceNumberUsed,
            RequestNo = createDto.RequestNo,
            UpdatedAt = createDto.UpdatedAt
        };

        if (createDto.Id != null)
        {
            bondRelease.Id = createDto.Id;
        }

        _context.BondReleases.Add(bondRelease);
        await _context.SaveChangesAsync();

        var result = await _context.FindAsync<BondReleaseDbModel>(bondRelease.Id);

        if (result == null)
        {
            throw new NotFoundException();
        }

        return result.ToDto();
    }

    /// <summary>
    /// Delete one BOND RELEASE
    /// </summary>
    public async Task DeleteBondRelease(BondReleaseWhereUniqueInput uniqueId)
    {
        var bondRelease = await _context.BondReleases.FindAsync(uniqueId.Id);
        if (bondRelease == null)
        {
            throw new NotFoundException();
        }

        _context.BondReleases.Remove(bondRelease);
        await _context.SaveChangesAsync();
    }

    /// <summary>
    /// Find many BOND RELEASES
    /// </summary>
    public async Task<List<BondRelease>> BondReleases(BondReleaseFindManyArgs findManyArgs)
    {
        var bondReleases = await _context
            .BondReleases.ApplyWhere(findManyArgs.Where)
            .ApplySkip(findManyArgs.Skip)
            .ApplyTake(findManyArgs.Take)
            .ApplyOrderBy(findManyArgs.SortBy)
            .ToListAsync();
        return bondReleases.ConvertAll(bondRelease => bondRelease.ToDto());
    }

    /// <summary>
    /// Meta data about BOND RELEASE records
    /// </summary>
    public async Task<MetadataDto> BondReleasesMeta(BondReleaseFindManyArgs findManyArgs)
    {
        var count = await _context.BondReleases.ApplyWhere(findManyArgs.Where).CountAsync();

        return new MetadataDto { Count = count };
    }

    /// <summary>
    /// Get one BOND RELEASE
    /// </summary>
    public async Task<BondRelease> BondRelease(BondReleaseWhereUniqueInput uniqueId)
    {
        var bondReleases = await this.BondReleases(
            new BondReleaseFindManyArgs { Where = new BondReleaseWhereInput { Id = uniqueId.Id } }
        );
        var bondRelease = bondReleases.FirstOrDefault();
        if (bondRelease == null)
        {
            throw new NotFoundException();
        }

        return bondRelease;
    }

    /// <summary>
    /// Update one BOND RELEASE
    /// </summary>
    public async Task UpdateBondRelease(
        BondReleaseWhereUniqueInput uniqueId,
        BondReleaseUpdateInput updateDto
    )
    {
        var bondRelease = updateDto.ToModel(uniqueId);

        _context.Entry(bondRelease).State = EntityState.Modified;

        try
        {
            await _context.SaveChangesAsync();
        }
        catch (DbUpdateConcurrencyException)
        {
            if (!_context.BondReleases.Any(e => e.Id == bondRelease.Id))
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
