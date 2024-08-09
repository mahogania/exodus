using Control.APIs;
using Control.APIs.Common;
using Control.APIs.Dtos;
using Control.APIs.Errors;
using Control.APIs.Extensions;
using Control.Infrastructure;
using Control.Infrastructure.Models;
using Microsoft.EntityFrameworkCore;

namespace Control.APIs;

public abstract class StateOfGoodsForPassivePerfectionCommonsServiceBase
    : IStateOfGoodsForPassivePerfectionCommonsService
{
    protected readonly ControlDbContext _context;

    public StateOfGoodsForPassivePerfectionCommonsServiceBase(ControlDbContext context)
    {
        _context = context;
    }

    /// <summary>
    /// Create one STATE OF GOODS FOR PASSIVE PERFECTION COMMON
    /// </summary>
    public async Task<StateOfGoodsForPassivePerfectionCommon> CreateStateOfGoodsForPassivePerfectionCommon(
        StateOfGoodsForPassivePerfectionCommonCreateInput createDto
    )
    {
        var stateOfGoodsForPassivePerfectionCommon =
            new StateOfGoodsForPassivePerfectionCommonDbModel
            {
                CompanyAddress = createDto.CompanyAddress,
                CompanyName = createDto.CompanyName,
                CreatedAt = createDto.CreatedAt,
                CustomsCodeOfExportDeclaration = createDto.CustomsCodeOfExportDeclaration,
                CustomsCodeOfImportDeclaration = createDto.CustomsCodeOfImportDeclaration,
                DeletionOn = createDto.DeletionOn,
                DocumentCode = createDto.DocumentCode,
                EndDateOfGrantedDeadline = createDto.EndDateOfGrantedDeadline,
                FinalModificationDateAndTime = createDto.FinalModificationDateAndTime,
                FinalModifierSId = createDto.FinalModifierSId,
                FirstRecorderSId = createDto.FirstRecorderSId,
                FirstRegistrationDateAndTime = createDto.FirstRegistrationDateAndTime,
                NatureOfPassivePerfection = createDto.NatureOfPassivePerfection,
                PaymentBankAgencyCode = createDto.PaymentBankAgencyCode,
                PaymentBankCode = createDto.PaymentBankCode,
                PaymentModeCode = createDto.PaymentModeCode,
                ReasonsCitedInFavorOfTheOperation = createDto.ReasonsCitedInFavorOfTheOperation,
                RectificationFrequency = createDto.RectificationFrequency,
                RegimeRequestNumber = createDto.RegimeRequestNumber,
                SpecifyOtherPaymentMethods = createDto.SpecifyOtherPaymentMethods,
                StartDateOfGrantedDeadline = createDto.StartDateOfGrantedDeadline,
                TotalAmount = createDto.TotalAmount,
                TransactionValueCurrencyCode = createDto.TransactionValueCurrencyCode,
                UpdatedAt = createDto.UpdatedAt
            };

        if (createDto.Id != null)
        {
            stateOfGoodsForPassivePerfectionCommon.Id = createDto.Id;
        }

        _context.StateOfGoodsForPassivePerfectionCommons.Add(
            stateOfGoodsForPassivePerfectionCommon
        );
        await _context.SaveChangesAsync();

        var result = await _context.FindAsync<StateOfGoodsForPassivePerfectionCommonDbModel>(
            stateOfGoodsForPassivePerfectionCommon.Id
        );

        if (result == null)
        {
            throw new NotFoundException();
        }

        return result.ToDto();
    }

    /// <summary>
    /// Delete one STATE OF GOODS FOR PASSIVE PERFECTION COMMON
    /// </summary>
    public async Task DeleteStateOfGoodsForPassivePerfectionCommon(
        StateOfGoodsForPassivePerfectionCommonWhereUniqueInput uniqueId
    )
    {
        var stateOfGoodsForPassivePerfectionCommon =
            await _context.StateOfGoodsForPassivePerfectionCommons.FindAsync(uniqueId.Id);
        if (stateOfGoodsForPassivePerfectionCommon == null)
        {
            throw new NotFoundException();
        }

        _context.StateOfGoodsForPassivePerfectionCommons.Remove(
            stateOfGoodsForPassivePerfectionCommon
        );
        await _context.SaveChangesAsync();
    }

    /// <summary>
    /// Find many STATE OF GOODS FOR PASSIVE PERFECTION COMMONS
    /// </summary>
    public async Task<
        List<StateOfGoodsForPassivePerfectionCommon>
    > StateOfGoodsForPassivePerfectionCommons(
        StateOfGoodsForPassivePerfectionCommonFindManyArgs findManyArgs
    )
    {
        var stateOfGoodsForPassivePerfectionCommons = await _context
            .StateOfGoodsForPassivePerfectionCommons.ApplyWhere(findManyArgs.Where)
            .ApplySkip(findManyArgs.Skip)
            .ApplyTake(findManyArgs.Take)
            .ApplyOrderBy(findManyArgs.SortBy)
            .ToListAsync();
        return stateOfGoodsForPassivePerfectionCommons.ConvertAll(
            stateOfGoodsForPassivePerfectionCommon => stateOfGoodsForPassivePerfectionCommon.ToDto()
        );
    }

    /// <summary>
    /// Meta data about STATE OF GOODS FOR PASSIVE PERFECTION COMMON records
    /// </summary>
    public async Task<MetadataDto> StateOfGoodsForPassivePerfectionCommonsMeta(
        StateOfGoodsForPassivePerfectionCommonFindManyArgs findManyArgs
    )
    {
        var count = await _context
            .StateOfGoodsForPassivePerfectionCommons.ApplyWhere(findManyArgs.Where)
            .CountAsync();

        return new MetadataDto { Count = count };
    }

    /// <summary>
    /// Get one STATE OF GOODS FOR PASSIVE PERFECTION COMMON
    /// </summary>
    public async Task<StateOfGoodsForPassivePerfectionCommon> StateOfGoodsForPassivePerfectionCommon(
        StateOfGoodsForPassivePerfectionCommonWhereUniqueInput uniqueId
    )
    {
        var stateOfGoodsForPassivePerfectionCommons =
            await this.StateOfGoodsForPassivePerfectionCommons(
                new StateOfGoodsForPassivePerfectionCommonFindManyArgs
                {
                    Where = new StateOfGoodsForPassivePerfectionCommonWhereInput
                    {
                        Id = uniqueId.Id
                    }
                }
            );
        var stateOfGoodsForPassivePerfectionCommon =
            stateOfGoodsForPassivePerfectionCommons.FirstOrDefault();
        if (stateOfGoodsForPassivePerfectionCommon == null)
        {
            throw new NotFoundException();
        }

        return stateOfGoodsForPassivePerfectionCommon;
    }

    /// <summary>
    /// Update one STATE OF GOODS FOR PASSIVE PERFECTION COMMON
    /// </summary>
    public async Task UpdateStateOfGoodsForPassivePerfectionCommon(
        StateOfGoodsForPassivePerfectionCommonWhereUniqueInput uniqueId,
        StateOfGoodsForPassivePerfectionCommonUpdateInput updateDto
    )
    {
        var stateOfGoodsForPassivePerfectionCommon = updateDto.ToModel(uniqueId);

        _context.Entry(stateOfGoodsForPassivePerfectionCommon).State = EntityState.Modified;

        try
        {
            await _context.SaveChangesAsync();
        }
        catch (DbUpdateConcurrencyException)
        {
            if (
                !_context.StateOfGoodsForPassivePerfectionCommons.Any(e =>
                    e.Id == stateOfGoodsForPassivePerfectionCommon.Id
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
