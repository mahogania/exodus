using Control.APIs;
using Control.APIs.Common;
using Control.APIs.Dtos;
using Control.APIs.Errors;
using Control.APIs.Extensions;
using Control.Infrastructure;
using Control.Infrastructure.Models;
using Microsoft.EntityFrameworkCore;

namespace Control.APIs;

public abstract class MacSubjectToAuthorizationsServiceBase : IMacSubjectToAuthorizationsService
{
    protected readonly ControlDbContext _context;

    public MacSubjectToAuthorizationsServiceBase(ControlDbContext context)
    {
        _context = context;
    }

    /// <summary>
    /// Create one MAC SUBJECT TO AUTHORIZATION
    /// </summary>
    public async Task<MacSubjectToAuthorization> CreateMacSubjectToAuthorization(
        MacSubjectToAuthorizationCreateInput createDto
    )
    {
        var macSubjectToAuthorization = new MacSubjectToAuthorizationDbModel
        {
            ApcCode = createDto.ApcCode,
            ApcLabel = createDto.ApcLabel,
            ArticleNumber = createDto.ArticleNumber,
            CountryOfDestination = createDto.CountryOfDestination,
            CountryOfOrigin = createDto.CountryOfOrigin,
            CreatedAt = createDto.CreatedAt,
            CustomsOfficeForMacClearance = createDto.CustomsOfficeForMacClearance,
            DateAndTimeOfFinalModification = createDto.DateAndTimeOfFinalModification,
            DateAndTimeOfFirstRegistration = createDto.DateAndTimeOfFirstRegistration,
            DeclarationOfficeCode = createDto.DeclarationOfficeCode,
            EpcCode = createDto.EpcCode,
            EpcLabel = createDto.EpcLabel,
            FinalModifierSId = createDto.FinalModifierSId,
            FirstRegistrantSId = createDto.FirstRegistrantSId,
            PreviousDeclarationDate = createDto.PreviousDeclarationDate,
            PreviousDeclarationNumber = createDto.PreviousDeclarationNumber,
            ReasonForTheRequest = createDto.ReasonForTheRequest,
            RecipientSupplier = createDto.RecipientSupplier,
            RectificationFrequency = createDto.RectificationFrequency,
            RegimeRequestNumber = createDto.RegimeRequestNumber,
            SuppressionOn = createDto.SuppressionOn,
            UpdatedAt = createDto.UpdatedAt
        };

        if (createDto.Id != null)
        {
            macSubjectToAuthorization.Id = createDto.Id;
        }

        _context.MacSubjectToAuthorizations.Add(macSubjectToAuthorization);
        await _context.SaveChangesAsync();

        var result = await _context.FindAsync<MacSubjectToAuthorizationDbModel>(
            macSubjectToAuthorization.Id
        );

        if (result == null)
        {
            throw new NotFoundException();
        }

        return result.ToDto();
    }

    /// <summary>
    /// Delete one MAC SUBJECT TO AUTHORIZATION
    /// </summary>
    public async Task DeleteMacSubjectToAuthorization(
        MacSubjectToAuthorizationWhereUniqueInput uniqueId
    )
    {
        var macSubjectToAuthorization = await _context.MacSubjectToAuthorizations.FindAsync(
            uniqueId.Id
        );
        if (macSubjectToAuthorization == null)
        {
            throw new NotFoundException();
        }

        _context.MacSubjectToAuthorizations.Remove(macSubjectToAuthorization);
        await _context.SaveChangesAsync();
    }

    /// <summary>
    /// Find many MAC SUBJECT TO AUTHORIZATIONS
    /// </summary>
    public async Task<List<MacSubjectToAuthorization>> MacSubjectToAuthorizations(
        MacSubjectToAuthorizationFindManyArgs findManyArgs
    )
    {
        var macSubjectToAuthorizations = await _context
            .MacSubjectToAuthorizations.ApplyWhere(findManyArgs.Where)
            .ApplySkip(findManyArgs.Skip)
            .ApplyTake(findManyArgs.Take)
            .ApplyOrderBy(findManyArgs.SortBy)
            .ToListAsync();
        return macSubjectToAuthorizations.ConvertAll(macSubjectToAuthorization =>
            macSubjectToAuthorization.ToDto()
        );
    }

    /// <summary>
    /// Meta data about MAC SUBJECT TO AUTHORIZATION records
    /// </summary>
    public async Task<MetadataDto> MacSubjectToAuthorizationsMeta(
        MacSubjectToAuthorizationFindManyArgs findManyArgs
    )
    {
        var count = await _context
            .MacSubjectToAuthorizations.ApplyWhere(findManyArgs.Where)
            .CountAsync();

        return new MetadataDto { Count = count };
    }

    /// <summary>
    /// Get one MAC SUBJECT TO AUTHORIZATION
    /// </summary>
    public async Task<MacSubjectToAuthorization> MacSubjectToAuthorization(
        MacSubjectToAuthorizationWhereUniqueInput uniqueId
    )
    {
        var macSubjectToAuthorizations = await this.MacSubjectToAuthorizations(
            new MacSubjectToAuthorizationFindManyArgs
            {
                Where = new MacSubjectToAuthorizationWhereInput { Id = uniqueId.Id }
            }
        );
        var macSubjectToAuthorization = macSubjectToAuthorizations.FirstOrDefault();
        if (macSubjectToAuthorization == null)
        {
            throw new NotFoundException();
        }

        return macSubjectToAuthorization;
    }

    /// <summary>
    /// Update one MAC SUBJECT TO AUTHORIZATION
    /// </summary>
    public async Task UpdateMacSubjectToAuthorization(
        MacSubjectToAuthorizationWhereUniqueInput uniqueId,
        MacSubjectToAuthorizationUpdateInput updateDto
    )
    {
        var macSubjectToAuthorization = updateDto.ToModel(uniqueId);

        _context.Entry(macSubjectToAuthorization).State = EntityState.Modified;

        try
        {
            await _context.SaveChangesAsync();
        }
        catch (DbUpdateConcurrencyException)
        {
            if (!_context.MacSubjectToAuthorizations.Any(e => e.Id == macSubjectToAuthorization.Id))
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
