using System.Runtime.Serialization;

namespace HarnishBalanceSheetAi.Server.DTO.Details;

[DataContract]
public class BullionDetailDto
{
    [DataMember]
    public IEnumerable<MetalPositionDetailDto> MetalPositions { get; set; } = [];

    [DataMember]
    public decimal TotalValue { get; set; }
}
