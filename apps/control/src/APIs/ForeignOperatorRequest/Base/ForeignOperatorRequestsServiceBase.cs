using Clre.APIs;
using Clre.APIs.Common;
using Clre.APIs.Dtos;
using Clre.APIs.Errors;
using Clre.APIs.Extensions;
using Clre.Infrastructure;
using Clre.Infrastructure.Models;
using Microsoft.EntityFrameworkCore;

namespace Clre.APIs;

public abstract class ForeignOperatorRequestsServiceBase : IForeignOperatorRequestsService
{
    protected readonly ClreDbContext _context;

    public ForeignOperatorRequestsServiceBase(ClreDbContext context)
    {
        _context = context;
    }

    /// <summary>
    /// Create one FOREIGN OPERATOR REQUEST
    /// </summary>
    public async Task<ForeignOperatorRequest> CreateForeignOperatorRequest(
        ForeignOperatorRequestCreateInput createDto
    )
    {
        var foreignOperatorRequest = new ForeignOperatorRequestDbModel
        {
            CreatedAt = createDto.CreatedAt,
            DateAndTimeOfFinalModification = createDto.DateAndTimeOfFinalModification,
            DateAndTimeOfFirstRegistration = createDto.DateAndTimeOfFirstRegistration,
            DeletionOn = createDto.DeletionOn,
            FinalModifierSId = createDto.FinalModifierSId,
            FirstRecorderSId = createDto.FirstRecorderSId,
            ForeignOperatorAddress = createDto.ForeignOperatorAddress,
            ForeignOperatorCityCode = createDto.ForeignOperatorCityCode,
            ForeignOperatorCode = createDto.ForeignOperatorCode,
            ForeignOperatorCompanyName = createDto.ForeignOperatorCompanyName,
            ForeignOperatorCountryCode = createDto.ForeignOperatorCountryCode,
            ForeignOperatorEmail = createDto.ForeignOperatorEmail,
            ForeignOperatorPhoneNumber = createDto.ForeignOperatorPhoneNumber,
            ForeignOperatorRepresentativeName = createDto.ForeignOperatorRepresentativeName,
            ForeignOperatorRequestNumber = createDto.ForeignOperatorRequestNumber,
            ProcessingDate = createDto.ProcessingDate,
            ProcessingStatusCode = createDto.ProcessingStatusCode,
            RequestDate = createDto.RequestDate,
            RequestReasonContent = createDto.RequestReasonContent,
            RequestTypeCode = createDto.RequestTypeCode,
            RequestingPersonId = createDto.RequestingPersonId,
            UpdatedAt = createDto.UpdatedAt,
            VerificationOpinionContent = createDto.VerificationOpinionContent
        };

        if (createDto.Id != null)
        {
            foreignOperatorRequest.Id = createDto.Id;
        }

        _context.ForeignOperatorRequests.Add(foreignOperatorRequest);
        await _context.SaveChangesAsync();

        var result = await _context.FindAsync<ForeignOperatorRequestDbModel>(
            foreignOperatorRequest.Id
        );

        if (result == null)
        {
            throw new NotFoundException();
        }

        return result.ToDto();
    }

    /// <summary>
    /// Delete one FOREIGN OPERATOR REQUEST
    /// </summary>
    public async Task DeleteForeignOperatorRequest(ForeignOperatorRequestWhereUniqueInput uniqueId)
    {
        var foreignOperatorRequest = await _context.ForeignOperatorRequests.FindAsync(uniqueId.Id);
        if (foreignOperatorRequest == null)
        {
            throw new NotFoundException();
        }

        _context.ForeignOperatorRequests.Remove(foreignOperatorRequest);
        await _context.SaveChangesAsync();
    }

    /// <summary>
    /// Find many FOREIGN OPERATOR REQUESTS
    /// </summary>
    public async Task<List<ForeignOperatorRequest>> ForeignOperatorRequests(
        ForeignOperatorRequestFindManyArgs findManyArgs
    )
    {
        var foreignOperatorRequests = await _context
            .ForeignOperatorRequests.ApplyWhere(findManyArgs.Where)
            .ApplySkip(findManyArgs.Skip)
            .ApplyTake(findManyArgs.Take)
            .ApplyOrderBy(findManyArgs.SortBy)
            .ToListAsync();
        return foreignOperatorRequests.ConvertAll(foreignOperatorRequest =>
            foreignOperatorRequest.ToDto()
        );
    }

    /// <summary>
    /// Meta data about FOREIGN OPERATOR REQUEST records
    /// </summary>
    public async Task<MetadataDto> ForeignOperatorRequestsMeta(
        ForeignOperatorRequestFindManyArgs findManyArgs
    )
    {
        var count = await _context
            .ForeignOperatorRequests.ApplyWhere(findManyArgs.Where)
            .CountAsync();

        return new MetadataDto { Count = count };
    }

    /// <summary>
    /// Get one FOREIGN OPERATOR REQUEST
    /// </summary>
    public async Task<ForeignOperatorRequest> ForeignOperatorRequest(
        ForeignOperatorRequestWhereUniqueInput uniqueId
    )
    {
        var foreignOperatorRequests = await this.ForeignOperatorRequests(
            new ForeignOperatorRequestFindManyArgs
            {
                Where = new ForeignOperatorRequestWhereInput { Id = uniqueId.Id }
            }
        );
        var foreignOperatorRequest = foreignOperatorRequests.FirstOrDefault();
        if (foreignOperatorRequest == null)
        {
            throw new NotFoundException();
        }

        return foreignOperatorRequest;
    }

    /// <summary>
    /// Update one FOREIGN OPERATOR REQUEST
    /// </summary>
    public async Task UpdateForeignOperatorRequest(
        ForeignOperatorRequestWhereUniqueInput uniqueId,
        ForeignOperatorRequestUpdateInput updateDto
    )
    {
        var foreignOperatorRequest = updateDto.ToModel(uniqueId);

        _context.Entry(foreignOperatorRequest).State = EntityState.Modified;

        try
        {
            await _context.SaveChangesAsync();
        }
        catch (DbUpdateConcurrencyException)
        {
            if (!_context.ForeignOperatorRequests.Any(e => e.Id == foreignOperatorRequest.Id))
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
