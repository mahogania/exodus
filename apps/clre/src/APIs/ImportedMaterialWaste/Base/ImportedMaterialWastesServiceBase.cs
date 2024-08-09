using Clre.APIs;
using Clre.APIs.Common;
using Clre.APIs.Dtos;
using Clre.APIs.Errors;
using Clre.APIs.Extensions;
using Clre.Infrastructure;
using Clre.Infrastructure.Models;
using Microsoft.EntityFrameworkCore;

namespace Clre.APIs;

public abstract class ImportedMaterialWastesServiceBase : IImportedMaterialWastesService
{
    protected readonly ClreDbContext _context;

    public ImportedMaterialWastesServiceBase(ClreDbContext context)
    {
        _context = context;
    }

    /// <summary>
    /// Create one IMPORTED MATERIAL WASTE
    /// </summary>
    public async Task<ImportedMaterialWaste> CreateImportedMaterialWaste(
        ImportedMaterialWasteCreateInput createDto
    )
    {
        var importedMaterialWaste = new ImportedMaterialWasteDbModel
        {
            CreatedAt = createDto.CreatedAt,
            DateAndTimeOfFinalModification = createDto.DateAndTimeOfFinalModification,
            DateAndTimeOfFirstRegistration = createDto.DateAndTimeOfFirstRegistration,
            FinalModifierSId = createDto.FinalModifierSId,
            FirstRegistrantSId = createDto.FirstRegistrantSId,
            LossRate = createDto.LossRate,
            NonRecoverableWasteRate = createDto.NonRecoverableWasteRate,
            RateOfWasteOnFinishedProducts = createDto.RateOfWasteOnFinishedProducts,
            RecoverableWasteRate = createDto.RecoverableWasteRate,
            RectificationFrequency = createDto.RectificationFrequency,
            RequestNumberOfRegime = createDto.RequestNumberOfRegime,
            SequenceNumber = createDto.SequenceNumber,
            SuppressionOn = createDto.SuppressionOn,
            UpdatedAt = createDto.UpdatedAt
        };

        if (createDto.Id != null)
        {
            importedMaterialWaste.Id = createDto.Id;
        }

        _context.ImportedMaterialWastes.Add(importedMaterialWaste);
        await _context.SaveChangesAsync();

        var result = await _context.FindAsync<ImportedMaterialWasteDbModel>(
            importedMaterialWaste.Id
        );

        if (result == null)
        {
            throw new NotFoundException();
        }

        return result.ToDto();
    }

    /// <summary>
    /// Delete one IMPORTED MATERIAL WASTE
    /// </summary>
    public async Task DeleteImportedMaterialWaste(ImportedMaterialWasteWhereUniqueInput uniqueId)
    {
        var importedMaterialWaste = await _context.ImportedMaterialWastes.FindAsync(uniqueId.Id);
        if (importedMaterialWaste == null)
        {
            throw new NotFoundException();
        }

        _context.ImportedMaterialWastes.Remove(importedMaterialWaste);
        await _context.SaveChangesAsync();
    }

    /// <summary>
    /// Find many IMPORTED MATERIAL WASTES
    /// </summary>
    public async Task<List<ImportedMaterialWaste>> ImportedMaterialWastes(
        ImportedMaterialWasteFindManyArgs findManyArgs
    )
    {
        var importedMaterialWastes = await _context
            .ImportedMaterialWastes.ApplyWhere(findManyArgs.Where)
            .ApplySkip(findManyArgs.Skip)
            .ApplyTake(findManyArgs.Take)
            .ApplyOrderBy(findManyArgs.SortBy)
            .ToListAsync();
        return importedMaterialWastes.ConvertAll(importedMaterialWaste =>
            importedMaterialWaste.ToDto()
        );
    }

    /// <summary>
    /// Meta data about IMPORTED MATERIAL WASTE records
    /// </summary>
    public async Task<MetadataDto> ImportedMaterialWastesMeta(
        ImportedMaterialWasteFindManyArgs findManyArgs
    )
    {
        var count = await _context
            .ImportedMaterialWastes.ApplyWhere(findManyArgs.Where)
            .CountAsync();

        return new MetadataDto { Count = count };
    }

    /// <summary>
    /// Get one IMPORTED MATERIAL WASTE
    /// </summary>
    public async Task<ImportedMaterialWaste> ImportedMaterialWaste(
        ImportedMaterialWasteWhereUniqueInput uniqueId
    )
    {
        var importedMaterialWastes = await this.ImportedMaterialWastes(
            new ImportedMaterialWasteFindManyArgs
            {
                Where = new ImportedMaterialWasteWhereInput { Id = uniqueId.Id }
            }
        );
        var importedMaterialWaste = importedMaterialWastes.FirstOrDefault();
        if (importedMaterialWaste == null)
        {
            throw new NotFoundException();
        }

        return importedMaterialWaste;
    }

    /// <summary>
    /// Update one IMPORTED MATERIAL WASTE
    /// </summary>
    public async Task UpdateImportedMaterialWaste(
        ImportedMaterialWasteWhereUniqueInput uniqueId,
        ImportedMaterialWasteUpdateInput updateDto
    )
    {
        var importedMaterialWaste = updateDto.ToModel(uniqueId);

        _context.Entry(importedMaterialWaste).State = EntityState.Modified;

        try
        {
            await _context.SaveChangesAsync();
        }
        catch (DbUpdateConcurrencyException)
        {
            if (!_context.ImportedMaterialWastes.Any(e => e.Id == importedMaterialWaste.Id))
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
