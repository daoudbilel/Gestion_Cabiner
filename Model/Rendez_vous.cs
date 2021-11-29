﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CabinetWebAPI.Model
{
    public class Rendez_vous
    {

        public int Id { get; set; }
        public string Prenom { get; set; }
        public string CNE { get; set; }
        public string Message { get; set; }
        public DateTime Date { get; set; }
        public int Medcineid { get; set; }
        public string UserId { get; set; }
        public virtual Medcine Medcine { get; set; }

        public virtual ApplicationUser user { get; set; }

    }
}