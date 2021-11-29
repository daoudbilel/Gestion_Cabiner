﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CabinetWebAPI.Model
{
    public class Medcine
    {
        public int id { get; set; }
        [Required]
        public string nom { get; set; }
        [Required]
        public string prenom { get; set; }
        [Required]
        [EmailAddress]
        [Display(Name = "Email")]
        public string Email { get; set; }
        [Required]
        public string Adresse { get; set; }
        [Required]
        public string Telephone { get; set; }
        [DisplayName("Photo de profil")]
        public string photo { get; set; }


        public string UserId { get; set; }
        public virtual ApplicationUser User { get; set; }



        public Patient Patient { get; set; }
        public int Patientid { get; set; }


        public Sexe Sexe { get; set; }
        public int Sexeid { get; set; }

        public Ville Ville { get; set; }
        public int Villeid { get; set; }

        public virtual Specialite Specialite { get; set; }
        public int Specialiteid { get; set; }
    }
}