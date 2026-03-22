namespace HarnishBalanceSheetAi.Server.Models;

public class Asset
{
    public int AssetId { get; set; }
    public int BalanceSheetId { get; set; }
    public bool IsPercent { get; set; }
    public ICollection<AssetPortion> AssetPortions { get; set; } = [];
}
