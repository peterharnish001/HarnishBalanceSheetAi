using System.Runtime.Serialization;

namespace HarnishBalanceSheetAi.Server.DTO.Index;

[DataContract]
public class TargetSaveDto
{
    [DataMember]
    public int AssetTypeId { get; set; }

    [DataMember]
    public decimal Percentage { get; set; }
}
