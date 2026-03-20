using System.Runtime.Serialization;

namespace HarnishBalanceSheetAi.Server.DTO.Edit.Get;

[DataContract]
public class MetalPriceGetEditDto
{
    [DataMember]
    public int MetalId { get; set; }

    [DataMember]
    public string MetalName { get; set; } = string.Empty;

    [DataMember]
    public decimal PricePerOunce { get; set; }
}
