namespace HarnishBalanceSheetAi.Server.Models;

public class Details
{
    public BalanceSheet BalanceSheet { get; set; } = new();
    public ICollection<AssetType> AssetTypes { get; set; } = [];
    public ICollection<PreciousMetal> PreciousMetals { get; set; } = [];
    public ICollection<Target> Targets { get; set; } = [];
}
