using Traveler.APIs.Common;
using Traveler.APIs.Dtos;

namespace Traveler.APIs;

public interface IGeneralBondNotesService
{
    /// <summary>
    /// Create one GeneralBondNote
    /// </summary>
    public Task<GeneralBondNote> CreateGeneralBondNote(GeneralBondNoteCreateInput generalbondnote);

    /// <summary>
    /// Delete one GeneralBondNote
    /// </summary>
    public Task DeleteGeneralBondNote(GeneralBondNoteWhereUniqueInput uniqueId);

    /// <summary>
    /// Find many GeneralBondNotes
    /// </summary>
    public Task<List<GeneralBondNote>> GeneralBondNotes(GeneralBondNoteFindManyArgs findManyArgs);

    /// <summary>
    /// Meta data about GeneralBondNote records
    /// </summary>
    public Task<MetadataDto> GeneralBondNotesMeta(GeneralBondNoteFindManyArgs findManyArgs);

    /// <summary>
    /// Get one GeneralBondNote
    /// </summary>
    public Task<GeneralBondNote> GeneralBondNote(GeneralBondNoteWhereUniqueInput uniqueId);

    /// <summary>
    /// Update one GeneralBondNote
    /// </summary>
    public Task UpdateGeneralBondNote(
        GeneralBondNoteWhereUniqueInput uniqueId,
        GeneralBondNoteUpdateInput updateDto
    );

    /// <summary>
    /// Connect multiple Appeals records to GeneralBondNote
    /// </summary>
    public Task ConnectAppeals(
        GeneralBondNoteWhereUniqueInput uniqueId,
        AppealWhereUniqueInput[] appealsId
    );

    /// <summary>
    /// Disconnect multiple Appeals records from GeneralBondNote
    /// </summary>
    public Task DisconnectAppeals(
        GeneralBondNoteWhereUniqueInput uniqueId,
        AppealWhereUniqueInput[] appealsId
    );

    /// <summary>
    /// Find multiple Appeals records for GeneralBondNote
    /// </summary>
    public Task<List<Appeal>> FindAppeals(
        GeneralBondNoteWhereUniqueInput uniqueId,
        AppealFindManyArgs AppealFindManyArgs
    );

    /// <summary>
    /// Update multiple Appeals records for GeneralBondNote
    /// </summary>
    public Task UpdateAppeals(
        GeneralBondNoteWhereUniqueInput uniqueId,
        AppealWhereUniqueInput[] appealsId
    );

    /// <summary>
    /// Connect multiple GeneralTravelerInformationTpds records to GeneralBondNote
    /// </summary>
    public Task ConnectGeneralTravelerInformationTpds(
        GeneralBondNoteWhereUniqueInput uniqueId,
        GeneralTravelerInformationTpdWhereUniqueInput[] generalTravelerInformationTpdsId
    );

    /// <summary>
    /// Disconnect multiple GeneralTravelerInformationTpds records from GeneralBondNote
    /// </summary>
    public Task DisconnectGeneralTravelerInformationTpds(
        GeneralBondNoteWhereUniqueInput uniqueId,
        GeneralTravelerInformationTpdWhereUniqueInput[] generalTravelerInformationTpdsId
    );

    /// <summary>
    /// Find multiple GeneralTravelerInformationTpds records for GeneralBondNote
    /// </summary>
    public Task<List<GeneralTravelerInformationTpd>> FindGeneralTravelerInformationTpds(
        GeneralBondNoteWhereUniqueInput uniqueId,
        GeneralTravelerInformationTpdFindManyArgs GeneralTravelerInformationTpdFindManyArgs
    );

    /// <summary>
    /// Update multiple GeneralTravelerInformationTpds records for GeneralBondNote
    /// </summary>
    public Task UpdateGeneralTravelerInformationTpds(
        GeneralBondNoteWhereUniqueInput uniqueId,
        GeneralTravelerInformationTpdWhereUniqueInput[] generalTravelerInformationTpdsId
    );
}
