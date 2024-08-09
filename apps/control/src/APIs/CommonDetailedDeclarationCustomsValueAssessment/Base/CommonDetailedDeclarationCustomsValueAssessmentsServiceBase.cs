using Clre.APIs;
using Clre.APIs.Common;
using Clre.APIs.Dtos;
using Clre.APIs.Errors;
using Clre.APIs.Extensions;
using Clre.Infrastructure;
using Clre.Infrastructure.Models;
using Microsoft.EntityFrameworkCore;

namespace Clre.APIs;

public abstract class CommonDetailedDeclarationCustomsValueAssessmentsServiceBase
    : ICommonDetailedDeclarationCustomsValueAssessmentsService
{
    protected readonly ClreDbContext _context;

    public CommonDetailedDeclarationCustomsValueAssessmentsServiceBase(ClreDbContext context)
    {
        _context = context;
    }

    /// <summary>
    /// Create one COMMON DETAILED DECLARATION (CUSTOMS) VALUE ASSESSMENT
    /// </summary>
    public async Task<CommonDetailedDeclarationCustomsValueAssessment> CreateCommonDetailedDeclarationCustomsValueAssessment(
        CommonDetailedDeclarationCustomsValueAssessmentCreateInput createDto
    )
    {
        var commonDetailedDeclarationCustomsValueAssessment =
            new CommonDetailedDeclarationCustomsValueAssessmentDbModel
            {
                CreatedAt = createDto.CreatedAt,
                UpdatedAt = createDto.UpdatedAt
            };

        if (createDto.Id != null)
        {
            commonDetailedDeclarationCustomsValueAssessment.Id = createDto.Id;
        }

        _context.CommonDetailedDeclarationCustomsValueAssessments.Add(
            commonDetailedDeclarationCustomsValueAssessment
        );
        await _context.SaveChangesAsync();

        var result =
            await _context.FindAsync<CommonDetailedDeclarationCustomsValueAssessmentDbModel>(
                commonDetailedDeclarationCustomsValueAssessment.Id
            );

        if (result == null)
        {
            throw new NotFoundException();
        }

        return result.ToDto();
    }

    /// <summary>
    /// Delete one COMMON DETAILED DECLARATION (CUSTOMS) VALUE ASSESSMENT
    /// </summary>
    public async Task DeleteCommonDetailedDeclarationCustomsValueAssessment(
        CommonDetailedDeclarationCustomsValueAssessmentWhereUniqueInput uniqueId
    )
    {
        var commonDetailedDeclarationCustomsValueAssessment =
            await _context.CommonDetailedDeclarationCustomsValueAssessments.FindAsync(uniqueId.Id);
        if (commonDetailedDeclarationCustomsValueAssessment == null)
        {
            throw new NotFoundException();
        }

        _context.CommonDetailedDeclarationCustomsValueAssessments.Remove(
            commonDetailedDeclarationCustomsValueAssessment
        );
        await _context.SaveChangesAsync();
    }

    /// <summary>
    /// Find many COMMON DETAILED DECLARATION (CUSTOMS) VALUE ASSESSMENTS
    /// </summary>
    public async Task<
        List<CommonDetailedDeclarationCustomsValueAssessment>
    > CommonDetailedDeclarationCustomsValueAssessments(
        CommonDetailedDeclarationCustomsValueAssessmentFindManyArgs findManyArgs
    )
    {
        var commonDetailedDeclarationCustomsValueAssessments = await _context
            .CommonDetailedDeclarationCustomsValueAssessments.ApplyWhere(findManyArgs.Where)
            .ApplySkip(findManyArgs.Skip)
            .ApplyTake(findManyArgs.Take)
            .ApplyOrderBy(findManyArgs.SortBy)
            .ToListAsync();
        return commonDetailedDeclarationCustomsValueAssessments.ConvertAll(
            commonDetailedDeclarationCustomsValueAssessment =>
                commonDetailedDeclarationCustomsValueAssessment.ToDto()
        );
    }

    /// <summary>
    /// Meta data about COMMON DETAILED DECLARATION (CUSTOMS) VALUE ASSESSMENT records
    /// </summary>
    public async Task<MetadataDto> CommonDetailedDeclarationCustomsValueAssessmentsMeta(
        CommonDetailedDeclarationCustomsValueAssessmentFindManyArgs findManyArgs
    )
    {
        var count = await _context
            .CommonDetailedDeclarationCustomsValueAssessments.ApplyWhere(findManyArgs.Where)
            .CountAsync();

        return new MetadataDto { Count = count };
    }

    /// <summary>
    /// Get one COMMON DETAILED DECLARATION (CUSTOMS) VALUE ASSESSMENT
    /// </summary>
    public async Task<CommonDetailedDeclarationCustomsValueAssessment> CommonDetailedDeclarationCustomsValueAssessment(
        CommonDetailedDeclarationCustomsValueAssessmentWhereUniqueInput uniqueId
    )
    {
        var commonDetailedDeclarationCustomsValueAssessments =
            await this.CommonDetailedDeclarationCustomsValueAssessments(
                new CommonDetailedDeclarationCustomsValueAssessmentFindManyArgs
                {
                    Where = new CommonDetailedDeclarationCustomsValueAssessmentWhereInput
                    {
                        Id = uniqueId.Id
                    }
                }
            );
        var commonDetailedDeclarationCustomsValueAssessment =
            commonDetailedDeclarationCustomsValueAssessments.FirstOrDefault();
        if (commonDetailedDeclarationCustomsValueAssessment == null)
        {
            throw new NotFoundException();
        }

        return commonDetailedDeclarationCustomsValueAssessment;
    }

    /// <summary>
    /// Update one COMMON DETAILED DECLARATION (CUSTOMS) VALUE ASSESSMENT
    /// </summary>
    public async Task UpdateCommonDetailedDeclarationCustomsValueAssessment(
        CommonDetailedDeclarationCustomsValueAssessmentWhereUniqueInput uniqueId,
        CommonDetailedDeclarationCustomsValueAssessmentUpdateInput updateDto
    )
    {
        var commonDetailedDeclarationCustomsValueAssessment = updateDto.ToModel(uniqueId);

        _context.Entry(commonDetailedDeclarationCustomsValueAssessment).State =
            EntityState.Modified;

        try
        {
            await _context.SaveChangesAsync();
        }
        catch (DbUpdateConcurrencyException)
        {
            if (
                !_context.CommonDetailedDeclarationCustomsValueAssessments.Any(e =>
                    e.Id == commonDetailedDeclarationCustomsValueAssessment.Id
                )
            )
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
