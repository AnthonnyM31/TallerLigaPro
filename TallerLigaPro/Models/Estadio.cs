﻿using System.ComponentModel.DataAnnotations;

namespace TallerLigaPro.Models
{
    public class Estadio
    {
        [Key]
        public int Id { get; set; }
        public string Direccion { get; set; }
        public string Ciudad { get; set; }
        public int Capacidad { get; set; }




    }
}
