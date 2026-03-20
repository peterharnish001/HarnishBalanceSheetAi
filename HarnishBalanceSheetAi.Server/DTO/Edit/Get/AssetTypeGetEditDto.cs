using System.Runtime.Serialization;

namespace HarnishBalanceSheetAi.Server.DTO.Edit.Get;

[DataContract]
public class AssetTypeGetEditDto
{
    [DataMember]
    public int AssetTypeId { get; set; }

    [DataMember]
    public string AssetTypeName { get; set; } = string.Empty;
}
