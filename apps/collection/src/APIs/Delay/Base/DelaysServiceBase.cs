using Collection.APIs.Common;
using Collection.APIs.Dtos;
using Collection.APIs.Errors;
using Collection.APIs.Extensions;
using Collection.Infrastructure;
using Collection.Infrastructure.Models;
using Microsoft.EntityFrameworkCore;

namespace Collection.APIs;

public abstract class DelaysServiceBase : IDelaysService
{
    protected readonly CollectionDbContext _context;

    public DelaysServiceBase(CollectionDbContext context)
    {
        _context = context;
    }

    /// <summary>
    ///     Create one DELAY
    /// </summary>
    public async Task<Delay> CreateDelay(DelayCreateInput createDto)
    {
        var delay = new DelayDbModel
        {
            CreatedAt = createDto.CreatedAt,
            DeletionFlag = createDto.DeletionFlag,
            FinalModificationDateAndTime = createDto.FinalModificationDateAndTime,
            FinalModifierId = createDto.FinalModifierId,
            FirstRegistrantId = createDto.FirstRegistrantId,
            FirstRegistrationDateAndTime = createDto.FirstRegistrationDateAndTime,
            LatePaymentDate = createDto.LatePaymentDate,
            LatePaymentInterestAmount = createDto.LatePaymentInterestAmount,
            LatePaymentInterestAmountExistingBeforeLatePayment =
                createDto.LatePaymentInterestAmountExistingBeforeLatePayment,
            NoticeNumber = createDto.NoticeNumber,
            NotificationDate = createDto.NotificationDate,
            NumberOfTimesOfLatePayments = createDto.NumberOfTimesOfLatePayments,
            OfficeCode = createDto.OfficeCode,
            PaymentDeadline = createDto.PaymentDeadline,
            PenaltyRate = createDto.PenaltyRate,
            PreviousDueDate = createDto.PreviousDueDate,
            PreviousNotificationDate = createDto.PreviousNotificationDate,
            ServiceCode = createDto.ServiceCode,
            TotalNoticeAmount = createDto.TotalNoticeAmount,
            TotalPreviousNoticeAmount = createDto.TotalPreviousNoticeAmount,
            UnadjustedLatePaymentInterestAmount = createDto.UnadjustedLatePaymentInterestAmount,
            UpdatedAt = createDto.UpdatedAt
        };

        if (createDto.Id != null) delay.Id = createDto.Id;

        _context.Delays.Add(delay);
        await _context.SaveChangesAsync();

        var result = await _context.FindAsync<DelayDbModel>(delay.Id);

        if (result == null) throw new NotFoundException();

        return result.ToDto();
    }

    /// <summary>
    ///     Delete one DELAY
    /// </summary>
    public async Task DeleteDelay(DelayWhereUniqueInput uniqueId)
    {
        var delay = await _context.Delays.FindAsync(uniqueId.Id);
        if (delay == null) throw new NotFoundException();

        _context.Delays.Remove(delay);
        await _context.SaveChangesAsync();
    }

    /// <summary>
    ///     Find many DELAYS
    /// </summary>
    public async Task<List<Delay>> Delays(DelayFindManyArgs findManyArgs)
    {
        var delays = await _context
            .Delays.ApplyWhere(findManyArgs.Where)
            .ApplySkip(findManyArgs.Skip)
            .ApplyTake(findManyArgs.Take)
            .ApplyOrderBy(findManyArgs.SortBy)
            .ToListAsync();
        return delays.ConvertAll(delay => delay.ToDto());
    }

    /// <summary>
    ///     Meta data about DELAY records
    /// </summary>
    public async Task<MetadataDto> DelaysMeta(DelayFindManyArgs findManyArgs)
    {
        var count = await _context.Delays.ApplyWhere(findManyArgs.Where).CountAsync();

        return new MetadataDto { Count = count };
    }

    /// <summary>
    ///     Get one DELAY
    /// </summary>
    public async Task<Delay> Delay(DelayWhereUniqueInput uniqueId)
    {
        var delays = await Delays(
            new DelayFindManyArgs { Where = new DelayWhereInput { Id = uniqueId.Id } }
        );
        var delay = delays.FirstOrDefault();
        if (delay == null) throw new NotFoundException();

        return delay;
    }

    /// <summary>
    ///     Update one DELAY
    /// </summary>
    public async Task UpdateDelay(DelayWhereUniqueInput uniqueId, DelayUpdateInput updateDto)
    {
        var delay = updateDto.ToModel(uniqueId);

        _context.Entry(delay).State = EntityState.Modified;

        try
        {
            await _context.SaveChangesAsync();
        }
        catch (DbUpdateConcurrencyException)
        {
            if (!_context.Delays.Any(e => e.Id == delay.Id))
                throw new NotFoundException();
            throw;
        }
    }
}
