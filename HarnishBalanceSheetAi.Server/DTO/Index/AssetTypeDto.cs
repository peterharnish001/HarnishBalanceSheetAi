using System.Runtime.Serialization;

namespace HarnishBalanceSheetAi.Server.DTO.Index;

[DataContract]
public class AssetTypeDto
{
    [DataMember]
    public int AssetTypeId { get; set; }

    [DataMember]
    public string AssetTypeName { get; set; } = string.Empty;
}
