using System.Runtime.Serialization;

namespace HarnishBalanceSheetAi.Server.DTO.Create.Get;

[DataContract]
public class MetalPriceGetCreateDto
{
    [DataMember]
    public int MetalId { get; set; }

    [DataMember]
    public string MetalName { get; set; } = string.Empty;

    [DataMember]
    public decimal PricePerOunce { get; set; }
}
