using Control.APIs;
using Control.APIs.Common;
using Control.APIs.Dtos;
using Control.APIs.Errors;
using Control.APIs.Extensions;
using Control.Infrastructure;
using Control.Infrastructure.Models;
using Microsoft.EntityFrameworkCore;

namespace Control.APIs;

public abstract class AnalysisRequestsServiceBase : IAnalysisRequestsService
{
    protected readonly ControlDbContext _context;

    public AnalysisRequestsServiceBase(ControlDbContext context)
    {
        _context = context;
    }

    /// <summary>
    /// Create one Analysis Request
    /// </summary>
    public async Task<AnalysisRequest> CreateAnalysisRequest(AnalysisRequestCreateInput createDto)
    {
        var analysisRequest = new AnalysisRequestDbModel
        {
            AnalysisExpertiseRequestNumber = createDto.AnalysisExpertiseRequestNumber,
            ArticleNumber = createDto.ArticleNumber,
            AttachedFileId = createDto.AttachedFileId,
            ControlInstitutionName = createDto.ControlInstitutionName,
            ControlProcessingDateTime = createDto.ControlProcessingDateTime,
            CreatedAt = createDto.CreatedAt,
            DetailedDeclarationNumber = createDto.DetailedDeclarationNumber,
            InspectorName = createDto.InspectorName,
            NotificationOn = createDto.NotificationOn,
            ProcessingStatusCode = createDto.ProcessingStatusCode,
            RequestContents = createDto.RequestContents,
            RequestDate = createDto.RequestDate,
            RequestTypeCode = createDto.RequestTypeCode,
            RequesterId = createDto.RequesterId,
            SealNumber = createDto.SealNumber,
            UpdatedAt = createDto.UpdatedAt,
            VerificationResultCode = createDto.VerificationResultCode,
            VerificationResultContents = createDto.VerificationResultContents
        };

        if (createDto.Id != null)
        {
            analysisRequest.Id = createDto.Id;
        }
        if (createDto.Procedure != null)
        {
            analysisRequest.Procedure = await _context
                .Procedures.Where(procedure => createDto.Procedure.Id == procedure.Id)
                .FirstOrDefaultAsync();
        }

        if (createDto.SampleRequests != null)
        {
            analysisRequest.SampleRequests = await _context
                .SampleRequests.Where(sampleRequest =>
                    createDto.SampleRequests.Id == sampleRequest.Id
                )
                .FirstOrDefaultAsync();
        }

        _context.AnalysisRequests.Add(analysisRequest);
        await _context.SaveChangesAsync();

        var result = await _context.FindAsync<AnalysisRequestDbModel>(analysisRequest.Id);

        if (result == null)
        {
            throw new NotFoundException();
        }

        return result.ToDto();
    }

    /// <summary>
    /// Delete one Analysis Request
    /// </summary>
    public async Task DeleteAnalysisRequest(AnalysisRequestWhereUniqueInput uniqueId)
    {
        var analysisRequest = await _context.AnalysisRequests.FindAsync(uniqueId.Id);
        if (analysisRequest == null)
        {
            throw new NotFoundException();
        }

        _context.AnalysisRequests.Remove(analysisRequest);
        await _context.SaveChangesAsync();
    }

    /// <summary>
    /// Find many Analysis Requests
    /// </summary>
    public async Task<List<AnalysisRequest>> AnalysisRequests(
        AnalysisRequestFindManyArgs findManyArgs
    )
    {
        var analysisRequests = await _context
            .AnalysisRequests.Include(x => x.Procedure)
            .Include(x => x.SampleRequests)
            .ApplyWhere(findManyArgs.Where)
            .ApplySkip(findManyArgs.Skip)
            .ApplyTake(findManyArgs.Take)
            .ApplyOrderBy(findManyArgs.SortBy)
            .ToListAsync();
        return analysisRequests.ConvertAll(analysisRequest => analysisRequest.ToDto());
    }

    /// <summary>
    /// Meta data about Analysis Request records
    /// </summary>
    public async Task<MetadataDto> AnalysisRequestsMeta(AnalysisRequestFindManyArgs findManyArgs)
    {
        var count = await _context.AnalysisRequests.ApplyWhere(findManyArgs.Where).CountAsync();

        return new MetadataDto { Count = count };
    }

    /// <summary>
    /// Get one Analysis Request
    /// </summary>
    public async Task<AnalysisRequest> AnalysisRequest(AnalysisRequestWhereUniqueInput uniqueId)
    {
        var analysisRequests = await this.AnalysisRequests(
            new AnalysisRequestFindManyArgs
            {
                Where = new AnalysisRequestWhereInput { Id = uniqueId.Id }
            }
        );
        var analysisRequest = analysisRequests.FirstOrDefault();
        if (analysisRequest == null)
        {
            throw new NotFoundException();
        }

        return analysisRequest;
    }

    /// <summary>
    /// Update one Analysis Request
    /// </summary>
    public async Task UpdateAnalysisRequest(
        AnalysisRequestWhereUniqueInput uniqueId,
        AnalysisRequestUpdateInput updateDto
    )
    {
        var analysisRequest = updateDto.ToModel(uniqueId);

        _context.Entry(analysisRequest).State = EntityState.Modified;

        try
        {
            await _context.SaveChangesAsync();
        }
        catch (DbUpdateConcurrencyException)
        {
            if (!_context.AnalysisRequests.Any(e => e.Id == analysisRequest.Id))
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
    /// Get a Procedure record for Analysis Request
    /// </summary>
    public async Task<Procedure> GetProcedure(AnalysisRequestWhereUniqueInput uniqueId)
    {
        var analysisRequest = await _context
            .AnalysisRequests.Where(analysisRequest => analysisRequest.Id == uniqueId.Id)
            .Include(analysisRequest => analysisRequest.Procedure)
            .FirstOrDefaultAsync();
        if (analysisRequest == null)
        {
            throw new NotFoundException();
        }
        return analysisRequest.Procedure.ToDto();
    }

    /// <summary>
    /// Get a Sample Requests record for Analysis Request
    /// </summary>
    public async Task<SampleRequest> GetSampleRequests(AnalysisRequestWhereUniqueInput uniqueId)
    {
        var analysisRequest = await _context
            .AnalysisRequests.Where(analysisRequest => analysisRequest.Id == uniqueId.Id)
            .Include(analysisRequest => analysisRequest.SampleRequests)
            .FirstOrDefaultAsync();
        if (analysisRequest == null)
        {
            throw new NotFoundException();
        }
        return analysisRequest.SampleRequests.ToDto();
    }
}
