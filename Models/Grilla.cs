﻿using System.ComponentModel.DataAnnotations;

namespace WebGrilla.Models
{
    public class Grilla
    {
        [Key]
        public int IdGrilla { get; set; }
        [Required]
        public string Nombre { get; set; }
        //Relaciones
        public ICollection<GrillaTema> GrillaTemas { get; set; }
        public ICollection<ResultadoConocimiento> Resultados { get; set; }
        public ICollection<ConocimientoRecurso> Conocimientos { get; set; }
    }
}
