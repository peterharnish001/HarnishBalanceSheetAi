using System.Runtime.Serialization;

namespace HarnishBalanceSheetAi.Server.DTO.Edit.Save;

[DataContract]
public class BalanceSheetEditDto
{
    [DataMember]
    public int BalanceSheetId { get; set; }

    [DataMember]
    public IEnumerable<AssetEditDto> Assets { get; set; } = [];

    [DataMember]
    public IEnumerable<MetalPositionEditDto> Bullion { get; set; } = [];

    [DataMember]
    public IEnumerable<LiabilityEditDto> Liabilities { get; set; } = [];
}
