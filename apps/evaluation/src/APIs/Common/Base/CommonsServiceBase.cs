using Evaluation.APIs;
using Evaluation.APIs.Common;
using Evaluation.APIs.Dtos;
using Evaluation.APIs.Errors;
using Evaluation.APIs.Extensions;
using Evaluation.Infrastructure;
using Evaluation.Infrastructure.Models;
using Microsoft.EntityFrameworkCore;

namespace Evaluation.APIs;

public abstract class CommonsServiceBase : ICommonsService
{
    protected readonly EvaluationDbContext _context;

    public CommonsServiceBase(EvaluationDbContext context)
    {
        _context = context;
    }

    /// <summary>
    /// Create one Common
    /// </summary>
    public async Task<Common> CreateCommon(CommonCreateInput createDto)
    {
        var common = new CommonDbModel
        {
            CodeDeDeviseDAssurance = createDto.CodeDeDeviseDAssurance,
            CodeDeDeviseDeLaDDuction = createDto.CodeDeDeviseDeLaDDuction,
            CodeDeDeviseDeLaFacture = createDto.CodeDeDeviseDeLaFacture,
            CodeDeDeviseDesAutresCoTs = createDto.CodeDeDeviseDesAutresCoTs,
            CodeDeDeviseDuFret = createDto.CodeDeDeviseDuFret,
            CreatedAt = createDto.CreatedAt,
            DateEtHeureDeModificationFinale = createDto.DateEtHeureDeModificationFinale,
            DateEtHeureDePremierEnregistrement = createDto.DateEtHeureDePremierEnregistrement,
            FrQuenceDeRectification = createDto.FrQuenceDeRectification,
            IdDuModificateurFinal = createDto.IdDuModificateurFinal,
            IdDuPremierEnregistrant = createDto.IdDuPremierEnregistrant,
            MontantDAssurance = createDto.MontantDAssurance,
            MontantDDuit = createDto.MontantDDuit,
            MontantDeFacture = createDto.MontantDeFacture,
            MontantDesAutresCoTs = createDto.MontantDesAutresCoTs,
            MontantDesAutresCoTsDeNcy = createDto.MontantDesAutresCoTsDeNcy,
            MontantDuFret = createDto.MontantDuFret,
            MontantNcyDDuit = createDto.MontantNcyDDuit,
            MontantNcyDeFacture = createDto.MontantNcyDeFacture,
            MontantNcyDuFret = createDto.MontantNcyDuFret,
            MontantNcyTotalDeLValuationDeValeur = createDto.MontantNcyTotalDeLValuationDeValeur,
            MontantNcyTotalDeLaBaseTaxable = createDto.MontantNcyTotalDeLaBaseTaxable,
            MontantNycDeLAssurance = createDto.MontantNycDeLAssurance,
            MontantUsdDeFacture = createDto.MontantUsdDeFacture,
            MontantUsdTotalDeLValuationDeValeur = createDto.MontantUsdTotalDeLValuationDeValeur,
            MontantUsdTotalDeLaBaseTaxable = createDto.MontantUsdTotalDeLaBaseTaxable,
            NDeRfRence = createDto.NDeRfRence,
            SuppressionOn = createDto.SuppressionOn,
            TauxDeChangeDAssurance = createDto.TauxDeChangeDAssurance,
            TauxDeChangeDeLaDDuction = createDto.TauxDeChangeDeLaDDuction,
            TauxDeChangeDeLaFacture = createDto.TauxDeChangeDeLaFacture,
            TauxDeChangeDesAutresCoTs = createDto.TauxDeChangeDesAutresCoTs,
            TauxDeChangeDuFret = createDto.TauxDeChangeDuFret,
            TauxDeRemise = createDto.TauxDeRemise,
            UpdatedAt = createDto.UpdatedAt
        };

        if (createDto.Id != null)
        {
            common.Id = createDto.Id;
        }

        _context.Commons.Add(common);
        await _context.SaveChangesAsync();

        var result = await _context.FindAsync<CommonDbModel>(common.Id);

        if (result == null)
        {
            throw new NotFoundException();
        }

        return result.ToDto();
    }

    /// <summary>
    /// Delete one Common
    /// </summary>
    public async Task DeleteCommon(CommonWhereUniqueInput uniqueId)
    {
        var common = await _context.Commons.FindAsync(uniqueId.Id);
        if (common == null)
        {
            throw new NotFoundException();
        }

        _context.Commons.Remove(common);
        await _context.SaveChangesAsync();
    }

    /// <summary>
    /// Find many Commons
    /// </summary>
    public async Task<List<Common>> Commons(CommonFindManyArgs findManyArgs)
    {
        var commons = await _context
            .Commons.ApplyWhere(findManyArgs.Where)
            .ApplySkip(findManyArgs.Skip)
            .ApplyTake(findManyArgs.Take)
            .ApplyOrderBy(findManyArgs.SortBy)
            .ToListAsync();
        return commons.ConvertAll(common => common.ToDto());
    }

    /// <summary>
    /// Meta data about Common records
    /// </summary>
    public async Task<MetadataDto> CommonsMeta(CommonFindManyArgs findManyArgs)
    {
        var count = await _context.Commons.ApplyWhere(findManyArgs.Where).CountAsync();

        return new MetadataDto { Count = count };
    }

    /// <summary>
    /// Get one Common
    /// </summary>
    public async Task<Common> Common(CommonWhereUniqueInput uniqueId)
    {
        var commons = await this.Commons(
            new CommonFindManyArgs { Where = new CommonWhereInput { Id = uniqueId.Id } }
        );
        var common = commons.FirstOrDefault();
        if (common == null)
        {
            throw new NotFoundException();
        }

        return common;
    }

    /// <summary>
    /// Update one Common
    /// </summary>
    public async Task UpdateCommon(CommonWhereUniqueInput uniqueId, CommonUpdateInput updateDto)
    {
        var common = updateDto.ToModel(uniqueId);

        _context.Entry(common).State = EntityState.Modified;

        try
        {
            await _context.SaveChangesAsync();
        }
        catch (DbUpdateConcurrencyException)
        {
            if (!_context.Commons.Any(e => e.Id == common.Id))
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
