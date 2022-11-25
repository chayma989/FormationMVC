using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace _11_Security_Strategy1.Models
{
    public class Utilisateur
    {
        public int UtilisateurId { get; set; }

        [Required]
        [EmailAddress]
        public string Email  { get; set; }

        [Required]
        [DataType(DataType.Password)]
        public string Password { get; set; }
        public bool Admin { get; set; }

    }
}