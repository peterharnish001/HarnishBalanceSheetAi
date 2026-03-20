using System.Runtime.Serialization;

namespace HarnishBalanceSheetAi.Server.DTO.Edit.Save;

[DataContract]
public class AssetPortionEditDto
{
    [DataMember]
    public int AssetTypeId { get; set; }

    [DataMember]
    public decimal AssetPortionValue { get; set; }
}
