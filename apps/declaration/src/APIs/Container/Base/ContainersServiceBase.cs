using Microsoft.EntityFrameworkCore;
using Statement.APIs;
using Statement.APIs.Common;
using Statement.APIs.Dtos;
using Statement.APIs.Errors;
using Statement.APIs.Extensions;
using Statement.Infrastructure;
using Statement.Infrastructure.Models;

namespace Statement.APIs;

public abstract class ContainersServiceBase : IContainersService
{
    protected readonly StatementDbContext _context;

    public ContainersServiceBase(StatementDbContext context)
    {
        _context = context;
    }

    /// <summary>
    /// Create one Container
    /// </summary>
    public async Task<Container> CreateContainer(ContainerCreateInput createDto)
    {
        var container = new ContainerDbModel
        {
            CntrNo = createDto.CntrNo,
            CntrSrno = createDto.CntrSrno,
            CntrStfnSttsCd = createDto.CntrStfnSttsCd,
            CntrTpCd = createDto.CntrTpCd,
            CreatedAt = createDto.CreatedAt,
            DelOn = createDto.DelOn,
            FrstRegstId = createDto.FrstRegstId,
            FrstRgsrDttm = createDto.FrstRgsrDttm,
            LastChgDttm = createDto.LastChgDttm,
            LastChprId = createDto.LastChprId,
            MdfyDgcnt = createDto.MdfyDgcnt,
            RefNo = createDto.RefNo,
            SealChpn1 = createDto.SealChpn1,
            SealChpn2 = createDto.SealChpn2,
            SealChpn3 = createDto.SealChpn3,
            SealChpnCd = createDto.SealChpnCd,
            SealNo1 = createDto.SealNo1,
            SealNo2 = createDto.SealNo2,
            SealNo3 = createDto.SealNo3,
            UpdatedAt = createDto.UpdatedAt
        };

        if (createDto.Id != null)
        {
            container.Id = createDto.Id;
        }

        _context.Containers.Add(container);
        await _context.SaveChangesAsync();

        var result = await _context.FindAsync<ContainerDbModel>(container.Id);

        if (result == null)
        {
            throw new NotFoundException();
        }

        return result.ToDto();
    }

    /// <summary>
    /// Delete one Container
    /// </summary>
    public async Task DeleteContainer(ContainerWhereUniqueInput uniqueId)
    {
        var container = await _context.Containers.FindAsync(uniqueId.Id);
        if (container == null)
        {
            throw new NotFoundException();
        }

        _context.Containers.Remove(container);
        await _context.SaveChangesAsync();
    }

    /// <summary>
    /// Find many Containers
    /// </summary>
    public async Task<List<Container>> Containers(ContainerFindManyArgs findManyArgs)
    {
        var containers = await _context
            .Containers.ApplyWhere(findManyArgs.Where)
            .ApplySkip(findManyArgs.Skip)
            .ApplyTake(findManyArgs.Take)
            .ApplyOrderBy(findManyArgs.SortBy)
            .ToListAsync();
        return containers.ConvertAll(container => container.ToDto());
    }

    /// <summary>
    /// Meta data about Container records
    /// </summary>
    public async Task<MetadataDto> ContainersMeta(ContainerFindManyArgs findManyArgs)
    {
        var count = await _context.Containers.ApplyWhere(findManyArgs.Where).CountAsync();

        return new MetadataDto { Count = count };
    }

    /// <summary>
    /// Get one Container
    /// </summary>
    public async Task<Container> Container(ContainerWhereUniqueInput uniqueId)
    {
        var containers = await this.Containers(
            new ContainerFindManyArgs { Where = new ContainerWhereInput { Id = uniqueId.Id } }
        );
        var container = containers.FirstOrDefault();
        if (container == null)
        {
            throw new NotFoundException();
        }

        return container;
    }

    /// <summary>
    /// Update one Container
    /// </summary>
    public async Task UpdateContainer(
        ContainerWhereUniqueInput uniqueId,
        ContainerUpdateInput updateDto
    )
    {
        var container = updateDto.ToModel(uniqueId);

        _context.Entry(container).State = EntityState.Modified;

        try
        {
            await _context.SaveChangesAsync();
        }
        catch (DbUpdateConcurrencyException)
        {
            if (!_context.Containers.Any(e => e.Id == container.Id))
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
