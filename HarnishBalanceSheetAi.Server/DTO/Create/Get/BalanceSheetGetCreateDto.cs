using System.Runtime.Serialization;

namespace HarnishBalanceSheetAi.Server.DTO.Create.Get;

[DataContract]
public class BalanceSheetGetCreateDto
{
    [DataMember]
    public IEnumerable<AssetGetCreateDto> Assets { get; set; } = [];

    [DataMember]
    public BullionGetCreateDto Bullion { get; set; } = new();

    [DataMember]
    public IEnumerable<LiabilityGetCreateDto> Liabilities { get; set; } = [];

    [DataMember]
    public IEnumerable<AssetTypeGetCreateDto> AssetTypes { get; set; } = [];

    [DataMember]
    public IEnumerable<MetalPriceGetCreateDto> MetalPrices { get; set; } = [];
}
