using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace _2_DemoController.Models
{
    public class Personne
    {
        public string Nom { get; set; }
        public string Prenom { get; set; }

        public override string ToString()
        {
            return "Nom : " + Nom + " Prenom : " + Prenom;
        }
    }
}