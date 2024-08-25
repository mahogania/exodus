using Criteria.APIs;
using Criteria.APIs.Common;
using Criteria.APIs.Dtos;
using Criteria.APIs.Errors;
using Criteria.APIs.Extensions;
using Criteria.Infrastructure;
using Criteria.Infrastructure.Models;
using Microsoft.EntityFrameworkCore;

namespace Criteria.APIs;

public abstract class ServiceChangesServiceBase : IServiceChangesService
{
    protected readonly CriteriaDbContext _context;

    public ServiceChangesServiceBase(CriteriaDbContext context)
    {
        _context = context;
    }

    /// <summary>
    /// Create one Service Change
    /// </summary>
    public async Task<ServiceChange> CreateServiceChange(ServiceChangeCreateInput createDto)
    {
        var serviceChange = new ServiceChangeDbModel
        {
            CreatedAt = createDto.CreatedAt,
            DetailedDeclarationNumber = createDto.DetailedDeclarationNumber,
            InitialServiceCode = createDto.InitialServiceCode,
            ModificationDate = createDto.ModificationDate,
            ModificationNumber = createDto.ModificationNumber,
            ModificationResponsibleId = createDto.ModificationResponsibleId,
            NewServiceCode = createDto.NewServiceCode,
            ReasonForModification = createDto.ReasonForModification,
            ServiceChangeReasonCode = createDto.ServiceChangeReasonCode,
            UpdatedAt = createDto.UpdatedAt
        };

        if (createDto.Id != null)
        {
            serviceChange.Id = createDto.Id;
        }

        _context.ServiceChanges.Add(serviceChange);
        await _context.SaveChangesAsync();

        var result = await _context.FindAsync<ServiceChangeDbModel>(serviceChange.Id);

        if (result == null)
        {
            throw new NotFoundException();
        }

        return result.ToDto();
    }

    /// <summary>
    /// Delete one Service Change
    /// </summary>
    public async Task DeleteServiceChange(ServiceChangeWhereUniqueInput uniqueId)
    {
        var serviceChange = await _context.ServiceChanges.FindAsync(uniqueId.Id);
        if (serviceChange == null)
        {
            throw new NotFoundException();
        }

        _context.ServiceChanges.Remove(serviceChange);
        await _context.SaveChangesAsync();
    }

    /// <summary>
    /// Find many Service Changes
    /// </summary>
    public async Task<List<ServiceChange>> ServiceChanges(ServiceChangeFindManyArgs findManyArgs)
    {
        var serviceChanges = await _context
            .ServiceChanges.ApplyWhere(findManyArgs.Where)
            .ApplySkip(findManyArgs.Skip)
            .ApplyTake(findManyArgs.Take)
            .ApplyOrderBy(findManyArgs.SortBy)
            .ToListAsync();
        return serviceChanges.ConvertAll(serviceChange => serviceChange.ToDto());
    }

    /// <summary>
    /// Meta data about Service Change records
    /// </summary>
    public async Task<MetadataDto> ServiceChangesMeta(ServiceChangeFindManyArgs findManyArgs)
    {
        var count = await _context.ServiceChanges.ApplyWhere(findManyArgs.Where).CountAsync();

        return new MetadataDto { Count = count };
    }

    /// <summary>
    /// Get one Service Change
    /// </summary>
    public async Task<ServiceChange> ServiceChange(ServiceChangeWhereUniqueInput uniqueId)
    {
        var serviceChanges = await this.ServiceChanges(
            new ServiceChangeFindManyArgs
            {
                Where = new ServiceChangeWhereInput { Id = uniqueId.Id }
            }
        );
        var serviceChange = serviceChanges.FirstOrDefault();
        if (serviceChange == null)
        {
            throw new NotFoundException();
        }

        return serviceChange;
    }

    /// <summary>
    /// Update one Service Change
    /// </summary>
    public async Task UpdateServiceChange(
        ServiceChangeWhereUniqueInput uniqueId,
        ServiceChangeUpdateInput updateDto
    )
    {
        var serviceChange = updateDto.ToModel(uniqueId);

        _context.Entry(serviceChange).State = EntityState.Modified;

        try
        {
            await _context.SaveChangesAsync();
        }
        catch (DbUpdateConcurrencyException)
        {
            if (!_context.ServiceChanges.Any(e => e.Id == serviceChange.Id))
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
