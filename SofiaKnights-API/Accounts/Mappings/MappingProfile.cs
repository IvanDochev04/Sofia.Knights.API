using AutoMapper;
using SofiaKnights_API.Accounts.Entities.DTOs;
using SofiaKnights_API.Accounts.Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SofiaKnights_API.Accounts.Mappings
{
    public class MappingProfile : Profile

    {
        public MappingProfile()
        {
            CreateMap<UserForRegistrationDto, User>()
    .ForMember(u => u.UserName, opt => opt.MapFrom(x => x.Email));
        }
    }
}
