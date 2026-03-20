using System.Runtime.Serialization;

namespace HarnishBalanceSheetAi.Server.DTO.Details;

[DataContract]
public class AssetDetailDto
{
    [DataMember]
    public string AssetName { get; set; } = string.Empty;

    [DataMember]
    public decimal AssetValue { get; set; }
}
