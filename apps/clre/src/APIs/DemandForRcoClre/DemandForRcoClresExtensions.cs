using Clre.APIs.Dtos;
using Clre.Infrastructure.Models;

namespace Clre.APIs.Extensions;

public static class DemandForRcoClresExtensions
{
    public static DemandForRcoClre ToDto(this DemandForRcoClreDbModel model)
    {
        return new DemandForRcoClre
        {
            AdditionalInformationOfGoods = model.AdditionalInformationOfGoods,
            BrochuresOn = model.BrochuresOn,
            ContentsOfThePreviousAdvanceDecision = model.ContentsOfThePreviousAdvanceDecision,
            CreatedAt = model.CreatedAt,
            DateAndTimeOfFinalModification = model.DateAndTimeOfFinalModification,
            DateAndTimeOfFirstRegistration = model.DateAndTimeOfFirstRegistration,
            DateOfRequest = model.DateOfRequest,
            DeclarantSAddress = model.DeclarantSAddress,
            DeclarantSCode = model.DeclarantSCode,
            DeclarantSName = model.DeclarantSName,
            DescriptionOfMerchandiseProduction = model.DescriptionOfMerchandiseProduction,
            DescriptionOfOtherRequests = model.DescriptionOfOtherRequests,
            DescriptionOn = model.DescriptionOn,
            DesignationOfGoods = model.DesignationOfGoods,
            ExporterCountryCode = model.ExporterCountryCode,
            FinalModifierSId = model.FinalModifierSId,
            FinalOn = model.FinalOn,
            FirstRegistrantSId = model.FirstRegistrantSId,
            HolderSAddress = model.HolderSAddress,
            HolderSeMail = model.HolderSeMail,
            HolderSTelNo = model.HolderSTelNo,
            Id = model.Id,
            IdOfTheBrochureAttachment = model.IdOfTheBrochureAttachment,
            IdOfTheExplanationAttachment = model.IdOfTheExplanationAttachment,
            IdOfTheManualAttachment = model.IdOfTheManualAttachment,
            IdOfTheOtherAttachment = model.IdOfTheOtherAttachment,
            IdOfThePhotoAttachment = model.IdOfThePhotoAttachment,
            IdOfTheReportAttachment = model.IdOfTheReportAttachment,
            ImportCountryCode = model.ImportCountryCode,
            InformantSeMail = model.InformantSeMail,
            NameAndFirstNameSOrBusinessName = model.NameAndFirstNameSOrBusinessName,
            OeaNo = model.OeaNo,
            OriginCountryCode = model.OriginCountryCode,
            OthersOn = model.OthersOn,
            PhotographsOn = model.PhotographsOn,
            PreferentialAgreementCode = model.PreferentialAgreementCode,
            PreferentialOriginOn = model.PreferentialOriginOn,
            PreviousAdvanceDecisionOn = model.PreviousAdvanceDecisionOn,
            RcoRequestNumber = model.RcoRequestNumber,
            RectificationFrequency = model.RectificationFrequency,
            ReferenceOfThePreviousRco = model.ReferenceOfThePreviousRco,
            ReissueOfAnRco = model.ReissueOfAnRco,
            ReissueOfAnRtcOn = model.ReissueOfAnRtcOn,
            ReportsExpertisePvOn = model.ReportsExpertisePvOn,
            RuleToConsiderOfRco = model.RuleToConsiderOfRco,
            SameJudgmentContent = model.SameJudgmentContent,
            ShCode = model.ShCode,
            SuppressionOn = model.SuppressionOn,
            TaxIdentificationNumber = model.TaxIdentificationNumber,
            TaxIdentificationNumberHolder = model.TaxIdentificationNumberHolder,
            TelNoOfTheInformant = model.TelNoOfTheInformant,
            ThatTheSameJudgment = model.ThatTheSameJudgment,
            TradeRegisterNumber = model.TradeRegisterNumber,
            TradeRegisterNumberHolder = model.TradeRegisterNumberHolder,
            TypeOfOperation = model.TypeOfOperation,
            UpdatedAt = model.UpdatedAt,
            UserGuideOn = model.UserGuideOn,
            VerificationOfWritingOfInformationYn = model.VerificationOfWritingOfInformationYn,
            ZipcodeApplicant = model.ZipcodeApplicant,
            ZipcodeHolder = model.ZipcodeHolder,
        };
    }

    public static DemandForRcoClreDbModel ToModel(
        this DemandForRcoClreUpdateInput updateDto,
        DemandForRcoClreWhereUniqueInput uniqueId
    )
    {
        var demandForRcoClre = new DemandForRcoClreDbModel
        {
            Id = uniqueId.Id,
            AdditionalInformationOfGoods = updateDto.AdditionalInformationOfGoods,
            BrochuresOn = updateDto.BrochuresOn,
            ContentsOfThePreviousAdvanceDecision = updateDto.ContentsOfThePreviousAdvanceDecision,
            DateAndTimeOfFinalModification = updateDto.DateAndTimeOfFinalModification,
            DateAndTimeOfFirstRegistration = updateDto.DateAndTimeOfFirstRegistration,
            DateOfRequest = updateDto.DateOfRequest,
            DeclarantSAddress = updateDto.DeclarantSAddress,
            DeclarantSCode = updateDto.DeclarantSCode,
            DeclarantSName = updateDto.DeclarantSName,
            DescriptionOfMerchandiseProduction = updateDto.DescriptionOfMerchandiseProduction,
            DescriptionOfOtherRequests = updateDto.DescriptionOfOtherRequests,
            DescriptionOn = updateDto.DescriptionOn,
            DesignationOfGoods = updateDto.DesignationOfGoods,
            ExporterCountryCode = updateDto.ExporterCountryCode,
            FinalModifierSId = updateDto.FinalModifierSId,
            FinalOn = updateDto.FinalOn,
            FirstRegistrantSId = updateDto.FirstRegistrantSId,
            HolderSAddress = updateDto.HolderSAddress,
            HolderSeMail = updateDto.HolderSeMail,
            HolderSTelNo = updateDto.HolderSTelNo,
            IdOfTheBrochureAttachment = updateDto.IdOfTheBrochureAttachment,
            IdOfTheExplanationAttachment = updateDto.IdOfTheExplanationAttachment,
            IdOfTheManualAttachment = updateDto.IdOfTheManualAttachment,
            IdOfTheOtherAttachment = updateDto.IdOfTheOtherAttachment,
            IdOfThePhotoAttachment = updateDto.IdOfThePhotoAttachment,
            IdOfTheReportAttachment = updateDto.IdOfTheReportAttachment,
            ImportCountryCode = updateDto.ImportCountryCode,
            InformantSeMail = updateDto.InformantSeMail,
            NameAndFirstNameSOrBusinessName = updateDto.NameAndFirstNameSOrBusinessName,
            OeaNo = updateDto.OeaNo,
            OriginCountryCode = updateDto.OriginCountryCode,
            OthersOn = updateDto.OthersOn,
            PhotographsOn = updateDto.PhotographsOn,
            PreferentialAgreementCode = updateDto.PreferentialAgreementCode,
            PreferentialOriginOn = updateDto.PreferentialOriginOn,
            PreviousAdvanceDecisionOn = updateDto.PreviousAdvanceDecisionOn,
            RcoRequestNumber = updateDto.RcoRequestNumber,
            RectificationFrequency = updateDto.RectificationFrequency,
            ReferenceOfThePreviousRco = updateDto.ReferenceOfThePreviousRco,
            ReissueOfAnRco = updateDto.ReissueOfAnRco,
            ReissueOfAnRtcOn = updateDto.ReissueOfAnRtcOn,
            ReportsExpertisePvOn = updateDto.ReportsExpertisePvOn,
            RuleToConsiderOfRco = updateDto.RuleToConsiderOfRco,
            SameJudgmentContent = updateDto.SameJudgmentContent,
            ShCode = updateDto.ShCode,
            SuppressionOn = updateDto.SuppressionOn,
            TaxIdentificationNumber = updateDto.TaxIdentificationNumber,
            TaxIdentificationNumberHolder = updateDto.TaxIdentificationNumberHolder,
            TelNoOfTheInformant = updateDto.TelNoOfTheInformant,
            ThatTheSameJudgment = updateDto.ThatTheSameJudgment,
            TradeRegisterNumber = updateDto.TradeRegisterNumber,
            TradeRegisterNumberHolder = updateDto.TradeRegisterNumberHolder,
            TypeOfOperation = updateDto.TypeOfOperation,
            UserGuideOn = updateDto.UserGuideOn,
            VerificationOfWritingOfInformationYn = updateDto.VerificationOfWritingOfInformationYn,
            ZipcodeApplicant = updateDto.ZipcodeApplicant,
            ZipcodeHolder = updateDto.ZipcodeHolder
        };

        if (updateDto.CreatedAt != null)
        {
            demandForRcoClre.CreatedAt = updateDto.CreatedAt.Value;
        }
        if (updateDto.UpdatedAt != null)
        {
            demandForRcoClre.UpdatedAt = updateDto.UpdatedAt.Value;
        }

        return demandForRcoClre;
    }
}
