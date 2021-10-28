using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using Thanh.FinalProject.Areas;
using Thanh.FinalProject.Items;
using Thanh.FinalProject.Shops;
using Thanh.FinalProject.test;

namespace Thanh.FinalProject
{
    public class ApplicationAutoMapperProfile : Profile
    {
        public ApplicationAutoMapperProfile()
        {
            CreateMap<Area, Areas.AreaDto>().ReverseMap();
            CreateMap<Area, CreateUpdateArea>().ReverseMap();
            CreateMap<Shop, Shops.ShopDto>().ReverseMap();
            CreateMap<Shop, CreateUpdateShop>().ReverseMap();
            CreateMap<Item, Items.ItemDto>().ReverseMap();
            CreateMap<Item, CreateUpdateItem>().ReverseMap();

            //CreateMap<bang2, bang2Dto>().ReverseMap();
            //CreateMap<bang2, createupdatebang2Dto>().ReverseMap();
        }
    }
}
