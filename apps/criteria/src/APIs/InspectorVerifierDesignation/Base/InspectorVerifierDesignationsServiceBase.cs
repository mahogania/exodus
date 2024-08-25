using Criteria.APIs;
using Criteria.APIs.Common;
using Criteria.APIs.Dtos;
using Criteria.APIs.Errors;
using Criteria.APIs.Extensions;
using Criteria.Infrastructure;
using Criteria.Infrastructure.Models;
using Microsoft.EntityFrameworkCore;

namespace Criteria.APIs;

public abstract class InspectorVerifierDesignationsServiceBase
    : IInspectorVerifierDesignationsService
{
    protected readonly CriteriaDbContext _context;

    public InspectorVerifierDesignationsServiceBase(CriteriaDbContext context)
    {
        _context = context;
    }

    /// <summary>
    /// Create one Inspector Verifier Designation
    /// </summary>
    public async Task<InspectorVerifierDesignation> CreateInspectorVerifierDesignation(
        InspectorVerifierDesignationCreateInput createDto
    )
    {
        var inspectorVerifierDesignation = new InspectorVerifierDesignationDbModel
        {
            AgencyCode = createDto.AgencyCode,
            CreatedAt = createDto.CreatedAt,
            InspectorId = createDto.InspectorId,
            ServiceCode = createDto.ServiceCode,
            UpdatedAt = createDto.UpdatedAt,
            VerifierId = createDto.VerifierId
        };

        if (createDto.Id != null)
        {
            inspectorVerifierDesignation.Id = createDto.Id;
        }

        _context.InspectorVerifierDesignations.Add(inspectorVerifierDesignation);
        await _context.SaveChangesAsync();

        var result = await _context.FindAsync<InspectorVerifierDesignationDbModel>(
            inspectorVerifierDesignation.Id
        );

        if (result == null)
        {
            throw new NotFoundException();
        }

        return result.ToDto();
    }

    /// <summary>
    /// Delete one Inspector Verifier Designation
    /// </summary>
    public async Task DeleteInspectorVerifierDesignation(
        InspectorVerifierDesignationWhereUniqueInput uniqueId
    )
    {
        var inspectorVerifierDesignation = await _context.InspectorVerifierDesignations.FindAsync(
            uniqueId.Id
        );
        if (inspectorVerifierDesignation == null)
        {
            throw new NotFoundException();
        }

        _context.InspectorVerifierDesignations.Remove(inspectorVerifierDesignation);
        await _context.SaveChangesAsync();
    }

    /// <summary>
    /// Find many Inspector Verifier Designations
    /// </summary>
    public async Task<List<InspectorVerifierDesignation>> InspectorVerifierDesignations(
        InspectorVerifierDesignationFindManyArgs findManyArgs
    )
    {
        var inspectorVerifierDesignations = await _context
            .InspectorVerifierDesignations.ApplyWhere(findManyArgs.Where)
            .ApplySkip(findManyArgs.Skip)
            .ApplyTake(findManyArgs.Take)
            .ApplyOrderBy(findManyArgs.SortBy)
            .ToListAsync();
        return inspectorVerifierDesignations.ConvertAll(inspectorVerifierDesignation =>
            inspectorVerifierDesignation.ToDto()
        );
    }

    /// <summary>
    /// Meta data about Inspector Verifier Designation records
    /// </summary>
    public async Task<MetadataDto> InspectorVerifierDesignationsMeta(
        InspectorVerifierDesignationFindManyArgs findManyArgs
    )
    {
        var count = await _context
            .InspectorVerifierDesignations.ApplyWhere(findManyArgs.Where)
            .CountAsync();

        return new MetadataDto { Count = count };
    }

    /// <summary>
    /// Get one Inspector Verifier Designation
    /// </summary>
    public async Task<InspectorVerifierDesignation> InspectorVerifierDesignation(
        InspectorVerifierDesignationWhereUniqueInput uniqueId
    )
    {
        var inspectorVerifierDesignations = await this.InspectorVerifierDesignations(
            new InspectorVerifierDesignationFindManyArgs
            {
                Where = new InspectorVerifierDesignationWhereInput { Id = uniqueId.Id }
            }
        );
        var inspectorVerifierDesignation = inspectorVerifierDesignations.FirstOrDefault();
        if (inspectorVerifierDesignation == null)
        {
            throw new NotFoundException();
        }

        return inspectorVerifierDesignation;
    }

    /// <summary>
    /// Update one Inspector Verifier Designation
    /// </summary>
    public async Task UpdateInspectorVerifierDesignation(
        InspectorVerifierDesignationWhereUniqueInput uniqueId,
        InspectorVerifierDesignationUpdateInput updateDto
    )
    {
        var inspectorVerifierDesignation = updateDto.ToModel(uniqueId);

        _context.Entry(inspectorVerifierDesignation).State = EntityState.Modified;

        try
        {
            await _context.SaveChangesAsync();
        }
        catch (DbUpdateConcurrencyException)
        {
            if (
                !_context.InspectorVerifierDesignations.Any(e =>
                    e.Id == inspectorVerifierDesignation.Id
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
