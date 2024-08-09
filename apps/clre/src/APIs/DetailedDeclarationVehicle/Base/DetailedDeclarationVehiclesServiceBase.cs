using Clre.APIs;
using Clre.APIs.Common;
using Clre.APIs.Dtos;
using Clre.APIs.Errors;
using Clre.APIs.Extensions;
using Clre.Infrastructure;
using Clre.Infrastructure.Models;
using Microsoft.EntityFrameworkCore;

namespace Clre.APIs;

public abstract class DetailedDeclarationVehiclesServiceBase : IDetailedDeclarationVehiclesService
{
    protected readonly ClreDbContext _context;

    public DetailedDeclarationVehiclesServiceBase(ClreDbContext context)
    {
        _context = context;
    }

    /// <summary>
    /// Create one DETAILED DECLARATION VEHICLE
    /// </summary>
    public async Task<DetailedDeclarationVehicle> CreateDetailedDeclarationVehicle(
        DetailedDeclarationVehicleCreateInput createDto
    )
    {
        var detailedDeclarationVehicle = new DetailedDeclarationVehicleDbModel
        {
            ArticleNumber = createDto.ArticleNumber,
            Body = createDto.Body,
            ChassisNumber = createDto.ChassisNumber,
            ColorName = createDto.ColorName,
            CreatedAt = createDto.CreatedAt,
            CubicCapacity = createDto.CubicCapacity,
            DateAndTimeOfFinalModification = createDto.DateAndTimeOfFinalModification,
            DateAndTimeOfFirstRegistration = createDto.DateAndTimeOfFirstRegistration,
            DateOfEndOfInalienability = createDto.DateOfEndOfInalienability,
            DateOfFirstCirculation = createDto.DateOfFirstCirculation,
            DateOfRelease = createDto.DateOfRelease,
            DateOfStartOfInalienability = createDto.DateOfStartOfInalienability,
            DriverSAddress = createDto.DriverSAddress,
            DriverSName = createDto.DriverSName,
            DriverSZipCode = createDto.DriverSZipCode,
            Energy = createDto.Energy,
            FinalModifierSId = createDto.FinalModifierSId,
            FirstRegistrantSId = createDto.FirstRegistrantSId,
            Frame = createDto.Frame,
            Inalienability = createDto.Inalienability,
            LoadU = createDto.LoadU,
            ModelAndSpecificationNumber = createDto.ModelAndSpecificationNumber,
            NumberOfSeats = createDto.NumberOfSeats,
            Power = createDto.Power,
            RectificationFrequency = createDto.RectificationFrequency,
            ReferenceNumber = createDto.ReferenceNumber,
            RegistrationNumber = createDto.RegistrationNumber,
            SuppressionOn = createDto.SuppressionOn,
            TotalWeightC = createDto.TotalWeightC,
            TpdManagementNumber = createDto.TpdManagementNumber,
            UpdatedAt = createDto.UpdatedAt,
            VehicleManufacturerCode = createDto.VehicleManufacturerCode,
            VehicleModelCode = createDto.VehicleModelCode,
            VehicleType = createDto.VehicleType,
            VehicleTypeCode = createDto.VehicleTypeCode,
            YearOfManufacture = createDto.YearOfManufacture
        };

        if (createDto.Id != null)
        {
            detailedDeclarationVehicle.Id = createDto.Id;
        }

        _context.DetailedDeclarationVehicles.Add(detailedDeclarationVehicle);
        await _context.SaveChangesAsync();

        var result = await _context.FindAsync<DetailedDeclarationVehicleDbModel>(
            detailedDeclarationVehicle.Id
        );

        if (result == null)
        {
            throw new NotFoundException();
        }

        return result.ToDto();
    }

    /// <summary>
    /// Delete one DETAILED DECLARATION VEHICLE
    /// </summary>
    public async Task DeleteDetailedDeclarationVehicle(
        DetailedDeclarationVehicleWhereUniqueInput uniqueId
    )
    {
        var detailedDeclarationVehicle = await _context.DetailedDeclarationVehicles.FindAsync(
            uniqueId.Id
        );
        if (detailedDeclarationVehicle == null)
        {
            throw new NotFoundException();
        }

        _context.DetailedDeclarationVehicles.Remove(detailedDeclarationVehicle);
        await _context.SaveChangesAsync();
    }

    /// <summary>
    /// Find many DETAILED DECLARATION VEHICLES
    /// </summary>
    public async Task<List<DetailedDeclarationVehicle>> DetailedDeclarationVehicles(
        DetailedDeclarationVehicleFindManyArgs findManyArgs
    )
    {
        var detailedDeclarationVehicles = await _context
            .DetailedDeclarationVehicles.ApplyWhere(findManyArgs.Where)
            .ApplySkip(findManyArgs.Skip)
            .ApplyTake(findManyArgs.Take)
            .ApplyOrderBy(findManyArgs.SortBy)
            .ToListAsync();
        return detailedDeclarationVehicles.ConvertAll(detailedDeclarationVehicle =>
            detailedDeclarationVehicle.ToDto()
        );
    }

    /// <summary>
    /// Meta data about DETAILED DECLARATION VEHICLE records
    /// </summary>
    public async Task<MetadataDto> DetailedDeclarationVehiclesMeta(
        DetailedDeclarationVehicleFindManyArgs findManyArgs
    )
    {
        var count = await _context
            .DetailedDeclarationVehicles.ApplyWhere(findManyArgs.Where)
            .CountAsync();

        return new MetadataDto { Count = count };
    }

    /// <summary>
    /// Get one DETAILED DECLARATION VEHICLE
    /// </summary>
    public async Task<DetailedDeclarationVehicle> DetailedDeclarationVehicle(
        DetailedDeclarationVehicleWhereUniqueInput uniqueId
    )
    {
        var detailedDeclarationVehicles = await this.DetailedDeclarationVehicles(
            new DetailedDeclarationVehicleFindManyArgs
            {
                Where = new DetailedDeclarationVehicleWhereInput { Id = uniqueId.Id }
            }
        );
        var detailedDeclarationVehicle = detailedDeclarationVehicles.FirstOrDefault();
        if (detailedDeclarationVehicle == null)
        {
            throw new NotFoundException();
        }

        return detailedDeclarationVehicle;
    }

    /// <summary>
    /// Update one DETAILED DECLARATION VEHICLE
    /// </summary>
    public async Task UpdateDetailedDeclarationVehicle(
        DetailedDeclarationVehicleWhereUniqueInput uniqueId,
        DetailedDeclarationVehicleUpdateInput updateDto
    )
    {
        var detailedDeclarationVehicle = updateDto.ToModel(uniqueId);

        _context.Entry(detailedDeclarationVehicle).State = EntityState.Modified;

        try
        {
            await _context.SaveChangesAsync();
        }
        catch (DbUpdateConcurrencyException)
        {
            if (
                !_context.DetailedDeclarationVehicles.Any(e =>
                    e.Id == detailedDeclarationVehicle.Id
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
