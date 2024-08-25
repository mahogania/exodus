using Control.APIs.Dtos;
using Control.Infrastructure.Models;

namespace Control.APIs.Extensions;

public static class ModelValueEvaluationVerificationsExtensions
{
    public static ModelValueEvaluationVerification ToDto(
        this ModelValueEvaluationVerificationDbModel model
    )
    {
        return new ModelValueEvaluationVerification
        {
            ArticleNumber = model.ArticleNumber,
            ArticlesSubmittedForVerification = model.ArticlesSubmittedForVerificationId,
            CreatedAt = model.CreatedAt,
            DateAndTimeOfFinalModification = model.DateAndTimeOfFinalModification,
            DateAndTimeOfInitialRecord = model.DateAndTimeOfInitialRecord,
            DeclaredInvoicePrice = model.DeclaredInvoicePrice,
            DeclaredQuantity = model.DeclaredQuantity,
            DeclaredQuantityUnitCode = model.DeclaredQuantityUnitCode,
            DeclaredUnitPrice = model.DeclaredUnitPrice,
            DeletedOn = model.DeletedOn,
            FinalModifierId = model.FinalModifierId,
            Id = model.Id,
            InitialRecorderId = model.InitialRecorderId,
            LiquidatedInvoicePrice = model.LiquidatedInvoicePrice,
            LiquidatedQuantity = model.LiquidatedQuantity,
            LiquidatedQuantityUnitCode = model.LiquidatedQuantityUnitCode,
            LiquidatedUnitPrice = model.LiquidatedUnitPrice,
            ModelAndSpecificationNumber = model.ModelAndSpecificationNumber,
            UpdatedAt = model.UpdatedAt,
            ValueEvaluationContent = model.ValueEvaluationContent,
        };
    }

    public static ModelValueEvaluationVerificationDbModel ToModel(
        this ModelValueEvaluationVerificationUpdateInput updateDto,
        ModelValueEvaluationVerificationWhereUniqueInput uniqueId
    )
    {
        var modelValueEvaluationVerification = new ModelValueEvaluationVerificationDbModel
        {
            Id = uniqueId.Id,
            ArticleNumber = updateDto.ArticleNumber,
            DateAndTimeOfFinalModification = updateDto.DateAndTimeOfFinalModification,
            DateAndTimeOfInitialRecord = updateDto.DateAndTimeOfInitialRecord,
            DeclaredInvoicePrice = updateDto.DeclaredInvoicePrice,
            DeclaredQuantity = updateDto.DeclaredQuantity,
            DeclaredQuantityUnitCode = updateDto.DeclaredQuantityUnitCode,
            DeclaredUnitPrice = updateDto.DeclaredUnitPrice,
            DeletedOn = updateDto.DeletedOn,
            FinalModifierId = updateDto.FinalModifierId,
            InitialRecorderId = updateDto.InitialRecorderId,
            LiquidatedInvoicePrice = updateDto.LiquidatedInvoicePrice,
            LiquidatedQuantity = updateDto.LiquidatedQuantity,
            LiquidatedQuantityUnitCode = updateDto.LiquidatedQuantityUnitCode,
            LiquidatedUnitPrice = updateDto.LiquidatedUnitPrice,
            ModelAndSpecificationNumber = updateDto.ModelAndSpecificationNumber,
            ValueEvaluationContent = updateDto.ValueEvaluationContent
        };

        if (updateDto.ArticlesSubmittedForVerification != null)
        {
            modelValueEvaluationVerification.ArticlesSubmittedForVerificationId =
                updateDto.ArticlesSubmittedForVerification;
        }
        if (updateDto.CreatedAt != null)
        {
            modelValueEvaluationVerification.CreatedAt = updateDto.CreatedAt.Value;
        }
        if (updateDto.UpdatedAt != null)
        {
            modelValueEvaluationVerification.UpdatedAt = updateDto.UpdatedAt.Value;
        }

        return modelValueEvaluationVerification;
    }
}
