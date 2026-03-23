namespace HarnishBalanceSheetAi.Server.Models;

public class PreciousMetalPrice
{
    public int PreciousMetalId { get; set; }
    public string MetalName { get; set; } = string.Empty;
    public decimal Price { get; set; }
}
