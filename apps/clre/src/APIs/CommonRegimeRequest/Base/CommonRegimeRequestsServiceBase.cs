using Clre.APIs;
using Clre.APIs.Common;
using Clre.APIs.Dtos;
using Clre.APIs.Errors;
using Clre.APIs.Extensions;
using Clre.Infrastructure;
using Clre.Infrastructure.Models;
using Microsoft.EntityFrameworkCore;

namespace Clre.APIs;

public abstract class CommonRegimeRequestsServiceBase : ICommonRegimeRequestsService
{
    protected readonly ClreDbContext _context;

    public CommonRegimeRequestsServiceBase(ClreDbContext context)
    {
        _context = context;
    }

    /// <summary>
    /// Create one COMMON REGIME REQUEST
    /// </summary>
    public async Task<CommonRegimeRequest> CreateCommonRegimeRequest(
        CommonRegimeRequestCreateInput createDto
    )
    {
        var commonRegimeRequest = new CommonRegimeRequestDbModel
        {
            ApcCode = createDto.ApcCode,
            AttachedFileId = createDto.AttachedFileId,
            ComplementaryRequestContent = createDto.ComplementaryRequestContent,
            ComplementaryRequestResponseContent = createDto.ComplementaryRequestResponseContent,
            CreatedAt = createDto.CreatedAt,
            CustomsOfficeCode = createDto.CustomsOfficeCode,
            DateAndTimeOfFinalModification = createDto.DateAndTimeOfFinalModification,
            DateAndTimeOfFirstRegistration = createDto.DateAndTimeOfFirstRegistration,
            DeclarantCode = createDto.DeclarantCode,
            DeletionOn = createDto.DeletionOn,
            DocumentCode = createDto.DocumentCode,
            EpcCode = createDto.EpcCode,
            FinalModifierSId = createDto.FinalModifierSId,
            FinalOn = createDto.FinalOn,
            FirstRecorderSId = createDto.FirstRecorderSId,
            ProcessingStatusCode = createDto.ProcessingStatusCode,
            RectificationFrequency = createDto.RectificationFrequency,
            RegimeRequestContent = createDto.RegimeRequestContent,
            RegimeRequestNumber = createDto.RegimeRequestNumber,
            RegimeRequestTitle = createDto.RegimeRequestTitle,
            RegimeValidationDate = createDto.RegimeValidationDate,
            RequestDate = createDto.RequestDate,
            UpdatedAt = createDto.UpdatedAt
        };

        if (createDto.Id != null)
        {
            commonRegimeRequest.Id = createDto.Id;
        }

        _context.CommonRegimeRequests.Add(commonRegimeRequest);
        await _context.SaveChangesAsync();

        var result = await _context.FindAsync<CommonRegimeRequestDbModel>(commonRegimeRequest.Id);

        if (result == null)
        {
            throw new NotFoundException();
        }

        return result.ToDto();
    }

    /// <summary>
    /// Delete one COMMON REGIME REQUEST
    /// </summary>
    public async Task DeleteCommonRegimeRequest(CommonRegimeRequestWhereUniqueInput uniqueId)
    {
        var commonRegimeRequest = await _context.CommonRegimeRequests.FindAsync(uniqueId.Id);
        if (commonRegimeRequest == null)
        {
            throw new NotFoundException();
        }

        _context.CommonRegimeRequests.Remove(commonRegimeRequest);
        await _context.SaveChangesAsync();
    }

    /// <summary>
    /// Find many COMMON REGIME REQUESTS
    /// </summary>
    public async Task<List<CommonRegimeRequest>> CommonRegimeRequests(
        CommonRegimeRequestFindManyArgs findManyArgs
    )
    {
        var commonRegimeRequests = await _context
            .CommonRegimeRequests.ApplyWhere(findManyArgs.Where)
            .ApplySkip(findManyArgs.Skip)
            .ApplyTake(findManyArgs.Take)
            .ApplyOrderBy(findManyArgs.SortBy)
            .ToListAsync();
        return commonRegimeRequests.ConvertAll(commonRegimeRequest => commonRegimeRequest.ToDto());
    }

    /// <summary>
    /// Meta data about COMMON REGIME REQUEST records
    /// </summary>
    public async Task<MetadataDto> CommonRegimeRequestsMeta(
        CommonRegimeRequestFindManyArgs findManyArgs
    )
    {
        var count = await _context.CommonRegimeRequests.ApplyWhere(findManyArgs.Where).CountAsync();

        return new MetadataDto { Count = count };
    }

    /// <summary>
    /// Get one COMMON REGIME REQUEST
    /// </summary>
    public async Task<CommonRegimeRequest> CommonRegimeRequest(
        CommonRegimeRequestWhereUniqueInput uniqueId
    )
    {
        var commonRegimeRequests = await this.CommonRegimeRequests(
            new CommonRegimeRequestFindManyArgs
            {
                Where = new CommonRegimeRequestWhereInput { Id = uniqueId.Id }
            }
        );
        var commonRegimeRequest = commonRegimeRequests.FirstOrDefault();
        if (commonRegimeRequest == null)
        {
            throw new NotFoundException();
        }

        return commonRegimeRequest;
    }

    /// <summary>
    /// Update one COMMON REGIME REQUEST
    /// </summary>
    public async Task UpdateCommonRegimeRequest(
        CommonRegimeRequestWhereUniqueInput uniqueId,
        CommonRegimeRequestUpdateInput updateDto
    )
    {
        var commonRegimeRequest = updateDto.ToModel(uniqueId);

        _context.Entry(commonRegimeRequest).State = EntityState.Modified;

        try
        {
            await _context.SaveChangesAsync();
        }
        catch (DbUpdateConcurrencyException)
        {
            if (!_context.CommonRegimeRequests.Any(e => e.Id == commonRegimeRequest.Id))
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
