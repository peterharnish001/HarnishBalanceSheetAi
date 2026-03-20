using System.Runtime.Serialization;

namespace HarnishBalanceSheetAi.Server.DTO.Index;

[DataContract]
public class BalanceSheetListItemDto
{
    [DataMember]
    public int BalanceSheetId { get; set; }

    [DataMember]
    public DateTime Date { get; set; }
}
