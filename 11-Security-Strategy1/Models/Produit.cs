using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace _11_Security_Strategy1.Models
{
    public class Produit
    {
        public int Id { get; set; }

        [Required]
        [Display(Name ="Détails:")]
        public string Description { get; set; }

        [Display(Name = "Prix HT:")]
        public double Prix { get; set; }
    }
}