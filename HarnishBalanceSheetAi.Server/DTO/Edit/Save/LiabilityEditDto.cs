using System.Runtime.Serialization;

namespace HarnishBalanceSheetAi.Server.DTO.Edit.Save;

[DataContract]
public class LiabilityEditDto
{
    [DataMember]
    public string LiabilityName { get; set; } = string.Empty;

    [DataMember]
    public decimal LiabilityValue { get; set; }
}
