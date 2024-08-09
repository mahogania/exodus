using Control.APIs;
using Control.APIs.Common;
using Control.APIs.Dtos;
using Control.APIs.Errors;
using Control.APIs.Extensions;
using Control.Infrastructure;
using Control.Infrastructure.Models;
using Microsoft.EntityFrameworkCore;

namespace Control.APIs;

public abstract class DirectImportationExportationsServiceBase
    : IDirectImportationExportationsService
{
    protected readonly ControlDbContext _context;

    public DirectImportationExportationsServiceBase(ControlDbContext context)
    {
        _context = context;
    }

    /// <summary>
    /// Create one DIRECT IMPORTATION/EXPORTATION
    /// </summary>
    public async Task<DirectImportationExportation> CreateDirectImportationExportation(
        DirectImportationExportationCreateInput createDto
    )
    {
        var directImportationExportation = new DirectImportationExportationDbModel
        {
            CargoStatus = createDto.CargoStatus,
            CodeOfTheReimportationReexportationOffice =
                createDto.CodeOfTheReimportationReexportationOffice,
            ContentsOfTheClearanceObjective = createDto.ContentsOfTheClearanceObjective,
            ContractReferenceCode = createDto.ContractReferenceCode,
            CreatedAt = createDto.CreatedAt,
            DeletionOn = createDto.DeletionOn,
            DocumentCode = createDto.DocumentCode,
            EndDateOfImportationExportation = createDto.EndDateOfImportationExportation,
            EndDateOfTheClearancePeriod = createDto.EndDateOfTheClearancePeriod,
            FinalModificationDateAndTime = createDto.FinalModificationDateAndTime,
            FinalModifierSId = createDto.FinalModifierSId,
            FirstRecorderSId = createDto.FirstRecorderSId,
            FirstRegistrationDateAndTime = createDto.FirstRegistrationDateAndTime,
            ImportationExportationTypeCode = createDto.ImportationExportationTypeCode,
            RealizationName = createDto.RealizationName,
            RectificationFrequency = createDto.RectificationFrequency,
            RegimeRequestNumber = createDto.RegimeRequestNumber,
            ReservedSuites = createDto.ReservedSuites,
            RightsAndTaxes = createDto.RightsAndTaxes,
            StartDateOfImportationExportation = createDto.StartDateOfImportationExportation,
            StartDateOfTheClearancePeriod = createDto.StartDateOfTheClearancePeriod,
            UpdatedAt = createDto.UpdatedAt
        };

        if (createDto.Id != null)
        {
            directImportationExportation.Id = createDto.Id;
        }

        _context.DirectImportationExportations.Add(directImportationExportation);
        await _context.SaveChangesAsync();

        var result = await _context.FindAsync<DirectImportationExportationDbModel>(
            directImportationExportation.Id
        );

        if (result == null)
        {
            throw new NotFoundException();
        }

        return result.ToDto();
    }

    /// <summary>
    /// Delete one DIRECT IMPORTATION/EXPORTATION
    /// </summary>
    public async Task DeleteDirectImportationExportation(
        DirectImportationExportationWhereUniqueInput uniqueId
    )
    {
        var directImportationExportation = await _context.DirectImportationExportations.FindAsync(
            uniqueId.Id
        );
        if (directImportationExportation == null)
        {
            throw new NotFoundException();
        }

        _context.DirectImportationExportations.Remove(directImportationExportation);
        await _context.SaveChangesAsync();
    }

    /// <summary>
    /// Find many DIRECT IMPORTATION/EXPORTATIONS
    /// </summary>
    public async Task<List<DirectImportationExportation>> DirectImportationExportations(
        DirectImportationExportationFindManyArgs findManyArgs
    )
    {
        var directImportationExportations = await _context
            .DirectImportationExportations.ApplyWhere(findManyArgs.Where)
            .ApplySkip(findManyArgs.Skip)
            .ApplyTake(findManyArgs.Take)
            .ApplyOrderBy(findManyArgs.SortBy)
            .ToListAsync();
        return directImportationExportations.ConvertAll(directImportationExportation =>
            directImportationExportation.ToDto()
        );
    }

    /// <summary>
    /// Meta data about DIRECT IMPORTATION/EXPORTATION records
    /// </summary>
    public async Task<MetadataDto> DirectImportationExportationsMeta(
        DirectImportationExportationFindManyArgs findManyArgs
    )
    {
        var count = await _context
            .DirectImportationExportations.ApplyWhere(findManyArgs.Where)
            .CountAsync();

        return new MetadataDto { Count = count };
    }

    /// <summary>
    /// Get one DIRECT IMPORTATION/EXPORTATION
    /// </summary>
    public async Task<DirectImportationExportation> DirectImportationExportation(
        DirectImportationExportationWhereUniqueInput uniqueId
    )
    {
        var directImportationExportations = await this.DirectImportationExportations(
            new DirectImportationExportationFindManyArgs
            {
                Where = new DirectImportationExportationWhereInput { Id = uniqueId.Id }
            }
        );
        var directImportationExportation = directImportationExportations.FirstOrDefault();
        if (directImportationExportation == null)
        {
            throw new NotFoundException();
        }

        return directImportationExportation;
    }

    /// <summary>
    /// Update one DIRECT IMPORTATION/EXPORTATION
    /// </summary>
    public async Task UpdateDirectImportationExportation(
        DirectImportationExportationWhereUniqueInput uniqueId,
        DirectImportationExportationUpdateInput updateDto
    )
    {
        var directImportationExportation = updateDto.ToModel(uniqueId);

        _context.Entry(directImportationExportation).State = EntityState.Modified;

        try
        {
            await _context.SaveChangesAsync();
        }
        catch (DbUpdateConcurrencyException)
        {
            if (
                !_context.DirectImportationExportations.Any(e =>
                    e.Id == directImportationExportation.Id
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
