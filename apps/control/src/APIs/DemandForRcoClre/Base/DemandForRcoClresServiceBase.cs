using Control.APIs;
using Control.APIs.Common;
using Control.APIs.Dtos;
using Control.APIs.Errors;
using Control.APIs.Extensions;
using Control.Infrastructure;
using Control.Infrastructure.Models;
using Microsoft.EntityFrameworkCore;

namespace Control.APIs;

public abstract class DemandForRcoClresServiceBase : IDemandForRcoClresService
{
    protected readonly ControlDbContext _context;

    public DemandForRcoClresServiceBase(ControlDbContext context)
    {
        _context = context;
    }

    /// <summary>
    /// Create one Demand for RCO | CLRE
    /// </summary>
    public async Task<DemandForRcoClre> CreateDemandForRcoClre(
        DemandForRcoClreCreateInput createDto
    )
    {
        var demandForRcoClre = new DemandForRcoClreDbModel
        {
            AdditionalInformationOfGoods = createDto.AdditionalInformationOfGoods,
            BrochuresOn = createDto.BrochuresOn,
            ContentsOfThePreviousAdvanceDecision = createDto.ContentsOfThePreviousAdvanceDecision,
            CreatedAt = createDto.CreatedAt,
            DateAndTimeOfFinalModification = createDto.DateAndTimeOfFinalModification,
            DateAndTimeOfFirstRegistration = createDto.DateAndTimeOfFirstRegistration,
            DateOfRequest = createDto.DateOfRequest,
            DeclarantSAddress = createDto.DeclarantSAddress,
            DeclarantSCode = createDto.DeclarantSCode,
            DeclarantSName = createDto.DeclarantSName,
            DescriptionOfMerchandiseProduction = createDto.DescriptionOfMerchandiseProduction,
            DescriptionOfOtherRequests = createDto.DescriptionOfOtherRequests,
            DescriptionOn = createDto.DescriptionOn,
            DesignationOfGoods = createDto.DesignationOfGoods,
            ExporterCountryCode = createDto.ExporterCountryCode,
            FinalModifierSId = createDto.FinalModifierSId,
            FinalOn = createDto.FinalOn,
            FirstRegistrantSId = createDto.FirstRegistrantSId,
            HolderSAddress = createDto.HolderSAddress,
            HolderSeMail = createDto.HolderSeMail,
            HolderSTelNo = createDto.HolderSTelNo,
            IdOfTheBrochureAttachment = createDto.IdOfTheBrochureAttachment,
            IdOfTheExplanationAttachment = createDto.IdOfTheExplanationAttachment,
            IdOfTheManualAttachment = createDto.IdOfTheManualAttachment,
            IdOfTheOtherAttachment = createDto.IdOfTheOtherAttachment,
            IdOfThePhotoAttachment = createDto.IdOfThePhotoAttachment,
            IdOfTheReportAttachment = createDto.IdOfTheReportAttachment,
            ImportCountryCode = createDto.ImportCountryCode,
            InformantSeMail = createDto.InformantSeMail,
            NameAndFirstNameSOrBusinessName = createDto.NameAndFirstNameSOrBusinessName,
            OeaNo = createDto.OeaNo,
            OriginCountryCode = createDto.OriginCountryCode,
            OthersOn = createDto.OthersOn,
            PhotographsOn = createDto.PhotographsOn,
            PreferentialAgreementCode = createDto.PreferentialAgreementCode,
            PreferentialOriginOn = createDto.PreferentialOriginOn,
            PreviousAdvanceDecisionOn = createDto.PreviousAdvanceDecisionOn,
            RcoRequestNumber = createDto.RcoRequestNumber,
            RectificationFrequency = createDto.RectificationFrequency,
            ReferenceOfThePreviousRco = createDto.ReferenceOfThePreviousRco,
            ReissueOfAnRco = createDto.ReissueOfAnRco,
            ReissueOfAnRtcOn = createDto.ReissueOfAnRtcOn,
            ReportsExpertisePvOn = createDto.ReportsExpertisePvOn,
            RuleToConsiderOfRco = createDto.RuleToConsiderOfRco,
            SameJudgmentContent = createDto.SameJudgmentContent,
            ShCode = createDto.ShCode,
            SuppressionOn = createDto.SuppressionOn,
            TaxIdentificationNumber = createDto.TaxIdentificationNumber,
            TaxIdentificationNumberHolder = createDto.TaxIdentificationNumberHolder,
            TelNoOfTheInformant = createDto.TelNoOfTheInformant,
            ThatTheSameJudgment = createDto.ThatTheSameJudgment,
            TradeRegisterNumber = createDto.TradeRegisterNumber,
            TradeRegisterNumberHolder = createDto.TradeRegisterNumberHolder,
            TypeOfOperation = createDto.TypeOfOperation,
            UpdatedAt = createDto.UpdatedAt,
            UserGuideOn = createDto.UserGuideOn,
            VerificationOfWritingOfInformationYn = createDto.VerificationOfWritingOfInformationYn,
            ZipcodeApplicant = createDto.ZipcodeApplicant,
            ZipcodeHolder = createDto.ZipcodeHolder
        };

        if (createDto.Id != null)
        {
            demandForRcoClre.Id = createDto.Id;
        }

        _context.DemandForRcoClres.Add(demandForRcoClre);
        await _context.SaveChangesAsync();

        var result = await _context.FindAsync<DemandForRcoClreDbModel>(demandForRcoClre.Id);

        if (result == null)
        {
            throw new NotFoundException();
        }

        return result.ToDto();
    }

    /// <summary>
    /// Delete one Demand for RCO | CLRE
    /// </summary>
    public async Task DeleteDemandForRcoClre(DemandForRcoClreWhereUniqueInput uniqueId)
    {
        var demandForRcoClre = await _context.DemandForRcoClres.FindAsync(uniqueId.Id);
        if (demandForRcoClre == null)
        {
            throw new NotFoundException();
        }

        _context.DemandForRcoClres.Remove(demandForRcoClre);
        await _context.SaveChangesAsync();
    }

    /// <summary>
    /// Find many Demand for RCO | CLRES
    /// </summary>
    public async Task<List<DemandForRcoClre>> DemandForRcoClres(
        DemandForRcoClreFindManyArgs findManyArgs
    )
    {
        var demandForRcoClres = await _context
            .DemandForRcoClres.ApplyWhere(findManyArgs.Where)
            .ApplySkip(findManyArgs.Skip)
            .ApplyTake(findManyArgs.Take)
            .ApplyOrderBy(findManyArgs.SortBy)
            .ToListAsync();
        return demandForRcoClres.ConvertAll(demandForRcoClre => demandForRcoClre.ToDto());
    }

    /// <summary>
    /// Meta data about Demand for RCO | CLRE records
    /// </summary>
    public async Task<MetadataDto> DemandForRcoClresMeta(DemandForRcoClreFindManyArgs findManyArgs)
    {
        var count = await _context.DemandForRcoClres.ApplyWhere(findManyArgs.Where).CountAsync();

        return new MetadataDto { Count = count };
    }

    /// <summary>
    /// Get one Demand for RCO | CLRE
    /// </summary>
    public async Task<DemandForRcoClre> DemandForRcoClre(DemandForRcoClreWhereUniqueInput uniqueId)
    {
        var demandForRcoClres = await this.DemandForRcoClres(
            new DemandForRcoClreFindManyArgs
            {
                Where = new DemandForRcoClreWhereInput { Id = uniqueId.Id }
            }
        );
        var demandForRcoClre = demandForRcoClres.FirstOrDefault();
        if (demandForRcoClre == null)
        {
            throw new NotFoundException();
        }

        return demandForRcoClre;
    }

    /// <summary>
    /// Update one Demand for RCO | CLRE
    /// </summary>
    public async Task UpdateDemandForRcoClre(
        DemandForRcoClreWhereUniqueInput uniqueId,
        DemandForRcoClreUpdateInput updateDto
    )
    {
        var demandForRcoClre = updateDto.ToModel(uniqueId);

        _context.Entry(demandForRcoClre).State = EntityState.Modified;

        try
        {
            await _context.SaveChangesAsync();
        }
        catch (DbUpdateConcurrencyException)
        {
            if (!_context.DemandForRcoClres.Any(e => e.Id == demandForRcoClre.Id))
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
