using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace _8_DemoFormValidation.Models
{
    public class Employe
    {
        [Required]
        [Display(Name ="User Name")]
        public string UserName { get; set; }

        [Required(ErrorMessage ="Mot de passe obligatoire")]
        [DataType(DataType.Password)]
        public string Password { get; set; }

        [Required(ErrorMessage = "Date naissance obligatoire")]
        [DataType(DataType.Date)]
        public DateTime DateNaissance { get; set; }

        [Required(ErrorMessage = "Email obligatoire")]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }

        [Required(ErrorMessage = "Valeur obligatoire compris entre 1 et 10")]
        [Range(1,10)]
        public int Evaluation { get; set; }

        [Required]
        [DataType(DataType.MultilineText)]
        public string Commentaire { get; set; }

        [FileExtensions(Extensions ="png,jpg,jpeg")]
        public string Photo { get; set; }
    }
}