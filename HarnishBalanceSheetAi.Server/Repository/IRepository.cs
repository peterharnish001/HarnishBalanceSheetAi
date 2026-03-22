using HarnishBalanceSheetAi.Server.Models;

namespace HarnishBalanceSheetAi.Server.Repository;

public interface IRepository
{
    Task<User> GetUser(string email);
    Task<bool> HasTargets(int userId);
    Task<IEnumerable<AssetType>> GetAssetTypes();
    Task<bool> SaveTargets(int userId, IEnumerable<Target> targets);
    Task<IEnumerable<BalanceSheetListItem>> GetBalanceSheetList(int userId, int count);
    Task<IEnumerable<LiabilityChartItem>> GetLiabilityChart(int userId, int count);
    Task<IEnumerable<NetWorthChartItem>> GetNetWorthChart(int userId, int count);
    Task<Details> GetDetails(int userId, int balanceSheetId);
    Task<Details> GetBalanceSheetForCreate(int userId);
    Task<int> CreateBalanceSheet(int userId, BalanceSheet balanceSheet);
    Task<Details> GetBalanceSheetForEdit(int userId, int balanceSheetId);
    Task<bool> EditBalanceSheet(int userId, BalanceSheet balanceSheet);
}
