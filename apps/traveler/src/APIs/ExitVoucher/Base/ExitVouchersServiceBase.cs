using Microsoft.EntityFrameworkCore;
using Traveler.APIs;
using Traveler.APIs.Common;
using Traveler.APIs.Dtos;
using Traveler.APIs.Errors;
using Traveler.APIs.Extensions;
using Traveler.Infrastructure;
using Traveler.Infrastructure.Models;

namespace Traveler.APIs;

public abstract class ExitVouchersServiceBase : IExitVouchersService
{
    protected readonly TravelerDbContext _context;

    public ExitVouchersServiceBase(TravelerDbContext context)
    {
        _context = context;
    }

    /// <summary>
    /// Create one ExitVoucher
    /// </summary>
    public async Task<ExitVoucher> CreateExitVoucher(ExitVoucherCreateInput createDto)
    {
        var exitVoucher = new ExitVoucherDbModel
        {
            CreatedAt = createDto.CreatedAt,
            DeletionOn = createDto.DeletionOn,
            ExitRequestDate = createDto.ExitRequestDate,
            ExitVoucherSerialNumber = createDto.ExitVoucherSerialNumber,
            FinalModificationDateAndTime = createDto.FinalModificationDateAndTime,
            FirstRegistrationDateAndTime = createDto.FirstRegistrationDateAndTime,
            OfficeCode = createDto.OfficeCode,
            ReferenceNumber = createDto.ReferenceNumber,
            UpdatedAt = createDto.UpdatedAt,
            VerifierId = createDto.VerifierId
        };

        if (createDto.Id != null)
        {
            exitVoucher.Id = createDto.Id;
        }
        if (createDto.GeneralTravelerInformationTpds != null)
        {
            exitVoucher.GeneralTravelerInformationTpds = await _context
                .GeneralTravelerInformationTpds.Where(generalTravelerInformationTpd =>
                    createDto
                        .GeneralTravelerInformationTpds.Select(t => t.Id)
                        .Contains(generalTravelerInformationTpd.Id)
                )
                .ToListAsync();
        }

        _context.ExitVouchers.Add(exitVoucher);
        await _context.SaveChangesAsync();

        var result = await _context.FindAsync<ExitVoucherDbModel>(exitVoucher.Id);

        if (result == null)
        {
            throw new NotFoundException();
        }

        return result.ToDto();
    }

    /// <summary>
    /// Delete one ExitVoucher
    /// </summary>
    public async Task DeleteExitVoucher(ExitVoucherWhereUniqueInput uniqueId)
    {
        var exitVoucher = await _context.ExitVouchers.FindAsync(uniqueId.Id);
        if (exitVoucher == null)
        {
            throw new NotFoundException();
        }

        _context.ExitVouchers.Remove(exitVoucher);
        await _context.SaveChangesAsync();
    }

    /// <summary>
    /// Find many ExitVouchers
    /// </summary>
    public async Task<List<ExitVoucher>> ExitVouchers(ExitVoucherFindManyArgs findManyArgs)
    {
        var exitVouchers = await _context
            .ExitVouchers.Include(x => x.GeneralTravelerInformationTpds)
            .ApplyWhere(findManyArgs.Where)
            .ApplySkip(findManyArgs.Skip)
            .ApplyTake(findManyArgs.Take)
            .ApplyOrderBy(findManyArgs.SortBy)
            .ToListAsync();
        return exitVouchers.ConvertAll(exitVoucher => exitVoucher.ToDto());
    }

    /// <summary>
    /// Meta data about ExitVoucher records
    /// </summary>
    public async Task<MetadataDto> ExitVouchersMeta(ExitVoucherFindManyArgs findManyArgs)
    {
        var count = await _context.ExitVouchers.ApplyWhere(findManyArgs.Where).CountAsync();

        return new MetadataDto { Count = count };
    }

    /// <summary>
    /// Get one ExitVoucher
    /// </summary>
    public async Task<ExitVoucher> ExitVoucher(ExitVoucherWhereUniqueInput uniqueId)
    {
        var exitVouchers = await this.ExitVouchers(
            new ExitVoucherFindManyArgs { Where = new ExitVoucherWhereInput { Id = uniqueId.Id } }
        );
        var exitVoucher = exitVouchers.FirstOrDefault();
        if (exitVoucher == null)
        {
            throw new NotFoundException();
        }

        return exitVoucher;
    }

    /// <summary>
    /// Update one ExitVoucher
    /// </summary>
    public async Task UpdateExitVoucher(
        ExitVoucherWhereUniqueInput uniqueId,
        ExitVoucherUpdateInput updateDto
    )
    {
        var exitVoucher = updateDto.ToModel(uniqueId);

        if (updateDto.GeneralTravelerInformationTpds != null)
        {
            exitVoucher.GeneralTravelerInformationTpds = await _context
                .GeneralTravelerInformationTpds.Where(generalTravelerInformationTpd =>
                    updateDto
                        .GeneralTravelerInformationTpds.Select(t => t)
                        .Contains(generalTravelerInformationTpd.Id)
                )
                .ToListAsync();
        }

        _context.Entry(exitVoucher).State = EntityState.Modified;

        try
        {
            await _context.SaveChangesAsync();
        }
        catch (DbUpdateConcurrencyException)
        {
            if (!_context.ExitVouchers.Any(e => e.Id == exitVoucher.Id))
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
    /// Connect multiple GeneralTravelerInformationTpds records to ExitVoucher
    /// </summary>
    public async Task ConnectGeneralTravelerInformationTpds(
        ExitVoucherWhereUniqueInput uniqueId,
        GeneralTravelerInformationTpdWhereUniqueInput[] generalTravelerInformationTpdsId
    )
    {
        var parent = await _context
            .ExitVouchers.Include(x => x.GeneralTravelerInformationTpds)
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
    /// Disconnect multiple GeneralTravelerInformationTpds records from ExitVoucher
    /// </summary>
    public async Task DisconnectGeneralTravelerInformationTpds(
        ExitVoucherWhereUniqueInput uniqueId,
        GeneralTravelerInformationTpdWhereUniqueInput[] generalTravelerInformationTpdsId
    )
    {
        var parent = await _context
            .ExitVouchers.Include(x => x.GeneralTravelerInformationTpds)
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
    /// Find multiple GeneralTravelerInformationTpds records for ExitVoucher
    /// </summary>
    public async Task<List<GeneralTravelerInformationTpd>> FindGeneralTravelerInformationTpds(
        ExitVoucherWhereUniqueInput uniqueId,
        GeneralTravelerInformationTpdFindManyArgs exitVoucherFindManyArgs
    )
    {
        var generalTravelerInformationTpds = await _context
            .GeneralTravelerInformationTpds.Where(m => m.ExitVoucherId == uniqueId.Id)
            .ApplyWhere(exitVoucherFindManyArgs.Where)
            .ApplySkip(exitVoucherFindManyArgs.Skip)
            .ApplyTake(exitVoucherFindManyArgs.Take)
            .ApplyOrderBy(exitVoucherFindManyArgs.SortBy)
            .ToListAsync();

        return generalTravelerInformationTpds.Select(x => x.ToDto()).ToList();
    }

    /// <summary>
    /// Update multiple GeneralTravelerInformationTpds records for ExitVoucher
    /// </summary>
    public async Task UpdateGeneralTravelerInformationTpds(
        ExitVoucherWhereUniqueInput uniqueId,
        GeneralTravelerInformationTpdWhereUniqueInput[] generalTravelerInformationTpdsId
    )
    {
        var exitVoucher = await _context
            .ExitVouchers.Include(t => t.GeneralTravelerInformationTpds)
            .FirstOrDefaultAsync(x => x.Id == uniqueId.Id);
        if (exitVoucher == null)
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

        exitVoucher.GeneralTravelerInformationTpds = generalTravelerInformationTpds;
        await _context.SaveChangesAsync();
    }
}
