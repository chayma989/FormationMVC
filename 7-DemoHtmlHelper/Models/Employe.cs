using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace _7_DemoHtmlHelper.Models
{
    public enum EmployeType
    {
        DEBUTANT=1,
        JUNIOR=2,
        SENIOR=3
    }
    public class Employe
    {
        public int Id { get; set; }
        public string Nom { get; set; }
        public double Salaire { get; set; }
        public bool IsActif { get; set; }
        public string Email { get; set; }
        public int DepartementId { get; set; }
        public DateTime DateEntree { get; set; }
        public EmployeType type { get; set; }
    }
}