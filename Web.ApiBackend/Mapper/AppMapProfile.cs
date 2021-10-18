using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Web.ApiBackend.Data.Identity;
using Web.ApiBackend.Models;

namespace Web.ApiBackend.Mapper
{
    public class AppMapProfile : Profile
    {
        public AppMapProfile()
        {
            CreateMap<RegisterViewModel, AppUser>()
                .ForMember(x => x.PhoneNumber, opt => opt.MapFrom(x => x.Phone))
                .ForMember(x => x.Photo, opt => opt.Ignore())
                .ForMember(x => x.UserName, opt => opt.MapFrom(x => x.Email));
            //.ForMember(x => x.Image, opt => opt.MapFrom(x => "images/"
            //    + (string.IsNullOrEmpty(x.Photo) ? "noimage.jpg" : x.Photo)));
        }
    }
}
