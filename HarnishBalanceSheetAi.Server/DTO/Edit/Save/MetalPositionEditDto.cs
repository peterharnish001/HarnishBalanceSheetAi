using System.Runtime.Serialization;

namespace HarnishBalanceSheetAi.Server.DTO.Edit.Save;

[DataContract]
public class MetalPositionEditDto
{
    [DataMember]
    public int MetalId { get; set; }

    [DataMember]
    public decimal NumberOfOunces { get; set; }

    [DataMember]
    public decimal PricePerOunce { get; set; }
}
