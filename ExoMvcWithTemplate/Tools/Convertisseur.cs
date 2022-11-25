using AutoMapper;
using ExoMvcWithTemplate.App_Start;
using ExoMvcWithTemplate.DTOs;
using ExoMvcWithTemplate.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ExoMvcWithTemplate.Tools
{
    public class Convertisseur
    {
        public static UtilisateurDTO UtilisateurDtoFromUtilisateur(UtilisateurDTO userDto,Utilisateur model)
        {
           /* MapperConfiguration config = new MapperConfiguration(cfg =>
            {
                cfg.CreateMap<UtilisateurDTO, Utilisateur>();
                cfg.CreateMap<Utilisateur, UtilisateurDTO>();
            });*/
            IMapper mapper = MapperConfig.Config.CreateMapper();
            userDto = mapper.Map(model, userDto);
            /*userDto.Id = model.Id;
            userDto.UserName = model.UserName;
            userDto.Email= model.Email;
            userDto.Password = model.Password;
            userDto.IsAdmin = model.IsAdmin;
            userDto.Photo = model.Photo;*/
            return userDto;

            
        }

       public static Utilisateur UtilisateurFromUtilisateurDTO(UtilisateurDTO userDto, Utilisateur utilisateur)
        {
           /* MapperConfiguration config = new MapperConfiguration(cfg =>
            {
                cfg.CreateMap<UtilisateurDTO, Utilisateur>();
                cfg.CreateMap<Utilisateur, UtilisateurDTO>();
            });*/
            IMapper mapper = MapperConfig.Config.CreateMapper();
           utilisateur = mapper.Map(userDto,utilisateur);

            /* utilisateur.Id = userDto.Id;
             utilisateur.UserName = userDto.UserName;
             utilisateur.Email = userDto.Email;
             utilisateur.Password = userDto.Password;
             utilisateur.IsAdmin = userDto.IsAdmin;
             utilisateur.Photo = userDto.Photo;
             */
            return utilisateur;
        }
    }
}