using Control.APIs.Dtos;
using Control.Infrastructure.Models;

namespace Control.APIs.Extensions;

public static class ModelofDetailedDeclarationsExtensions
{
    public static ModelofDetailedDeclaration ToDto(this ModelofDetailedDeclarationDbModel model)
    {
        return new ModelofDetailedDeclaration
        {
            Article = model.ArticleId,
            CreatedAt = model.CreatedAt,
            DateAndTimeOfFinalModification = model.DateAndTimeOfFinalModification,
            DateAndTimeOfFirstRegistration = model.DateAndTimeOfFirstRegistration,
            DeletionOn = model.DeletionOn,
            FinalModifierId = model.FinalModifierId,
            FirstRegistrarId = model.FirstRegistrarId,
            Id = model.Id,
            InvoiceAmount = model.InvoiceAmount,
            ModelAndSpecificationNameComponent = model.ModelAndSpecificationNameComponent,
            Quantity = model.Quantity,
            UnitOfQuantityCode = model.UnitOfQuantityCode,
            UnitPrice = model.UnitPrice,
            UpdatedAt = model.UpdatedAt,
        };
    }

    public static ModelofDetailedDeclarationDbModel ToModel(
        this ModelofDetailedDeclarationUpdateInput updateDto,
        ModelofDetailedDeclarationWhereUniqueInput uniqueId
    )
    {
        var modelofDetailedDeclaration = new ModelofDetailedDeclarationDbModel
        {
            Id = uniqueId.Id,
            DateAndTimeOfFinalModification = updateDto.DateAndTimeOfFinalModification,
            DateAndTimeOfFirstRegistration = updateDto.DateAndTimeOfFirstRegistration,
            DeletionOn = updateDto.DeletionOn,
            FinalModifierId = updateDto.FinalModifierId,
            FirstRegistrarId = updateDto.FirstRegistrarId,
            InvoiceAmount = updateDto.InvoiceAmount,
            ModelAndSpecificationNameComponent = updateDto.ModelAndSpecificationNameComponent,
            Quantity = updateDto.Quantity,
            UnitOfQuantityCode = updateDto.UnitOfQuantityCode,
            UnitPrice = updateDto.UnitPrice
        };

        if (updateDto.Article != null)
        {
            modelofDetailedDeclaration.ArticleId = updateDto.Article;
        }
        if (updateDto.CreatedAt != null)
        {
            modelofDetailedDeclaration.CreatedAt = updateDto.CreatedAt.Value;
        }
        if (updateDto.UpdatedAt != null)
        {
            modelofDetailedDeclaration.UpdatedAt = updateDto.UpdatedAt.Value;
        }

        return modelofDetailedDeclaration;
    }
}
