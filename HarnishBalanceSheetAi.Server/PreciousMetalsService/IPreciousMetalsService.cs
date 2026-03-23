using HarnishBalanceSheetAi.Server.Models;

namespace HarnishBalanceSheetAi.Server.PreciousMetalsService;

public interface IPreciousMetalsService
{
    Task<IEnumerable<PreciousMetalPrice>> GetPreciousMetalsPrices(IEnumerable<PreciousMetalPrice> preciousMetalPrices);
}
