namespace HarnishBalanceSheetAi.Server.Models;

public class MetalPosition
{
    public int MetalPositionId { get; set; }
    public int BalanceSheetId { get; set; }
    public int PreciousMetalId { get; set; }
    public decimal NumberOfOunces { get; set; }
    public decimal PricePerOunce { get; set; }
}
