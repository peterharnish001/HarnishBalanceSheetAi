using System.Runtime.Serialization;

namespace HarnishBalanceSheetAi.Server.DTO.Edit.Get;

[DataContract]
public class AssetEditGetDto
{
    [DataMember]
    public string AssetName { get; set; } = string.Empty;

    [DataMember]
    public string AssetTypeName { get; set; } = string.Empty;

    [DataMember]
    public int AssetTypeId { get; set; }

    [DataMember]
    public bool IsPercent { get; set; }

    [DataMember]
    public decimal AssetValue { get; set; }

    [DataMember]
    public IEnumerable<AssetPortionEditGetDto> AssetPortions { get; set; } = [];
}
