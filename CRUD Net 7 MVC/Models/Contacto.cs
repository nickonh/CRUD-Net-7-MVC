﻿using System.ComponentModel.DataAnnotations;

namespace CRUD_Net_7_MVC.Models
{
    public class Contacto
    {
        [Key]
        public int Id { get; set; }
        [Required(ErrorMessage = "El nombre es obligatorio")]
        public string Nombre { get; set; }
        [Required(ErrorMessage = "El Telefono es obligatorio")]
        public string Telefono { get; set; }
        [Required(ErrorMessage = "El Celular es obligatorio")]
        public string Celular { get; set; }
        [Required(ErrorMessage = "El Email es obligatorio")]
        public string Email { get; set; }
        public DateTime FechaCreacion { get; set; }
    }
}
