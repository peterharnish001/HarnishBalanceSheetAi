using System.Runtime.Serialization;

namespace HarnishBalanceSheetAi.Server.DTO.Details;

[DataContract]
public class AssetTargetDetailDto
{
    [DataMember]
    public string AssetTypeName { get; set; } = string.Empty;

    [DataMember]
    public decimal Target { get; set; }

    [DataMember]
    public decimal Actual { get; set; }

    [DataMember]
    public decimal Difference { get; set; }
}
