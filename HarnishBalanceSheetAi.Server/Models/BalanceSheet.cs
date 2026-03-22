namespace HarnishBalanceSheetAi.Server.Models;

public class BalanceSheet
{
    public int BalanceSheetId { get; set; }
    public int UserId { get; set; }
    public DateTime Date { get; set; }
    public ICollection<Asset> Assets { get; set; } = [];
    public ICollection<MetalPosition> Bullion { get; set; } = [];
    public ICollection<Liability> Liabilities { get; set; } = [];
}
