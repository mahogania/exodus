using Control.APIs.Dtos;
using Control.Infrastructure.Models;

namespace Control.APIs.Extensions;

public static class JointDocumentsExtensions
{
    public static JointDocument ToDto(this JointDocumentDbModel model)
    {
        return new JointDocument
        {
            CommonDetailedDeclaration = model.CommonDetailedDeclaration?.ToDto(),
            CreatedAt = model.CreatedAt,
            Id = model.Id,
            UpdatedAt = model.UpdatedAt,
        };
    }

    public static JointDocumentDbModel ToModel(
        this JointDocumentUpdateInput updateDto,
        JointDocumentWhereUniqueInput uniqueId
    )
    {
        var jointDocument = new JointDocumentDbModel { Id = uniqueId.Id };

        if (updateDto.CreatedAt != null)
        {
            jointDocument.CreatedAt = updateDto.CreatedAt.Value;
        }
        if (updateDto.UpdatedAt != null)
        {
            jointDocument.UpdatedAt = updateDto.UpdatedAt.Value;
        }

        return jointDocument;
    }
}
