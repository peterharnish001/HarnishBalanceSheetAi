namespace HarnishBalanceSheetAi.Server.Models;

public class AssetPortion
{
    public int AssetPortionId { get; set; }
    public int AssetId { get; set; }
    public int AssetTypeId { get; set; }
    public decimal AssetPortionValue { get; set; }
}
