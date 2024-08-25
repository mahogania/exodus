using Control.APIs;
using Control.APIs.Common;
using Control.APIs.Dtos;
using Control.APIs.Errors;
using Control.APIs.Extensions;
using Control.Infrastructure;
using Control.Infrastructure.Models;
using Microsoft.EntityFrameworkCore;

namespace Control.APIs;

public abstract class CarnetControlsServiceBase : ICarnetControlsService
{
    protected readonly ControlDbContext _context;

    public CarnetControlsServiceBase(ControlDbContext context)
    {
        _context = context;
    }

    /// <summary>
    /// Create one CarnetControl
    /// </summary>
    public async Task<CarnetControl> CreateCarnetControl(CarnetControlCreateInput createDto)
    {
        var carnetControl = new CarnetControlDbModel
        {
            AtaCarnetManagementNumber = createDto.AtaCarnetManagementNumber,
            AttachedFileId = createDto.AttachedFileId,
            AuthorizationDate = createDto.AuthorizationDate,
            CarnetTypeCode = createDto.CarnetTypeCode,
            CreatedAt = createDto.CreatedAt,
            DateAndTimeOfFinalModification = createDto.DateAndTimeOfFinalModification,
            DateAndTimeOfInitialRecord = createDto.DateAndTimeOfInitialRecord,
            DeletedOn = createDto.DeletedOn,
            FinalModifierId = createDto.FinalModifierId,
            GrantedDeadlineEndDate = createDto.GrantedDeadlineEndDate,
            InitialRecorderId = createDto.InitialRecorderId,
            ProcessingStatusCode = createDto.ProcessingStatusCode,
            UpdatedAt = createDto.UpdatedAt,
            VerificationResultContent = createDto.VerificationResultContent
        };

        if (createDto.Id != null)
        {
            carnetControl.Id = createDto.Id;
        }

        _context.CarnetControls.Add(carnetControl);
        await _context.SaveChangesAsync();

        var result = await _context.FindAsync<CarnetControlDbModel>(carnetControl.Id);

        if (result == null)
        {
            throw new NotFoundException();
        }

        return result.ToDto();
    }

    /// <summary>
    /// Delete one CarnetControl
    /// </summary>
    public async Task DeleteCarnetControl(CarnetControlWhereUniqueInput uniqueId)
    {
        var carnetControl = await _context.CarnetControls.FindAsync(uniqueId.Id);
        if (carnetControl == null)
        {
            throw new NotFoundException();
        }

        _context.CarnetControls.Remove(carnetControl);
        await _context.SaveChangesAsync();
    }

    /// <summary>
    /// Find many CarnetControls
    /// </summary>
    public async Task<List<CarnetControl>> CarnetControls(CarnetControlFindManyArgs findManyArgs)
    {
        var carnetControls = await _context
            .CarnetControls.ApplyWhere(findManyArgs.Where)
            .ApplySkip(findManyArgs.Skip)
            .ApplyTake(findManyArgs.Take)
            .ApplyOrderBy(findManyArgs.SortBy)
            .ToListAsync();
        return carnetControls.ConvertAll(carnetControl => carnetControl.ToDto());
    }

    /// <summary>
    /// Meta data about CarnetControl records
    /// </summary>
    public async Task<MetadataDto> CarnetControlsMeta(CarnetControlFindManyArgs findManyArgs)
    {
        var count = await _context.CarnetControls.ApplyWhere(findManyArgs.Where).CountAsync();

        return new MetadataDto { Count = count };
    }

    /// <summary>
    /// Get one CarnetControl
    /// </summary>
    public async Task<CarnetControl> CarnetControl(CarnetControlWhereUniqueInput uniqueId)
    {
        var carnetControls = await this.CarnetControls(
            new CarnetControlFindManyArgs
            {
                Where = new CarnetControlWhereInput { Id = uniqueId.Id }
            }
        );
        var carnetControl = carnetControls.FirstOrDefault();
        if (carnetControl == null)
        {
            throw new NotFoundException();
        }

        return carnetControl;
    }

    /// <summary>
    /// Update one CarnetControl
    /// </summary>
    public async Task UpdateCarnetControl(
        CarnetControlWhereUniqueInput uniqueId,
        CarnetControlUpdateInput updateDto
    )
    {
        var carnetControl = updateDto.ToModel(uniqueId);

        _context.Entry(carnetControl).State = EntityState.Modified;

        try
        {
            await _context.SaveChangesAsync();
        }
        catch (DbUpdateConcurrencyException)
        {
            if (!_context.CarnetControls.Any(e => e.Id == carnetControl.Id))
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
