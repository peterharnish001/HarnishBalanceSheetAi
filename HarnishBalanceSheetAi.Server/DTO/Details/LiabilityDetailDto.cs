using System.Runtime.Serialization;

namespace HarnishBalanceSheetAi.Server.DTO.Details;

[DataContract]
public class LiabilityDetailDto
{
    [DataMember]
    public string LiabilityName { get; set; } = string.Empty;

    [DataMember]
    public decimal LiabilityValue { get; set; }
}
