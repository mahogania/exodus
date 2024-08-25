using Control.APIs;
using Control.APIs.Common;
using Control.APIs.Dtos;
using Control.APIs.Errors;
using Control.APIs.Extensions;
using Control.Infrastructure;
using Control.Infrastructure.Models;
using Microsoft.EntityFrameworkCore;

namespace Control.APIs;

public abstract class ModelValueEvaluationVerificationsServiceBase
    : IModelValueEvaluationVerificationsService
{
    protected readonly ControlDbContext _context;

    public ModelValueEvaluationVerificationsServiceBase(ControlDbContext context)
    {
        _context = context;
    }

    /// <summary>
    /// Create one Model Value Evaluation Verification
    /// </summary>
    public async Task<ModelValueEvaluationVerification> CreateModelValueEvaluationVerification(
        ModelValueEvaluationVerificationCreateInput createDto
    )
    {
        var modelValueEvaluationVerification = new ModelValueEvaluationVerificationDbModel
        {
            ArticleNumber = createDto.ArticleNumber,
            CreatedAt = createDto.CreatedAt,
            DateAndTimeOfFinalModification = createDto.DateAndTimeOfFinalModification,
            DateAndTimeOfInitialRecord = createDto.DateAndTimeOfInitialRecord,
            DeclaredInvoicePrice = createDto.DeclaredInvoicePrice,
            DeclaredQuantity = createDto.DeclaredQuantity,
            DeclaredQuantityUnitCode = createDto.DeclaredQuantityUnitCode,
            DeclaredUnitPrice = createDto.DeclaredUnitPrice,
            DeletedOn = createDto.DeletedOn,
            FinalModifierId = createDto.FinalModifierId,
            InitialRecorderId = createDto.InitialRecorderId,
            LiquidatedInvoicePrice = createDto.LiquidatedInvoicePrice,
            LiquidatedQuantity = createDto.LiquidatedQuantity,
            LiquidatedQuantityUnitCode = createDto.LiquidatedQuantityUnitCode,
            LiquidatedUnitPrice = createDto.LiquidatedUnitPrice,
            ModelAndSpecificationNumber = createDto.ModelAndSpecificationNumber,
            UpdatedAt = createDto.UpdatedAt,
            ValueEvaluationContent = createDto.ValueEvaluationContent
        };

        if (createDto.Id != null)
        {
            modelValueEvaluationVerification.Id = createDto.Id;
        }

        _context.ModelValueEvaluationVerifications.Add(modelValueEvaluationVerification);
        await _context.SaveChangesAsync();

        var result = await _context.FindAsync<ModelValueEvaluationVerificationDbModel>(
            modelValueEvaluationVerification.Id
        );

        if (result == null)
        {
            throw new NotFoundException();
        }

        return result.ToDto();
    }

    /// <summary>
    /// Delete one Model Value Evaluation Verification
    /// </summary>
    public async Task DeleteModelValueEvaluationVerification(
        ModelValueEvaluationVerificationWhereUniqueInput uniqueId
    )
    {
        var modelValueEvaluationVerification =
            await _context.ModelValueEvaluationVerifications.FindAsync(uniqueId.Id);
        if (modelValueEvaluationVerification == null)
        {
            throw new NotFoundException();
        }

        _context.ModelValueEvaluationVerifications.Remove(modelValueEvaluationVerification);
        await _context.SaveChangesAsync();
    }

    /// <summary>
    /// Find many Value Evaluation Model Verifications
    /// </summary>
    public async Task<List<ModelValueEvaluationVerification>> ModelValueEvaluationVerifications(
        ModelValueEvaluationVerificationFindManyArgs findManyArgs
    )
    {
        var modelValueEvaluationVerifications = await _context
            .ModelValueEvaluationVerifications.ApplyWhere(findManyArgs.Where)
            .ApplySkip(findManyArgs.Skip)
            .ApplyTake(findManyArgs.Take)
            .ApplyOrderBy(findManyArgs.SortBy)
            .ToListAsync();
        return modelValueEvaluationVerifications.ConvertAll(modelValueEvaluationVerification =>
            modelValueEvaluationVerification.ToDto()
        );
    }

    /// <summary>
    /// Meta data about Model Value Evaluation Verification records
    /// </summary>
    public async Task<MetadataDto> ModelValueEvaluationVerificationsMeta(
        ModelValueEvaluationVerificationFindManyArgs findManyArgs
    )
    {
        var count = await _context
            .ModelValueEvaluationVerifications.ApplyWhere(findManyArgs.Where)
            .CountAsync();

        return new MetadataDto { Count = count };
    }

    /// <summary>
    /// Get one Model Value Evaluation Verification
    /// </summary>
    public async Task<ModelValueEvaluationVerification> ModelValueEvaluationVerification(
        ModelValueEvaluationVerificationWhereUniqueInput uniqueId
    )
    {
        var modelValueEvaluationVerifications = await this.ModelValueEvaluationVerifications(
            new ModelValueEvaluationVerificationFindManyArgs
            {
                Where = new ModelValueEvaluationVerificationWhereInput { Id = uniqueId.Id }
            }
        );
        var modelValueEvaluationVerification = modelValueEvaluationVerifications.FirstOrDefault();
        if (modelValueEvaluationVerification == null)
        {
            throw new NotFoundException();
        }

        return modelValueEvaluationVerification;
    }

    /// <summary>
    /// Update one Model Value Evaluation Verification
    /// </summary>
    public async Task UpdateModelValueEvaluationVerification(
        ModelValueEvaluationVerificationWhereUniqueInput uniqueId,
        ModelValueEvaluationVerificationUpdateInput updateDto
    )
    {
        var modelValueEvaluationVerification = updateDto.ToModel(uniqueId);

        _context.Entry(modelValueEvaluationVerification).State = EntityState.Modified;

        try
        {
            await _context.SaveChangesAsync();
        }
        catch (DbUpdateConcurrencyException)
        {
            if (
                !_context.ModelValueEvaluationVerifications.Any(e =>
                    e.Id == modelValueEvaluationVerification.Id
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
