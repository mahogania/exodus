using Control.APIs;
using Control.APIs.Common;
using Control.APIs.Dtos;
using Control.APIs.Errors;
using Control.APIs.Extensions;
using Control.Infrastructure;
using Control.Infrastructure.Models;
using Microsoft.EntityFrameworkCore;

namespace Control.APIs;

public abstract class ChangeInTheDetailedDeclarationsServiceBase
    : IChangeInTheDetailedDeclarationsService
{
    protected readonly ControlDbContext _context;

    public ChangeInTheDetailedDeclarationsServiceBase(ControlDbContext context)
    {
        _context = context;
    }

    /// <summary>
    /// Create one Change in the Detailed Declaration
    /// </summary>
    public async Task<ChangeInTheDetailedDeclaration> CreateChangeInTheDetailedDeclaration(
        ChangeInTheDetailedDeclarationCreateInput createDto
    )
    {
        var changeInTheDetailedDeclaration = new ChangeInTheDetailedDeclarationDbModel
        {
            CreatedAt = createDto.CreatedAt,
            DateAndTimeOfFinalModification = createDto.DateAndTimeOfFinalModification,
            DateAndTimeOfFirstRegistration = createDto.DateAndTimeOfFirstRegistration,
            DateAndTimeOfTreatmentDecision = createDto.DateAndTimeOfTreatmentDecision,
            DeletionOn = createDto.DeletionOn,
            ExecutionCodeByStatusTreatment = createDto.ExecutionCodeByStatusTreatment,
            FinalModifierId = createDto.FinalModifierId,
            FirstRegistrantId = createDto.FirstRegistrantId,
            StatusTreatmentCode = createDto.StatusTreatmentCode,
            TreatmentStatusContent = createDto.TreatmentStatusContent,
            UpdatedAt = createDto.UpdatedAt
        };

        if (createDto.Id != null)
        {
            changeInTheDetailedDeclaration.Id = createDto.Id;
        }
        if (createDto.CommonDetailedDeclaration != null)
        {
            changeInTheDetailedDeclaration.CommonDetailedDeclaration = await _context
                .CommonDetailedDeclarations.Where(commonDetailedDeclaration =>
                    createDto.CommonDetailedDeclaration.Id == commonDetailedDeclaration.Id
                )
                .FirstOrDefaultAsync();
        }

        _context.ChangeInTheDetailedDeclarations.Add(changeInTheDetailedDeclaration);
        await _context.SaveChangesAsync();

        var result = await _context.FindAsync<ChangeInTheDetailedDeclarationDbModel>(
            changeInTheDetailedDeclaration.Id
        );

        if (result == null)
        {
            throw new NotFoundException();
        }

        return result.ToDto();
    }

    /// <summary>
    /// Delete one Change in the Detailed Declaration
    /// </summary>
    public async Task DeleteChangeInTheDetailedDeclaration(
        ChangeInTheDetailedDeclarationWhereUniqueInput uniqueId
    )
    {
        var changeInTheDetailedDeclaration =
            await _context.ChangeInTheDetailedDeclarations.FindAsync(uniqueId.Id);
        if (changeInTheDetailedDeclaration == null)
        {
            throw new NotFoundException();
        }

        _context.ChangeInTheDetailedDeclarations.Remove(changeInTheDetailedDeclaration);
        await _context.SaveChangesAsync();
    }

    /// <summary>
    /// Find many Change in the Detailed Declarations
    /// </summary>
    public async Task<List<ChangeInTheDetailedDeclaration>> ChangeInTheDetailedDeclarations(
        ChangeInTheDetailedDeclarationFindManyArgs findManyArgs
    )
    {
        var changeInTheDetailedDeclarations = await _context
            .ChangeInTheDetailedDeclarations.Include(x => x.CommonDetailedDeclaration)
            .ApplyWhere(findManyArgs.Where)
            .ApplySkip(findManyArgs.Skip)
            .ApplyTake(findManyArgs.Take)
            .ApplyOrderBy(findManyArgs.SortBy)
            .ToListAsync();
        return changeInTheDetailedDeclarations.ConvertAll(changeInTheDetailedDeclaration =>
            changeInTheDetailedDeclaration.ToDto()
        );
    }

    /// <summary>
    /// Meta data about Change in the Detailed Declaration records
    /// </summary>
    public async Task<MetadataDto> ChangeInTheDetailedDeclarationsMeta(
        ChangeInTheDetailedDeclarationFindManyArgs findManyArgs
    )
    {
        var count = await _context
            .ChangeInTheDetailedDeclarations.ApplyWhere(findManyArgs.Where)
            .CountAsync();

        return new MetadataDto { Count = count };
    }

    /// <summary>
    /// Get one Change in the Detailed Declaration
    /// </summary>
    public async Task<ChangeInTheDetailedDeclaration> ChangeInTheDetailedDeclaration(
        ChangeInTheDetailedDeclarationWhereUniqueInput uniqueId
    )
    {
        var changeInTheDetailedDeclarations = await this.ChangeInTheDetailedDeclarations(
            new ChangeInTheDetailedDeclarationFindManyArgs
            {
                Where = new ChangeInTheDetailedDeclarationWhereInput { Id = uniqueId.Id }
            }
        );
        var changeInTheDetailedDeclaration = changeInTheDetailedDeclarations.FirstOrDefault();
        if (changeInTheDetailedDeclaration == null)
        {
            throw new NotFoundException();
        }

        return changeInTheDetailedDeclaration;
    }

    /// <summary>
    /// Update one Change in the Detailed Declaration
    /// </summary>
    public async Task UpdateChangeInTheDetailedDeclaration(
        ChangeInTheDetailedDeclarationWhereUniqueInput uniqueId,
        ChangeInTheDetailedDeclarationUpdateInput updateDto
    )
    {
        var changeInTheDetailedDeclaration = updateDto.ToModel(uniqueId);

        _context.Entry(changeInTheDetailedDeclaration).State = EntityState.Modified;

        try
        {
            await _context.SaveChangesAsync();
        }
        catch (DbUpdateConcurrencyException)
        {
            if (
                !_context.ChangeInTheDetailedDeclarations.Any(e =>
                    e.Id == changeInTheDetailedDeclaration.Id
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

    /// <summary>
    /// Get a COMMON DETAILED DECLARATION record for Change in the Detailed Declaration
    /// </summary>
    public async Task<CommonDetailedDeclaration> GetCommonDetailedDeclaration(
        ChangeInTheDetailedDeclarationWhereUniqueInput uniqueId
    )
    {
        var changeInTheDetailedDeclaration = await _context
            .ChangeInTheDetailedDeclarations.Where(changeInTheDetailedDeclaration =>
                changeInTheDetailedDeclaration.Id == uniqueId.Id
            )
            .Include(changeInTheDetailedDeclaration =>
                changeInTheDetailedDeclaration.CommonDetailedDeclaration
            )
            .FirstOrDefaultAsync();
        if (changeInTheDetailedDeclaration == null)
        {
            throw new NotFoundException();
        }
        return changeInTheDetailedDeclaration.CommonDetailedDeclaration.ToDto();
    }
}
