using System.Runtime.Serialization;

namespace HarnishBalanceSheetAi.Server.DTO.Details;

[DataContract]
public class AssetPortionSummaryDto
{
    [DataMember]
    public string AssetTypeName { get; set; } = string.Empty;

    [DataMember]
    public decimal TotalValue { get; set; }

    [DataMember]
    public IEnumerable<AssetPortionDto> AssetPortions { get; set; } = [];
}
