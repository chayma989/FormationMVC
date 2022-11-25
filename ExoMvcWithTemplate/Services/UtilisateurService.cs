using ExoMvcWithTemplate.DTOs;
using ExoMvcWithTemplate.Models;
using ExoMvcWithTemplate.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ExoMvcWithTemplate.Services
{
    public class UtilisateurService
    {
        private UtilisateurRepository utilRep =new UtilisateurRepository();
        public UtilisateurDTO FindUserByUserNameAndPassword(LoginDTO loginDTO)
        {
            UtilisateurDTO userDto = utilRep.FindUserByUserNameAndPassword(loginDTO);
            return userDto;
        }

        public void Add(UtilisateurDTO userDto)
        {
            utilRep.Add(userDto);
        }

        public List<UtilisateurDTO> GetAllUser()
        {
            return utilRep.GetAllUser();
        }
    }
}