using Traveler.APIs.Dtos;
using Traveler.Infrastructure.Models;

namespace Traveler.APIs.Extensions;

public static class GeneralBondNotesExtensions
{
    public static GeneralBondNote ToDto(this GeneralBondNoteDbModel model)
    {
        return new GeneralBondNote
        {
            Appeals = model.Appeals?.Select(x => x.Id).ToList(),
            CreatedAt = model.CreatedAt,
            GeneralTravelerInformationTpds = model
                .GeneralTravelerInformationTpds?.Select(x => x.Id)
                .ToList(),
            Id = model.Id,
            UpdatedAt = model.UpdatedAt,
        };
    }

    public static GeneralBondNoteDbModel ToModel(
        this GeneralBondNoteUpdateInput updateDto,
        GeneralBondNoteWhereUniqueInput uniqueId
    )
    {
        var generalBondNote = new GeneralBondNoteDbModel { Id = uniqueId.Id };

        if (updateDto.CreatedAt != null)
        {
            generalBondNote.CreatedAt = updateDto.CreatedAt.Value;
        }
        if (updateDto.UpdatedAt != null)
        {
            generalBondNote.UpdatedAt = updateDto.UpdatedAt.Value;
        }

        return generalBondNote;
    }
}
