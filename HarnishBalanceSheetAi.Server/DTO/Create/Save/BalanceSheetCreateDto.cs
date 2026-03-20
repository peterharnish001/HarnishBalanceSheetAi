using System.Runtime.Serialization;

namespace HarnishBalanceSheetAi.Server.DTO.Create.Save;

[DataContract]
public class BalanceSheetCreateDto
{
    [DataMember]
    public IEnumerable<AssetCreateDto> Assets { get; set; } = [];

    [DataMember]
    public IEnumerable<MetalPositionCreateDto> Bullion { get; set; } = [];

    [DataMember]
    public IEnumerable<LiabilityCreateDto> Liabilities { get; set; } = [];
}
