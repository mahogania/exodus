using Microsoft.EntityFrameworkCore;
using Traveler.APIs;
using Traveler.APIs.Common;
using Traveler.APIs.Dtos;
using Traveler.APIs.Errors;
using Traveler.APIs.Extensions;
using Traveler.Infrastructure;
using Traveler.Infrastructure.Models;

namespace Traveler.APIs;

public abstract class AccompaniedBaggageEntryAndExitsServiceBase
    : IAccompaniedBaggageEntryAndExitsService
{
    protected readonly TravelerDbContext _context;

    public AccompaniedBaggageEntryAndExitsServiceBase(TravelerDbContext context)
    {
        _context = context;
    }

    /// <summary>
    /// Create one AccompaniedBaggageEntryAndExit
    /// </summary>
    public async Task<AccompaniedBaggageEntryAndExit> CreateAccompaniedBaggageEntryAndExit(
        AccompaniedBaggageEntryAndExitCreateInput createDto
    )
    {
        var accompaniedBaggageEntryAndExit = new AccompaniedBaggageEntryAndExitDbModel
        {
            BaggageNumber = createDto.BaggageNumber,
            CreatedAt = createDto.CreatedAt,
            DeletionOn = createDto.DeletionOn,
            DepositBulletinNumber = createDto.DepositBulletinNumber,
            EntryAndExitCategoryCode = createDto.EntryAndExitCategoryCode,
            ExitRequestDate = createDto.ExitRequestDate,
            ExitRequestTypeCode = createDto.ExitRequestTypeCode,
            FinalModificationDateAndTime = createDto.FinalModificationDateAndTime,
            FirstRegistrationDateAndTime = createDto.FirstRegistrationDateAndTime,
            OfficerId = createDto.OfficerId,
            PersonalEffectsClearanceNumber = createDto.PersonalEffectsClearanceNumber,
            RemovalDate = createDto.RemovalDate,
            StockQuantity = createDto.StockQuantity,
            StockWeight = createDto.StockWeight,
            TravelerName = createDto.TravelerName,
            UpdatedAt = createDto.UpdatedAt
        };

        if (createDto.Id != null)
        {
            accompaniedBaggageEntryAndExit.Id = createDto.Id;
        }
        if (createDto.GeneralTravelerInformationTpds != null)
        {
            accompaniedBaggageEntryAndExit.GeneralTravelerInformationTpds = await _context
                .GeneralTravelerInformationTpds.Where(generalTravelerInformationTpd =>
                    createDto
                        .GeneralTravelerInformationTpds.Select(t => t.Id)
                        .Contains(generalTravelerInformationTpd.Id)
                )
                .ToListAsync();
        }

        _context.AccompaniedBaggageEntryAndExits.Add(accompaniedBaggageEntryAndExit);
        await _context.SaveChangesAsync();

        var result = await _context.FindAsync<AccompaniedBaggageEntryAndExitDbModel>(
            accompaniedBaggageEntryAndExit.Id
        );

        if (result == null)
        {
            throw new NotFoundException();
        }

        return result.ToDto();
    }

    /// <summary>
    /// Delete one AccompaniedBaggageEntryAndExit
    /// </summary>
    public async Task DeleteAccompaniedBaggageEntryAndExit(
        AccompaniedBaggageEntryAndExitWhereUniqueInput uniqueId
    )
    {
        var accompaniedBaggageEntryAndExit =
            await _context.AccompaniedBaggageEntryAndExits.FindAsync(uniqueId.Id);
        if (accompaniedBaggageEntryAndExit == null)
        {
            throw new NotFoundException();
        }

        _context.AccompaniedBaggageEntryAndExits.Remove(accompaniedBaggageEntryAndExit);
        await _context.SaveChangesAsync();
    }

    /// <summary>
    /// Find many AccompaniedBaggageEntryAndExits
    /// </summary>
    public async Task<List<AccompaniedBaggageEntryAndExit>> AccompaniedBaggageEntryAndExits(
        AccompaniedBaggageEntryAndExitFindManyArgs findManyArgs
    )
    {
        var accompaniedBaggageEntryAndExits = await _context
            .AccompaniedBaggageEntryAndExits.Include(x => x.GeneralTravelerInformationTpds)
            .ApplyWhere(findManyArgs.Where)
            .ApplySkip(findManyArgs.Skip)
            .ApplyTake(findManyArgs.Take)
            .ApplyOrderBy(findManyArgs.SortBy)
            .ToListAsync();
        return accompaniedBaggageEntryAndExits.ConvertAll(accompaniedBaggageEntryAndExit =>
            accompaniedBaggageEntryAndExit.ToDto()
        );
    }

    /// <summary>
    /// Meta data about AccompaniedBaggageEntryAndExit records
    /// </summary>
    public async Task<MetadataDto> AccompaniedBaggageEntryAndExitsMeta(
        AccompaniedBaggageEntryAndExitFindManyArgs findManyArgs
    )
    {
        var count = await _context
            .AccompaniedBaggageEntryAndExits.ApplyWhere(findManyArgs.Where)
            .CountAsync();

        return new MetadataDto { Count = count };
    }

    /// <summary>
    /// Get one AccompaniedBaggageEntryAndExit
    /// </summary>
    public async Task<AccompaniedBaggageEntryAndExit> AccompaniedBaggageEntryAndExit(
        AccompaniedBaggageEntryAndExitWhereUniqueInput uniqueId
    )
    {
        var accompaniedBaggageEntryAndExits = await this.AccompaniedBaggageEntryAndExits(
            new AccompaniedBaggageEntryAndExitFindManyArgs
            {
                Where = new AccompaniedBaggageEntryAndExitWhereInput { Id = uniqueId.Id }
            }
        );
        var accompaniedBaggageEntryAndExit = accompaniedBaggageEntryAndExits.FirstOrDefault();
        if (accompaniedBaggageEntryAndExit == null)
        {
            throw new NotFoundException();
        }

        return accompaniedBaggageEntryAndExit;
    }

    /// <summary>
    /// Update one AccompaniedBaggageEntryAndExit
    /// </summary>
    public async Task UpdateAccompaniedBaggageEntryAndExit(
        AccompaniedBaggageEntryAndExitWhereUniqueInput uniqueId,
        AccompaniedBaggageEntryAndExitUpdateInput updateDto
    )
    {
        var accompaniedBaggageEntryAndExit = updateDto.ToModel(uniqueId);

        if (updateDto.GeneralTravelerInformationTpds != null)
        {
            accompaniedBaggageEntryAndExit.GeneralTravelerInformationTpds = await _context
                .GeneralTravelerInformationTpds.Where(generalTravelerInformationTpd =>
                    updateDto
                        .GeneralTravelerInformationTpds.Select(t => t)
                        .Contains(generalTravelerInformationTpd.Id)
                )
                .ToListAsync();
        }

        _context.Entry(accompaniedBaggageEntryAndExit).State = EntityState.Modified;

        try
        {
            await _context.SaveChangesAsync();
        }
        catch (DbUpdateConcurrencyException)
        {
            if (
                !_context.AccompaniedBaggageEntryAndExits.Any(e =>
                    e.Id == accompaniedBaggageEntryAndExit.Id
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
    /// Connect multiple GeneralTravelerInformationTpds records to AccompaniedBaggageEntryAndExit
    /// </summary>
    public async Task ConnectGeneralTravelerInformationTpds(
        AccompaniedBaggageEntryAndExitWhereUniqueInput uniqueId,
        GeneralTravelerInformationTpdWhereUniqueInput[] generalTravelerInformationTpdsId
    )
    {
        var parent = await _context
            .AccompaniedBaggageEntryAndExits.Include(x => x.GeneralTravelerInformationTpds)
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
    /// Disconnect multiple GeneralTravelerInformationTpds records from AccompaniedBaggageEntryAndExit
    /// </summary>
    public async Task DisconnectGeneralTravelerInformationTpds(
        AccompaniedBaggageEntryAndExitWhereUniqueInput uniqueId,
        GeneralTravelerInformationTpdWhereUniqueInput[] generalTravelerInformationTpdsId
    )
    {
        var parent = await _context
            .AccompaniedBaggageEntryAndExits.Include(x => x.GeneralTravelerInformationTpds)
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
    /// Find multiple GeneralTravelerInformationTpds records for AccompaniedBaggageEntryAndExit
    /// </summary>
    public async Task<List<GeneralTravelerInformationTpd>> FindGeneralTravelerInformationTpds(
        AccompaniedBaggageEntryAndExitWhereUniqueInput uniqueId,
        GeneralTravelerInformationTpdFindManyArgs accompaniedBaggageEntryAndExitFindManyArgs
    )
    {
        var generalTravelerInformationTpds = await _context
            .GeneralTravelerInformationTpds.Where(m =>
                m.AccompaniedBaggageEntryAndExitId == uniqueId.Id
            )
            .ApplyWhere(accompaniedBaggageEntryAndExitFindManyArgs.Where)
            .ApplySkip(accompaniedBaggageEntryAndExitFindManyArgs.Skip)
            .ApplyTake(accompaniedBaggageEntryAndExitFindManyArgs.Take)
            .ApplyOrderBy(accompaniedBaggageEntryAndExitFindManyArgs.SortBy)
            .ToListAsync();

        return generalTravelerInformationTpds.Select(x => x.ToDto()).ToList();
    }

    /// <summary>
    /// Update multiple GeneralTravelerInformationTpds records for AccompaniedBaggageEntryAndExit
    /// </summary>
    public async Task UpdateGeneralTravelerInformationTpds(
        AccompaniedBaggageEntryAndExitWhereUniqueInput uniqueId,
        GeneralTravelerInformationTpdWhereUniqueInput[] generalTravelerInformationTpdsId
    )
    {
        var accompaniedBaggageEntryAndExit = await _context
            .AccompaniedBaggageEntryAndExits.Include(t => t.GeneralTravelerInformationTpds)
            .FirstOrDefaultAsync(x => x.Id == uniqueId.Id);
        if (accompaniedBaggageEntryAndExit == null)
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

        accompaniedBaggageEntryAndExit.GeneralTravelerInformationTpds =
            generalTravelerInformationTpds;
        await _context.SaveChangesAsync();
    }
}
