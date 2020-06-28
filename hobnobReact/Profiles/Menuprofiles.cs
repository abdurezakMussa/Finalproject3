using AutoMapper;
using hobnobReact.Dtos;
using hobnobReact.Models;

namespace hobnobReact.Profiles
{
    public class Menuprofiles : Profile
    {
        public Menuprofiles()
        {
            CreateMap<Menu,MenuReadDto>();
            CreateMap<MenuCreateDto, Menu>();
            CreateMap<MenuUpdateDto,Menu>();
            
        }
    }
}
