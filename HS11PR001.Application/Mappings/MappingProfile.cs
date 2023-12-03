using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using HS11PR001.Application.Features.Products.Commands.ProductCreate;
using HS11PR001.Application.Features.Products.ViewModels;
using HS11PR001.Domain;
using ProductSystem.Application.Features.Products.Commands.ProductUpdate;

namespace HS11PR001.Application.Mappings;

public class MappingProfile : Profile
{
    public MappingProfile()
    {
        CreateMap<Product, ProductCreateCommand>().ReverseMap();
		CreateMap<Product, ProductUpdateCommand>().ReverseMap();
		CreateMap<Product, ProductVM>().ReverseMap();
    }
}
