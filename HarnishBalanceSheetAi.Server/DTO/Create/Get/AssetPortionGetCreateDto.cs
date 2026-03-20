using System.Runtime.Serialization;

namespace HarnishBalanceSheetAi.Server.DTO.Create.Get;

[DataContract]
public class AssetPortionGetCreateDto
{
    [DataMember]
    public int AssetTypeId { get; set; }

    [DataMember]
    public string AssetTypeName { get; set; } = string.Empty;

    [DataMember]
    public decimal Percentage { get; set; }

    [DataMember]
    public decimal AssetPortionValue { get; set; }
}
