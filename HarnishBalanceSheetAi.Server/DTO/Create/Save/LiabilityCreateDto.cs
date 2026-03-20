using System.Runtime.Serialization;

namespace HarnishBalanceSheetAi.Server.DTO.Create.Save;

[DataContract]
public class LiabilityCreateDto
{
    [DataMember]
    public string LiabilityName { get; set; } = string.Empty;

    [DataMember]
    public decimal LiabilityValue { get; set; }
}
