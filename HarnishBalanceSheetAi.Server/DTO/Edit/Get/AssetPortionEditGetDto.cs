using System.Runtime.Serialization;

namespace HarnishBalanceSheetAi.Server.DTO.Edit.Get;

[DataContract]
public class AssetPortionEditGetDto
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
