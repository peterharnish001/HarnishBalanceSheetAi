using System.Runtime.Serialization;

namespace HarnishBalanceSheetAi.Server.DTO.Index;

[DataContract]
public class NetWorthChartDto
{
    [DataMember]
    public DateTime Date { get; set; }

    [DataMember]
    public decimal NetWorth { get; set; }
}
