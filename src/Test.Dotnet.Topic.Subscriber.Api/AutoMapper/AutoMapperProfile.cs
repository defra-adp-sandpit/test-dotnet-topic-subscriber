using Test.Dotnet.Topic.Subscriber.Api.Models;
using Test.Dotnet.Topic.Subscriber.Core.Entities;

using AutoMapper;

namespace Test.Dotnet.Topic.Subscriber.Api.AutoMapper;

public class AutoMapperProfile : Profile
{
    public AutoMapperProfile()
    {
        CreateMap<ItemRequest, Item>();
    }
}
