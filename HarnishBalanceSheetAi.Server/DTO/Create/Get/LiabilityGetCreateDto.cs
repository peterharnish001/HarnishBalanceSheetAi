using System.Runtime.Serialization;

namespace HarnishBalanceSheetAi.Server.DTO.Create.Get;

[DataContract]
public class LiabilityGetCreateDto
{
    [DataMember]
    public string LiabilityName { get; set; } = string.Empty;

    [DataMember]
    public decimal LiabilityValue { get; set; }
}
