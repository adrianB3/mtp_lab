using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace lab5_webapp.Models
{
    public class Carte
    {
        public int CarteId { get; set; }
        public string Titlu { get; set; }
        public string Autor { get; set; }
        public string Editura { get; set; }
        [Range(1900, 2018), Display(Name = "Anul Aparitiei")]
        public int AnAparitie { get; set; }
    }
}