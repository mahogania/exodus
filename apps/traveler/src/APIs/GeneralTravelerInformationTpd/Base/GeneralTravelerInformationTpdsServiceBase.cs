using Microsoft.EntityFrameworkCore;
using Traveler.APIs;
using Traveler.APIs.Common;
using Traveler.APIs.Dtos;
using Traveler.APIs.Errors;
using Traveler.APIs.Extensions;
using Traveler.Infrastructure;
using Traveler.Infrastructure.Models;

namespace Traveler.APIs;

public abstract class GeneralTravelerInformationTpdsServiceBase
    : IGeneralTravelerInformationTpdsService
{
    protected readonly TravelerDbContext _context;

    public GeneralTravelerInformationTpdsServiceBase(TravelerDbContext context)
    {
        _context = context;
    }

    /// <summary>
    /// Create one GeneralTravelerInformationTpd
    /// </summary>
    public async Task<GeneralTravelerInformationTpd> CreateGeneralTravelerInformationTpd(
        GeneralTravelerInformationTpdCreateInput createDto
    )
    {
        var generalTravelerInformationTpd = new GeneralTravelerInformationTpdDbModel
        {
            CommanderNationalityCode = createDto.CommanderNationalityCode,
            CreatedAt = createDto.CreatedAt,
            DeletionOn = createDto.DeletionOn,
            DriverAddress = createDto.DriverAddress,
            DriverDateOfBirth = createDto.DriverDateOfBirth,
            DriverFatherFullName = createDto.DriverFatherFullName,
            DriverFirstName = createDto.DriverFirstName,
            DriverForeignAddress = createDto.DriverForeignAddress,
            DriverLastName = createDto.DriverLastName,
            DriverMotherFullName = createDto.DriverMotherFullName,
            DriverOccupation = createDto.DriverOccupation,
            DriverPassportIssuanceDate = createDto.DriverPassportIssuanceDate,
            DriverPassportIssuancePlace = createDto.DriverPassportIssuancePlace,
            DriverPassportNumber = createDto.DriverPassportNumber,
            DriverPlaceOfBirth = createDto.DriverPlaceOfBirth,
            DriverTypeCode = createDto.DriverTypeCode,
            DriverZipCode = createDto.DriverZipCode,
            FinalModificationDateAndTime = createDto.FinalModificationDateAndTime,
            FirstRegistrationDateAndTime = createDto.FirstRegistrationDateAndTime,
            OwnerAddress = createDto.OwnerAddress,
            OwnerCountryCode = createDto.OwnerCountryCode,
            OwnerDateOfBirth = createDto.OwnerDateOfBirth,
            OwnerFatherFullName = createDto.OwnerFatherFullName,
            OwnerFirstName = createDto.OwnerFirstName,
            OwnerForeignAddress = createDto.OwnerForeignAddress,
            OwnerLastName = createDto.OwnerLastName,
            OwnerMotherFullName = createDto.OwnerMotherFullName,
            OwnerOccupation = createDto.OwnerOccupation,
            OwnerPassportIssuanceDate = createDto.OwnerPassportIssuanceDate,
            OwnerPassportIssuancePlace = createDto.OwnerPassportIssuancePlace,
            OwnerPassportNumber = createDto.OwnerPassportNumber,
            OwnerPlaceOfBirth = createDto.OwnerPlaceOfBirth,
            OwnerZipCode = createDto.OwnerZipCode,
            ProvisionalTpdNumber = createDto.ProvisionalTpdNumber,
            UpdatedAt = createDto.UpdatedAt
        };

        if (createDto.Id != null)
        {
            generalTravelerInformationTpd.Id = createDto.Id;
        }
        if (createDto.AccompaniedBaggageEntryAndExit != null)
        {
            generalTravelerInformationTpd.AccompaniedBaggageEntryAndExit = await _context
                .AccompaniedBaggageEntryAndExits.Where(accompaniedBaggageEntryAndExit =>
                    createDto.AccompaniedBaggageEntryAndExit.Id == accompaniedBaggageEntryAndExit.Id
                )
                .FirstOrDefaultAsync();
        }

        if (createDto.Appeal != null)
        {
            generalTravelerInformationTpd.Appeal = await _context
                .Appeals.Where(appeal => createDto.Appeal.Id == appeal.Id)
                .FirstOrDefaultAsync();
        }

        if (createDto.BaggageControlArticle != null)
        {
            generalTravelerInformationTpd.BaggageControlArticle = await _context
                .BaggageControlArticles.Where(baggageControlArticle =>
                    createDto.BaggageControlArticle.Id == baggageControlArticle.Id
                )
                .FirstOrDefaultAsync();
        }

        if (createDto.ExitVoucher != null)
        {
            generalTravelerInformationTpd.ExitVoucher = await _context
                .ExitVouchers.Where(exitVoucher => createDto.ExitVoucher.Id == exitVoucher.Id)
                .FirstOrDefaultAsync();
        }

        if (createDto.GeneralBondNote != null)
        {
            generalTravelerInformationTpd.GeneralBondNote = await _context
                .GeneralBondNotes.Where(generalBondNote =>
                    createDto.GeneralBondNote.Id == generalBondNote.Id
                )
                .FirstOrDefaultAsync();
        }

        if (createDto.ImportDeclaration != null)
        {
            generalTravelerInformationTpd.ImportDeclaration = await _context
                .ImportDeclarations.Where(importDeclaration =>
                    createDto.ImportDeclaration.Id == importDeclaration.Id
                )
                .FirstOrDefaultAsync();
        }

        if (createDto.InspectorRatingModificationHistory != null)
        {
            generalTravelerInformationTpd.InspectorRatingModificationHistory = await _context
                .InspectorRatingModificationHistories.Where(inspectorRatingModificationHistory =>
                    createDto.InspectorRatingModificationHistory.Id
                    == inspectorRatingModificationHistory.Id
                )
                .FirstOrDefaultAsync();
        }

        if (createDto.TpdControl != null)
        {
            generalTravelerInformationTpd.TpdControl = await _context
                .TpdControls.Where(tpdControl => createDto.TpdControl.Id == tpdControl.Id)
                .FirstOrDefaultAsync();
        }

        if (createDto.TpdEntryAndExitHistory != null)
        {
            generalTravelerInformationTpd.TpdEntryAndExitHistory = await _context
                .TpdEntryAndExitHistories.Where(tpdEntryAndExitHistory =>
                    createDto.TpdEntryAndExitHistory.Id == tpdEntryAndExitHistory.Id
                )
                .FirstOrDefaultAsync();
        }

        if (createDto.TpdVehicle != null)
        {
            generalTravelerInformationTpd.TpdVehicle = await _context
                .TpdVehicles.Where(tpdVehicle => createDto.TpdVehicle.Id == tpdVehicle.Id)
                .FirstOrDefaultAsync();
        }

        if (createDto.TravelerSearchHistory != null)
        {
            generalTravelerInformationTpd.TravelerSearchHistory = await _context
                .TravelerSearchHistories.Where(travelerSearchHistory =>
                    createDto.TravelerSearchHistory.Id == travelerSearchHistory.Id
                )
                .FirstOrDefaultAsync();
        }

        if (createDto.TravelersArticlesEntryExit != null)
        {
            generalTravelerInformationTpd.TravelersArticlesEntryExit = await _context
                .TravelersArticlesEntryExits.Where(travelersArticlesEntryExit =>
                    createDto.TravelersArticlesEntryExit.Id == travelersArticlesEntryExit.Id
                )
                .FirstOrDefaultAsync();
        }

        _context.GeneralTravelerInformationTpds.Add(generalTravelerInformationTpd);
        await _context.SaveChangesAsync();

        var result = await _context.FindAsync<GeneralTravelerInformationTpdDbModel>(
            generalTravelerInformationTpd.Id
        );

        if (result == null)
        {
            throw new NotFoundException();
        }

        return result.ToDto();
    }

    /// <summary>
    /// Delete one GeneralTravelerInformationTpd
    /// </summary>
    public async Task DeleteGeneralTravelerInformationTpd(
        GeneralTravelerInformationTpdWhereUniqueInput uniqueId
    )
    {
        var generalTravelerInformationTpd = await _context.GeneralTravelerInformationTpds.FindAsync(
            uniqueId.Id
        );
        if (generalTravelerInformationTpd == null)
        {
            throw new NotFoundException();
        }

        _context.GeneralTravelerInformationTpds.Remove(generalTravelerInformationTpd);
        await _context.SaveChangesAsync();
    }

    /// <summary>
    /// Find many GeneralTravelerInformationTpds
    /// </summary>
    public async Task<List<GeneralTravelerInformationTpd>> GeneralTravelerInformationTpds(
        GeneralTravelerInformationTpdFindManyArgs findManyArgs
    )
    {
        var generalTravelerInformationTpds = await _context
            .GeneralTravelerInformationTpds.Include(x => x.TpdEntryAndExitHistory)
            .Include(x => x.TpdControl)
            .Include(x => x.TpdVehicle)
            .Include(x => x.ExitVoucher)
            .Include(x => x.AccompaniedBaggageEntryAndExit)
            .Include(x => x.Appeal)
            .Include(x => x.TravelersArticlesEntryExit)
            .Include(x => x.InspectorRatingModificationHistory)
            .Include(x => x.BaggageControlArticle)
            .Include(x => x.ImportDeclaration)
            .Include(x => x.GeneralBondNote)
            .Include(x => x.TravelerSearchHistory)
            .ApplyWhere(findManyArgs.Where)
            .ApplySkip(findManyArgs.Skip)
            .ApplyTake(findManyArgs.Take)
            .ApplyOrderBy(findManyArgs.SortBy)
            .ToListAsync();
        return generalTravelerInformationTpds.ConvertAll(generalTravelerInformationTpd =>
            generalTravelerInformationTpd.ToDto()
        );
    }

    /// <summary>
    /// Meta data about GeneralTravelerInformationTpd records
    /// </summary>
    public async Task<MetadataDto> GeneralTravelerInformationTpdsMeta(
        GeneralTravelerInformationTpdFindManyArgs findManyArgs
    )
    {
        var count = await _context
            .GeneralTravelerInformationTpds.ApplyWhere(findManyArgs.Where)
            .CountAsync();

        return new MetadataDto { Count = count };
    }

    /// <summary>
    /// Get one GeneralTravelerInformationTpd
    /// </summary>
    public async Task<GeneralTravelerInformationTpd> GeneralTravelerInformationTpd(
        GeneralTravelerInformationTpdWhereUniqueInput uniqueId
    )
    {
        var generalTravelerInformationTpds = await this.GeneralTravelerInformationTpds(
            new GeneralTravelerInformationTpdFindManyArgs
            {
                Where = new GeneralTravelerInformationTpdWhereInput { Id = uniqueId.Id }
            }
        );
        var generalTravelerInformationTpd = generalTravelerInformationTpds.FirstOrDefault();
        if (generalTravelerInformationTpd == null)
        {
            throw new NotFoundException();
        }

        return generalTravelerInformationTpd;
    }

    /// <summary>
    /// Update one GeneralTravelerInformationTpd
    /// </summary>
    public async Task UpdateGeneralTravelerInformationTpd(
        GeneralTravelerInformationTpdWhereUniqueInput uniqueId,
        GeneralTravelerInformationTpdUpdateInput updateDto
    )
    {
        var generalTravelerInformationTpd = updateDto.ToModel(uniqueId);

        _context.Entry(generalTravelerInformationTpd).State = EntityState.Modified;

        try
        {
            await _context.SaveChangesAsync();
        }
        catch (DbUpdateConcurrencyException)
        {
            if (
                !_context.GeneralTravelerInformationTpds.Any(e =>
                    e.Id == generalTravelerInformationTpd.Id
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

    /// <summary>
    /// Get a Accompanied Baggage Entry and Exit record for GeneralTravelerInformationTpd
    /// </summary>
    public async Task<AccompaniedBaggageEntryAndExit> GetAccompaniedBaggageEntryAndExit(
        GeneralTravelerInformationTpdWhereUniqueInput uniqueId
    )
    {
        var generalTravelerInformationTpd = await _context
            .GeneralTravelerInformationTpds.Where(generalTravelerInformationTpd =>
                generalTravelerInformationTpd.Id == uniqueId.Id
            )
            .Include(generalTravelerInformationTpd =>
                generalTravelerInformationTpd.AccompaniedBaggageEntryAndExit
            )
            .FirstOrDefaultAsync();
        if (generalTravelerInformationTpd == null)
        {
            throw new NotFoundException();
        }
        return generalTravelerInformationTpd.AccompaniedBaggageEntryAndExit.ToDto();
    }

    /// <summary>
    /// Get a Appeal record for GeneralTravelerInformationTpd
    /// </summary>
    public async Task<Appeal> GetAppeal(GeneralTravelerInformationTpdWhereUniqueInput uniqueId)
    {
        var generalTravelerInformationTpd = await _context
            .GeneralTravelerInformationTpds.Where(generalTravelerInformationTpd =>
                generalTravelerInformationTpd.Id == uniqueId.Id
            )
            .Include(generalTravelerInformationTpd => generalTravelerInformationTpd.Appeal)
            .FirstOrDefaultAsync();
        if (generalTravelerInformationTpd == null)
        {
            throw new NotFoundException();
        }
        return generalTravelerInformationTpd.Appeal.ToDto();
    }

    /// <summary>
    /// Get a Baggage Control Article record for GeneralTravelerInformationTpd
    /// </summary>
    public async Task<BaggageControlArticle> GetBaggageControlArticle(
        GeneralTravelerInformationTpdWhereUniqueInput uniqueId
    )
    {
        var generalTravelerInformationTpd = await _context
            .GeneralTravelerInformationTpds.Where(generalTravelerInformationTpd =>
                generalTravelerInformationTpd.Id == uniqueId.Id
            )
            .Include(generalTravelerInformationTpd =>
                generalTravelerInformationTpd.BaggageControlArticle
            )
            .FirstOrDefaultAsync();
        if (generalTravelerInformationTpd == null)
        {
            throw new NotFoundException();
        }
        return generalTravelerInformationTpd.BaggageControlArticle.ToDto();
    }

    /// <summary>
    /// Get a Exit Voucher record for GeneralTravelerInformationTpd
    /// </summary>
    public async Task<ExitVoucher> GetExitVoucher(
        GeneralTravelerInformationTpdWhereUniqueInput uniqueId
    )
    {
        var generalTravelerInformationTpd = await _context
            .GeneralTravelerInformationTpds.Where(generalTravelerInformationTpd =>
                generalTravelerInformationTpd.Id == uniqueId.Id
            )
            .Include(generalTravelerInformationTpd => generalTravelerInformationTpd.ExitVoucher)
            .FirstOrDefaultAsync();
        if (generalTravelerInformationTpd == null)
        {
            throw new NotFoundException();
        }
        return generalTravelerInformationTpd.ExitVoucher.ToDto();
    }

    /// <summary>
    /// Get a General Bond Note record for GeneralTravelerInformationTpd
    /// </summary>
    public async Task<GeneralBondNote> GetGeneralBondNote(
        GeneralTravelerInformationTpdWhereUniqueInput uniqueId
    )
    {
        var generalTravelerInformationTpd = await _context
            .GeneralTravelerInformationTpds.Where(generalTravelerInformationTpd =>
                generalTravelerInformationTpd.Id == uniqueId.Id
            )
            .Include(generalTravelerInformationTpd => generalTravelerInformationTpd.GeneralBondNote)
            .FirstOrDefaultAsync();
        if (generalTravelerInformationTpd == null)
        {
            throw new NotFoundException();
        }
        return generalTravelerInformationTpd.GeneralBondNote.ToDto();
    }

    /// <summary>
    /// Get a Import Declaration record for GeneralTravelerInformationTpd
    /// </summary>
    public async Task<ImportDeclaration> GetImportDeclaration(
        GeneralTravelerInformationTpdWhereUniqueInput uniqueId
    )
    {
        var generalTravelerInformationTpd = await _context
            .GeneralTravelerInformationTpds.Where(generalTravelerInformationTpd =>
                generalTravelerInformationTpd.Id == uniqueId.Id
            )
            .Include(generalTravelerInformationTpd =>
                generalTravelerInformationTpd.ImportDeclaration
            )
            .FirstOrDefaultAsync();
        if (generalTravelerInformationTpd == null)
        {
            throw new NotFoundException();
        }
        return generalTravelerInformationTpd.ImportDeclaration.ToDto();
    }

    /// <summary>
    /// Get a Inspector Rating Modification History record for GeneralTravelerInformationTpd
    /// </summary>
    public async Task<InspectorRatingModificationHistory> GetInspectorRatingModificationHistory(
        GeneralTravelerInformationTpdWhereUniqueInput uniqueId
    )
    {
        var generalTravelerInformationTpd = await _context
            .GeneralTravelerInformationTpds.Where(generalTravelerInformationTpd =>
                generalTravelerInformationTpd.Id == uniqueId.Id
            )
            .Include(generalTravelerInformationTpd =>
                generalTravelerInformationTpd.InspectorRatingModificationHistory
            )
            .FirstOrDefaultAsync();
        if (generalTravelerInformationTpd == null)
        {
            throw new NotFoundException();
        }
        return generalTravelerInformationTpd.InspectorRatingModificationHistory.ToDto();
    }

    /// <summary>
    /// Get a TPD Control record for GeneralTravelerInformationTpd
    /// </summary>
    public async Task<TpdControl> GetTpdControl(
        GeneralTravelerInformationTpdWhereUniqueInput uniqueId
    )
    {
        var generalTravelerInformationTpd = await _context
            .GeneralTravelerInformationTpds.Where(generalTravelerInformationTpd =>
                generalTravelerInformationTpd.Id == uniqueId.Id
            )
            .Include(generalTravelerInformationTpd => generalTravelerInformationTpd.TpdControl)
            .FirstOrDefaultAsync();
        if (generalTravelerInformationTpd == null)
        {
            throw new NotFoundException();
        }
        return generalTravelerInformationTpd.TpdControl.ToDto();
    }

    /// <summary>
    /// Get a TPD Entry and Exit History record for GeneralTravelerInformationTpd
    /// </summary>
    public async Task<TpdEntryAndExitHistory> GetTpdEntryAndExitHistory(
        GeneralTravelerInformationTpdWhereUniqueInput uniqueId
    )
    {
        var generalTravelerInformationTpd = await _context
            .GeneralTravelerInformationTpds.Where(generalTravelerInformationTpd =>
                generalTravelerInformationTpd.Id == uniqueId.Id
            )
            .Include(generalTravelerInformationTpd =>
                generalTravelerInformationTpd.TpdEntryAndExitHistory
            )
            .FirstOrDefaultAsync();
        if (generalTravelerInformationTpd == null)
        {
            throw new NotFoundException();
        }
        return generalTravelerInformationTpd.TpdEntryAndExitHistory.ToDto();
    }

    /// <summary>
    /// Get a TPD Vehicle record for GeneralTravelerInformationTpd
    /// </summary>
    public async Task<TpdVehicle> GetTpdVehicle(
        GeneralTravelerInformationTpdWhereUniqueInput uniqueId
    )
    {
        var generalTravelerInformationTpd = await _context
            .GeneralTravelerInformationTpds.Where(generalTravelerInformationTpd =>
                generalTravelerInformationTpd.Id == uniqueId.Id
            )
            .Include(generalTravelerInformationTpd => generalTravelerInformationTpd.TpdVehicle)
            .FirstOrDefaultAsync();
        if (generalTravelerInformationTpd == null)
        {
            throw new NotFoundException();
        }
        return generalTravelerInformationTpd.TpdVehicle.ToDto();
    }

    /// <summary>
    /// Get a Traveler Search History record for GeneralTravelerInformationTpd
    /// </summary>
    public async Task<TravelerSearchHistory> GetTravelerSearchHistory(
        GeneralTravelerInformationTpdWhereUniqueInput uniqueId
    )
    {
        var generalTravelerInformationTpd = await _context
            .GeneralTravelerInformationTpds.Where(generalTravelerInformationTpd =>
                generalTravelerInformationTpd.Id == uniqueId.Id
            )
            .Include(generalTravelerInformationTpd =>
                generalTravelerInformationTpd.TravelerSearchHistory
            )
            .FirstOrDefaultAsync();
        if (generalTravelerInformationTpd == null)
        {
            throw new NotFoundException();
        }
        return generalTravelerInformationTpd.TravelerSearchHistory.ToDto();
    }

    /// <summary>
    /// Get a Travelers Articles Entry Exit record for GeneralTravelerInformationTpd
    /// </summary>
    public async Task<TravelersArticlesEntryExit> GetTravelersArticlesEntryExit(
        GeneralTravelerInformationTpdWhereUniqueInput uniqueId
    )
    {
        var generalTravelerInformationTpd = await _context
            .GeneralTravelerInformationTpds.Where(generalTravelerInformationTpd =>
                generalTravelerInformationTpd.Id == uniqueId.Id
            )
            .Include(generalTravelerInformationTpd =>
                generalTravelerInformationTpd.TravelersArticlesEntryExit
            )
            .FirstOrDefaultAsync();
        if (generalTravelerInformationTpd == null)
        {
            throw new NotFoundException();
        }
        return generalTravelerInformationTpd.TravelersArticlesEntryExit.ToDto();
    }
}
