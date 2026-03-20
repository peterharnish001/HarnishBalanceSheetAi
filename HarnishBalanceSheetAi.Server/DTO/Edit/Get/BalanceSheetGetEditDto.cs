using System.Runtime.Serialization;

namespace HarnishBalanceSheetAi.Server.DTO.Edit.Get;

[DataContract]
public class BalanceSheetGetEditDto
{
    [DataMember]
    public IEnumerable<AssetEditGetDto> Assets { get; set; } = [];

    [DataMember]
    public BullionGetEditDto Bullion { get; set; } = new();

    [DataMember]
    public IEnumerable<LiabilityGetEditDto> Liabilities { get; set; } = [];

    [DataMember]
    public IEnumerable<AssetTypeGetEditDto> AssetTypes { get; set; } = [];

    [DataMember]
    public IEnumerable<MetalPriceGetEditDto> MetalPrices { get; set; } = [];
}
