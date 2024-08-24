using Control.APIs.Dtos;
using Control.Infrastructure.Models;

namespace Control.APIs.Extensions;

public static class JournalsExtensions
{
    public static Journal ToDto(this JournalDbModel model)
    {
        return new Journal
        {
            CancellationRequests = model.CancellationRequests?.Select(x => x.Id).ToList(),
            CommonActiveGoodsRequests = model.CommonActiveGoodsRequests?.Select(x => x.Id).ToList(),
            CommonDetailedDeclaration = model.CommonDetailedDeclarationId,
            CommonOriginCertificateRequests = model
                .CommonOriginCertificateRequests?.Select(x => x.Id)
                .ToList(),
            CommonRegimeRequests = model.CommonRegimeRequests?.Select(x => x.Id).ToList(),
            CreatedAt = model.CreatedAt,
            ForeignOperatorRequests = model.ForeignOperatorRequests?.Select(x => x.Id).ToList(),
            Id = model.Id,
            UpdatedAt = model.UpdatedAt,
        };
    }

    public static JournalDbModel ToModel(
        this JournalUpdateInput updateDto,
        JournalWhereUniqueInput uniqueId
    )
    {
        var journal = new JournalDbModel { Id = uniqueId.Id };

        if (updateDto.CommonDetailedDeclaration != null)
        {
            journal.CommonDetailedDeclarationId = updateDto.CommonDetailedDeclaration;
        }
        if (updateDto.CreatedAt != null)
        {
            journal.CreatedAt = updateDto.CreatedAt.Value;
        }
        if (updateDto.UpdatedAt != null)
        {
            journal.UpdatedAt = updateDto.UpdatedAt.Value;
        }

        return journal;
    }
}
