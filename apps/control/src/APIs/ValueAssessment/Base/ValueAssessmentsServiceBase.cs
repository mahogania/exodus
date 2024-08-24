using Control.APIs;
using Control.APIs.Common;
using Control.APIs.Dtos;
using Control.APIs.Errors;
using Control.APIs.Extensions;
using Control.Infrastructure;
using Control.Infrastructure.Models;
using Microsoft.EntityFrameworkCore;

namespace Control.APIs;

public abstract class ValueAssessmentsServiceBase : IValueAssessmentsService
{
    protected readonly ControlDbContext _context;

    public ValueAssessmentsServiceBase(ControlDbContext context)
    {
        _context = context;
    }

    /// <summary>
    /// Create one Value Assessment
    /// </summary>
    public async Task<ValueAssessment> CreateValueAssessment(ValueAssessmentCreateInput createDto)
    {
        var valueAssessment = new ValueAssessmentDbModel
        {
            CreatedAt = createDto.CreatedAt,
            UpdatedAt = createDto.UpdatedAt
        };

        if (createDto.Id != null)
        {
            valueAssessment.Id = createDto.Id;
        }
        if (createDto.Articles != null)
        {
            valueAssessment.Articles = await _context
                .ArticleAssessments.Where(articleAssessment =>
                    createDto.Articles.Select(t => t.Id).Contains(articleAssessment.Id)
                )
                .ToListAsync();
        }

        if (createDto.CommonDetailedDeclarations != null)
        {
            valueAssessment.CommonDetailedDeclarations = await _context
                .CommonDetailedDeclarations.Where(commonDetailedDeclaration =>
                    createDto.CommonDetailedDeclarations.Id == commonDetailedDeclaration.Id
                )
                .FirstOrDefaultAsync();
        }

        _context.ValueAssessments.Add(valueAssessment);
        await _context.SaveChangesAsync();

        var result = await _context.FindAsync<ValueAssessmentDbModel>(valueAssessment.Id);

        if (result == null)
        {
            throw new NotFoundException();
        }

        return result.ToDto();
    }

    /// <summary>
    /// Delete one Value Assessment
    /// </summary>
    public async Task DeleteValueAssessment(ValueAssessmentWhereUniqueInput uniqueId)
    {
        var valueAssessment = await _context.ValueAssessments.FindAsync(uniqueId.Id);
        if (valueAssessment == null)
        {
            throw new NotFoundException();
        }

        _context.ValueAssessments.Remove(valueAssessment);
        await _context.SaveChangesAsync();
    }

    /// <summary>
    /// Find many Value Assessments
    /// </summary>
    public async Task<List<ValueAssessment>> ValueAssessments(
        ValueAssessmentFindManyArgs findManyArgs
    )
    {
        var valueAssessments = await _context
            .ValueAssessments.Include(x => x.CommonDetailedDeclarations)
            .Include(x => x.Articles)
            .ApplyWhere(findManyArgs.Where)
            .ApplySkip(findManyArgs.Skip)
            .ApplyTake(findManyArgs.Take)
            .ApplyOrderBy(findManyArgs.SortBy)
            .ToListAsync();
        return valueAssessments.ConvertAll(valueAssessment => valueAssessment.ToDto());
    }

    /// <summary>
    /// Meta data about Value Assessment records
    /// </summary>
    public async Task<MetadataDto> ValueAssessmentsMeta(ValueAssessmentFindManyArgs findManyArgs)
    {
        var count = await _context.ValueAssessments.ApplyWhere(findManyArgs.Where).CountAsync();

        return new MetadataDto { Count = count };
    }

    /// <summary>
    /// Get one Value Assessment
    /// </summary>
    public async Task<ValueAssessment> ValueAssessment(ValueAssessmentWhereUniqueInput uniqueId)
    {
        var valueAssessments = await this.ValueAssessments(
            new ValueAssessmentFindManyArgs
            {
                Where = new ValueAssessmentWhereInput { Id = uniqueId.Id }
            }
        );
        var valueAssessment = valueAssessments.FirstOrDefault();
        if (valueAssessment == null)
        {
            throw new NotFoundException();
        }

        return valueAssessment;
    }

    /// <summary>
    /// Update one Value Assessment
    /// </summary>
    public async Task UpdateValueAssessment(
        ValueAssessmentWhereUniqueInput uniqueId,
        ValueAssessmentUpdateInput updateDto
    )
    {
        var valueAssessment = updateDto.ToModel(uniqueId);

        if (updateDto.Articles != null)
        {
            valueAssessment.Articles = await _context
                .ArticleAssessments.Where(articleAssessment =>
                    updateDto.Articles.Select(t => t).Contains(articleAssessment.Id)
                )
                .ToListAsync();
        }

        _context.Entry(valueAssessment).State = EntityState.Modified;

        try
        {
            await _context.SaveChangesAsync();
        }
        catch (DbUpdateConcurrencyException)
        {
            if (!_context.ValueAssessments.Any(e => e.Id == valueAssessment.Id))
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
    /// Connect multiple Articles records to Value Assessment
    /// </summary>
    public async Task ConnectArticles(
        ValueAssessmentWhereUniqueInput uniqueId,
        ArticleAssessmentWhereUniqueInput[] articleAssessmentsId
    )
    {
        var parent = await _context
            .ValueAssessments.Include(x => x.Articles)
            .FirstOrDefaultAsync(x => x.Id == uniqueId.Id);
        if (parent == null)
        {
            throw new NotFoundException();
        }

        var articleAssessments = await _context
            .ArticleAssessments.Where(t => articleAssessmentsId.Select(x => x.Id).Contains(t.Id))
            .ToListAsync();
        if (articleAssessments.Count == 0)
        {
            throw new NotFoundException();
        }

        var articleAssessmentsToConnect = articleAssessments.Except(parent.Articles);

        foreach (var articleAssessment in articleAssessmentsToConnect)
        {
            parent.Articles.Add(articleAssessment);
        }

        await _context.SaveChangesAsync();
    }

    /// <summary>
    /// Disconnect multiple Articles records from Value Assessment
    /// </summary>
    public async Task DisconnectArticles(
        ValueAssessmentWhereUniqueInput uniqueId,
        ArticleAssessmentWhereUniqueInput[] articleAssessmentsId
    )
    {
        var parent = await _context
            .ValueAssessments.Include(x => x.Articles)
            .FirstOrDefaultAsync(x => x.Id == uniqueId.Id);
        if (parent == null)
        {
            throw new NotFoundException();
        }

        var articleAssessments = await _context
            .ArticleAssessments.Where(t => articleAssessmentsId.Select(x => x.Id).Contains(t.Id))
            .ToListAsync();

        foreach (var articleAssessment in articleAssessments)
        {
            parent.Articles?.Remove(articleAssessment);
        }
        await _context.SaveChangesAsync();
    }

    /// <summary>
    /// Find multiple Articles records for Value Assessment
    /// </summary>
    public async Task<List<ArticleAssessment>> FindArticles(
        ValueAssessmentWhereUniqueInput uniqueId,
        ArticleAssessmentFindManyArgs valueAssessmentFindManyArgs
    )
    {
        var articleAssessments = await _context
            .ArticleAssessments.Where(m => m.ValueAssessmentId == uniqueId.Id)
            .ApplyWhere(valueAssessmentFindManyArgs.Where)
            .ApplySkip(valueAssessmentFindManyArgs.Skip)
            .ApplyTake(valueAssessmentFindManyArgs.Take)
            .ApplyOrderBy(valueAssessmentFindManyArgs.SortBy)
            .ToListAsync();

        return articleAssessments.Select(x => x.ToDto()).ToList();
    }

    /// <summary>
    /// Update multiple Articles records for Value Assessment
    /// </summary>
    public async Task UpdateArticles(
        ValueAssessmentWhereUniqueInput uniqueId,
        ArticleAssessmentWhereUniqueInput[] articleAssessmentsId
    )
    {
        var valueAssessment = await _context
            .ValueAssessments.Include(t => t.Articles)
            .FirstOrDefaultAsync(x => x.Id == uniqueId.Id);
        if (valueAssessment == null)
        {
            throw new NotFoundException();
        }

        var articleAssessments = await _context
            .ArticleAssessments.Where(a => articleAssessmentsId.Select(x => x.Id).Contains(a.Id))
            .ToListAsync();

        if (articleAssessments.Count == 0)
        {
            throw new NotFoundException();
        }

        valueAssessment.Articles = articleAssessments;
        await _context.SaveChangesAsync();
    }

    /// <summary>
    /// Get a Common Detailed Declarations record for COMMON DETAILED DECLARATION (CUSTOMS) VALUE ASSESSMENT
    /// </summary>
    public async Task<CommonDetailedDeclaration> GetCommonDetailedDeclarations(
        ValueAssessmentWhereUniqueInput uniqueId
    )
    {
        var valueAssessment = await _context
            .ValueAssessments.Where(valueAssessment => valueAssessment.Id == uniqueId.Id)
            .Include(valueAssessment => valueAssessment.CommonDetailedDeclarations)
            .FirstOrDefaultAsync();
        if (valueAssessment == null)
        {
            throw new NotFoundException();
        }
        return valueAssessment.CommonDetailedDeclarations.ToDto();
    }
}
