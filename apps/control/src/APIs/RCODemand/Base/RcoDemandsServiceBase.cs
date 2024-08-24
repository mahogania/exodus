using Control.APIs;
using Control.APIs.Common;
using Control.APIs.Dtos;
using Control.APIs.Errors;
using Control.APIs.Extensions;
using Control.Infrastructure;
using Control.Infrastructure.Models;
using Microsoft.EntityFrameworkCore;

namespace Control.APIs;

public abstract class RcoDemandsServiceBase : IRcoDemandsService
{
    protected readonly ControlDbContext _context;

    public RcoDemandsServiceBase(ControlDbContext context)
    {
        _context = context;
    }

    /// <summary>
    /// Create one RCO Demand
    /// </summary>
    public async Task<RCODemand> CreateRcoDemand(RCODemandCreateInput createDto)
    {
        var rcoDemand = new RcoDemandDbModel
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
            rcoDemand.Id = createDto.Id;
        }

        _context.RcoDemands.Add(rcoDemand);
        await _context.SaveChangesAsync();

        var result = await _context.FindAsync<RcoDemandDbModel>(rcoDemand.Id);

        if (result == null)
        {
            throw new NotFoundException();
        }

        return result.ToDto();
    }

    /// <summary>
    /// Delete one RCO Demand
    /// </summary>
    public async Task DeleteRcoDemand(RCODemandWhereUniqueInput uniqueId)
    {
        var rcoDemand = await _context.RcoDemands.FindAsync(uniqueId.Id);
        if (rcoDemand == null)
        {
            throw new NotFoundException();
        }

        _context.RcoDemands.Remove(rcoDemand);
        await _context.SaveChangesAsync();
    }

    /// <summary>
    /// Find many Demand for RCO | CLRES
    /// </summary>
    public async Task<List<RCODemand>> RcoDemands(RCODemandFindManyArgs findManyArgs)
    {
        var rcoDemands = await _context
            .RcoDemands.ApplyWhere(findManyArgs.Where)
            .ApplySkip(findManyArgs.Skip)
            .ApplyTake(findManyArgs.Take)
            .ApplyOrderBy(findManyArgs.SortBy)
            .ToListAsync();
        return rcoDemands.ConvertAll(rcoDemand => rcoDemand.ToDto());
    }

    /// <summary>
    /// Meta data about RCO Demand records
    /// </summary>
    public async Task<MetadataDto> RcoDemandsMeta(RCODemandFindManyArgs findManyArgs)
    {
        var count = await _context.RcoDemands.ApplyWhere(findManyArgs.Where).CountAsync();

        return new MetadataDto { Count = count };
    }

    /// <summary>
    /// Get one RCO Demand
    /// </summary>
    public async Task<RCODemand> RcoDemand(RCODemandWhereUniqueInput uniqueId)
    {
        var rcoDemands = await this.RcoDemands(
            new RCODemandFindManyArgs { Where = new RCODemandWhereInput { Id = uniqueId.Id } }
        );
        var rcoDemand = rcoDemands.FirstOrDefault();
        if (rcoDemand == null)
        {
            throw new NotFoundException();
        }

        return rcoDemand;
    }

    /// <summary>
    /// Update one RCO Demand
    /// </summary>
    public async Task UpdateRcoDemand(
        RCODemandWhereUniqueInput uniqueId,
        RCODemandUpdateInput updateDto
    )
    {
        var rcoDemand = updateDto.ToModel(uniqueId);

        _context.Entry(rcoDemand).State = EntityState.Modified;

        try
        {
            await _context.SaveChangesAsync();
        }
        catch (DbUpdateConcurrencyException)
        {
            if (!_context.RcoDemands.Any(e => e.Id == rcoDemand.Id))
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
