using Collection.APIs.Common;
using Collection.APIs.Dtos;
using Collection.APIs.Errors;
using Collection.APIs.Extensions;
using Collection.Infrastructure;
using Collection.Infrastructure.Models;
using Microsoft.EntityFrameworkCore;

namespace Collection.APIs;

public abstract class FinesServiceBase : IFinesService
{
    protected readonly CollectionDbContext _context;

    public FinesServiceBase(CollectionDbContext context)
    {
        _context = context;
    }

    /// <summary>
    ///     Create one FINE
    /// </summary>
    public async Task<Fine> CreateFine(FineCreateInput createDto)
    {
        var fine = new FineDbModel
        {
            AttachmentId = createDto.AttachmentId,
            CreatedAt = createDto.CreatedAt,
            DeclarantCode = createDto.DeclarantCode,
            DeletionOn = createDto.DeletionOn,
            FinalModificationDateAndTime = createDto.FinalModificationDateAndTime,
            FinalModifierId = createDto.FinalModifierId,
            FinancialManagerName = createDto.FinancialManagerName,
            FineAmount = createDto.FineAmount,
            FineAmountInEur = createDto.FineAmountInEur,
            FineAmountInUsd = createDto.FineAmountInUsd,
            FineCancellationDate = createDto.FineCancellationDate,
            FineCancellationOfficerId = createDto.FineCancellationOfficerId,
            FineCancellationReasonContent = createDto.FineCancellationReasonContent,
            FineCancellationRequestNo = createDto.FineCancellationRequestNo,
            FineImpositionRequestNo = createDto.FineImpositionRequestNo,
            FineRegistrationReasonContent = createDto.FineRegistrationReasonContent,
            FirstRegistrantId = createDto.FirstRegistrantId,
            FirstRegistrationDateAndTime = createDto.FirstRegistrationDateAndTime,
            NiuCategoryCode = createDto.NiuCategoryCode,
            NiuCategoryName = createDto.NiuCategoryName,
            NoticeNo = createDto.NoticeNo,
            NotificationRequiredOn = createDto.NotificationRequiredOn,
            OfficeCode = createDto.OfficeCode,
            ReferenceDate = createDto.ReferenceDate,
            ReferenceNo = createDto.ReferenceNo,
            ReferenceNumberTypeCode = createDto.ReferenceNumberTypeCode,
            ReferenceNumberTypeName = createDto.ReferenceNumberTypeName,
            RegisteringPersonId = createDto.RegisteringPersonId,
            RegistrationDate = createDto.RegistrationDate,
            ServiceCode = createDto.ServiceCode,
            TaxpayerIdentificationNo = createDto.TaxpayerIdentificationNo,
            UpdatedAt = createDto.UpdatedAt
        };

        if (createDto.Id != null) fine.Id = createDto.Id;

        _context.Fines.Add(fine);
        await _context.SaveChangesAsync();

        var result = await _context.FindAsync<FineDbModel>(fine.Id);

        if (result == null) throw new NotFoundException();

        return result.ToDto();
    }

    /// <summary>
    ///     Delete one FINE
    /// </summary>
    public async Task DeleteFine(FineWhereUniqueInput uniqueId)
    {
        var fine = await _context.Fines.FindAsync(uniqueId.Id);
        if (fine == null) throw new NotFoundException();

        _context.Fines.Remove(fine);
        await _context.SaveChangesAsync();
    }

    /// <summary>
    ///     Find many FINES
    /// </summary>
    public async Task<List<Fine>> Fines(FineFindManyArgs findManyArgs)
    {
        var fines = await _context
            .Fines.ApplyWhere(findManyArgs.Where)
            .ApplySkip(findManyArgs.Skip)
            .ApplyTake(findManyArgs.Take)
            .ApplyOrderBy(findManyArgs.SortBy)
            .ToListAsync();
        return fines.ConvertAll(fine => fine.ToDto());
    }

    /// <summary>
    ///     Meta data about FINE records
    /// </summary>
    public async Task<MetadataDto> FinesMeta(FineFindManyArgs findManyArgs)
    {
        var count = await _context.Fines.ApplyWhere(findManyArgs.Where).CountAsync();

        return new MetadataDto { Count = count };
    }

    /// <summary>
    ///     Get one FINE
    /// </summary>
    public async Task<Fine> Fine(FineWhereUniqueInput uniqueId)
    {
        var fines = await Fines(
            new FineFindManyArgs { Where = new FineWhereInput { Id = uniqueId.Id } }
        );
        var fine = fines.FirstOrDefault();
        if (fine == null) throw new NotFoundException();

        return fine;
    }

    /// <summary>
    ///     Update one FINE
    /// </summary>
    public async Task UpdateFine(FineWhereUniqueInput uniqueId, FineUpdateInput updateDto)
    {
        var fine = updateDto.ToModel(uniqueId);

        _context.Entry(fine).State = EntityState.Modified;

        try
        {
            await _context.SaveChangesAsync();
        }
        catch (DbUpdateConcurrencyException)
        {
            if (!_context.Fines.Any(e => e.Id == fine.Id))
                throw new NotFoundException();
            throw;
        }
    }
}
