using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Control.Infrastructure.Models;

[Table("RCODemands")]
public class RCODemandDbModel
{
    [StringLength(1000)]
    public string? AdditionalInformationOfGoods { get; set; }

    [StringLength(1000)]
    public string? BrochuresOn { get; set; }

    [StringLength(1000)]
    public string? ContentsOfThePreviousAdvanceDecision { get; set; }

    [Required()]
    public DateTime CreatedAt { get; set; }

    public DateTime? DateAndTimeOfFinalModification { get; set; }

    public DateTime? DateAndTimeOfFirstRegistration { get; set; }

    [StringLength(1000)]
    public string? DateOfRequest { get; set; }

    [StringLength(1000)]
    public string? DeclarantSAddress { get; set; }

    [StringLength(1000)]
    public string? DeclarantSCode { get; set; }

    [StringLength(1000)]
    public string? DeclarantSName { get; set; }

    [StringLength(1000)]
    public string? DescriptionOfMerchandiseProduction { get; set; }

    [StringLength(1000)]
    public string? DescriptionOfOtherRequests { get; set; }

    [StringLength(1000)]
    public string? DescriptionOn { get; set; }

    [StringLength(1000)]
    public string? DesignationOfGoods { get; set; }

    [StringLength(1000)]
    public string? ExporterCountryCode { get; set; }

    [StringLength(1000)]
    public string? FinalModifierSId { get; set; }

    [StringLength(1000)]
    public string? FinalOn { get; set; }

    [StringLength(1000)]
    public string? FirstRegistrantSId { get; set; }

    [StringLength(1000)]
    public string? HolderSAddress { get; set; }

    [StringLength(1000)]
    public string? HolderSeMail { get; set; }

    [StringLength(1000)]
    public string? HolderSTelNo { get; set; }

    [Key()]
    [Required()]
    public string Id { get; set; }

    [StringLength(1000)]
    public string? IdOfTheBrochureAttachment { get; set; }

    [StringLength(1000)]
    public string? IdOfTheExplanationAttachment { get; set; }

    [StringLength(1000)]
    public string? IdOfTheManualAttachment { get; set; }

    [StringLength(1000)]
    public string? IdOfTheOtherAttachment { get; set; }

    [StringLength(1000)]
    public string? IdOfThePhotoAttachment { get; set; }

    [StringLength(1000)]
    public string? IdOfTheReportAttachment { get; set; }

    [StringLength(1000)]
    public string? ImportCountryCode { get; set; }

    [StringLength(1000)]
    public string? InformantSeMail { get; set; }

    [StringLength(1000)]
    public string? NameAndFirstNameSOrBusinessName { get; set; }

    [StringLength(1000)]
    public string? OeaNo { get; set; }

    [StringLength(1000)]
    public string? OriginCountryCode { get; set; }

    [StringLength(1000)]
    public string? OthersOn { get; set; }

    [StringLength(1000)]
    public string? PhotographsOn { get; set; }

    [StringLength(1000)]
    public string? PreferentialAgreementCode { get; set; }

    [StringLength(1000)]
    public string? PreferentialOriginOn { get; set; }

    [StringLength(1000)]
    public string? PreviousAdvanceDecisionOn { get; set; }

    [StringLength(1000)]
    public string? RcoRequestNumber { get; set; }

    [Range(-999999999, 999999999)]
    public double? RectificationFrequency { get; set; }

    [StringLength(1000)]
    public string? ReferenceOfThePreviousRco { get; set; }

    [StringLength(1000)]
    public string? ReissueOfAnRco { get; set; }

    [StringLength(1000)]
    public string? ReissueOfAnRtcOn { get; set; }

    [StringLength(1000)]
    public string? ReportsExpertisePvOn { get; set; }

    [StringLength(1000)]
    public string? RuleToConsiderOfRco { get; set; }

    [StringLength(1000)]
    public string? SameJudgmentContent { get; set; }

    [StringLength(1000)]
    public string? ShCode { get; set; }

    [StringLength(1000)]
    public string? SuppressionOn { get; set; }

    [StringLength(1000)]
    public string? TaxIdentificationNumber { get; set; }

    [StringLength(1000)]
    public string? TaxIdentificationNumberHolder { get; set; }

    [StringLength(1000)]
    public string? TelNoOfTheInformant { get; set; }

    [StringLength(1000)]
    public string? ThatTheSameJudgment { get; set; }

    [StringLength(1000)]
    public string? TradeRegisterNumber { get; set; }

    [StringLength(1000)]
    public string? TradeRegisterNumberHolder { get; set; }

    [StringLength(1000)]
    public string? TypeOfOperation { get; set; }

    [Required()]
    public DateTime UpdatedAt { get; set; }

    [StringLength(1000)]
    public string? UserGuideOn { get; set; }

    [StringLength(1000)]
    public string? VerificationOfWritingOfInformationYn { get; set; }

    [StringLength(1000)]
    public string? ZipcodeApplicant { get; set; }

    [StringLength(1000)]
    public string? ZipcodeHolder { get; set; }
}
