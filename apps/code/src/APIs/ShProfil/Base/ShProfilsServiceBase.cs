using Code.APIs;
using Code.APIs.Common;
using Code.APIs.Dtos;
using Code.APIs.Errors;
using Code.APIs.Extensions;
using Code.Infrastructure;
using Code.Infrastructure.Models;
using Microsoft.EntityFrameworkCore;

namespace Code.APIs;

public abstract class ShProfilsServiceBase : IShProfilsService
{
    protected readonly CodeDbContext _context;

    public ShProfilsServiceBase(CodeDbContext context)
    {
        _context = context;
    }

    /// <summary>
    /// Create one ShProfil
    /// </summary>
    public async Task<ShProfil> CreateShProfil(ShProfilCreateInput createDto)
    {
        var shProfil = new ShProfilDbModel
        {
            CodeClassificationInferieureSh = createDto.CodeClassificationInferieureSh,
            CodeClassificationSuperieureSh = createDto.CodeClassificationSuperieureSh,
            CodeSh = createDto.CodeSh,
            CreatedAt = createDto.CreatedAt,
            DateHeureModificationFinale = createDto.DateHeureModificationFinale,
            DateHeurePremierEnregistrement = createDto.DateHeurePremierEnregistrement,
            ModificateurFinalId = createDto.ModificateurFinalId,
            PremierEnregistrantId = createDto.PremierEnregistrantId,
            SuppressionOn = createDto.SuppressionOn,
            UpdatedAt = createDto.UpdatedAt,
            UtiliseOn = createDto.UtiliseOn
        };

        if (createDto.Id != null)
        {
            shProfil.Id = createDto.Id;
        }

        _context.ShProfils.Add(shProfil);
        await _context.SaveChangesAsync();

        var result = await _context.FindAsync<ShProfilDbModel>(shProfil.Id);

        if (result == null)
        {
            throw new NotFoundException();
        }

        return result.ToDto();
    }

    /// <summary>
    /// Delete one ShProfil
    /// </summary>
    public async Task DeleteShProfil(ShProfilWhereUniqueInput uniqueId)
    {
        var shProfil = await _context.ShProfils.FindAsync(uniqueId.Id);
        if (shProfil == null)
        {
            throw new NotFoundException();
        }

        _context.ShProfils.Remove(shProfil);
        await _context.SaveChangesAsync();
    }

    /// <summary>
    /// Find many ShProfils
    /// </summary>
    public async Task<List<ShProfil>> ShProfils(ShProfilFindManyArgs findManyArgs)
    {
        var shProfils = await _context
            .ShProfils.ApplyWhere(findManyArgs.Where)
            .ApplySkip(findManyArgs.Skip)
            .ApplyTake(findManyArgs.Take)
            .ApplyOrderBy(findManyArgs.SortBy)
            .ToListAsync();
        return shProfils.ConvertAll(shProfil => shProfil.ToDto());
    }

    /// <summary>
    /// Meta data about ShProfil records
    /// </summary>
    public async Task<MetadataDto> ShProfilsMeta(ShProfilFindManyArgs findManyArgs)
    {
        var count = await _context.ShProfils.ApplyWhere(findManyArgs.Where).CountAsync();

        return new MetadataDto { Count = count };
    }

    /// <summary>
    /// Get one ShProfil
    /// </summary>
    public async Task<ShProfil> ShProfil(ShProfilWhereUniqueInput uniqueId)
    {
        var shProfils = await this.ShProfils(
            new ShProfilFindManyArgs { Where = new ShProfilWhereInput { Id = uniqueId.Id } }
        );
        var shProfil = shProfils.FirstOrDefault();
        if (shProfil == null)
        {
            throw new NotFoundException();
        }

        return shProfil;
    }

    /// <summary>
    /// Update one ShProfil
    /// </summary>
    public async Task UpdateShProfil(
        ShProfilWhereUniqueInput uniqueId,
        ShProfilUpdateInput updateDto
    )
    {
        var shProfil = updateDto.ToModel(uniqueId);

        _context.Entry(shProfil).State = EntityState.Modified;

        try
        {
            await _context.SaveChangesAsync();
        }
        catch (DbUpdateConcurrencyException)
        {
            if (!_context.ShProfils.Any(e => e.Id == shProfil.Id))
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
