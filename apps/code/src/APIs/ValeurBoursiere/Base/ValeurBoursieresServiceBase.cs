using Code.APIs;
using Code.APIs.Common;
using Code.APIs.Dtos;
using Code.APIs.Errors;
using Code.APIs.Extensions;
using Code.Infrastructure;
using Code.Infrastructure.Models;
using Microsoft.EntityFrameworkCore;

namespace Code.APIs;

public abstract class ValeurBoursieresServiceBase : IValeurBoursieresService
{
    protected readonly CodeDbContext _context;

    public ValeurBoursieresServiceBase(CodeDbContext context)
    {
        _context = context;
    }

    /// <summary>
    /// Create one ValeurBoursiere
    /// </summary>
    public async Task<ValeurBoursiere> CreateValeurBoursiere(ValeurBoursiereCreateInput createDto)
    {
        var valeurBoursiere = new ValeurBoursiereDbModel
        {
            CodeDevisePoidsBrutExporte = createDto.CodeDevisePoidsBrutExporte,
            CodeDevisePoidsBrutImporte = createDto.CodeDevisePoidsBrutImporte,
            CodeDevisePoidsNetExporte = createDto.CodeDevisePoidsNetExporte,
            CodeDevisePoidsNetImporte = createDto.CodeDevisePoidsNetImporte,
            CodeDeviseUnite1QuantiteExportee = createDto.CodeDeviseUnite1QuantiteExportee,
            CodeDeviseUnite1QuantiteImportee = createDto.CodeDeviseUnite1QuantiteImportee,
            CodeDeviseUnite2QuantiteExportee = createDto.CodeDeviseUnite2QuantiteExportee,
            CodeDeviseUnite2QuantiteImportee = createDto.CodeDeviseUnite2QuantiteImportee,
            CodeDeviseUnite3QuantiteExportee = createDto.CodeDeviseUnite3QuantiteExportee,
            CodeDeviseUnite3QuantiteImportee = createDto.CodeDeviseUnite3QuantiteImportee,
            CodeValeurBoursiere = createDto.CodeValeurBoursiere,
            CreatedAt = createDto.CreatedAt,
            DateDebutApplicationValeurBoursiere = createDto.DateDebutApplicationValeurBoursiere,
            DateFinApplicationValeurBoursiere = createDto.DateFinApplicationValeurBoursiere,
            DateHeureModificationFinale = createDto.DateHeureModificationFinale,
            DateHeurePremierEnregistrement = createDto.DateHeurePremierEnregistrement,
            ModificateurFinalId = createDto.ModificateurFinalId,
            NomValeurBoursiere = createDto.NomValeurBoursiere,
            PremierEnregistrantId = createDto.PremierEnregistrantId,
            PrixBaseTaxableModifieOn = createDto.PrixBaseTaxableModifieOn,
            PrixLePlusHauxOn = createDto.PrixLePlusHauxOn,
            PrixUnitairePoidsBrutExporte = createDto.PrixUnitairePoidsBrutExporte,
            PrixUnitairePoidsBrutImporte = createDto.PrixUnitairePoidsBrutImporte,
            PrixUnitairePoidsNetExporte = createDto.PrixUnitairePoidsNetExporte,
            PrixUnitairePoidsNetImporte = createDto.PrixUnitairePoidsNetImporte,
            PrixUnitaireUnite1QuantiteExportee = createDto.PrixUnitaireUnite1QuantiteExportee,
            PrixUnitaireUnite1QuantiteImportee = createDto.PrixUnitaireUnite1QuantiteImportee,
            PrixUnitaireUnite2QuantiteExportee = createDto.PrixUnitaireUnite2QuantiteExportee,
            PrixUnitaireUnite2QuantiteImportee = createDto.PrixUnitaireUnite2QuantiteImportee,
            PrixUnitaireUnite3QuantiteExportee = createDto.PrixUnitaireUnite3QuantiteExportee,
            PrixUnitaireUnite3QuantiteImportee = createDto.PrixUnitaireUnite3QuantiteImportee,
            SuppressionOn = createDto.SuppressionOn,
            UpdatedAt = createDto.UpdatedAt
        };

        if (createDto.Id != null)
        {
            valeurBoursiere.Id = createDto.Id;
        }

        _context.ValeurBoursieres.Add(valeurBoursiere);
        await _context.SaveChangesAsync();

        var result = await _context.FindAsync<ValeurBoursiereDbModel>(valeurBoursiere.Id);

        if (result == null)
        {
            throw new NotFoundException();
        }

        return result.ToDto();
    }

    /// <summary>
    /// Delete one ValeurBoursiere
    /// </summary>
    public async Task DeleteValeurBoursiere(ValeurBoursiereWhereUniqueInput uniqueId)
    {
        var valeurBoursiere = await _context.ValeurBoursieres.FindAsync(uniqueId.Id);
        if (valeurBoursiere == null)
        {
            throw new NotFoundException();
        }

        _context.ValeurBoursieres.Remove(valeurBoursiere);
        await _context.SaveChangesAsync();
    }

    /// <summary>
    /// Find many ValeurBoursieres
    /// </summary>
    public async Task<List<ValeurBoursiere>> ValeurBoursieres(
        ValeurBoursiereFindManyArgs findManyArgs
    )
    {
        var valeurBoursieres = await _context
            .ValeurBoursieres.ApplyWhere(findManyArgs.Where)
            .ApplySkip(findManyArgs.Skip)
            .ApplyTake(findManyArgs.Take)
            .ApplyOrderBy(findManyArgs.SortBy)
            .ToListAsync();
        return valeurBoursieres.ConvertAll(valeurBoursiere => valeurBoursiere.ToDto());
    }

    /// <summary>
    /// Meta data about ValeurBoursiere records
    /// </summary>
    public async Task<MetadataDto> ValeurBoursieresMeta(ValeurBoursiereFindManyArgs findManyArgs)
    {
        var count = await _context.ValeurBoursieres.ApplyWhere(findManyArgs.Where).CountAsync();

        return new MetadataDto { Count = count };
    }

    /// <summary>
    /// Get one ValeurBoursiere
    /// </summary>
    public async Task<ValeurBoursiere> ValeurBoursiere(ValeurBoursiereWhereUniqueInput uniqueId)
    {
        var valeurBoursieres = await this.ValeurBoursieres(
            new ValeurBoursiereFindManyArgs
            {
                Where = new ValeurBoursiereWhereInput { Id = uniqueId.Id }
            }
        );
        var valeurBoursiere = valeurBoursieres.FirstOrDefault();
        if (valeurBoursiere == null)
        {
            throw new NotFoundException();
        }

        return valeurBoursiere;
    }

    /// <summary>
    /// Update one ValeurBoursiere
    /// </summary>
    public async Task UpdateValeurBoursiere(
        ValeurBoursiereWhereUniqueInput uniqueId,
        ValeurBoursiereUpdateInput updateDto
    )
    {
        var valeurBoursiere = updateDto.ToModel(uniqueId);

        _context.Entry(valeurBoursiere).State = EntityState.Modified;

        try
        {
            await _context.SaveChangesAsync();
        }
        catch (DbUpdateConcurrencyException)
        {
            if (!_context.ValeurBoursieres.Any(e => e.Id == valeurBoursiere.Id))
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
