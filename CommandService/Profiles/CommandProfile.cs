using AutoMapper;
using CommandsService.Dtos;
using CommandsService.Models;
using PlatformService.Models;


namespace CommandsService.Profiles
{
    public class CommandsProfile : Profile
    {
        public CommandsProfile()
        {
            // Source -> Target
            CreateMap<Platform, PlatformreadDto>();
            CreateMap<CommandCreateDto, Command>();
            CreateMap<Command, CommandReadDto>();
            CreateMap<PlatformPublishedDto, Platform>()
              .ForMember(dest => dest.Id, opt => opt.MapFrom(src => src.Id));
        }
    }
}