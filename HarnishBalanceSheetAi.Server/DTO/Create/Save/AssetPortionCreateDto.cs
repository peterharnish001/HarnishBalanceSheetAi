using System.Runtime.Serialization;

namespace HarnishBalanceSheetAi.Server.DTO.Create.Save;

[DataContract]
public class AssetPortionCreateDto
{
    [DataMember]
    public int AssetTypeId { get; set; }

    [DataMember]
    public decimal AssetPortionValue { get; set; }
}
