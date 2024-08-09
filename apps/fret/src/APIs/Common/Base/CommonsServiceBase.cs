using Fret.APIs;
using Fret.APIs.Common;
using Fret.APIs.Dtos;
using Fret.APIs.Errors;
using Fret.APIs.Extensions;
using Fret.Infrastructure;
using Fret.Infrastructure.Models;
using Microsoft.EntityFrameworkCore;

namespace Fret.APIs;

public abstract class CommonsServiceBase : ICommonsService
{
    protected readonly FretDbContext _context;

    public CommonsServiceBase(FretDbContext context)
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
            AutoLiquidationOn = createDto.AutoLiquidationOn,
            CargaisonConteneurisEOn = createDto.CargaisonConteneurisEOn,
            CodeDAgnceDeBanqueDePaiement = createDto.CodeDAgnceDeBanqueDePaiement,
            CodeDEntrepTDeLaMarchandiseSousDouane = createDto.CodeDEntrepTDeLaMarchandiseSousDouane,
            CodeDeBanqueDePaiement = createDto.CodeDeBanqueDePaiement,
            CodeDeBureauDeDClaration = createDto.CodeDeBureauDeDClaration,
            CodeDeConditionDeTransaction_1 = createDto.CodeDeConditionDeTransaction_1,
            CodeDeConditionDeTransaction_2 = createDto.CodeDeConditionDeTransaction_2,
            CodeDeFormulaireDeLaDClaration = createDto.CodeDeFormulaireDeLaDClaration,
            CodeDeLEntrepTPrCDentDeLaMarchandiseSousDouane =
                createDto.CodeDeLEntrepTPrCDentDeLaMarchandiseSousDouane,
            CodeDeLaConditionDeLivraison = createDto.CodeDeLaConditionDeLivraison,
            CodeDeLieuDeChargement = createDto.CodeDeLieuDeChargement,
            CodeDeLieuDeDChargement = createDto.CodeDeLieuDeDChargement,
            CodeDeLocalisationDeStockage = createDto.CodeDeLocalisationDeStockage,
            CodeDeModeDePaiement = createDto.CodeDeModeDePaiement,
            CodeDeMotifDeLaModification = createDto.CodeDeMotifDeLaModification,
            CodeDeNationalitDuMoyenDeTransport = createDto.CodeDeNationalitDuMoyenDeTransport,
            CodeDePaysDExpDition = createDto.CodeDePaysDExpDition,
            CodeDePaysDeTransaction = createDto.CodeDePaysDeTransaction,
            CodeDePaysDestinataire = createDto.CodeDePaysDestinataire,
            CodeDePaysExportateur = createDto.CodeDePaysExportateur,
            CodeDePlanDeDDouanement = createDto.CodeDePlanDeDDouanement,
            CodeDeRGionDestinataire = createDto.CodeDeRGionDestinataire,
            CodeDeService = createDto.CodeDeService,
            CodeDeStatutDeDomiciliation = createDto.CodeDeStatutDeDomiciliation,
            CodeDeTypeDeDClaration = createDto.CodeDeTypeDeDClaration,
            CodeDeTypeDeDDouanementPartiel = createDto.CodeDeTypeDeDDouanementPartiel,
            CodeDeTypeDeNdIdentificationDeLExportateur =
                createDto.CodeDeTypeDeNdIdentificationDeLExportateur,
            CodeDeTypeDuMoyenDeTransport = createDto.CodeDeTypeDuMoyenDeTransport,
            CodeDeTypeDuNdIdentificationDeLImportateur =
                createDto.CodeDeTypeDuNdIdentificationDeLImportateur,
            CodeDuBureauDEntrEEtDeSortie = createDto.CodeDuBureauDEntrEEtDeSortie,
            CodeDuDClarant = createDto.CodeDuDClarant,
            CodeDuLieuDeLivraison = createDto.CodeDuLieuDeLivraison,
            CodeEpc = createDto.CodeEpc,
            CreatedAt = createDto.CreatedAt,
            Crn = createDto.Crn,
            DClarationDeLaValeurSaisieOn = createDto.DClarationDeLaValeurSaisieOn,
            DateDArrivE = createDto.DateDArrivE,
            DateDMissionDeLaFacture = createDto.DateDMissionDeLaFacture,
            DateDeConnaissement = createDto.DateDeConnaissement,
            DateDeDChargement = createDto.DateDeDChargement,
            DateDeDemande = createDto.DateDeDemande,
            DateDeDomiciliation = createDto.DateDeDomiciliation,
            DateEtHeureDeModificationFinale = createDto.DateEtHeureDeModificationFinale,
            DateEtHeureDePremierEnregistrement = createDto.DateEtHeureDePremierEnregistrement,
            DateInitialeDeLaDClaration = createDto.DateInitialeDeLaDClaration,
            EnlVementEnVHiculeOn = createDto.EnlVementEnVHiculeOn,
            FinalOn = createDto.FinalOn,
            FrQuenceDeRectification = createDto.FrQuenceDeRectification,
            IdDuModificateurFinal = createDto.IdDuModificateurFinal,
            IdDuPremierEnregistrant = createDto.IdDuPremierEnregistrant,
            ModeFinancement = createDto.ModeFinancement,
            MotifDeRectification = createDto.MotifDeRectification,
            NDIdentificationDeLExportateur = createDto.NDIdentificationDeLExportateur,
            NDIdentificationDeLImportateur = createDto.NDIdentificationDeLImportateur,
            NDIdentificationDeRedevable = createDto.NDIdentificationDeRedevable,
            NDIdentificationDuMoyenDeTransport = createDto.NDIdentificationDuMoyenDeTransport,
            NDeBl = createDto.NDeBl,
            NDeCompteDePaiement = createDto.NDeCompteDePaiement,
            NDeDemandeDeRGime = createDto.NDeDemandeDeRGime,
            NDeFacture = createDto.NDeFacture,
            NDeRfRence = createDto.NDeRfRence,
            NomDuNavire = createDto.NomDuNavire,
            NombreDArticles = createDto.NombreDArticles,
            NombreDeConteneurs = createDto.NombreDeConteneurs,
            NombreTotalDeColis = createDto.NombreTotalDeColis,
            NumRoDeRfRenceDeVoyageur = createDto.NumRoDeRfRenceDeVoyageur,
            NumRoDeRegistreDeCommerceDeLExportateur =
                createDto.NumRoDeRegistreDeCommerceDeLExportateur,
            NumRoDeRegistreDeCommerceDeLImportateur =
                createDto.NumRoDeRegistreDeCommerceDeLImportateur,
            NumRoDeRegistreDeCommerceDuRedevable = createDto.NumRoDeRegistreDeCommerceDuRedevable,
            NumeroDeLaDClarationEnDTail = createDto.NumeroDeLaDClarationEnDTail,
            PRiodeDChAnceDeLApurementDeLaGestionEtSuivi =
                createDto.PRiodeDChAnceDeLApurementDeLaGestionEtSuivi,
            PoidsBrutTotal = createDto.PoidsBrutTotal,
            PoidsNetTotal = createDto.PoidsNetTotal,
            SuppressionOn = createDto.SuppressionOn,
            TempsUtilisationDuSystMeEnSeconde = createDto.TempsUtilisationDuSystMeEnSeconde,
            TexteDeTraitementDeVoyageur = createDto.TexteDeTraitementDeVoyageur,
            TexteLibreRServAuDClarant = createDto.TexteLibreRServAuDClarant,
            TypeDOpRation = createDto.TypeDOpRation,
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
