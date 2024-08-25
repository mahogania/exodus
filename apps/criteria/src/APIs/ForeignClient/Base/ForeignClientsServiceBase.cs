using Criteria.APIs;
using Criteria.APIs.Common;
using Criteria.APIs.Dtos;
using Criteria.APIs.Errors;
using Criteria.APIs.Extensions;
using Criteria.Infrastructure;
using Criteria.Infrastructure.Models;
using Microsoft.EntityFrameworkCore;

namespace Criteria.APIs;

public abstract class ForeignClientsServiceBase : IForeignClientsService
{
    protected readonly CriteriaDbContext _context;

    public ForeignClientsServiceBase(CriteriaDbContext context)
    {
        _context = context;
    }

    /// <summary>
    /// Create one Foreign Client
    /// </summary>
    public async Task<ForeignClient> CreateForeignClient(ForeignClientCreateInput createDto)
    {
        var foreignClient = new ForeignClientDbModel
        {
            AddressOfForeignOperator = createDto.AddressOfForeignOperator,
            CityCodeOfForeignOperator = createDto.CityCodeOfForeignOperator,
            CompanyNameOfForeignOperator = createDto.CompanyNameOfForeignOperator,
            CountryCodeOfForeignOperator = createDto.CountryCodeOfForeignOperator,
            CreatedAt = createDto.CreatedAt,
            EmailOfForeignOperator = createDto.EmailOfForeignOperator,
            PhoneNumberOfForeignOperator = createDto.PhoneNumberOfForeignOperator,
            RepresentativeNameOfForeignOperator = createDto.RepresentativeNameOfForeignOperator,
            UpdatedAt = createDto.UpdatedAt
        };

        if (createDto.Id != null)
        {
            foreignClient.Id = createDto.Id;
        }

        _context.ForeignClients.Add(foreignClient);
        await _context.SaveChangesAsync();

        var result = await _context.FindAsync<ForeignClientDbModel>(foreignClient.Id);

        if (result == null)
        {
            throw new NotFoundException();
        }

        return result.ToDto();
    }

    /// <summary>
    /// Delete one Foreign Client
    /// </summary>
    public async Task DeleteForeignClient(ForeignClientWhereUniqueInput uniqueId)
    {
        var foreignClient = await _context.ForeignClients.FindAsync(uniqueId.Id);
        if (foreignClient == null)
        {
            throw new NotFoundException();
        }

        _context.ForeignClients.Remove(foreignClient);
        await _context.SaveChangesAsync();
    }

    /// <summary>
    /// Find many Foreign Clients
    /// </summary>
    public async Task<List<ForeignClient>> ForeignClients(ForeignClientFindManyArgs findManyArgs)
    {
        var foreignClients = await _context
            .ForeignClients.ApplyWhere(findManyArgs.Where)
            .ApplySkip(findManyArgs.Skip)
            .ApplyTake(findManyArgs.Take)
            .ApplyOrderBy(findManyArgs.SortBy)
            .ToListAsync();
        return foreignClients.ConvertAll(foreignClient => foreignClient.ToDto());
    }

    /// <summary>
    /// Meta data about Foreign Client records
    /// </summary>
    public async Task<MetadataDto> ForeignClientsMeta(ForeignClientFindManyArgs findManyArgs)
    {
        var count = await _context.ForeignClients.ApplyWhere(findManyArgs.Where).CountAsync();

        return new MetadataDto { Count = count };
    }

    /// <summary>
    /// Get one Foreign Client
    /// </summary>
    public async Task<ForeignClient> ForeignClient(ForeignClientWhereUniqueInput uniqueId)
    {
        var foreignClients = await this.ForeignClients(
            new ForeignClientFindManyArgs
            {
                Where = new ForeignClientWhereInput { Id = uniqueId.Id }
            }
        );
        var foreignClient = foreignClients.FirstOrDefault();
        if (foreignClient == null)
        {
            throw new NotFoundException();
        }

        return foreignClient;
    }

    /// <summary>
    /// Update one Foreign Client
    /// </summary>
    public async Task UpdateForeignClient(
        ForeignClientWhereUniqueInput uniqueId,
        ForeignClientUpdateInput updateDto
    )
    {
        var foreignClient = updateDto.ToModel(uniqueId);

        _context.Entry(foreignClient).State = EntityState.Modified;

        try
        {
            await _context.SaveChangesAsync();
        }
        catch (DbUpdateConcurrencyException)
        {
            if (!_context.ForeignClients.Any(e => e.Id == foreignClient.Id))
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
