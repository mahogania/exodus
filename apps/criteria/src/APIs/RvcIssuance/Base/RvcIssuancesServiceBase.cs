using Criteria.APIs;
using Criteria.APIs.Common;
using Criteria.APIs.Dtos;
using Criteria.APIs.Errors;
using Criteria.APIs.Extensions;
using Criteria.Infrastructure;
using Criteria.Infrastructure.Models;
using Microsoft.EntityFrameworkCore;

namespace Criteria.APIs;

public abstract class RvcIssuancesServiceBase : IRvcIssuancesService
{
    protected readonly CriteriaDbContext _context;

    public RvcIssuancesServiceBase(CriteriaDbContext context)
    {
        _context = context;
    }

    /// <summary>
    /// Create one RVC Issuance
    /// </summary>
    public async Task<RvcIssuance> CreateRvcIssuance(RvcIssuanceCreateInput createDto)
    {
        var rvcIssuance = new RvcIssuanceDbModel
        {
            AttachmentFileId = createDto.AttachmentFileId,
            BlNumber = createDto.BlNumber,
            CreatedAt = createDto.CreatedAt,
            DeclaredNcyFobAmount = createDto.DeclaredNcyFobAmount,
            DeclaredNcyFreightAmount = createDto.DeclaredNcyFreightAmount,
            DeclaredNcyInsuranceAmount = createDto.DeclaredNcyInsuranceAmount,
            DeclaredNcyOtherChargesAmount = createDto.DeclaredNcyOtherChargesAmount,
            DeclaredNcyTotalTaxableBaseAmount = createDto.DeclaredNcyTotalTaxableBaseAmount,
            DeliveryConditionCode = createDto.DeliveryConditionCode,
            ExporterAddress = createDto.ExporterAddress,
            ExporterCompanyName = createDto.ExporterCompanyName,
            ExporterCountryCode = createDto.ExporterCountryCode,
            ExporterIdentificationNumber = createDto.ExporterIdentificationNumber,
            ImporterAddress = createDto.ImporterAddress,
            ImporterCompanyName = createDto.ImporterCompanyName,
            ImporterIdentificationNumber = createDto.ImporterIdentificationNumber,
            InvoiceAmount = createDto.InvoiceAmount,
            InvoiceCurrencyCode = createDto.InvoiceCurrencyCode,
            InvoiceIssueDate = createDto.InvoiceIssueDate,
            InvoiceNumber = createDto.InvoiceNumber,
            IssueDate = createDto.IssueDate,
            LiquidNcyFobAmount = createDto.LiquidNcyFobAmount,
            LiquidNcyFreightAmount = createDto.LiquidNcyFreightAmount,
            LiquidNcyInsuranceAmount = createDto.LiquidNcyInsuranceAmount,
            LiquidNcyOtherChargesAmount = createDto.LiquidNcyOtherChargesAmount,
            LiquidNcyTotalTaxableBaseAmount = createDto.LiquidNcyTotalTaxableBaseAmount,
            PackageUnitCode = createDto.PackageUnitCode,
            RecipientCountryCode = createDto.RecipientCountryCode,
            ReportNumber = createDto.ReportNumber,
            RvcNumber = createDto.RvcNumber,
            TotalGrossWeight = createDto.TotalGrossWeight,
            TotalNetWeight = createDto.TotalNetWeight,
            TotalNumberOfPackages = createDto.TotalNumberOfPackages,
            UpdatedAt = createDto.UpdatedAt
        };

        if (createDto.Id != null)
        {
            rvcIssuance.Id = createDto.Id;
        }

        _context.RvcIssuances.Add(rvcIssuance);
        await _context.SaveChangesAsync();

        var result = await _context.FindAsync<RvcIssuanceDbModel>(rvcIssuance.Id);

        if (result == null)
        {
            throw new NotFoundException();
        }

        return result.ToDto();
    }

    /// <summary>
    /// Delete one RVC Issuance
    /// </summary>
    public async Task DeleteRvcIssuance(RvcIssuanceWhereUniqueInput uniqueId)
    {
        var rvcIssuance = await _context.RvcIssuances.FindAsync(uniqueId.Id);
        if (rvcIssuance == null)
        {
            throw new NotFoundException();
        }

        _context.RvcIssuances.Remove(rvcIssuance);
        await _context.SaveChangesAsync();
    }

    /// <summary>
    /// Find many RVC Issuances
    /// </summary>
    public async Task<List<RvcIssuance>> RvcIssuances(RvcIssuanceFindManyArgs findManyArgs)
    {
        var rvcIssuances = await _context
            .RvcIssuances.ApplyWhere(findManyArgs.Where)
            .ApplySkip(findManyArgs.Skip)
            .ApplyTake(findManyArgs.Take)
            .ApplyOrderBy(findManyArgs.SortBy)
            .ToListAsync();
        return rvcIssuances.ConvertAll(rvcIssuance => rvcIssuance.ToDto());
    }

    /// <summary>
    /// Meta data about RVC Issuance records
    /// </summary>
    public async Task<MetadataDto> RvcIssuancesMeta(RvcIssuanceFindManyArgs findManyArgs)
    {
        var count = await _context.RvcIssuances.ApplyWhere(findManyArgs.Where).CountAsync();

        return new MetadataDto { Count = count };
    }

    /// <summary>
    /// Get one RVC Issuance
    /// </summary>
    public async Task<RvcIssuance> RvcIssuance(RvcIssuanceWhereUniqueInput uniqueId)
    {
        var rvcIssuances = await this.RvcIssuances(
            new RvcIssuanceFindManyArgs { Where = new RvcIssuanceWhereInput { Id = uniqueId.Id } }
        );
        var rvcIssuance = rvcIssuances.FirstOrDefault();
        if (rvcIssuance == null)
        {
            throw new NotFoundException();
        }

        return rvcIssuance;
    }

    /// <summary>
    /// Update one RVC Issuance
    /// </summary>
    public async Task UpdateRvcIssuance(
        RvcIssuanceWhereUniqueInput uniqueId,
        RvcIssuanceUpdateInput updateDto
    )
    {
        var rvcIssuance = updateDto.ToModel(uniqueId);

        _context.Entry(rvcIssuance).State = EntityState.Modified;

        try
        {
            await _context.SaveChangesAsync();
        }
        catch (DbUpdateConcurrencyException)
        {
            if (!_context.RvcIssuances.Any(e => e.Id == rvcIssuance.Id))
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
