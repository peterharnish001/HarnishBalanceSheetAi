using System.Runtime.Serialization;

namespace HarnishBalanceSheetAi.Server.DTO.Create.Save;

[DataContract]
public class AssetCreateDto
{
    [DataMember]
    public string AssetName { get; set; } = string.Empty;

    [DataMember]
    public bool IsPercent { get; set; }

    [DataMember]
    public IEnumerable<AssetPortionCreateDto> AssetPortions { get; set; } = [];
}
