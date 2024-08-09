using Clre.APIs;
using Clre.APIs.Common;
using Clre.APIs.Dtos;
using Clre.APIs.Errors;
using Clre.APIs.Extensions;
using Clre.Infrastructure;
using Clre.Infrastructure.Models;
using Microsoft.EntityFrameworkCore;

namespace Clre.APIs;

public abstract class TemporaryAdmissionOfVehiclesServiceBase : ITemporaryAdmissionOfVehiclesService
{
    protected readonly ClreDbContext _context;

    public TemporaryAdmissionOfVehiclesServiceBase(ClreDbContext context)
    {
        _context = context;
    }

    /// <summary>
    /// Create one TEMPORARY ADMISSION OF VEHICLE
    /// </summary>
    public async Task<TemporaryAdmissionOfVehicle> CreateTemporaryAdmissionOfVehicle(
        TemporaryAdmissionOfVehicleCreateInput createDto
    )
    {
        var temporaryAdmissionOfVehicle = new TemporaryAdmissionOfVehicleDbModel
        {
            CreatedAt = createDto.CreatedAt,
            DeletionOn = createDto.DeletionOn,
            EntryCustomsOfficeCode = createDto.EntryCustomsOfficeCode,
            FinalModificationDateAndTime = createDto.FinalModificationDateAndTime,
            FinalModifierSId = createDto.FinalModifierSId,
            FirstRecorderSId = createDto.FirstRecorderSId,
            FirstRegistrationDateAndTime = createDto.FirstRegistrationDateAndTime,
            ReImportationReExportationOfficeCode = createDto.ReImportationReExportationOfficeCode,
            RectificationFrequency = createDto.RectificationFrequency,
            RegimeRequestNumber = createDto.RegimeRequestNumber,
            RequestedDelayEndDate = createDto.RequestedDelayEndDate,
            RequestedDelayStartDate = createDto.RequestedDelayStartDate,
            UpdatedAt = createDto.UpdatedAt
        };

        if (createDto.Id != null)
        {
            temporaryAdmissionOfVehicle.Id = createDto.Id;
        }

        _context.TemporaryAdmissionOfVehicles.Add(temporaryAdmissionOfVehicle);
        await _context.SaveChangesAsync();

        var result = await _context.FindAsync<TemporaryAdmissionOfVehicleDbModel>(
            temporaryAdmissionOfVehicle.Id
        );

        if (result == null)
        {
            throw new NotFoundException();
        }

        return result.ToDto();
    }

    /// <summary>
    /// Delete one TEMPORARY ADMISSION OF VEHICLE
    /// </summary>
    public async Task DeleteTemporaryAdmissionOfVehicle(
        TemporaryAdmissionOfVehicleWhereUniqueInput uniqueId
    )
    {
        var temporaryAdmissionOfVehicle = await _context.TemporaryAdmissionOfVehicles.FindAsync(
            uniqueId.Id
        );
        if (temporaryAdmissionOfVehicle == null)
        {
            throw new NotFoundException();
        }

        _context.TemporaryAdmissionOfVehicles.Remove(temporaryAdmissionOfVehicle);
        await _context.SaveChangesAsync();
    }

    /// <summary>
    /// Find many TEMPORARY ADMISSION OF VEHICLES
    /// </summary>
    public async Task<List<TemporaryAdmissionOfVehicle>> TemporaryAdmissionOfVehicles(
        TemporaryAdmissionOfVehicleFindManyArgs findManyArgs
    )
    {
        var temporaryAdmissionOfVehicles = await _context
            .TemporaryAdmissionOfVehicles.ApplyWhere(findManyArgs.Where)
            .ApplySkip(findManyArgs.Skip)
            .ApplyTake(findManyArgs.Take)
            .ApplyOrderBy(findManyArgs.SortBy)
            .ToListAsync();
        return temporaryAdmissionOfVehicles.ConvertAll(temporaryAdmissionOfVehicle =>
            temporaryAdmissionOfVehicle.ToDto()
        );
    }

    /// <summary>
    /// Meta data about TEMPORARY ADMISSION OF VEHICLE records
    /// </summary>
    public async Task<MetadataDto> TemporaryAdmissionOfVehiclesMeta(
        TemporaryAdmissionOfVehicleFindManyArgs findManyArgs
    )
    {
        var count = await _context
            .TemporaryAdmissionOfVehicles.ApplyWhere(findManyArgs.Where)
            .CountAsync();

        return new MetadataDto { Count = count };
    }

    /// <summary>
    /// Get one TEMPORARY ADMISSION OF VEHICLE
    /// </summary>
    public async Task<TemporaryAdmissionOfVehicle> TemporaryAdmissionOfVehicle(
        TemporaryAdmissionOfVehicleWhereUniqueInput uniqueId
    )
    {
        var temporaryAdmissionOfVehicles = await this.TemporaryAdmissionOfVehicles(
            new TemporaryAdmissionOfVehicleFindManyArgs
            {
                Where = new TemporaryAdmissionOfVehicleWhereInput { Id = uniqueId.Id }
            }
        );
        var temporaryAdmissionOfVehicle = temporaryAdmissionOfVehicles.FirstOrDefault();
        if (temporaryAdmissionOfVehicle == null)
        {
            throw new NotFoundException();
        }

        return temporaryAdmissionOfVehicle;
    }

    /// <summary>
    /// Update one TEMPORARY ADMISSION OF VEHICLE
    /// </summary>
    public async Task UpdateTemporaryAdmissionOfVehicle(
        TemporaryAdmissionOfVehicleWhereUniqueInput uniqueId,
        TemporaryAdmissionOfVehicleUpdateInput updateDto
    )
    {
        var temporaryAdmissionOfVehicle = updateDto.ToModel(uniqueId);

        _context.Entry(temporaryAdmissionOfVehicle).State = EntityState.Modified;

        try
        {
            await _context.SaveChangesAsync();
        }
        catch (DbUpdateConcurrencyException)
        {
            if (
                !_context.TemporaryAdmissionOfVehicles.Any(e =>
                    e.Id == temporaryAdmissionOfVehicle.Id
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
