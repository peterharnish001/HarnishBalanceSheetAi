using AutoMapper;
using HarnishBalanceSheetAi.Server.DTO.Create.Get;
using HarnishBalanceSheetAi.Server.DTO.Create.Save;
using HarnishBalanceSheetAi.Server.DTO.Details;
using HarnishBalanceSheetAi.Server.DTO.Edit.Get;
using HarnishBalanceSheetAi.Server.DTO.Edit.Save;
using HarnishBalanceSheetAi.Server.DTO.Index;
using HarnishBalanceSheetAi.Server.Models;

namespace HarnishBalanceSheetAi.Server;

public class MappingProfile : Profile
{
    public MappingProfile()
    {
        // Index
        CreateMap<AssetType, AssetTypeDto>();
        CreateMap<BalanceSheetListItem, BalanceSheetListItemDto>();
        CreateMap<LiabilityChartItem, LiabilityChartDto>();
        CreateMap<NetWorthChartItem, NetWorthChartDto>();

        // Details
        CreateMap<AssetPortion, AssetPortionDto>();
        CreateMap<Asset, AssetDetailDto>();
        CreateMap<MetalPosition, MetalPositionDetailDto>();
        CreateMap<Liability, LiabilityDetailDto>();
        CreateMap<Details, DetailsDto>()
            .ForMember(dest => dest.Date, opt => opt.MapFrom(src => src.BalanceSheet.Date))
            .ForMember(dest => dest.Assets, opt => opt.MapFrom(src => src.BalanceSheet.Assets))
            .ForMember(dest => dest.Bullion, opt => opt.MapFrom(src => src.BalanceSheet.Bullion))
            .ForMember(dest => dest.Liabilities, opt => opt.MapFrom(src => src.BalanceSheet.Liabilities));

        // Create Get
        CreateMap<AssetPortion, AssetPortionGetCreateDto>();
        CreateMap<Asset, AssetGetCreateDto>();
        CreateMap<MetalPosition, MetalPositionGetCreateDto>();
        CreateMap<Liability, LiabilityGetCreateDto>();
        CreateMap<BalanceSheet, BalanceSheetGetCreateDto>();
        CreateMap<AssetType, AssetTypeGetCreateDto>();

        // Edit Get
        CreateMap<AssetPortion, AssetPortionEditGetDto>();
        CreateMap<Asset, AssetEditGetDto>();
        CreateMap<MetalPosition, MetalPositionGetEditDto>();
        CreateMap<Liability, LiabilityGetEditDto>();
        CreateMap<BalanceSheet, BalanceSheetGetEditDto>();
        CreateMap<AssetType, AssetTypeGetEditDto>();

        // Create Save
        CreateMap<TargetSaveDto, Target>();
        CreateMap<AssetPortionCreateDto, AssetPortion>();
        CreateMap<AssetCreateDto, Asset>();
        CreateMap<MetalPositionCreateDto, MetalPosition>();
        CreateMap<LiabilityCreateDto, Liability>();
        CreateMap<BalanceSheetCreateDto, BalanceSheet>();

        // Edit Save
        CreateMap<AssetPortionEditDto, AssetPortion>();
        CreateMap<AssetEditDto, Asset>();
        CreateMap<MetalPositionEditDto, MetalPosition>();
        CreateMap<LiabilityEditDto, Liability>();
        CreateMap<BalanceSheetEditDto, BalanceSheet>();
    }
}
