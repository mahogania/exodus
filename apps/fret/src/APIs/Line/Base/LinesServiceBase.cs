using Fret.APIs;
using Fret.APIs.Common;
using Fret.APIs.Dtos;
using Fret.APIs.Errors;
using Fret.APIs.Extensions;
using Fret.Infrastructure;
using Fret.Infrastructure.Models;
using Microsoft.EntityFrameworkCore;

namespace Fret.APIs;

public abstract class LinesServiceBase : ILinesService
{
    protected readonly FretDbContext _context;

    public LinesServiceBase(FretDbContext context)
    {
        _context = context;
    }

    /// <summary>
    /// Create one Ligne
    /// </summary>
    public async Task<Line> CreateLine(LineCreateInput createDto)
    {
        var line = new LineDbModel
        {
            AdresseAffrTeurSlotteur = createDto.AdresseAffrTeurSlotteur,
            AdresseDeLExpDiteur = createDto.AdresseDeLExpDiteur,
            AdresseDeLExportateur = createDto.AdresseDeLExportateur,
            AdresseDeLaPartieNotifier = createDto.AdresseDeLaPartieNotifier,
            AdresseDuDestinataire = createDto.AdresseDuDestinataire,
            AffrTeurDEspaceSlot = createDto.AffrTeurDEspaceSlot,
            ArticleMontantCodeDeDevise = createDto.ArticleMontantCodeDeDevise,
            CabotageOn = createDto.CabotageOn,
            CodeDeCatGorieDeBl = createDto.CodeDeCatGorieDeBl,
            CodeDeCatGorieDeRectificationDeBl = createDto.CodeDeCatGorieDeRectificationDeBl,
            CodeDeClasseUndg = createDto.CodeDeClasseUndg,
            CodeDeGroupeur = createDto.CodeDeGroupeur,
            CodeDeLUnitDeColis = createDto.CodeDeLUnitDeColis,
            CodeDeLieuDeChargement = createDto.CodeDeLieuDeChargement,
            CodeDeLieuDeDChargement = createDto.CodeDeLieuDeDChargement,
            CodeDeRGionDeTransbordement = createDto.CodeDeRGionDeTransbordement,
            CodeDeStevedoremanutentionnaire = createDto.CodeDeStevedoremanutentionnaire,
            CodeDeTypeDHydrocarbure = createDto.CodeDeTypeDHydrocarbure,
            CodeDeTypeDeBl = createDto.CodeDeTypeDeBl,
            CodeDeZoneSousDouane = createDto.CodeDeZoneSousDouane,
            CodeSh = createDto.CodeSh,
            CreatedAt = createDto.CreatedAt,
            Crn = createDto.Crn,
            CrnPrCDent = createDto.CrnPrCDent,
            DChargementOn = createDto.DChargementOn,
            DateEmissionBl = createDto.DateEmissionBl,
            DateEtHeureDeModificationFinale = createDto.DateEtHeureDeModificationFinale,
            DateEtHeureDePremierEnregistrement = createDto.DateEtHeureDePremierEnregistrement,
            EMailDeDestinataire = createDto.EMailDeDestinataire,
            EmailDeLExpDiteur = createDto.EmailDeLExpDiteur,
            EmailDeLExportateur = createDto.EmailDeLExportateur,
            EmailDeLaPartieNotifier = createDto.EmailDeLaPartieNotifier,
            Hsn = createDto.Hsn,
            IdDuModificateurFinal = createDto.IdDuModificateurFinal,
            IdDuPremierEnregistrant = createDto.IdDuPremierEnregistrant,
            IdentifiantUndg = createDto.IdentifiantUndg,
            IndFretPrPayD = createDto.IndFretPrPayD,
            InfoSupplMentaire = createDto.InfoSupplMentaire,
            MarqueDeColis = createDto.MarqueDeColis,
            ModeDeLivraison = createDto.ModeDeLivraison,
            Msn = createDto.Msn,
            NDeBl = createDto.NDeBl,
            NDeHouseBl = createDto.NDeHouseBl,
            NDeSQuenceDeBl = createDto.NDeSQuenceDeBl,
            NDeTlPhoneDeDestinataire = createDto.NDeTlPhoneDeDestinataire,
            NatureDeCargaison = createDto.NatureDeCargaison,
            NatureDeMarchandise = createDto.NatureDeMarchandise,
            NifDeDStinataire = createDto.NifDeDStinataire,
            NifDeLExportateur = createDto.NifDeLExportateur,
            NinDExportateur = createDto.NinDExportateur,
            NinDeDStinataire = createDto.NinDeDStinataire,
            NomDeDestinataire = createDto.NomDeDestinataire,
            NomDeLAffrTeurSlotteur = createDto.NomDeLAffrTeurSlotteur,
            NomDeLArticle = createDto.NomDeLArticle,
            NomDeLExpDiteur = createDto.NomDeLExpDiteur,
            NomDeLExportateur = createDto.NomDeLExportateur,
            NomDeLaPartieNotifier = createDto.NomDeLaPartieNotifier,
            NombreDeColis = createDto.NombreDeColis,
            NombreDeConteneurs = createDto.NombreDeConteneurs,
            NombreDeVHicules = createDto.NombreDeVHicules,
            NombreTotalDeSousBl = createDto.NombreTotalDeSousBl,
            NumRoDeGestionDeLEnregistrementDeLaDClarationDeFret =
                createDto.NumRoDeGestionDeLEnregistrementDeLaDClarationDeFret,
            NumeroCas = createDto.NumeroCas,
            PoidsBrut = createDto.PoidsBrut,
            PoidsNet = createDto.PoidsNet,
            SuppressionOn = createDto.SuppressionOn,
            TLPhoneDeLExpDiteur = createDto.TLPhoneDeLExpDiteur,
            TLPhoneDeLExportateur = createDto.TLPhoneDeLExportateur,
            TLPhoneDeLaPartieNotifier = createDto.TLPhoneDeLaPartieNotifier,
            TareDeConteneurSVide = createDto.TareDeConteneurSVide,
            TypeDeFlux = createDto.TypeDeFlux,
            UpdatedAt = createDto.UpdatedAt,
            ValeurDeMarchandise = createDto.ValeurDeMarchandise,
            VolumeLitre = createDto.VolumeLitre,
            VolumeMtq = createDto.VolumeMtq
        };

        if (createDto.Id != null)
        {
            line.Id = createDto.Id;
        }

        _context.Lines.Add(line);
        await _context.SaveChangesAsync();

        var result = await _context.FindAsync<LineDbModel>(line.Id);

        if (result == null)
        {
            throw new NotFoundException();
        }

        return result.ToDto();
    }

    /// <summary>
    /// Delete one Ligne
    /// </summary>
    public async Task DeleteLine(LineWhereUniqueInput uniqueId)
    {
        var line = await _context.Lines.FindAsync(uniqueId.Id);
        if (line == null)
        {
            throw new NotFoundException();
        }

        _context.Lines.Remove(line);
        await _context.SaveChangesAsync();
    }

    /// <summary>
    /// Find many Lines
    /// </summary>
    public async Task<List<Line>> Lines(LineFindManyArgs findManyArgs)
    {
        var lines = await _context
            .Lines.ApplyWhere(findManyArgs.Where)
            .ApplySkip(findManyArgs.Skip)
            .ApplyTake(findManyArgs.Take)
            .ApplyOrderBy(findManyArgs.SortBy)
            .ToListAsync();
        return lines.ConvertAll(line => line.ToDto());
    }

    /// <summary>
    /// Meta data about Ligne records
    /// </summary>
    public async Task<MetadataDto> LinesMeta(LineFindManyArgs findManyArgs)
    {
        var count = await _context.Lines.ApplyWhere(findManyArgs.Where).CountAsync();

        return new MetadataDto { Count = count };
    }

    /// <summary>
    /// Get one Ligne
    /// </summary>
    public async Task<Line> Line(LineWhereUniqueInput uniqueId)
    {
        var lines = await this.Lines(
            new LineFindManyArgs { Where = new LineWhereInput { Id = uniqueId.Id } }
        );
        var line = lines.FirstOrDefault();
        if (line == null)
        {
            throw new NotFoundException();
        }

        return line;
    }

    /// <summary>
    /// Update one Ligne
    /// </summary>
    public async Task UpdateLine(LineWhereUniqueInput uniqueId, LineUpdateInput updateDto)
    {
        var line = updateDto.ToModel(uniqueId);

        _context.Entry(line).State = EntityState.Modified;

        try
        {
            await _context.SaveChangesAsync();
        }
        catch (DbUpdateConcurrencyException)
        {
            if (!_context.Lines.Any(e => e.Id == line.Id))
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
