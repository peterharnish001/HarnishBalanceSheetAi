using System.Runtime.Serialization;

namespace HarnishBalanceSheetAi.Server.DTO.Edit.Get;

[DataContract]
public class LiabilityGetEditDto
{
    [DataMember]
    public string LiabilityName { get; set; } = string.Empty;

    [DataMember]
    public decimal LiabilityValue { get; set; }
}
