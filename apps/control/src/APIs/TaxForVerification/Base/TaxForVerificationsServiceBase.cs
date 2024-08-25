using Control.APIs;
using Control.APIs.Common;
using Control.APIs.Dtos;
using Control.APIs.Errors;
using Control.APIs.Extensions;
using Control.Infrastructure;
using Control.Infrastructure.Models;
using Microsoft.EntityFrameworkCore;

namespace Control.APIs;

public abstract class TaxForVerificationsServiceBase : ITaxForVerificationsService
{
    protected readonly ControlDbContext _context;

    public TaxForVerificationsServiceBase(ControlDbContext context)
    {
        _context = context;
    }

    /// <summary>
    /// Create one Tax For Verification
    /// </summary>
    public async Task<TaxForVerification> CreateTaxForVerification(
        TaxForVerificationCreateInput createDto
    )
    {
        var taxForVerification = new TaxForVerificationDbModel
        {
            ArticleNumber = createDto.ArticleNumber,
            BasicTaxAmount = createDto.BasicTaxAmount,
            BasicTaxRate = createDto.BasicTaxRate,
            BasicTaxableAmount = createDto.BasicTaxableAmount,
            CreatedAt = createDto.CreatedAt,
            DateAndTimeOfFinalModification = createDto.DateAndTimeOfFinalModification,
            DateAndTimeOfInitialRecord = createDto.DateAndTimeOfInitialRecord,
            DeletedOn = createDto.DeletedOn,
            ExemptedAmount = createDto.ExemptedAmount,
            ExemptedTaxRate = createDto.ExemptedTaxRate,
            ExemptionBaseAmount = createDto.ExemptionBaseAmount,
            ExemptionTypeCode = createDto.ExemptionTypeCode,
            FinalModifierId = createDto.FinalModifierId,
            InitialRecorderId = createDto.InitialRecorderId,
            NumberOfTimesOfValueEvaluation = createDto.NumberOfTimesOfValueEvaluation,
            PaidTaxAmount = createDto.PaidTaxAmount,
            PaymentTypeCode = createDto.PaymentTypeCode,
            SecurityDepositAfterExemption = createDto.SecurityDepositAfterExemption,
            TariffCategoryCode = createDto.TariffCategoryCode,
            TaxAmount = createDto.TaxAmount,
            TaxBaseAmount = createDto.TaxBaseAmount,
            TaxBenefitCode = createDto.TaxBenefitCode,
            TaxCode = createDto.TaxCode,
            TaxRate = createDto.TaxRate,
            UpdatedAt = createDto.UpdatedAt
        };

        if (createDto.Id != null)
        {
            taxForVerification.Id = createDto.Id;
        }
        if (createDto.ArticlesSubmittedForVerifications != null)
        {
            taxForVerification.ArticlesSubmittedForVerifications = await _context
                .ArticlesSubmittedForVerifications.Where(articlesSubmittedForVerification =>
                    createDto.ArticlesSubmittedForVerifications.Id
                    == articlesSubmittedForVerification.Id
                )
                .FirstOrDefaultAsync();
        }

        if (createDto.CommonVerifications != null)
        {
            taxForVerification.CommonVerifications = await _context
                .CommonVerifications.Where(commonVerification =>
                    createDto.CommonVerifications.Select(t => t.Id).Contains(commonVerification.Id)
                )
                .ToListAsync();
        }

        _context.TaxForVerifications.Add(taxForVerification);
        await _context.SaveChangesAsync();

        var result = await _context.FindAsync<TaxForVerificationDbModel>(taxForVerification.Id);

        if (result == null)
        {
            throw new NotFoundException();
        }

        return result.ToDto();
    }

    /// <summary>
    /// Delete one Tax For Verification
    /// </summary>
    public async Task DeleteTaxForVerification(TaxForVerificationWhereUniqueInput uniqueId)
    {
        var taxForVerification = await _context.TaxForVerifications.FindAsync(uniqueId.Id);
        if (taxForVerification == null)
        {
            throw new NotFoundException();
        }

        _context.TaxForVerifications.Remove(taxForVerification);
        await _context.SaveChangesAsync();
    }

    /// <summary>
    /// Find many Tax For Verifications
    /// </summary>
    public async Task<List<TaxForVerification>> TaxForVerifications(
        TaxForVerificationFindManyArgs findManyArgs
    )
    {
        var taxForVerifications = await _context
            .TaxForVerifications.Include(x => x.CommonVerifications)
            .Include(x => x.ArticlesSubmittedForVerifications)
            .ApplyWhere(findManyArgs.Where)
            .ApplySkip(findManyArgs.Skip)
            .ApplyTake(findManyArgs.Take)
            .ApplyOrderBy(findManyArgs.SortBy)
            .ToListAsync();
        return taxForVerifications.ConvertAll(taxForVerification => taxForVerification.ToDto());
    }

    /// <summary>
    /// Meta data about Tax For Verification records
    /// </summary>
    public async Task<MetadataDto> TaxForVerificationsMeta(
        TaxForVerificationFindManyArgs findManyArgs
    )
    {
        var count = await _context.TaxForVerifications.ApplyWhere(findManyArgs.Where).CountAsync();

        return new MetadataDto { Count = count };
    }

    /// <summary>
    /// Get one Tax For Verification
    /// </summary>
    public async Task<TaxForVerification> TaxForVerification(
        TaxForVerificationWhereUniqueInput uniqueId
    )
    {
        var taxForVerifications = await this.TaxForVerifications(
            new TaxForVerificationFindManyArgs
            {
                Where = new TaxForVerificationWhereInput { Id = uniqueId.Id }
            }
        );
        var taxForVerification = taxForVerifications.FirstOrDefault();
        if (taxForVerification == null)
        {
            throw new NotFoundException();
        }

        return taxForVerification;
    }

    /// <summary>
    /// Update one Tax For Verification
    /// </summary>
    public async Task UpdateTaxForVerification(
        TaxForVerificationWhereUniqueInput uniqueId,
        TaxForVerificationUpdateInput updateDto
    )
    {
        var taxForVerification = updateDto.ToModel(uniqueId);

        if (updateDto.CommonVerifications != null)
        {
            taxForVerification.CommonVerifications = await _context
                .CommonVerifications.Where(commonVerification =>
                    updateDto.CommonVerifications.Select(t => t).Contains(commonVerification.Id)
                )
                .ToListAsync();
        }

        _context.Entry(taxForVerification).State = EntityState.Modified;

        try
        {
            await _context.SaveChangesAsync();
        }
        catch (DbUpdateConcurrencyException)
        {
            if (!_context.TaxForVerifications.Any(e => e.Id == taxForVerification.Id))
            {
                throw new NotFoundException();
            }
            else
            {
                throw;
            }
        }
    }

    /// <summary>
    /// Get a Articles Submitted For Verifications record for Tax For Verification
    /// </summary>
    public async Task<ArticlesSubmittedForVerification> GetArticlesSubmittedForVerifications(
        TaxForVerificationWhereUniqueInput uniqueId
    )
    {
        var taxForVerification = await _context
            .TaxForVerifications.Where(taxForVerification => taxForVerification.Id == uniqueId.Id)
            .Include(taxForVerification => taxForVerification.ArticlesSubmittedForVerifications)
            .FirstOrDefaultAsync();
        if (taxForVerification == null)
        {
            throw new NotFoundException();
        }
        return taxForVerification.ArticlesSubmittedForVerifications.ToDto();
    }

    /// <summary>
    /// Connect multiple Common Verifications records to Tax For Verification
    /// </summary>
    public async Task ConnectCommonVerifications(
        TaxForVerificationWhereUniqueInput uniqueId,
        CommonVerificationWhereUniqueInput[] commonVerificationsId
    )
    {
        var parent = await _context
            .TaxForVerifications.Include(x => x.CommonVerifications)
            .FirstOrDefaultAsync(x => x.Id == uniqueId.Id);
        if (parent == null)
        {
            throw new NotFoundException();
        }

        var commonVerifications = await _context
            .CommonVerifications.Where(t => commonVerificationsId.Select(x => x.Id).Contains(t.Id))
            .ToListAsync();
        if (commonVerifications.Count == 0)
        {
            throw new NotFoundException();
        }

        var commonVerificationsToConnect = commonVerifications.Except(parent.CommonVerifications);

        foreach (var commonVerification in commonVerificationsToConnect)
        {
            parent.CommonVerifications.Add(commonVerification);
        }

        await _context.SaveChangesAsync();
    }

    /// <summary>
    /// Disconnect multiple Common Verifications records from Tax For Verification
    /// </summary>
    public async Task DisconnectCommonVerifications(
        TaxForVerificationWhereUniqueInput uniqueId,
        CommonVerificationWhereUniqueInput[] commonVerificationsId
    )
    {
        var parent = await _context
            .TaxForVerifications.Include(x => x.CommonVerifications)
            .FirstOrDefaultAsync(x => x.Id == uniqueId.Id);
        if (parent == null)
        {
            throw new NotFoundException();
        }

        var commonVerifications = await _context
            .CommonVerifications.Where(t => commonVerificationsId.Select(x => x.Id).Contains(t.Id))
            .ToListAsync();

        foreach (var commonVerification in commonVerifications)
        {
            parent.CommonVerifications?.Remove(commonVerification);
        }
        await _context.SaveChangesAsync();
    }

    /// <summary>
    /// Find multiple Common Verifications records for Tax For Verification
    /// </summary>
    public async Task<List<CommonVerification>> FindCommonVerifications(
        TaxForVerificationWhereUniqueInput uniqueId,
        CommonVerificationFindManyArgs taxForVerificationFindManyArgs
    )
    {
        var commonVerifications = await _context
            .CommonVerifications.Where(m => m.TaxesForVerificationId == uniqueId.Id)
            .ApplyWhere(taxForVerificationFindManyArgs.Where)
            .ApplySkip(taxForVerificationFindManyArgs.Skip)
            .ApplyTake(taxForVerificationFindManyArgs.Take)
            .ApplyOrderBy(taxForVerificationFindManyArgs.SortBy)
            .ToListAsync();

        return commonVerifications.Select(x => x.ToDto()).ToList();
    }

    /// <summary>
    /// Update multiple Common Verifications records for Tax For Verification
    /// </summary>
    public async Task UpdateCommonVerifications(
        TaxForVerificationWhereUniqueInput uniqueId,
        CommonVerificationWhereUniqueInput[] commonVerificationsId
    )
    {
        var taxForVerification = await _context
            .TaxForVerifications.Include(t => t.CommonVerifications)
            .FirstOrDefaultAsync(x => x.Id == uniqueId.Id);
        if (taxForVerification == null)
        {
            throw new NotFoundException();
        }

        var commonVerifications = await _context
            .CommonVerifications.Where(a => commonVerificationsId.Select(x => x.Id).Contains(a.Id))
            .ToListAsync();

        if (commonVerifications.Count == 0)
        {
            throw new NotFoundException();
        }

        taxForVerification.CommonVerifications = commonVerifications;
        await _context.SaveChangesAsync();
    }
}
