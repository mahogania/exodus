using Control.APIs;
using Control.APIs.Common;
using Control.APIs.Dtos;
using Control.APIs.Errors;
using Control.APIs.Extensions;
using Control.Infrastructure;
using Control.Infrastructure.Models;
using Microsoft.EntityFrameworkCore;

namespace Control.APIs;

public abstract class SampleRequestsServiceBase : ISampleRequestsService
{
    protected readonly ControlDbContext _context;

    public SampleRequestsServiceBase(ControlDbContext context)
    {
        _context = context;
    }

    /// <summary>
    /// Create one Sample Request
    /// </summary>
    public async Task<SampleRequest> CreateSampleRequest(SampleRequestCreateInput createDto)
    {
        var sampleRequest = new SampleRequestDbModel
        {
            AnalysisExpertiseRequestId = createDto.AnalysisExpertiseRequestId,
            ArticleName = createDto.ArticleName,
            CreatedAt = createDto.CreatedAt,
            DeclarantCode = createDto.DeclarantCode,
            DeclarantPresence = createDto.DeclarantPresence,
            DetailedDeclarationId = createDto.DetailedDeclarationId,
            Quantity = createDto.Quantity,
            RequestTypeId = createDto.RequestTypeId,
            RestitutedSampleQuantity = createDto.RestitutedSampleQuantity,
            RestitutedSampleWeight = createDto.RestitutedSampleWeight,
            SampleCollectionDate = createDto.SampleCollectionDate,
            SampleCollectionEndDate = createDto.SampleCollectionEndDate,
            SampleCollectionStartDate = createDto.SampleCollectionStartDate,
            SampleDescription = createDto.SampleDescription,
            SampleRequestDate = createDto.SampleRequestDate,
            SampleRestitution = createDto.SampleRestitution,
            SampleRestitutionConfirmation = createDto.SampleRestitutionConfirmation,
            SampleRestitutionDate = createDto.SampleRestitutionDate,
            SuspicionResultsContents = createDto.SuspicionResultsContents,
            UpdatedAt = createDto.UpdatedAt,
            Weight = createDto.Weight
        };

        if (createDto.Id != null)
        {
            sampleRequest.Id = createDto.Id;
        }
        if (createDto.AnalysisRequest != null)
        {
            sampleRequest.AnalysisRequest = await _context
                .AnalysisRequests.Where(analysisRequest =>
                    createDto.AnalysisRequest.Id == analysisRequest.Id
                )
                .FirstOrDefaultAsync();
        }

        if (createDto.Article != null)
        {
            sampleRequest.Article = await _context
                .Articles.Where(article => createDto.Article.Id == article.Id)
                .FirstOrDefaultAsync();
        }

        _context.SampleRequests.Add(sampleRequest);
        await _context.SaveChangesAsync();

        var result = await _context.FindAsync<SampleRequestDbModel>(sampleRequest.Id);

        if (result == null)
        {
            throw new NotFoundException();
        }

        return result.ToDto();
    }

    /// <summary>
    /// Delete one Sample Request
    /// </summary>
    public async Task DeleteSampleRequest(SampleRequestWhereUniqueInput uniqueId)
    {
        var sampleRequest = await _context.SampleRequests.FindAsync(uniqueId.Id);
        if (sampleRequest == null)
        {
            throw new NotFoundException();
        }

        _context.SampleRequests.Remove(sampleRequest);
        await _context.SaveChangesAsync();
    }

    /// <summary>
    /// Find many Sample Requests
    /// </summary>
    public async Task<List<SampleRequest>> SampleRequests(SampleRequestFindManyArgs findManyArgs)
    {
        var sampleRequests = await _context
            .SampleRequests.Include(x => x.Article)
            .Include(x => x.AnalysisRequest)
            .ApplyWhere(findManyArgs.Where)
            .ApplySkip(findManyArgs.Skip)
            .ApplyTake(findManyArgs.Take)
            .ApplyOrderBy(findManyArgs.SortBy)
            .ToListAsync();
        return sampleRequests.ConvertAll(sampleRequest => sampleRequest.ToDto());
    }

    /// <summary>
    /// Meta data about Sample Request records
    /// </summary>
    public async Task<MetadataDto> SampleRequestsMeta(SampleRequestFindManyArgs findManyArgs)
    {
        var count = await _context.SampleRequests.ApplyWhere(findManyArgs.Where).CountAsync();

        return new MetadataDto { Count = count };
    }

    /// <summary>
    /// Get one Sample Request
    /// </summary>
    public async Task<SampleRequest> SampleRequest(SampleRequestWhereUniqueInput uniqueId)
    {
        var sampleRequests = await this.SampleRequests(
            new SampleRequestFindManyArgs
            {
                Where = new SampleRequestWhereInput { Id = uniqueId.Id }
            }
        );
        var sampleRequest = sampleRequests.FirstOrDefault();
        if (sampleRequest == null)
        {
            throw new NotFoundException();
        }

        return sampleRequest;
    }

    /// <summary>
    /// Update one Sample Request
    /// </summary>
    public async Task UpdateSampleRequest(
        SampleRequestWhereUniqueInput uniqueId,
        SampleRequestUpdateInput updateDto
    )
    {
        var sampleRequest = updateDto.ToModel(uniqueId);

        _context.Entry(sampleRequest).State = EntityState.Modified;

        try
        {
            await _context.SaveChangesAsync();
        }
        catch (DbUpdateConcurrencyException)
        {
            if (!_context.SampleRequests.Any(e => e.Id == sampleRequest.Id))
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
    /// Get a Analysis Request record for Sample Request
    /// </summary>
    public async Task<AnalysisRequest> GetAnalysisRequest(SampleRequestWhereUniqueInput uniqueId)
    {
        var sampleRequest = await _context
            .SampleRequests.Where(sampleRequest => sampleRequest.Id == uniqueId.Id)
            .Include(sampleRequest => sampleRequest.AnalysisRequest)
            .FirstOrDefaultAsync();
        if (sampleRequest == null)
        {
            throw new NotFoundException();
        }
        return sampleRequest.AnalysisRequest.ToDto();
    }

    /// <summary>
    /// Get a article record for Sample Request
    /// </summary>
    public async Task<Article> GetArticle(SampleRequestWhereUniqueInput uniqueId)
    {
        var sampleRequest = await _context
            .SampleRequests.Where(sampleRequest => sampleRequest.Id == uniqueId.Id)
            .Include(sampleRequest => sampleRequest.Article)
            .FirstOrDefaultAsync();
        if (sampleRequest == null)
        {
            throw new NotFoundException();
        }
        return sampleRequest.Article.ToDto();
    }
}
