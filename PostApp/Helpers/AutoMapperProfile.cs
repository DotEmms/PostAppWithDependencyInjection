using AutoMapper;
using PostApp.Entities;
using PostApp.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PostApp.Helpers
{
    public class AutoMapperProfile : Profile
    {
        public AutoMapperProfile()
        {
            CreateMap<Post, PostDTO>()
                .ForMember(dest => dest.CountryOfCreation, opt => opt.MapFrom(src => src.CountryCreatedIn))
                .ForMember(dest => dest.PostedBy, opt => opt.MapFrom(src => src.Name))
                .ForMember(dest => dest.CreationTime, opt => opt.MapFrom(src => src.CreatedAt.CalculateCreation()));
        }
        
    }
}
