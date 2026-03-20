using System.Runtime.Serialization;

namespace HarnishBalanceSheetAi.Server.DTO.Details;

[DataContract]
public class DetailsDto
{
    [DataMember]
    public DateTime Date { get; set; }

    [DataMember]
    public IEnumerable<AssetDetailDto> Assets { get; set; } = [];

    [DataMember]
    public decimal TotalAssets { get; set; }

    [DataMember]
    public IEnumerable<LiabilityDetailDto> Liabilities { get; set; } = [];

    [DataMember]
    public decimal TotalLiabilities { get; set; }

    [DataMember]
    public decimal NetWorth { get; set; }

    [DataMember]
    public BullionDetailDto Bullion { get; set; } = new();

    [DataMember]
    public IEnumerable<AssetTargetDetailDto> AssetTargets { get; set; } = [];
}
