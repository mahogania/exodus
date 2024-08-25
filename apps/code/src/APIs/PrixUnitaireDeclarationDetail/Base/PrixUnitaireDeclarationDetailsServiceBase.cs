using Code.APIs;
using Code.APIs.Common;
using Code.APIs.Dtos;
using Code.APIs.Errors;
using Code.APIs.Extensions;
using Code.Infrastructure;
using Code.Infrastructure.Models;
using Microsoft.EntityFrameworkCore;

namespace Code.APIs;

public abstract class PrixUnitaireDeclarationDetailsServiceBase
    : IPrixUnitaireDeclarationDetailsService
{
    protected readonly CodeDbContext _context;

    public PrixUnitaireDeclarationDetailsServiceBase(CodeDbContext context)
    {
        _context = context;
    }

    /// <summary>
    /// Create one PrixUnitaireDeclarationDetail
    /// </summary>
    public async Task<PrixUnitaireDeclarationDetail> CreatePrixUnitaireDeclarationDetail(
        PrixUnitaireDeclarationDetailCreateInput createDto
    )
    {
        var prixUnitaireDeclarationDetail = new PrixUnitaireDeclarationDetailDbModel
        {
            CodeDevise = createDto.CodeDevise,
            CodeMethodeEvaluationValeur = createDto.CodeMethodeEvaluationValeur,
            CodePaysExpedition = createDto.CodePaysExpedition,
            CodePaysOrigine = createDto.CodePaysOrigine,
            CodeProduitNeufEtUsage = createDto.CodeProduitNeufEtUsage,
            CodeShDeclare = createDto.CodeShDeclare,
            CodeShLiquide = createDto.CodeShLiquide,
            CodeUniteQuantite = createDto.CodeUniteQuantite,
            ContenuEvaluationValeur = createDto.ContenuEvaluationValeur,
            CreatedAt = createDto.CreatedAt,
            DateDemande = createDto.DateDemande,
            DateEvaluationValeur = createDto.DateEvaluationValeur,
            DateHeureModificationFinale = createDto.DateHeureModificationFinale,
            DateHeurePremierEnregistrement = createDto.DateHeurePremierEnregistrement,
            DateValidation = createDto.DateValidation,
            ModificateurFinalId = createDto.ModificateurFinalId,
            MontantDeclareFacture = createDto.MontantDeclareFacture,
            MontantDeclareNcyFacture = createDto.MontantDeclareNcyFacture,
            MontantNcyLiquideFacture = createDto.MontantNcyLiquideFacture,
            MontantUsdLiquideFacture = createDto.MontantUsdLiquideFacture,
            NomArticle = createDto.NomArticle,
            NomComposant = createDto.NomComposant,
            NomEntrepriseExportateur = createDto.NomEntrepriseExportateur,
            NomEntrepriseImportateur = createDto.NomEntrepriseImportateur,
            NomMarque = createDto.NomMarque,
            NomModeleSpecification = createDto.NomModeleSpecification,
            NumeroArticle = createDto.NumeroArticle,
            NumeroDeclarationDetail = createDto.NumeroDeclarationDetail,
            NumeroIdentificationExportateur = createDto.NumeroIdentificationExportateur,
            NumeroIdentificationImportateur = createDto.NumeroIdentificationImportateur,
            NumeroModeleSpecification = createDto.NumeroModeleSpecification,
            PoidsNet = createDto.PoidsNet,
            PremierEnregistrantId = createDto.PremierEnregistrantId,
            PrixNcyUnitaireDeclare = createDto.PrixNcyUnitaireDeclare,
            PrixUnitaireNcyLiquide = createDto.PrixUnitaireNcyLiquide,
            PrixUnitaireUsdLiquide = createDto.PrixUnitaireUsdLiquide,
            PrixUsdUnitaireDeclare = createDto.PrixUsdUnitaireDeclare,
            Quantite = createDto.Quantite,
            SuppressionOn = createDto.SuppressionOn,
            UpdatedAt = createDto.UpdatedAt
        };

        if (createDto.Id != null)
        {
            prixUnitaireDeclarationDetail.Id = createDto.Id;
        }

        _context.PrixUnitaireDeclarationDetails.Add(prixUnitaireDeclarationDetail);
        await _context.SaveChangesAsync();

        var result = await _context.FindAsync<PrixUnitaireDeclarationDetailDbModel>(
            prixUnitaireDeclarationDetail.Id
        );

        if (result == null)
        {
            throw new NotFoundException();
        }

        return result.ToDto();
    }

    /// <summary>
    /// Delete one PrixUnitaireDeclarationDetail
    /// </summary>
    public async Task DeletePrixUnitaireDeclarationDetail(
        PrixUnitaireDeclarationDetailWhereUniqueInput uniqueId
    )
    {
        var prixUnitaireDeclarationDetail = await _context.PrixUnitaireDeclarationDetails.FindAsync(
            uniqueId.Id
        );
        if (prixUnitaireDeclarationDetail == null)
        {
            throw new NotFoundException();
        }

        _context.PrixUnitaireDeclarationDetails.Remove(prixUnitaireDeclarationDetail);
        await _context.SaveChangesAsync();
    }

    /// <summary>
    /// Find many PrixUnitaireDeclarationDetails
    /// </summary>
    public async Task<List<PrixUnitaireDeclarationDetail>> PrixUnitaireDeclarationDetails(
        PrixUnitaireDeclarationDetailFindManyArgs findManyArgs
    )
    {
        var prixUnitaireDeclarationDetails = await _context
            .PrixUnitaireDeclarationDetails.ApplyWhere(findManyArgs.Where)
            .ApplySkip(findManyArgs.Skip)
            .ApplyTake(findManyArgs.Take)
            .ApplyOrderBy(findManyArgs.SortBy)
            .ToListAsync();
        return prixUnitaireDeclarationDetails.ConvertAll(prixUnitaireDeclarationDetail =>
            prixUnitaireDeclarationDetail.ToDto()
        );
    }

    /// <summary>
    /// Meta data about PrixUnitaireDeclarationDetail records
    /// </summary>
    public async Task<MetadataDto> PrixUnitaireDeclarationDetailsMeta(
        PrixUnitaireDeclarationDetailFindManyArgs findManyArgs
    )
    {
        var count = await _context
            .PrixUnitaireDeclarationDetails.ApplyWhere(findManyArgs.Where)
            .CountAsync();

        return new MetadataDto { Count = count };
    }

    /// <summary>
    /// Get one PrixUnitaireDeclarationDetail
    /// </summary>
    public async Task<PrixUnitaireDeclarationDetail> PrixUnitaireDeclarationDetail(
        PrixUnitaireDeclarationDetailWhereUniqueInput uniqueId
    )
    {
        var prixUnitaireDeclarationDetails = await this.PrixUnitaireDeclarationDetails(
            new PrixUnitaireDeclarationDetailFindManyArgs
            {
                Where = new PrixUnitaireDeclarationDetailWhereInput { Id = uniqueId.Id }
            }
        );
        var prixUnitaireDeclarationDetail = prixUnitaireDeclarationDetails.FirstOrDefault();
        if (prixUnitaireDeclarationDetail == null)
        {
            throw new NotFoundException();
        }

        return prixUnitaireDeclarationDetail;
    }

    /// <summary>
    /// Update one PrixUnitaireDeclarationDetail
    /// </summary>
    public async Task UpdatePrixUnitaireDeclarationDetail(
        PrixUnitaireDeclarationDetailWhereUniqueInput uniqueId,
        PrixUnitaireDeclarationDetailUpdateInput updateDto
    )
    {
        var prixUnitaireDeclarationDetail = updateDto.ToModel(uniqueId);

        _context.Entry(prixUnitaireDeclarationDetail).State = EntityState.Modified;

        try
        {
            await _context.SaveChangesAsync();
        }
        catch (DbUpdateConcurrencyException)
        {
            if (
                !_context.PrixUnitaireDeclarationDetails.Any(e =>
                    e.Id == prixUnitaireDeclarationDetail.Id
                )
            )
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
