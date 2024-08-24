using Microsoft.EntityFrameworkCore;
using Traveler.APIs;
using Traveler.APIs.Common;
using Traveler.APIs.Dtos;
using Traveler.APIs.Errors;
using Traveler.APIs.Extensions;
using Traveler.Infrastructure;
using Traveler.Infrastructure.Models;

namespace Traveler.APIs;

public abstract class TpdControlsServiceBase : ITpdControlsService
{
    protected readonly TravelerDbContext _context;

    public TpdControlsServiceBase(TravelerDbContext context)
    {
        _context = context;
    }

    /// <summary>
    /// Create one TpdControl
    /// </summary>
    public async Task<TpdControl> CreateTpdControl(TpdControlCreateInput createDto)
    {
        var tpdControl = new TpdControlDbModel
        {
            ApprovalId = createDto.ApprovalId,
            ApprovalProcessStatusCode = createDto.ApprovalProcessStatusCode,
            ControlResult = createDto.ControlResult,
            ControlResultRegistrationDateTime = createDto.ControlResultRegistrationDateTime,
            ControlStatus = createDto.ControlStatus,
            ControlTypeCode = createDto.ControlTypeCode,
            CreatedAt = createDto.CreatedAt,
            DeletionOn = createDto.DeletionOn,
            FinalModificationDateAndTime = createDto.FinalModificationDateAndTime,
            FirstRegistrationDateAndTime = createDto.FirstRegistrationDateAndTime,
            InspectorId = createDto.InspectorId,
            JudgmentOrder = createDto.JudgmentOrder,
            TpdNumber = createDto.TpdNumber,
            UpdatedAt = createDto.UpdatedAt,
            VerificationResultCode = createDto.VerificationResultCode,
            VerificationResultContent = createDto.VerificationResultContent
        };

        if (createDto.Id != null)
        {
            tpdControl.Id = createDto.Id;
        }
        if (createDto.BaggageControlArticle != null)
        {
            tpdControl.BaggageControlArticle = await _context
                .BaggageControlArticles.Where(baggageControlArticle =>
                    createDto.BaggageControlArticle.Id == baggageControlArticle.Id
                )
                .FirstOrDefaultAsync();
        }

        if (createDto.GeneralTravelerInformationTpds != null)
        {
            tpdControl.GeneralTravelerInformationTpds = await _context
                .GeneralTravelerInformationTpds.Where(generalTravelerInformationTpd =>
                    createDto
                        .GeneralTravelerInformationTpds.Select(t => t.Id)
                        .Contains(generalTravelerInformationTpd.Id)
                )
                .ToListAsync();
        }

        if (createDto.ImportDeclarations != null)
        {
            tpdControl.ImportDeclarations = await _context
                .ImportDeclarations.Where(importDeclaration =>
                    createDto.ImportDeclarations.Select(t => t.Id).Contains(importDeclaration.Id)
                )
                .ToListAsync();
        }

        _context.TpdControls.Add(tpdControl);
        await _context.SaveChangesAsync();

        var result = await _context.FindAsync<TpdControlDbModel>(tpdControl.Id);

        if (result == null)
        {
            throw new NotFoundException();
        }

        return result.ToDto();
    }

    /// <summary>
    /// Delete one TpdControl
    /// </summary>
    public async Task DeleteTpdControl(TpdControlWhereUniqueInput uniqueId)
    {
        var tpdControl = await _context.TpdControls.FindAsync(uniqueId.Id);
        if (tpdControl == null)
        {
            throw new NotFoundException();
        }

        _context.TpdControls.Remove(tpdControl);
        await _context.SaveChangesAsync();
    }

    /// <summary>
    /// Find many TpdControls
    /// </summary>
    public async Task<List<TpdControl>> TpdControls(TpdControlFindManyArgs findManyArgs)
    {
        var tpdControls = await _context
            .TpdControls.Include(x => x.GeneralTravelerInformationTpds)
            .Include(x => x.BaggageControlArticle)
            .Include(x => x.ImportDeclarations)
            .ApplyWhere(findManyArgs.Where)
            .ApplySkip(findManyArgs.Skip)
            .ApplyTake(findManyArgs.Take)
            .ApplyOrderBy(findManyArgs.SortBy)
            .ToListAsync();
        return tpdControls.ConvertAll(tpdControl => tpdControl.ToDto());
    }

    /// <summary>
    /// Meta data about TpdControl records
    /// </summary>
    public async Task<MetadataDto> TpdControlsMeta(TpdControlFindManyArgs findManyArgs)
    {
        var count = await _context.TpdControls.ApplyWhere(findManyArgs.Where).CountAsync();

        return new MetadataDto { Count = count };
    }

    /// <summary>
    /// Get one TpdControl
    /// </summary>
    public async Task<TpdControl> TpdControl(TpdControlWhereUniqueInput uniqueId)
    {
        var tpdControls = await this.TpdControls(
            new TpdControlFindManyArgs { Where = new TpdControlWhereInput { Id = uniqueId.Id } }
        );
        var tpdControl = tpdControls.FirstOrDefault();
        if (tpdControl == null)
        {
            throw new NotFoundException();
        }

        return tpdControl;
    }

    /// <summary>
    /// Update one TpdControl
    /// </summary>
    public async Task UpdateTpdControl(
        TpdControlWhereUniqueInput uniqueId,
        TpdControlUpdateInput updateDto
    )
    {
        var tpdControl = updateDto.ToModel(uniqueId);

        if (updateDto.GeneralTravelerInformationTpds != null)
        {
            tpdControl.GeneralTravelerInformationTpds = await _context
                .GeneralTravelerInformationTpds.Where(generalTravelerInformationTpd =>
                    updateDto
                        .GeneralTravelerInformationTpds.Select(t => t)
                        .Contains(generalTravelerInformationTpd.Id)
                )
                .ToListAsync();
        }

        if (updateDto.ImportDeclarations != null)
        {
            tpdControl.ImportDeclarations = await _context
                .ImportDeclarations.Where(importDeclaration =>
                    updateDto.ImportDeclarations.Select(t => t).Contains(importDeclaration.Id)
                )
                .ToListAsync();
        }

        _context.Entry(tpdControl).State = EntityState.Modified;

        try
        {
            await _context.SaveChangesAsync();
        }
        catch (DbUpdateConcurrencyException)
        {
            if (!_context.TpdControls.Any(e => e.Id == tpdControl.Id))
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
    /// Get a Baggage Control Article record for TpdControl
    /// </summary>
    public async Task<BaggageControlArticle> GetBaggageControlArticle(
        TpdControlWhereUniqueInput uniqueId
    )
    {
        var tpdControl = await _context
            .TpdControls.Where(tpdControl => tpdControl.Id == uniqueId.Id)
            .Include(tpdControl => tpdControl.BaggageControlArticle)
            .FirstOrDefaultAsync();
        if (tpdControl == null)
        {
            throw new NotFoundException();
        }
        return tpdControl.BaggageControlArticle.ToDto();
    }

    /// <summary>
    /// Connect multiple GeneralTravelerInformationTpds records to TpdControl
    /// </summary>
    public async Task ConnectGeneralTravelerInformationTpds(
        TpdControlWhereUniqueInput uniqueId,
        GeneralTravelerInformationTpdWhereUniqueInput[] generalTravelerInformationTpdsId
    )
    {
        var parent = await _context
            .TpdControls.Include(x => x.GeneralTravelerInformationTpds)
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
    /// Disconnect multiple GeneralTravelerInformationTpds records from TpdControl
    /// </summary>
    public async Task DisconnectGeneralTravelerInformationTpds(
        TpdControlWhereUniqueInput uniqueId,
        GeneralTravelerInformationTpdWhereUniqueInput[] generalTravelerInformationTpdsId
    )
    {
        var parent = await _context
            .TpdControls.Include(x => x.GeneralTravelerInformationTpds)
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
    /// Find multiple GeneralTravelerInformationTpds records for TpdControl
    /// </summary>
    public async Task<List<GeneralTravelerInformationTpd>> FindGeneralTravelerInformationTpds(
        TpdControlWhereUniqueInput uniqueId,
        GeneralTravelerInformationTpdFindManyArgs tpdControlFindManyArgs
    )
    {
        var generalTravelerInformationTpds = await _context
            .GeneralTravelerInformationTpds.Where(m => m.TpdControlId == uniqueId.Id)
            .ApplyWhere(tpdControlFindManyArgs.Where)
            .ApplySkip(tpdControlFindManyArgs.Skip)
            .ApplyTake(tpdControlFindManyArgs.Take)
            .ApplyOrderBy(tpdControlFindManyArgs.SortBy)
            .ToListAsync();

        return generalTravelerInformationTpds.Select(x => x.ToDto()).ToList();
    }

    /// <summary>
    /// Update multiple GeneralTravelerInformationTpds records for TpdControl
    /// </summary>
    public async Task UpdateGeneralTravelerInformationTpds(
        TpdControlWhereUniqueInput uniqueId,
        GeneralTravelerInformationTpdWhereUniqueInput[] generalTravelerInformationTpdsId
    )
    {
        var tpdControl = await _context
            .TpdControls.Include(t => t.GeneralTravelerInformationTpds)
            .FirstOrDefaultAsync(x => x.Id == uniqueId.Id);
        if (tpdControl == null)
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

        tpdControl.GeneralTravelerInformationTpds = generalTravelerInformationTpds;
        await _context.SaveChangesAsync();
    }

    /// <summary>
    /// Connect multiple ImportDeclarations records to TpdControl
    /// </summary>
    public async Task ConnectImportDeclarations(
        TpdControlWhereUniqueInput uniqueId,
        ImportDeclarationWhereUniqueInput[] importDeclarationsId
    )
    {
        var parent = await _context
            .TpdControls.Include(x => x.ImportDeclarations)
            .FirstOrDefaultAsync(x => x.Id == uniqueId.Id);
        if (parent == null)
        {
            throw new NotFoundException();
        }

        var importDeclarations = await _context
            .ImportDeclarations.Where(t => importDeclarationsId.Select(x => x.Id).Contains(t.Id))
            .ToListAsync();
        if (importDeclarations.Count == 0)
        {
            throw new NotFoundException();
        }

        var importDeclarationsToConnect = importDeclarations.Except(parent.ImportDeclarations);

        foreach (var importDeclaration in importDeclarationsToConnect)
        {
            parent.ImportDeclarations.Add(importDeclaration);
        }

        await _context.SaveChangesAsync();
    }

    /// <summary>
    /// Disconnect multiple ImportDeclarations records from TpdControl
    /// </summary>
    public async Task DisconnectImportDeclarations(
        TpdControlWhereUniqueInput uniqueId,
        ImportDeclarationWhereUniqueInput[] importDeclarationsId
    )
    {
        var parent = await _context
            .TpdControls.Include(x => x.ImportDeclarations)
            .FirstOrDefaultAsync(x => x.Id == uniqueId.Id);
        if (parent == null)
        {
            throw new NotFoundException();
        }

        var importDeclarations = await _context
            .ImportDeclarations.Where(t => importDeclarationsId.Select(x => x.Id).Contains(t.Id))
            .ToListAsync();

        foreach (var importDeclaration in importDeclarations)
        {
            parent.ImportDeclarations?.Remove(importDeclaration);
        }
        await _context.SaveChangesAsync();
    }

    /// <summary>
    /// Find multiple ImportDeclarations records for TpdControl
    /// </summary>
    public async Task<List<ImportDeclaration>> FindImportDeclarations(
        TpdControlWhereUniqueInput uniqueId,
        ImportDeclarationFindManyArgs tpdControlFindManyArgs
    )
    {
        var importDeclarations = await _context
            .ImportDeclarations.Where(m => m.TpdControlId == uniqueId.Id)
            .ApplyWhere(tpdControlFindManyArgs.Where)
            .ApplySkip(tpdControlFindManyArgs.Skip)
            .ApplyTake(tpdControlFindManyArgs.Take)
            .ApplyOrderBy(tpdControlFindManyArgs.SortBy)
            .ToListAsync();

        return importDeclarations.Select(x => x.ToDto()).ToList();
    }

    /// <summary>
    /// Update multiple ImportDeclarations records for TpdControl
    /// </summary>
    public async Task UpdateImportDeclarations(
        TpdControlWhereUniqueInput uniqueId,
        ImportDeclarationWhereUniqueInput[] importDeclarationsId
    )
    {
        var tpdControl = await _context
            .TpdControls.Include(t => t.ImportDeclarations)
            .FirstOrDefaultAsync(x => x.Id == uniqueId.Id);
        if (tpdControl == null)
        {
            throw new NotFoundException();
        }

        var importDeclarations = await _context
            .ImportDeclarations.Where(a => importDeclarationsId.Select(x => x.Id).Contains(a.Id))
            .ToListAsync();

        if (importDeclarations.Count == 0)
        {
            throw new NotFoundException();
        }

        tpdControl.ImportDeclarations = importDeclarations;
        await _context.SaveChangesAsync();
    }
}
