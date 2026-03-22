namespace HarnishBalanceSheetAi.Server.Models;

public class Target
{
    public int TargetId { get; set; }
    public int UserId { get; set; }
    public int AssetTypeId { get; set; }
    public decimal Percentage { get; set; }
}
