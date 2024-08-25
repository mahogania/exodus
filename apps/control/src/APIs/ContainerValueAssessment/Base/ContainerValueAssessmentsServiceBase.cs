using Control.APIs;
using Control.APIs.Common;
using Control.APIs.Dtos;
using Control.APIs.Errors;
using Control.APIs.Extensions;
using Control.Infrastructure;
using Control.Infrastructure.Models;
using Microsoft.EntityFrameworkCore;

namespace Control.APIs;

public abstract class ContainerValueAssessmentsServiceBase : IContainerValueAssessmentsService
{
    protected readonly ControlDbContext _context;

    public ContainerValueAssessmentsServiceBase(ControlDbContext context)
    {
        _context = context;
    }

    /// <summary>
    /// Create one Container Value Assessment
    /// </summary>
    public async Task<ContainerValueAssessment> CreateContainerValueAssessment(
        ContainerValueAssessmentCreateInput createDto
    )
    {
        var containerValueAssessment = new ContainerValueAssessmentDbModel
        {
            ContainerNumber = createDto.ContainerNumber,
            ContainerSequenceNumber = createDto.ContainerSequenceNumber,
            ContainerStuffingStateCode = createDto.ContainerStuffingStateCode,
            ContainerTypeCode = createDto.ContainerTypeCode,
            CreatedAt = createDto.CreatedAt,
            DateAndTimeOfFinalModification = createDto.DateAndTimeOfFinalModification,
            DateAndTimeOfInitialRecord = createDto.DateAndTimeOfInitialRecord,
            DeletedOn = createDto.DeletedOn,
            FinalModifierId = createDto.FinalModifierId,
            InitialRecorderId = createDto.InitialRecorderId,
            SealNumber1 = createDto.SealNumber1,
            SealNumber2_24310 = createDto.SealNumber2_24310,
            SealNumber3 = createDto.SealNumber3,
            SealingPersonCode = createDto.SealingPersonCode,
            UpdatedAt = createDto.UpdatedAt
        };

        if (createDto.Id != null)
        {
            containerValueAssessment.Id = createDto.Id;
        }
        if (createDto.CommonVerification != null)
        {
            containerValueAssessment.CommonVerification = await _context
                .CommonVerifications.Where(commonVerification =>
                    createDto.CommonVerification.Id == commonVerification.Id
                )
                .FirstOrDefaultAsync();
        }

        _context.ContainerValueAssessments.Add(containerValueAssessment);
        await _context.SaveChangesAsync();

        var result = await _context.FindAsync<ContainerValueAssessmentDbModel>(
            containerValueAssessment.Id
        );

        if (result == null)
        {
            throw new NotFoundException();
        }

        return result.ToDto();
    }

    /// <summary>
    /// Delete one Container Value Assessment
    /// </summary>
    public async Task DeleteContainerValueAssessment(
        ContainerValueAssessmentWhereUniqueInput uniqueId
    )
    {
        var containerValueAssessment = await _context.ContainerValueAssessments.FindAsync(
            uniqueId.Id
        );
        if (containerValueAssessment == null)
        {
            throw new NotFoundException();
        }

        _context.ContainerValueAssessments.Remove(containerValueAssessment);
        await _context.SaveChangesAsync();
    }

    /// <summary>
    /// Find many Value Evaluation_Containers
    /// </summary>
    public async Task<List<ContainerValueAssessment>> ContainerValueAssessments(
        ContainerValueAssessmentFindManyArgs findManyArgs
    )
    {
        var containerValueAssessments = await _context
            .ContainerValueAssessments.Include(x => x.CommonVerification)
            .ApplyWhere(findManyArgs.Where)
            .ApplySkip(findManyArgs.Skip)
            .ApplyTake(findManyArgs.Take)
            .ApplyOrderBy(findManyArgs.SortBy)
            .ToListAsync();
        return containerValueAssessments.ConvertAll(containerValueAssessment =>
            containerValueAssessment.ToDto()
        );
    }

    /// <summary>
    /// Meta data about Container Value Assessment records
    /// </summary>
    public async Task<MetadataDto> ContainerValueAssessmentsMeta(
        ContainerValueAssessmentFindManyArgs findManyArgs
    )
    {
        var count = await _context
            .ContainerValueAssessments.ApplyWhere(findManyArgs.Where)
            .CountAsync();

        return new MetadataDto { Count = count };
    }

    /// <summary>
    /// Get one Container Value Assessment
    /// </summary>
    public async Task<ContainerValueAssessment> ContainerValueAssessment(
        ContainerValueAssessmentWhereUniqueInput uniqueId
    )
    {
        var containerValueAssessments = await this.ContainerValueAssessments(
            new ContainerValueAssessmentFindManyArgs
            {
                Where = new ContainerValueAssessmentWhereInput { Id = uniqueId.Id }
            }
        );
        var containerValueAssessment = containerValueAssessments.FirstOrDefault();
        if (containerValueAssessment == null)
        {
            throw new NotFoundException();
        }

        return containerValueAssessment;
    }

    /// <summary>
    /// Update one Container Value Assessment
    /// </summary>
    public async Task UpdateContainerValueAssessment(
        ContainerValueAssessmentWhereUniqueInput uniqueId,
        ContainerValueAssessmentUpdateInput updateDto
    )
    {
        var containerValueAssessment = updateDto.ToModel(uniqueId);

        _context.Entry(containerValueAssessment).State = EntityState.Modified;

        try
        {
            await _context.SaveChangesAsync();
        }
        catch (DbUpdateConcurrencyException)
        {
            if (!_context.ContainerValueAssessments.Any(e => e.Id == containerValueAssessment.Id))
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
    /// Get a Common Verification record for Container Value Assessment
    /// </summary>
    public async Task<CommonVerification> GetCommonVerification(
        ContainerValueAssessmentWhereUniqueInput uniqueId
    )
    {
        var containerValueAssessment = await _context
            .ContainerValueAssessments.Where(containerValueAssessment =>
                containerValueAssessment.Id == uniqueId.Id
            )
            .Include(containerValueAssessment => containerValueAssessment.CommonVerification)
            .FirstOrDefaultAsync();
        if (containerValueAssessment == null)
        {
            throw new NotFoundException();
        }
        return containerValueAssessment.CommonVerification.ToDto();
    }
}
