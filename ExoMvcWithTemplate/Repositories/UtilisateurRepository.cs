using ExoMvcWithTemplate.DTOs;
using ExoMvcWithTemplate.Models;
using ExoMvcWithTemplate.Tools;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ExoMvcWithTemplate.Repositories
{
    public class UtilisateurRepository
    {
        public UtilisateurDTO FindUserByUserNameAndPassword(LoginDTO loginDTO)
        {
            UtilisateurDTO userDto = new UtilisateurDTO();

            using (var context=new MyContext())
            {
                Utilisateur model= 
                context.Utilisateurs.FirstOrDefault(u => u.UserName.Equals(loginDTO.UserName) && 
                u.Password.Equals(loginDTO.Password));
               userDto= Convertisseur.UtilisateurDtoFromUtilisateur(userDto, model);
            }
            return userDto;
        }

        internal void Add(UtilisateurDTO userDto)
        {
            Utilisateur u = Convertisseur.UtilisateurFromUtilisateurDTO(userDto, new Utilisateur());
            using (var context = new MyContext())
            {
                context.Utilisateurs.Add(u);
                context.SaveChanges();
            }
        }

        public List<UtilisateurDTO> GetAllUser()
        {
            List<UtilisateurDTO> lstDTO = new List<UtilisateurDTO>();
            using (var context = new MyContext())
            {
                List<Utilisateur> lstModel = context.Utilisateurs.ToList();
                foreach (var model in lstModel)
                {
                    lstDTO.Add(Convertisseur.UtilisateurDtoFromUtilisateur(new UtilisateurDTO(), model));
                }
            }


            return lstDTO;

        }
    }
}