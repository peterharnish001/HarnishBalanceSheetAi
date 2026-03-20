using HarnishBalanceSheetAi.Server.DTO.Create.Get;
using HarnishBalanceSheetAi.Server.DTO.Create.Save;
using HarnishBalanceSheetAi.Server.DTO.Details;
using HarnishBalanceSheetAi.Server.DTO.Edit.Get;
using HarnishBalanceSheetAi.Server.DTO.Edit.Save;
using HarnishBalanceSheetAi.Server.DTO.Index;

namespace HarnishBalanceSheetAi.Server.BusinessLogic;

public interface IBusinessLogic
{
    Task<bool> HasTargets(int userId);
    Task<IEnumerable<AssetTypeDto>> GetAssetTypes();
    Task<bool> SaveTargets(int userId, IEnumerable<TargetSaveDto> targets);
    Task<IEnumerable<BalanceSheetListItemDto>> GetBalanceSheetList(int userId, int count);
    Task<IEnumerable<LiabilityChartDto>> GetLiabilityChart(int userId, int count);
    Task<IEnumerable<NetWorthChartDto>> GetNetWorthChart(int userId, int count);
    Task<DetailsDto> GetDetails(int userId, int balanceSheetId);
    Task<BalanceSheetGetCreateDto> GetBalanceSheetForCreate(int userId);
    Task<int> CreateBalanceSheet(int userId, BalanceSheetCreateDto balanceSheet);
    Task<BalanceSheetGetEditDto> GetBalanceSheetForEdit(int userId, int balanceSheetId);
    Task<bool> EditBalanceSheet(int userId, BalanceSheetEditDto balanceSheet);
}
