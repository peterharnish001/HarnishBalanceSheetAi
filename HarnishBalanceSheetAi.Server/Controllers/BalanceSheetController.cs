using HarnishBalanceSheetAi.Server.BusinessLogic;
using HarnishBalanceSheetAi.Server.DTO.Create.Save;
using HarnishBalanceSheetAi.Server.DTO.Edit.Save;
using HarnishBalanceSheetAi.Server.DTO.Index;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace HarnishBalanceSheetAi.Server.Controllers;

[Authorize]
[ApiController]
[Route("api/balance-sheet")]
public class BalanceSheetController(IBusinessLogic businessLogic) : ControllerBase
{
    private int UserId => int.Parse(User.FindFirst("UserId")!.Value);

    [HttpGet("has-targets")]
    public async Task<JsonResult> HasTargets()
    {
        var result = await businessLogic.HasTargets(UserId);
        return new JsonResult(result);
    }

    [HttpGet("asset-types")]
    public async Task<JsonResult> GetAssetTypes()
    {
        var result = await businessLogic.GetAssetTypes();
        return new JsonResult(result);
    }

    [HttpPost("targets")]
    public async Task<JsonResult> SaveTargets([FromBody] IEnumerable<TargetSaveDto> targets)
    {
        var result = await businessLogic.SaveTargets(UserId, targets);
        return new JsonResult(result);
    }

    [HttpGet("liability-chart")]
    public async Task<JsonResult> GetLiabilityChart([FromQuery] int count)
    {
        var result = await businessLogic.GetLiabilityChart(UserId, count);
        return new JsonResult(result);
    }

    [HttpGet("list")]
    public async Task<JsonResult> GetBalanceSheetList([FromQuery] int count)
    {
        var result = await businessLogic.GetBalanceSheetList(UserId, count);
        return new JsonResult(result);
    }

    [HttpGet("net-worth-chart")]
    public async Task<JsonResult> GetNetWorthChart([FromQuery] int count)
    {
        var result = await businessLogic.GetNetWorthChart(UserId, count);
        return new JsonResult(result);
    }

    [HttpGet("details/{balanceSheetId:int}")]
    public async Task<JsonResult> GetDetails(int balanceSheetId)
    {
        var result = await businessLogic.GetDetails(UserId, balanceSheetId);
        return new JsonResult(result);
    }

    [HttpGet("create")]
    public async Task<JsonResult> Create()
    {
        var result = await businessLogic.GetBalanceSheetForCreate(UserId);
        return new JsonResult(result);
    }

    [HttpPost("create")]
    public async Task<JsonResult> Create([FromBody] BalanceSheetCreateDto balanceSheet)
    {
        var result = await businessLogic.CreateBalanceSheet(UserId, balanceSheet);
        return new JsonResult(result);
    }

    [HttpGet("edit/{balanceSheetId:int}")]
    public async Task<JsonResult> Edit(int balanceSheetId)
    {
        var result = await businessLogic.GetBalanceSheetForEdit(UserId, balanceSheetId);
        return new JsonResult(result);
    }

    [HttpPut("edit/{balanceSheetId:int}")]
    public async Task<JsonResult> Edit([FromBody] BalanceSheetEditDto balanceSheet)
    {
        var result = await businessLogic.EditBalanceSheet(UserId, balanceSheet);
        return new JsonResult(result);
    }
}
