using Control.APIs;
using Control.APIs.Common;
using Control.APIs.Dtos;
using Control.APIs.Errors;
using Control.APIs.Extensions;
using Control.Infrastructure;
using Control.Infrastructure.Models;
using Microsoft.EntityFrameworkCore;

namespace Control.APIs;

public abstract class VehiclesServiceBase : IVehiclesService
{
    protected readonly ControlDbContext _context;

    public VehiclesServiceBase(ControlDbContext context)
    {
        _context = context;
    }

    /// <summary>
    /// Create one Vehicle
    /// </summary>
    public async Task<Vehicle> CreateVehicle(VehicleCreateInput createDto)
    {
        var vehicle = new VehicleDbModel
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
            vehicle.Id = createDto.Id;
        }
        if (createDto.Articles != null)
        {
            vehicle.Articles = await _context
                .Articles.Where(article => createDto.Articles.Id == article.Id)
                .FirstOrDefaultAsync();
        }

        _context.Vehicles.Add(vehicle);
        await _context.SaveChangesAsync();

        var result = await _context.FindAsync<VehicleDbModel>(vehicle.Id);

        if (result == null)
        {
            throw new NotFoundException();
        }

        return result.ToDto();
    }

    /// <summary>
    /// Delete one Vehicle
    /// </summary>
    public async Task DeleteVehicle(VehicleWhereUniqueInput uniqueId)
    {
        var vehicle = await _context.Vehicles.FindAsync(uniqueId.Id);
        if (vehicle == null)
        {
            throw new NotFoundException();
        }

        _context.Vehicles.Remove(vehicle);
        await _context.SaveChangesAsync();
    }

    /// <summary>
    /// Find many DETAILED DECLARATION VEHICLES
    /// </summary>
    public async Task<List<Vehicle>> Vehicles(VehicleFindManyArgs findManyArgs)
    {
        var vehicles = await _context
            .Vehicles.Include(x => x.Articles)
            .ApplyWhere(findManyArgs.Where)
            .ApplySkip(findManyArgs.Skip)
            .ApplyTake(findManyArgs.Take)
            .ApplyOrderBy(findManyArgs.SortBy)
            .ToListAsync();
        return vehicles.ConvertAll(vehicle => vehicle.ToDto());
    }

    /// <summary>
    /// Meta data about Vehicle records
    /// </summary>
    public async Task<MetadataDto> VehiclesMeta(VehicleFindManyArgs findManyArgs)
    {
        var count = await _context.Vehicles.ApplyWhere(findManyArgs.Where).CountAsync();

        return new MetadataDto { Count = count };
    }

    /// <summary>
    /// Get one Vehicle
    /// </summary>
    public async Task<Vehicle> Vehicle(VehicleWhereUniqueInput uniqueId)
    {
        var vehicles = await this.Vehicles(
            new VehicleFindManyArgs { Where = new VehicleWhereInput { Id = uniqueId.Id } }
        );
        var vehicle = vehicles.FirstOrDefault();
        if (vehicle == null)
        {
            throw new NotFoundException();
        }

        return vehicle;
    }

    /// <summary>
    /// Update one Vehicle
    /// </summary>
    public async Task UpdateVehicle(VehicleWhereUniqueInput uniqueId, VehicleUpdateInput updateDto)
    {
        var vehicle = updateDto.ToModel(uniqueId);

        _context.Entry(vehicle).State = EntityState.Modified;

        try
        {
            await _context.SaveChangesAsync();
        }
        catch (DbUpdateConcurrencyException)
        {
            if (!_context.Vehicles.Any(e => e.Id == vehicle.Id))
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
    /// Get a Articles record for DETAILED DECLARATION VEHICLE
    /// </summary>
    public async Task<Article> GetArticles(VehicleWhereUniqueInput uniqueId)
    {
        var vehicle = await _context
            .Vehicles.Where(vehicle => vehicle.Id == uniqueId.Id)
            .Include(vehicle => vehicle.Articles)
            .FirstOrDefaultAsync();
        if (vehicle == null)
        {
            throw new NotFoundException();
        }
        return vehicle.Articles.ToDto();
    }
}
