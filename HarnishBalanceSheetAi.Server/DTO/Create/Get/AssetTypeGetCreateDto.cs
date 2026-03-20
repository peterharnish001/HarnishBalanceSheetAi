using System.Runtime.Serialization;

namespace HarnishBalanceSheetAi.Server.DTO.Create.Get;

[DataContract]
public class AssetTypeGetCreateDto
{
    [DataMember]
    public int AssetTypeId { get; set; }

    [DataMember]
    public string AssetTypeName { get; set; } = string.Empty;
}
