using Fret.APIs;
using Fret.APIs.Common;
using Fret.APIs.Dtos;
using Fret.APIs.Errors;
using Fret.APIs.Extensions;
using Fret.Infrastructure;
using Fret.Infrastructure.Models;
using Microsoft.EntityFrameworkCore;

namespace Fret.APIs;

public abstract class ContainersServiceBase : IContainersService
{
    protected readonly FretDbContext _context;

    public ContainersServiceBase(FretDbContext context)
    {
        _context = context;
    }

    /// <summary>
    /// Create one Conteneur
    /// </summary>
    public async Task<Container> CreateContainer(ContainerCreateInput createDto)
    {
        var container = new ContainerDbModel
        {
            CodeDeLUnitDeColis = createDto.CodeDeLUnitDeColis,
            CodeDeTypeDeConteneur = createDto.CodeDeTypeDeConteneur,
            CreatedAt = createDto.CreatedAt,
            DateEtHeureDeModificationFinale = createDto.DateEtHeureDeModificationFinale,
            DateEtHeureDePremierEnregistrement = createDto.DateEtHeureDePremierEnregistrement,
            IdDuModificateurFinal = createDto.IdDuModificateurFinal,
            IdDuPremierEnregistrant = createDto.IdDuPremierEnregistrant,
            NDeConteneur = createDto.NDeConteneur,
            NDeSQuenceDeBl = createDto.NDeSQuenceDeBl,
            NDeSQuenceDuConteneur = createDto.NDeSQuenceDuConteneur,
            NDeScell_1 = createDto.NDeScell_1,
            NDeScell_2 = createDto.NDeScell_2,
            NDeScell_3 = createDto.NDeScell_3,
            NombreDeColis = createDto.NombreDeColis,
            NumRoDeGestionDeLEnregistrementDeLaDClarationDeFret =
                createDto.NumRoDeGestionDeLEnregistrementDeLaDClarationDeFret,
            PoidsBrut = createDto.PoidsBrut,
            ResponsableDeScell_1 = createDto.ResponsableDeScell_1,
            ResponsableDeScell_2 = createDto.ResponsableDeScell_2,
            ResponsableDeScell_3 = createDto.ResponsableDeScell_3,
            SuppressionOn = createDto.SuppressionOn,
            TareDeConteneurSVide = createDto.TareDeConteneurSVide,
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
    /// Delete one Conteneur
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
    /// Meta data about Conteneur records
    /// </summary>
    public async Task<MetadataDto> ContainersMeta(ContainerFindManyArgs findManyArgs)
    {
        var count = await _context.Containers.ApplyWhere(findManyArgs.Where).CountAsync();

        return new MetadataDto { Count = count };
    }

    /// <summary>
    /// Get one Conteneur
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
    /// Update one Conteneur
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
