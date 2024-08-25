using Microsoft.EntityFrameworkCore;
using Traveler.APIs;
using Traveler.APIs.Common;
using Traveler.APIs.Dtos;
using Traveler.APIs.Errors;
using Traveler.APIs.Extensions;
using Traveler.Infrastructure;
using Traveler.Infrastructure.Models;

namespace Traveler.APIs;

public abstract class GeneralBondNotesServiceBase : IGeneralBondNotesService
{
    protected readonly TravelerDbContext _context;

    public GeneralBondNotesServiceBase(TravelerDbContext context)
    {
        _context = context;
    }

    /// <summary>
    /// Create one GeneralBondNote
    /// </summary>
    public async Task<GeneralBondNote> CreateGeneralBondNote(GeneralBondNoteCreateInput createDto)
    {
        var generalBondNote = new GeneralBondNoteDbModel
        {
            CreatedAt = createDto.CreatedAt,
            UpdatedAt = createDto.UpdatedAt
        };

        if (createDto.Id != null)
        {
            generalBondNote.Id = createDto.Id;
        }
        if (createDto.Appeals != null)
        {
            generalBondNote.Appeals = await _context
                .Appeals.Where(appeal => createDto.Appeals.Select(t => t.Id).Contains(appeal.Id))
                .ToListAsync();
        }

        if (createDto.GeneralTravelerInformationTpds != null)
        {
            generalBondNote.GeneralTravelerInformationTpds = await _context
                .GeneralTravelerInformationTpds.Where(generalTravelerInformationTpd =>
                    createDto
                        .GeneralTravelerInformationTpds.Select(t => t.Id)
                        .Contains(generalTravelerInformationTpd.Id)
                )
                .ToListAsync();
        }

        _context.GeneralBondNotes.Add(generalBondNote);
        await _context.SaveChangesAsync();

        var result = await _context.FindAsync<GeneralBondNoteDbModel>(generalBondNote.Id);

        if (result == null)
        {
            throw new NotFoundException();
        }

        return result.ToDto();
    }

    /// <summary>
    /// Delete one GeneralBondNote
    /// </summary>
    public async Task DeleteGeneralBondNote(GeneralBondNoteWhereUniqueInput uniqueId)
    {
        var generalBondNote = await _context.GeneralBondNotes.FindAsync(uniqueId.Id);
        if (generalBondNote == null)
        {
            throw new NotFoundException();
        }

        _context.GeneralBondNotes.Remove(generalBondNote);
        await _context.SaveChangesAsync();
    }

    /// <summary>
    /// Find many GeneralBondNotes
    /// </summary>
    public async Task<List<GeneralBondNote>> GeneralBondNotes(
        GeneralBondNoteFindManyArgs findManyArgs
    )
    {
        var generalBondNotes = await _context
            .GeneralBondNotes.Include(x => x.GeneralTravelerInformationTpds)
            .Include(x => x.Appeals)
            .ApplyWhere(findManyArgs.Where)
            .ApplySkip(findManyArgs.Skip)
            .ApplyTake(findManyArgs.Take)
            .ApplyOrderBy(findManyArgs.SortBy)
            .ToListAsync();
        return generalBondNotes.ConvertAll(generalBondNote => generalBondNote.ToDto());
    }

    /// <summary>
    /// Meta data about GeneralBondNote records
    /// </summary>
    public async Task<MetadataDto> GeneralBondNotesMeta(GeneralBondNoteFindManyArgs findManyArgs)
    {
        var count = await _context.GeneralBondNotes.ApplyWhere(findManyArgs.Where).CountAsync();

        return new MetadataDto { Count = count };
    }

    /// <summary>
    /// Get one GeneralBondNote
    /// </summary>
    public async Task<GeneralBondNote> GeneralBondNote(GeneralBondNoteWhereUniqueInput uniqueId)
    {
        var generalBondNotes = await this.GeneralBondNotes(
            new GeneralBondNoteFindManyArgs
            {
                Where = new GeneralBondNoteWhereInput { Id = uniqueId.Id }
            }
        );
        var generalBondNote = generalBondNotes.FirstOrDefault();
        if (generalBondNote == null)
        {
            throw new NotFoundException();
        }

        return generalBondNote;
    }

    /// <summary>
    /// Update one GeneralBondNote
    /// </summary>
    public async Task UpdateGeneralBondNote(
        GeneralBondNoteWhereUniqueInput uniqueId,
        GeneralBondNoteUpdateInput updateDto
    )
    {
        var generalBondNote = updateDto.ToModel(uniqueId);

        if (updateDto.GeneralTravelerInformationTpds != null)
        {
            generalBondNote.GeneralTravelerInformationTpds = await _context
                .GeneralTravelerInformationTpds.Where(generalTravelerInformationTpd =>
                    updateDto
                        .GeneralTravelerInformationTpds.Select(t => t)
                        .Contains(generalTravelerInformationTpd.Id)
                )
                .ToListAsync();
        }

        if (updateDto.Appeals != null)
        {
            generalBondNote.Appeals = await _context
                .Appeals.Where(appeal => updateDto.Appeals.Select(t => t).Contains(appeal.Id))
                .ToListAsync();
        }

        _context.Entry(generalBondNote).State = EntityState.Modified;

        try
        {
            await _context.SaveChangesAsync();
        }
        catch (DbUpdateConcurrencyException)
        {
            if (!_context.GeneralBondNotes.Any(e => e.Id == generalBondNote.Id))
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
    /// Connect multiple Appeals records to GeneralBondNote
    /// </summary>
    public async Task ConnectAppeals(
        GeneralBondNoteWhereUniqueInput uniqueId,
        AppealWhereUniqueInput[] appealsId
    )
    {
        var parent = await _context
            .GeneralBondNotes.Include(x => x.Appeals)
            .FirstOrDefaultAsync(x => x.Id == uniqueId.Id);
        if (parent == null)
        {
            throw new NotFoundException();
        }

        var appeals = await _context
            .Appeals.Where(t => appealsId.Select(x => x.Id).Contains(t.Id))
            .ToListAsync();
        if (appeals.Count == 0)
        {
            throw new NotFoundException();
        }

        var appealsToConnect = appeals.Except(parent.Appeals);

        foreach (var appeal in appealsToConnect)
        {
            parent.Appeals.Add(appeal);
        }

        await _context.SaveChangesAsync();
    }

    /// <summary>
    /// Disconnect multiple Appeals records from GeneralBondNote
    /// </summary>
    public async Task DisconnectAppeals(
        GeneralBondNoteWhereUniqueInput uniqueId,
        AppealWhereUniqueInput[] appealsId
    )
    {
        var parent = await _context
            .GeneralBondNotes.Include(x => x.Appeals)
            .FirstOrDefaultAsync(x => x.Id == uniqueId.Id);
        if (parent == null)
        {
            throw new NotFoundException();
        }

        var appeals = await _context
            .Appeals.Where(t => appealsId.Select(x => x.Id).Contains(t.Id))
            .ToListAsync();

        foreach (var appeal in appeals)
        {
            parent.Appeals?.Remove(appeal);
        }
        await _context.SaveChangesAsync();
    }

    /// <summary>
    /// Find multiple Appeals records for GeneralBondNote
    /// </summary>
    public async Task<List<Appeal>> FindAppeals(
        GeneralBondNoteWhereUniqueInput uniqueId,
        AppealFindManyArgs generalBondNoteFindManyArgs
    )
    {
        var appeals = await _context
            .Appeals.Where(m => m.GeneralBondNoteId == uniqueId.Id)
            .ApplyWhere(generalBondNoteFindManyArgs.Where)
            .ApplySkip(generalBondNoteFindManyArgs.Skip)
            .ApplyTake(generalBondNoteFindManyArgs.Take)
            .ApplyOrderBy(generalBondNoteFindManyArgs.SortBy)
            .ToListAsync();

        return appeals.Select(x => x.ToDto()).ToList();
    }

    /// <summary>
    /// Update multiple Appeals records for GeneralBondNote
    /// </summary>
    public async Task UpdateAppeals(
        GeneralBondNoteWhereUniqueInput uniqueId,
        AppealWhereUniqueInput[] appealsId
    )
    {
        var generalBondNote = await _context
            .GeneralBondNotes.Include(t => t.Appeals)
            .FirstOrDefaultAsync(x => x.Id == uniqueId.Id);
        if (generalBondNote == null)
        {
            throw new NotFoundException();
        }

        var appeals = await _context
            .Appeals.Where(a => appealsId.Select(x => x.Id).Contains(a.Id))
            .ToListAsync();

        if (appeals.Count == 0)
        {
            throw new NotFoundException();
        }

        generalBondNote.Appeals = appeals;
        await _context.SaveChangesAsync();
    }

    /// <summary>
    /// Connect multiple GeneralTravelerInformationTpds records to GeneralBondNote
    /// </summary>
    public async Task ConnectGeneralTravelerInformationTpds(
        GeneralBondNoteWhereUniqueInput uniqueId,
        GeneralTravelerInformationTpdWhereUniqueInput[] generalTravelerInformationTpdsId
    )
    {
        var parent = await _context
            .GeneralBondNotes.Include(x => x.GeneralTravelerInformationTpds)
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
    /// Disconnect multiple GeneralTravelerInformationTpds records from GeneralBondNote
    /// </summary>
    public async Task DisconnectGeneralTravelerInformationTpds(
        GeneralBondNoteWhereUniqueInput uniqueId,
        GeneralTravelerInformationTpdWhereUniqueInput[] generalTravelerInformationTpdsId
    )
    {
        var parent = await _context
            .GeneralBondNotes.Include(x => x.GeneralTravelerInformationTpds)
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
    /// Find multiple GeneralTravelerInformationTpds records for GeneralBondNote
    /// </summary>
    public async Task<List<GeneralTravelerInformationTpd>> FindGeneralTravelerInformationTpds(
        GeneralBondNoteWhereUniqueInput uniqueId,
        GeneralTravelerInformationTpdFindManyArgs generalBondNoteFindManyArgs
    )
    {
        var generalTravelerInformationTpds = await _context
            .GeneralTravelerInformationTpds.Where(m => m.GeneralBondNoteId == uniqueId.Id)
            .ApplyWhere(generalBondNoteFindManyArgs.Where)
            .ApplySkip(generalBondNoteFindManyArgs.Skip)
            .ApplyTake(generalBondNoteFindManyArgs.Take)
            .ApplyOrderBy(generalBondNoteFindManyArgs.SortBy)
            .ToListAsync();

        return generalTravelerInformationTpds.Select(x => x.ToDto()).ToList();
    }

    /// <summary>
    /// Update multiple GeneralTravelerInformationTpds records for GeneralBondNote
    /// </summary>
    public async Task UpdateGeneralTravelerInformationTpds(
        GeneralBondNoteWhereUniqueInput uniqueId,
        GeneralTravelerInformationTpdWhereUniqueInput[] generalTravelerInformationTpdsId
    )
    {
        var generalBondNote = await _context
            .GeneralBondNotes.Include(t => t.GeneralTravelerInformationTpds)
            .FirstOrDefaultAsync(x => x.Id == uniqueId.Id);
        if (generalBondNote == null)
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

        generalBondNote.GeneralTravelerInformationTpds = generalTravelerInformationTpds;
        await _context.SaveChangesAsync();
    }
}
