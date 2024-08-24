using Control.APIs;
using Control.APIs.Common;
using Control.APIs.Dtos;
using Control.APIs.Errors;
using Control.APIs.Extensions;
using Control.Infrastructure;
using Control.Infrastructure.Models;
using Microsoft.EntityFrameworkCore;

namespace Control.APIs;

public abstract class CommonExpressClearancesServiceBase : ICommonExpressClearancesService
{
    protected readonly ControlDbContext _context;

    public CommonExpressClearancesServiceBase(ControlDbContext context)
    {
        _context = context;
    }

    /// <summary>
    /// Create one Common Express Clearance
    /// </summary>
    public async Task<CommonExpressClearance> CreateCommonExpressClearance(
        CommonExpressClearanceCreateInput createDto
    )
    {
        var commonExpressClearance = new CommonExpressClearanceDbModel
        {
            ArrivalDate = createDto.ArrivalDate,
            AttachedFileId = createDto.AttachedFileId,
            CountryOfLoadingCode = createDto.CountryOfLoadingCode,
            CreatedAt = createDto.CreatedAt,
            CustomsOfficeCode = createDto.CustomsOfficeCode,
            DeletionOn = createDto.DeletionOn,
            ExpressClearanceRequestNumber = createDto.ExpressClearanceRequestNumber,
            ExpressOperatorCode = createDto.ExpressOperatorCode,
            ExpressOperatorName = createDto.ExpressOperatorName,
            FinalModificationDateAndTime = createDto.FinalModificationDateAndTime,
            FinalModifierSId = createDto.FinalModifierSId,
            FirstRecorderSId = createDto.FirstRecorderSId,
            FirstRegistrationDateAndTime = createDto.FirstRegistrationDateAndTime,
            MasterBlNumber = createDto.MasterBlNumber,
            RequestDate = createDto.RequestDate,
            ShipName = createDto.ShipName,
            TransmissionTypeCode = createDto.TransmissionTypeCode,
            TreatmentStatusCode = createDto.TreatmentStatusCode,
            UpdatedAt = createDto.UpdatedAt
        };

        if (createDto.Id != null)
        {
            commonExpressClearance.Id = createDto.Id;
        }
        if (createDto.Details != null)
        {
            commonExpressClearance.Details = await _context
                .ExpressCustomsClearanceDetailsItems.Where(expressCustomsClearanceDetails =>
                    createDto.Details.Select(t => t.Id).Contains(expressCustomsClearanceDetails.Id)
                )
                .ToListAsync();
        }

        _context.CommonExpressClearances.Add(commonExpressClearance);
        await _context.SaveChangesAsync();

        var result = await _context.FindAsync<CommonExpressClearanceDbModel>(
            commonExpressClearance.Id
        );

        if (result == null)
        {
            throw new NotFoundException();
        }

        return result.ToDto();
    }

    /// <summary>
    /// Delete one Common Express Clearance
    /// </summary>
    public async Task DeleteCommonExpressClearance(CommonExpressClearanceWhereUniqueInput uniqueId)
    {
        var commonExpressClearance = await _context.CommonExpressClearances.FindAsync(uniqueId.Id);
        if (commonExpressClearance == null)
        {
            throw new NotFoundException();
        }

        _context.CommonExpressClearances.Remove(commonExpressClearance);
        await _context.SaveChangesAsync();
    }

    /// <summary>
    /// Find many COMMON EXPRESS CLEARANCES
    /// </summary>
    public async Task<List<CommonExpressClearance>> CommonExpressClearances(
        CommonExpressClearanceFindManyArgs findManyArgs
    )
    {
        var commonExpressClearances = await _context
            .CommonExpressClearances.Include(x => x.Details)
            .ApplyWhere(findManyArgs.Where)
            .ApplySkip(findManyArgs.Skip)
            .ApplyTake(findManyArgs.Take)
            .ApplyOrderBy(findManyArgs.SortBy)
            .ToListAsync();
        return commonExpressClearances.ConvertAll(commonExpressClearance =>
            commonExpressClearance.ToDto()
        );
    }

    /// <summary>
    /// Meta data about Common Express Clearance records
    /// </summary>
    public async Task<MetadataDto> CommonExpressClearancesMeta(
        CommonExpressClearanceFindManyArgs findManyArgs
    )
    {
        var count = await _context
            .CommonExpressClearances.ApplyWhere(findManyArgs.Where)
            .CountAsync();

        return new MetadataDto { Count = count };
    }

    /// <summary>
    /// Get one Common Express Clearance
    /// </summary>
    public async Task<CommonExpressClearance> CommonExpressClearance(
        CommonExpressClearanceWhereUniqueInput uniqueId
    )
    {
        var commonExpressClearances = await this.CommonExpressClearances(
            new CommonExpressClearanceFindManyArgs
            {
                Where = new CommonExpressClearanceWhereInput { Id = uniqueId.Id }
            }
        );
        var commonExpressClearance = commonExpressClearances.FirstOrDefault();
        if (commonExpressClearance == null)
        {
            throw new NotFoundException();
        }

        return commonExpressClearance;
    }

    /// <summary>
    /// Update one Common Express Clearance
    /// </summary>
    public async Task UpdateCommonExpressClearance(
        CommonExpressClearanceWhereUniqueInput uniqueId,
        CommonExpressClearanceUpdateInput updateDto
    )
    {
        var commonExpressClearance = updateDto.ToModel(uniqueId);

        if (updateDto.Details != null)
        {
            commonExpressClearance.Details = await _context
                .ExpressCustomsClearanceDetailsItems.Where(expressCustomsClearanceDetails =>
                    updateDto.Details.Select(t => t).Contains(expressCustomsClearanceDetails.Id)
                )
                .ToListAsync();
        }

        _context.Entry(commonExpressClearance).State = EntityState.Modified;

        try
        {
            await _context.SaveChangesAsync();
        }
        catch (DbUpdateConcurrencyException)
        {
            if (!_context.CommonExpressClearances.Any(e => e.Id == commonExpressClearance.Id))
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
