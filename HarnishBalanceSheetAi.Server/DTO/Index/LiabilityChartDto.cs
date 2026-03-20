using System.Runtime.Serialization;

namespace HarnishBalanceSheetAi.Server.DTO.Index;

[DataContract]
public class LiabilityChartDto
{
    [DataMember]
    public DateTime Date { get; set; }

    [DataMember]
    public decimal TotalLiabilities { get; set; }
}
