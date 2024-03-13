﻿using AutoMapper;
using Kunigi.Entities;
using Kunigi.ViewModels.Game;
using Kunigi.ViewModels.Team;

namespace Kunigi.Utilities;

public class AutoMapperProfiles : Profile
{
    public AutoMapperProfiles()
    {
        CreateMap<Team, TeamDetailsViewModel>();
        CreateMap<Team, TeamEditViewModel>();
        
        CreateMap<Game, GameDetailsViewModel>();
    }
}