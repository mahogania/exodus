using Evaluation.APIs;
using Evaluation.APIs.Common;
using Evaluation.APIs.Dtos;
using Evaluation.APIs.Errors;
using Evaluation.APIs.Extensions;
using Evaluation.Infrastructure;
using Evaluation.Infrastructure.Models;
using Microsoft.EntityFrameworkCore;

namespace Evaluation.APIs;

public abstract class ExpressesServiceBase : IExpressesService
{
    protected readonly EvaluationDbContext _context;

    public ExpressesServiceBase(EvaluationDbContext context)
    {
        _context = context;
    }

    /// <summary>
    /// Create one Express
    /// </summary>
    public async Task<Express> CreateExpress(ExpressCreateInput createDto)
    {
        var express = new ExpressDbModel
        {
            CodeDeBureauDeDouane = createDto.CodeDeBureauDeDouane,
            CodeDeLOpRateurExpress = createDto.CodeDeLOpRateurExpress,
            CodeDePaysDeChargement = createDto.CodeDePaysDeChargement,
            CodeDeStatutDeTraitement = createDto.CodeDeStatutDeTraitement,
            CodeDeTypeDeTransmission = createDto.CodeDeTypeDeTransmission,
            CreatedAt = createDto.CreatedAt,
            DateDArrivE = createDto.DateDArrivE,
            DateDeDemande = createDto.DateDeDemande,
            DateEtHeureDeModificationFinale = createDto.DateEtHeureDeModificationFinale,
            DateEtHeureDePremierEnregistrement = createDto.DateEtHeureDePremierEnregistrement,
            IdDuFichierJoint = createDto.IdDuFichierJoint,
            IdDuModificateurFinal = createDto.IdDuModificateurFinal,
            IdDuPremierEnregistrant = createDto.IdDuPremierEnregistrant,
            NDeDemandeDeDDouanementExpress = createDto.NDeDemandeDeDDouanementExpress,
            NDeMasterBl = createDto.NDeMasterBl,
            NomDeLOpRateurExpress = createDto.NomDeLOpRateurExpress,
            NomDuNavire = createDto.NomDuNavire,
            SuppressionOn = createDto.SuppressionOn,
            UpdatedAt = createDto.UpdatedAt
        };

        if (createDto.Id != null)
        {
            express.Id = createDto.Id;
        }

        _context.Expresses.Add(express);
        await _context.SaveChangesAsync();

        var result = await _context.FindAsync<ExpressDbModel>(express.Id);

        if (result == null)
        {
            throw new NotFoundException();
        }

        return result.ToDto();
    }

    /// <summary>
    /// Delete one Express
    /// </summary>
    public async Task DeleteExpress(ExpressWhereUniqueInput uniqueId)
    {
        var express = await _context.Expresses.FindAsync(uniqueId.Id);
        if (express == null)
        {
            throw new NotFoundException();
        }

        _context.Expresses.Remove(express);
        await _context.SaveChangesAsync();
    }

    /// <summary>
    /// Find many Expresses
    /// </summary>
    public async Task<List<Express>> Expresses(ExpressFindManyArgs findManyArgs)
    {
        var expresses = await _context
            .Expresses.ApplyWhere(findManyArgs.Where)
            .ApplySkip(findManyArgs.Skip)
            .ApplyTake(findManyArgs.Take)
            .ApplyOrderBy(findManyArgs.SortBy)
            .ToListAsync();
        return expresses.ConvertAll(express => express.ToDto());
    }

    /// <summary>
    /// Meta data about Express records
    /// </summary>
    public async Task<MetadataDto> ExpressesMeta(ExpressFindManyArgs findManyArgs)
    {
        var count = await _context.Expresses.ApplyWhere(findManyArgs.Where).CountAsync();

        return new MetadataDto { Count = count };
    }

    /// <summary>
    /// Get one Express
    /// </summary>
    public async Task<Express> Express(ExpressWhereUniqueInput uniqueId)
    {
        var expresses = await this.Expresses(
            new ExpressFindManyArgs { Where = new ExpressWhereInput { Id = uniqueId.Id } }
        );
        var express = expresses.FirstOrDefault();
        if (express == null)
        {
            throw new NotFoundException();
        }

        return express;
    }

    /// <summary>
    /// Update one Express
    /// </summary>
    public async Task UpdateExpress(ExpressWhereUniqueInput uniqueId, ExpressUpdateInput updateDto)
    {
        var express = updateDto.ToModel(uniqueId);

        _context.Entry(express).State = EntityState.Modified;

        try
        {
            await _context.SaveChangesAsync();
        }
        catch (DbUpdateConcurrencyException)
        {
            if (!_context.Expresses.Any(e => e.Id == express.Id))
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
