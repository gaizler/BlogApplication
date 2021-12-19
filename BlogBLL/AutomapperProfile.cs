using AutoMapper;
using BlogBLL.Models;
using BlogDAL.Entities;
using System.Linq;

namespace BlogBLL
{
    public class AutomapperProfile : Profile
    {
        public AutomapperProfile()
        {
            CreateMap<Post, PostModel>()
                .ReverseMap();
        }
    }
}