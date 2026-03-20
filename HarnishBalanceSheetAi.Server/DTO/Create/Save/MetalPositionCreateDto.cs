using System.Runtime.Serialization;

namespace HarnishBalanceSheetAi.Server.DTO.Create.Save;

[DataContract]
public class MetalPositionCreateDto
{
    [DataMember]
    public int MetalId { get; set; }

    [DataMember]
    public decimal NumberOfOunces { get; set; }

    [DataMember]
    public decimal PricePerOunce { get; set; }
}
