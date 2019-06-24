using AutoMapper;
using Training.UserIdentify.WebApi.Dtos;
using Training.UserIdentify.WebApi.Entities;

namespace Training.UserIdentify.WebApi.Helpers
{
    public class AutoMapperProfile : Profile
    {
        public AutoMapperProfile()
        {
            CreateMap<User, UserDto>();
            CreateMap<UserDto, User>();
        }
    }
}
