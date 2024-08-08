using Evaluation.APIs;
using Evaluation.APIs.Common;
using Evaluation.APIs.Dtos;
using Evaluation.APIs.Errors;
using Evaluation.APIs.Extensions;
using Evaluation.Infrastructure;
using Evaluation.Infrastructure.Models;
using Microsoft.EntityFrameworkCore;

namespace Evaluation.APIs;

public abstract class DetailsServiceBase : IDetailsService
{
    protected readonly EvaluationDbContext _context;

    public DetailsServiceBase(EvaluationDbContext context)
    {
        _context = context;
    }

    /// <summary>
    /// Create one Detail
    /// </summary>
    public async Task<Detail> CreateDetail(DetailCreateInput createDto)
    {
        var detail = new DetailDbModel
        {
            AdreseDeLExpDiteur = createDto.AdreseDeLExpDiteur,
            AdresseDeDestinataire = createDto.AdresseDeDestinataire,
            CodeDIdentificationDeDestinataire = createDto.CodeDIdentificationDeDestinataire,
            CodeDeDDouanement = createDto.CodeDeDDouanement,
            CodeDeLOpRateurExpress = createDto.CodeDeLOpRateurExpress,
            CodeDePaysDExpDition = createDto.CodeDePaysDExpDition,
            CodeDeStatutDeTraitement = createDto.CodeDeStatutDeTraitement,
            CodeDeTransporteur = createDto.CodeDeTransporteur,
            CodeDeTypeDeTraitementDeDDouanementExpress =
                createDto.CodeDeTypeDeTraitementDeDDouanementExpress,
            CodeDeTypeDesFins = createDto.CodeDeTypeDesFins,
            CodePostalDeDestinataire = createDto.CodePostalDeDestinataire,
            CodeSh = createDto.CodeSh,
            ContenuDeCodeBarre = createDto.ContenuDeCodeBarre,
            CreatedAt = createDto.CreatedAt,
            DDouanementOrdinaireOn = createDto.DDouanementOrdinaireOn,
            DDouanementSimplifiOn = createDto.DDouanementSimplifiOn,
            DNominationCommerciale = createDto.DNominationCommerciale,
            DateEtHeureDeModificationFinale = createDto.DateEtHeureDeModificationFinale,
            DateEtHeureDePremierEnregistrement = createDto.DateEtHeureDePremierEnregistrement,
            DateEtHeureDeTransmissionDeCodeBarre = createDto.DateEtHeureDeTransmissionDeCodeBarre,
            IdDuModificateurFinal = createDto.IdDuModificateurFinal,
            IdDuPremierEnregistrant = createDto.IdDuPremierEnregistrant,
            MontantDeLaTaxeDouaniReSimple = createDto.MontantDeLaTaxeDouaniReSimple,
            NDeCertificationDeLEntrepriseDeCommercialLectronique =
                createDto.NDeCertificationDeLEntrepriseDeCommercialLectronique,
            NDeDemandeDeDDouanementExpress = createDto.NDeDemandeDeDDouanementExpress,
            NDeHouseBl = createDto.NDeHouseBl,
            NDeMasterBl = createDto.NDeMasterBl,
            NDeSQuence = createDto.NDeSQuence,
            NDeTlPhoneDeDestinataire = createDto.NDeTlPhoneDeDestinataire,
            NDeTlPhoneDeLExpDiteur = createDto.NDeTlPhoneDeLExpDiteur,
            NomDeDestinataire = createDto.NomDeDestinataire,
            NomDeLExpDiteur = createDto.NomDeLExpDiteur,
            NoteDeDouane = createDto.NoteDeDouane,
            Poids = createDto.Poids,
            Quantit = createDto.Quantit,
            QuantitDuColis = createDto.QuantitDuColis,
            SiteInternetDeECommercial = createDto.SiteInternetDeECommercial,
            Standards = createDto.Standards,
            SuppressionOn = createDto.SuppressionOn,
            TypeDOpRation = createDto.TypeDOpRation,
            UpdatedAt = createDto.UpdatedAt,
            ValeurDeMarchandise = createDto.ValeurDeMarchandise
        };

        if (createDto.Id != null)
        {
            detail.Id = createDto.Id;
        }

        _context.Details.Add(detail);
        await _context.SaveChangesAsync();

        var result = await _context.FindAsync<DetailDbModel>(detail.Id);

        if (result == null)
        {
            throw new NotFoundException();
        }

        return result.ToDto();
    }

    /// <summary>
    /// Delete one Detail
    /// </summary>
    public async Task DeleteDetail(DetailWhereUniqueInput uniqueId)
    {
        var detail = await _context.Details.FindAsync(uniqueId.Id);
        if (detail == null)
        {
            throw new NotFoundException();
        }

        _context.Details.Remove(detail);
        await _context.SaveChangesAsync();
    }

    /// <summary>
    /// Find many Details
    /// </summary>
    public async Task<List<Detail>> Details(DetailFindManyArgs findManyArgs)
    {
        var details = await _context
            .Details.ApplyWhere(findManyArgs.Where)
            .ApplySkip(findManyArgs.Skip)
            .ApplyTake(findManyArgs.Take)
            .ApplyOrderBy(findManyArgs.SortBy)
            .ToListAsync();
        return details.ConvertAll(detail => detail.ToDto());
    }

    /// <summary>
    /// Meta data about Detail records
    /// </summary>
    public async Task<MetadataDto> DetailsMeta(DetailFindManyArgs findManyArgs)
    {
        var count = await _context.Details.ApplyWhere(findManyArgs.Where).CountAsync();

        return new MetadataDto { Count = count };
    }

    /// <summary>
    /// Get one Detail
    /// </summary>
    public async Task<Detail> Detail(DetailWhereUniqueInput uniqueId)
    {
        var details = await this.Details(
            new DetailFindManyArgs { Where = new DetailWhereInput { Id = uniqueId.Id } }
        );
        var detail = details.FirstOrDefault();
        if (detail == null)
        {
            throw new NotFoundException();
        }

        return detail;
    }

    /// <summary>
    /// Update one Detail
    /// </summary>
    public async Task UpdateDetail(DetailWhereUniqueInput uniqueId, DetailUpdateInput updateDto)
    {
        var detail = updateDto.ToModel(uniqueId);

        _context.Entry(detail).State = EntityState.Modified;

        try
        {
            await _context.SaveChangesAsync();
        }
        catch (DbUpdateConcurrencyException)
        {
            if (!_context.Details.Any(e => e.Id == detail.Id))
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
