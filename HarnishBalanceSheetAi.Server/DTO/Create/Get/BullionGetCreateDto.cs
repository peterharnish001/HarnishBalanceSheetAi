using System.Runtime.Serialization;

namespace HarnishBalanceSheetAi.Server.DTO.Create.Get;

[DataContract]
public class BullionGetCreateDto
{
    [DataMember]
    public decimal TotalValue { get; set; }

    [DataMember]
    public IEnumerable<MetalPositionGetCreateDto> MetalPositions { get; set; } = [];
}
