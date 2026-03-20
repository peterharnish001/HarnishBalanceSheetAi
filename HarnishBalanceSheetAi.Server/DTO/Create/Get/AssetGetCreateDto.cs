using System.Runtime.Serialization;

namespace HarnishBalanceSheetAi.Server.DTO.Create.Get;

[DataContract]
public class AssetGetCreateDto
{
    [DataMember]
    public string AssetName { get; set; } = string.Empty;

    [DataMember]
    public int AssetTypeId { get; set; }

    [DataMember]
    public string AssetTypeName { get; set; } = string.Empty;

    [DataMember]
    public bool IsPercent { get; set; }

    [DataMember]
    public decimal AssetValue { get; set; }

    [DataMember]
    public IEnumerable<AssetPortionGetCreateDto> AssetPortions { get; set; } = [];
}
