using System.Runtime.Serialization;

namespace HarnishBalanceSheetAi.Server.DTO.Edit.Save;

[DataContract]
public class AssetEditDto
{
    [DataMember]
    public string AssetName { get; set; } = string.Empty;

    [DataMember]
    public bool IsPercent { get; set; }

    [DataMember]
    public IEnumerable<AssetPortionEditDto> AssetPortions { get; set; } = [];
}
