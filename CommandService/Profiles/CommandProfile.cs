using AutoMapper;
using CommandsService.Dtos;
using CommandsService.Models;
using PlatformService;
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
            CreateMap<GrpcPlatformModel, Platform>()
             .ForMember(dest => dest.Id, opt => opt.MapFrom(src => src.PlatformId))
             .ForMember(dest => dest.DogName, opt => opt.MapFrom(src => src.DogName))
             .ForMember(dest => dest.Commands, opt => opt.Ignore());
        }
    }
}