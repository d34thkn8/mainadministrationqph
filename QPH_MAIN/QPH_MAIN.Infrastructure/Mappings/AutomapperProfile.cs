﻿using AutoMapper;
using QPH_MAIN.Core.DTOs;
using QPH_MAIN.Core.Entities;

namespace QPH_MAIN.Infrastructure.Mappings
{
    public class AutomapperProfile : Profile
    {
        public AutomapperProfile()
        {
            CreateMap<City, CityDto>();
            CreateMap<CityDto, City>();
            CreateMap<SystemParametersDto, SystemParameters>();
            CreateMap<SystemParameters, SystemParametersDto>();
            CreateMap<Region, RegionDto>();
            CreateMap<RegionDto, Region>();
            CreateMap<Branched_enterprise, Branched_EnterpriseDto>();
            CreateMap<Branched_EnterpriseDto, Branched_enterprise>();
            CreateMap<Country, CountryDto>();
            CreateMap<CountryDto, Country>();
            CreateMap<Roles, RolesDto>();
            CreateMap<RolesDto, Roles>();
            CreateMap<Views, ViewsDto>();
            CreateMap<ViewsDto, Views>();
            CreateMap<Catalog, CatalogDto>();
            CreateMap<CatalogDto, Catalog>();
            CreateMap<Blacklist, BlacklistDto>();
            CreateMap<BlacklistDto, Blacklist>();
            CreateMap<Tree, TreeDto>();
            CreateMap<TreeDto, Tree>();
            CreateMap<TableColumn, TableColumnDto>();
            CreateMap<TableColumnDto, TableColumn>();
            CreateMap<CatalogTree, CatalogTreeDto>();
            CreateMap<CatalogTreeDto, CatalogTree>();
            CreateMap<Chanel, ChannelDto>();
            CreateMap<ChannelDto, Chanel>();
            CreateMap<UserView, UserViewDto>();
            CreateMap<UserViewDto, UserView>();
            CreateMap<EnterpriseHierarchyCatalog, EnterpriseHierarchyCatalogDto>();
            CreateMap<EnterpriseHierarchyCatalogDto, EnterpriseHierarchyCatalog>();
            CreateMap<Enterprise, EnterpriseDto>();
            CreateMap<EnterpriseDto, Enterprise>();
            CreateMap<User, UserDto>();
            CreateMap<UserDto, User>();
            CreateMap<PermissionsDto, Permissions>();
            CreateMap<Permissions, PermissionsDto>();
            CreateMap<CardsDto, Cards>();
            CreateMap<Cards, CardsDto>();
            CreateMap<ViewCardDto, ViewCard>();
            CreateMap<ViewCard, ViewCardDto>();
            CreateMap<UserCardGrantedDto, UserCardGranted>();
            CreateMap<UserCardGranted, UserCardGrantedDto>();
            CreateMap<UserCardPermissionDto, UserCardPermission>();
            CreateMap<UserCardPermission, UserCardPermissionDto>();
            CreateMap<Security, SecurityDto>().ReverseMap();
        }
    }
}