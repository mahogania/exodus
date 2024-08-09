using Collection.APIs;
using Collection.APIs.Common;
using Collection.APIs.Dtos;
using Collection.APIs.Errors;
using Collection.APIs.Extensions;
using Collection.Infrastructure;
using Collection.Infrastructure.Models;
using Microsoft.EntityFrameworkCore;

namespace Collection.APIs;

public abstract class ReceptionsServiceBase : IReceptionsService
{
    protected readonly CollectionDbContext _context;

    public ReceptionsServiceBase(CollectionDbContext context)
    {
        _context = context;
    }

    /// <summary>
    /// Create one RECEPTION
    /// </summary>
    public async Task<Reception> CreateReception(ReceptionCreateInput createDto)
    {
        var reception = new ReceptionDbModel
        {
            AuthorizationCode = createDto.AuthorizationCode,
            CardNo = createDto.CardNo,
            CardValidityDuration = createDto.CardValidityDuration,
            CardholderName = createDto.CardholderName,
            CollectionNo = createDto.CollectionNo,
            ConnectionIp = createDto.ConnectionIp,
            CreatedAt = createDto.CreatedAt,
            DeletionOn = createDto.DeletionOn,
            ErrorMessageContent = createDto.ErrorMessageContent,
            ErrorsErrorCode = createDto.ErrorsErrorCode,
            FinalModificationDateAndTime = createDto.FinalModificationDateAndTime,
            FinalModifierId = createDto.FinalModifierId,
            FirstRegistrantId = createDto.FirstRegistrantId,
            FirstRegistrationDateAndTime = createDto.FirstRegistrationDateAndTime,
            LinkingParameterContent = createDto.LinkingParameterContent,
            NoticeNo = createDto.NoticeNo,
            OrderIdentifier = createDto.OrderIdentifier,
            OrderNumber = createDto.OrderNumber,
            OrderStatusParameter = createDto.OrderStatusParameter,
            PaymentDateAndTime = createDto.PaymentDateAndTime,
            ProcessingStatusCode = createDto.ProcessingStatusCode,
            ProcessingStatusContent = createDto.ProcessingStatusContent,
            ThreeDigitCountryCode = createDto.ThreeDigitCountryCode,
            TotalNoticeAmount = createDto.TotalNoticeAmount,
            UpdatedAt = createDto.UpdatedAt
        };

        if (createDto.Id != null)
        {
            reception.Id = createDto.Id;
        }

        _context.Receptions.Add(reception);
        await _context.SaveChangesAsync();

        var result = await _context.FindAsync<ReceptionDbModel>(reception.Id);

        if (result == null)
        {
            throw new NotFoundException();
        }

        return result.ToDto();
    }

    /// <summary>
    /// Delete one RECEPTION
    /// </summary>
    public async Task DeleteReception(ReceptionWhereUniqueInput uniqueId)
    {
        var reception = await _context.Receptions.FindAsync(uniqueId.Id);
        if (reception == null)
        {
            throw new NotFoundException();
        }

        _context.Receptions.Remove(reception);
        await _context.SaveChangesAsync();
    }

    /// <summary>
    /// Find many RECEPTIONS
    /// </summary>
    public async Task<List<Reception>> Receptions(ReceptionFindManyArgs findManyArgs)
    {
        var receptions = await _context
            .Receptions.ApplyWhere(findManyArgs.Where)
            .ApplySkip(findManyArgs.Skip)
            .ApplyTake(findManyArgs.Take)
            .ApplyOrderBy(findManyArgs.SortBy)
            .ToListAsync();
        return receptions.ConvertAll(reception => reception.ToDto());
    }

    /// <summary>
    /// Meta data about RECEPTION records
    /// </summary>
    public async Task<MetadataDto> ReceptionsMeta(ReceptionFindManyArgs findManyArgs)
    {
        var count = await _context.Receptions.ApplyWhere(findManyArgs.Where).CountAsync();

        return new MetadataDto { Count = count };
    }

    /// <summary>
    /// Get one RECEPTION
    /// </summary>
    public async Task<Reception> Reception(ReceptionWhereUniqueInput uniqueId)
    {
        var receptions = await this.Receptions(
            new ReceptionFindManyArgs { Where = new ReceptionWhereInput { Id = uniqueId.Id } }
        );
        var reception = receptions.FirstOrDefault();
        if (reception == null)
        {
            throw new NotFoundException();
        }

        return reception;
    }

    /// <summary>
    /// Update one RECEPTION
    /// </summary>
    public async Task UpdateReception(
        ReceptionWhereUniqueInput uniqueId,
        ReceptionUpdateInput updateDto
    )
    {
        var reception = updateDto.ToModel(uniqueId);

        _context.Entry(reception).State = EntityState.Modified;

        try
        {
            await _context.SaveChangesAsync();
        }
        catch (DbUpdateConcurrencyException)
        {
            if (!_context.Receptions.Any(e => e.Id == reception.Id))
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
