using System.Runtime.Serialization;

namespace HarnishBalanceSheetAi.Server.DTO.Edit.Get;

[DataContract]
public class MetalPositionGetEditDto
{
    [DataMember]
    public int MetalId { get; set; }

    [DataMember]
    public string MetalName { get; set; } = string.Empty;

    [DataMember]
    public decimal NumberOfOunces { get; set; }

    [DataMember]
    public decimal PricePerOunce { get; set; }
}
