using System.Runtime.Serialization;

namespace HarnishBalanceSheetAi.Server.DTO.Edit.Get;

[DataContract]
public class BullionGetEditDto
{
    [DataMember]
    public decimal TotalValue { get; set; }

    [DataMember]
    public IEnumerable<MetalPositionGetEditDto> MetalPositions { get; set; } = [];
}
