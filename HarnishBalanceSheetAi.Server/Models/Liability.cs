namespace HarnishBalanceSheetAi.Server.Models;

public class Liability
{
    public int LiabilityId { get; set; }
    public int BalanceSheetId { get; set; }
    public string LiabilityName { get; set; } = string.Empty;
    public decimal LiabilityValue { get; set; }
}
