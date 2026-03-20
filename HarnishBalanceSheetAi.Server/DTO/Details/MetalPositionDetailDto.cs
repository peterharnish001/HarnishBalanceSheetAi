using System.Runtime.Serialization;

namespace HarnishBalanceSheetAi.Server.DTO.Details;

[DataContract]
public class MetalPositionDetailDto
{
    [DataMember]
    public string MetalName { get; set; } = string.Empty;

    [DataMember]
    public decimal NumberOfOunces { get; set; }

    [DataMember]
    public decimal PricePerOunce { get; set; }

    [DataMember]
    public decimal TotalPrice { get; set; }
}
