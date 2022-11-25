using AutoMapper;
using ExoMvcWithTemplate.DTOs;
using ExoMvcWithTemplate.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ExoMvcWithTemplate.App_Start
{
    public class MapperConfig
    {
        public static MapperConfiguration Config { get; set; }
        public static MapperConfiguration Configure()
        {
            Config = new MapperConfiguration(cfg =>
            {
                cfg.CreateMap<UtilisateurDTO, Utilisateur>();
                cfg.CreateMap<Utilisateur, UtilisateurDTO>();
            });
            return Config;
        }
    }
}