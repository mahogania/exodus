using Microsoft.EntityFrameworkCore;
using Traveler.APIs;
using Traveler.APIs.Common;
using Traveler.APIs.Dtos;
using Traveler.APIs.Errors;
using Traveler.APIs.Extensions;
using Traveler.Infrastructure;
using Traveler.Infrastructure.Models;

namespace Traveler.APIs;

public abstract class ImportDeclarationsServiceBase : IImportDeclarationsService
{
    protected readonly TravelerDbContext _context;

    public ImportDeclarationsServiceBase(TravelerDbContext context)
    {
        _context = context;
    }

    /// <summary>
    /// Create one ImportDeclaration
    /// </summary>
    public async Task<ImportDeclaration> CreateImportDeclaration(
        ImportDeclarationCreateInput createDto
    )
    {
        var importDeclaration = new ImportDeclarationDbModel
        {
            CreatedAt = createDto.CreatedAt,
            UpdatedAt = createDto.UpdatedAt
        };

        if (createDto.Id != null)
        {
            importDeclaration.Id = createDto.Id;
        }
        if (createDto.BaggageControlArticle != null)
        {
            importDeclaration.BaggageControlArticle = await _context
                .BaggageControlArticles.Where(baggageControlArticle =>
                    createDto.BaggageControlArticle.Id == baggageControlArticle.Id
                )
                .FirstOrDefaultAsync();
        }

        if (createDto.GeneralTravelerInformationTpds != null)
        {
            importDeclaration.GeneralTravelerInformationTpds = await _context
                .GeneralTravelerInformationTpds.Where(generalTravelerInformationTpd =>
                    createDto
                        .GeneralTravelerInformationTpds.Select(t => t.Id)
                        .Contains(generalTravelerInformationTpd.Id)
                )
                .ToListAsync();
        }

        if (createDto.TpdControl != null)
        {
            importDeclaration.TpdControl = await _context
                .TpdControls.Where(tpdControl => createDto.TpdControl.Id == tpdControl.Id)
                .FirstOrDefaultAsync();
        }

        if (createDto.TpdEntryAndExitHistory != null)
        {
            importDeclaration.TpdEntryAndExitHistory = await _context
                .TpdEntryAndExitHistories.Where(tpdEntryAndExitHistory =>
                    createDto.TpdEntryAndExitHistory.Id == tpdEntryAndExitHistory.Id
                )
                .FirstOrDefaultAsync();
        }

        if (createDto.TravelersArticlesEntryExit != null)
        {
            importDeclaration.TravelersArticlesEntryExit = await _context
                .TravelersArticlesEntryExits.Where(travelersArticlesEntryExit =>
                    createDto.TravelersArticlesEntryExit.Id == travelersArticlesEntryExit.Id
                )
                .FirstOrDefaultAsync();
        }

        _context.ImportDeclarations.Add(importDeclaration);
        await _context.SaveChangesAsync();

        var result = await _context.FindAsync<ImportDeclarationDbModel>(importDeclaration.Id);

        if (result == null)
        {
            throw new NotFoundException();
        }

        return result.ToDto();
    }

    /// <summary>
    /// Delete one ImportDeclaration
    /// </summary>
    public async Task DeleteImportDeclaration(ImportDeclarationWhereUniqueInput uniqueId)
    {
        var importDeclaration = await _context.ImportDeclarations.FindAsync(uniqueId.Id);
        if (importDeclaration == null)
        {
            throw new NotFoundException();
        }

        _context.ImportDeclarations.Remove(importDeclaration);
        await _context.SaveChangesAsync();
    }

    /// <summary>
    /// Find many ImportDeclarations
    /// </summary>
    public async Task<List<ImportDeclaration>> ImportDeclarations(
        ImportDeclarationFindManyArgs findManyArgs
    )
    {
        var importDeclarations = await _context
            .ImportDeclarations.Include(x => x.GeneralTravelerInformationTpds)
            .Include(x => x.TpdEntryAndExitHistory)
            .Include(x => x.TpdControl)
            .Include(x => x.TravelersArticlesEntryExit)
            .Include(x => x.BaggageControlArticle)
            .ApplyWhere(findManyArgs.Where)
            .ApplySkip(findManyArgs.Skip)
            .ApplyTake(findManyArgs.Take)
            .ApplyOrderBy(findManyArgs.SortBy)
            .ToListAsync();
        return importDeclarations.ConvertAll(importDeclaration => importDeclaration.ToDto());
    }

    /// <summary>
    /// Meta data about ImportDeclaration records
    /// </summary>
    public async Task<MetadataDto> ImportDeclarationsMeta(
        ImportDeclarationFindManyArgs findManyArgs
    )
    {
        var count = await _context.ImportDeclarations.ApplyWhere(findManyArgs.Where).CountAsync();

        return new MetadataDto { Count = count };
    }

    /// <summary>
    /// Get one ImportDeclaration
    /// </summary>
    public async Task<ImportDeclaration> ImportDeclaration(
        ImportDeclarationWhereUniqueInput uniqueId
    )
    {
        var importDeclarations = await this.ImportDeclarations(
            new ImportDeclarationFindManyArgs
            {
                Where = new ImportDeclarationWhereInput { Id = uniqueId.Id }
            }
        );
        var importDeclaration = importDeclarations.FirstOrDefault();
        if (importDeclaration == null)
        {
            throw new NotFoundException();
        }

        return importDeclaration;
    }

    /// <summary>
    /// Update one ImportDeclaration
    /// </summary>
    public async Task UpdateImportDeclaration(
        ImportDeclarationWhereUniqueInput uniqueId,
        ImportDeclarationUpdateInput updateDto
    )
    {
        var importDeclaration = updateDto.ToModel(uniqueId);

        if (updateDto.GeneralTravelerInformationTpds != null)
        {
            importDeclaration.GeneralTravelerInformationTpds = await _context
                .GeneralTravelerInformationTpds.Where(generalTravelerInformationTpd =>
                    updateDto
                        .GeneralTravelerInformationTpds.Select(t => t)
                        .Contains(generalTravelerInformationTpd.Id)
                )
                .ToListAsync();
        }

        _context.Entry(importDeclaration).State = EntityState.Modified;

        try
        {
            await _context.SaveChangesAsync();
        }
        catch (DbUpdateConcurrencyException)
        {
            if (!_context.ImportDeclarations.Any(e => e.Id == importDeclaration.Id))
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
    /// Get a Baggage Control Article record for ImportDeclaration
    /// </summary>
    public async Task<BaggageControlArticle> GetBaggageControlArticle(
        ImportDeclarationWhereUniqueInput uniqueId
    )
    {
        var importDeclaration = await _context
            .ImportDeclarations.Where(importDeclaration => importDeclaration.Id == uniqueId.Id)
            .Include(importDeclaration => importDeclaration.BaggageControlArticle)
            .FirstOrDefaultAsync();
        if (importDeclaration == null)
        {
            throw new NotFoundException();
        }
        return importDeclaration.BaggageControlArticle.ToDto();
    }

    /// <summary>
    /// Connect multiple GeneralTravelerInformationTpds records to ImportDeclaration
    /// </summary>
    public async Task ConnectGeneralTravelerInformationTpds(
        ImportDeclarationWhereUniqueInput uniqueId,
        GeneralTravelerInformationTpdWhereUniqueInput[] generalTravelerInformationTpdsId
    )
    {
        var parent = await _context
            .ImportDeclarations.Include(x => x.GeneralTravelerInformationTpds)
            .FirstOrDefaultAsync(x => x.Id == uniqueId.Id);
        if (parent == null)
        {
            throw new NotFoundException();
        }

        var generalTravelerInformationTpds = await _context
            .GeneralTravelerInformationTpds.Where(t =>
                generalTravelerInformationTpdsId.Select(x => x.Id).Contains(t.Id)
            )
            .ToListAsync();
        if (generalTravelerInformationTpds.Count == 0)
        {
            throw new NotFoundException();
        }

        var generalTravelerInformationTpdsToConnect = generalTravelerInformationTpds.Except(
            parent.GeneralTravelerInformationTpds
        );

        foreach (var generalTravelerInformationTpd in generalTravelerInformationTpdsToConnect)
        {
            parent.GeneralTravelerInformationTpds.Add(generalTravelerInformationTpd);
        }

        await _context.SaveChangesAsync();
    }

    /// <summary>
    /// Disconnect multiple GeneralTravelerInformationTpds records from ImportDeclaration
    /// </summary>
    public async Task DisconnectGeneralTravelerInformationTpds(
        ImportDeclarationWhereUniqueInput uniqueId,
        GeneralTravelerInformationTpdWhereUniqueInput[] generalTravelerInformationTpdsId
    )
    {
        var parent = await _context
            .ImportDeclarations.Include(x => x.GeneralTravelerInformationTpds)
            .FirstOrDefaultAsync(x => x.Id == uniqueId.Id);
        if (parent == null)
        {
            throw new NotFoundException();
        }

        var generalTravelerInformationTpds = await _context
            .GeneralTravelerInformationTpds.Where(t =>
                generalTravelerInformationTpdsId.Select(x => x.Id).Contains(t.Id)
            )
            .ToListAsync();

        foreach (var generalTravelerInformationTpd in generalTravelerInformationTpds)
        {
            parent.GeneralTravelerInformationTpds?.Remove(generalTravelerInformationTpd);
        }
        await _context.SaveChangesAsync();
    }

    /// <summary>
    /// Find multiple GeneralTravelerInformationTpds records for ImportDeclaration
    /// </summary>
    public async Task<List<GeneralTravelerInformationTpd>> FindGeneralTravelerInformationTpds(
        ImportDeclarationWhereUniqueInput uniqueId,
        GeneralTravelerInformationTpdFindManyArgs importDeclarationFindManyArgs
    )
    {
        var generalTravelerInformationTpds = await _context
            .GeneralTravelerInformationTpds.Where(m => m.ImportDeclarationId == uniqueId.Id)
            .ApplyWhere(importDeclarationFindManyArgs.Where)
            .ApplySkip(importDeclarationFindManyArgs.Skip)
            .ApplyTake(importDeclarationFindManyArgs.Take)
            .ApplyOrderBy(importDeclarationFindManyArgs.SortBy)
            .ToListAsync();

        return generalTravelerInformationTpds.Select(x => x.ToDto()).ToList();
    }

    /// <summary>
    /// Update multiple GeneralTravelerInformationTpds records for ImportDeclaration
    /// </summary>
    public async Task UpdateGeneralTravelerInformationTpds(
        ImportDeclarationWhereUniqueInput uniqueId,
        GeneralTravelerInformationTpdWhereUniqueInput[] generalTravelerInformationTpdsId
    )
    {
        var importDeclaration = await _context
            .ImportDeclarations.Include(t => t.GeneralTravelerInformationTpds)
            .FirstOrDefaultAsync(x => x.Id == uniqueId.Id);
        if (importDeclaration == null)
        {
            throw new NotFoundException();
        }

        var generalTravelerInformationTpds = await _context
            .GeneralTravelerInformationTpds.Where(a =>
                generalTravelerInformationTpdsId.Select(x => x.Id).Contains(a.Id)
            )
            .ToListAsync();

        if (generalTravelerInformationTpds.Count == 0)
        {
            throw new NotFoundException();
        }

        importDeclaration.GeneralTravelerInformationTpds = generalTravelerInformationTpds;
        await _context.SaveChangesAsync();
    }

    /// <summary>
    /// Get a TPD Control record for ImportDeclaration
    /// </summary>
    public async Task<TpdControl> GetTpdControl(ImportDeclarationWhereUniqueInput uniqueId)
    {
        var importDeclaration = await _context
            .ImportDeclarations.Where(importDeclaration => importDeclaration.Id == uniqueId.Id)
            .Include(importDeclaration => importDeclaration.TpdControl)
            .FirstOrDefaultAsync();
        if (importDeclaration == null)
        {
            throw new NotFoundException();
        }
        return importDeclaration.TpdControl.ToDto();
    }

    /// <summary>
    /// Get a TPD Entry and Exit History record for ImportDeclaration
    /// </summary>
    public async Task<TpdEntryAndExitHistory> GetTpdEntryAndExitHistory(
        ImportDeclarationWhereUniqueInput uniqueId
    )
    {
        var importDeclaration = await _context
            .ImportDeclarations.Where(importDeclaration => importDeclaration.Id == uniqueId.Id)
            .Include(importDeclaration => importDeclaration.TpdEntryAndExitHistory)
            .FirstOrDefaultAsync();
        if (importDeclaration == null)
        {
            throw new NotFoundException();
        }
        return importDeclaration.TpdEntryAndExitHistory.ToDto();
    }

    /// <summary>
    /// Get a Travelers Articles Entry Exit record for ImportDeclaration
    /// </summary>
    public async Task<TravelersArticlesEntryExit> GetTravelersArticlesEntryExit(
        ImportDeclarationWhereUniqueInput uniqueId
    )
    {
        var importDeclaration = await _context
            .ImportDeclarations.Where(importDeclaration => importDeclaration.Id == uniqueId.Id)
            .Include(importDeclaration => importDeclaration.TravelersArticlesEntryExit)
            .FirstOrDefaultAsync();
        if (importDeclaration == null)
        {
            throw new NotFoundException();
        }
        return importDeclaration.TravelersArticlesEntryExit.ToDto();
    }
}
