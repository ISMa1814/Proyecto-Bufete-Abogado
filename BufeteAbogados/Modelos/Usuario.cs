﻿using System.ComponentModel.DataAnnotations;

namespace Modelos;

public class Usuario
{
    [Required(ErrorMessage = "El campo Codigo es obligatorio")]
    public string Codigo { get; set; }
    [Required(ErrorMessage = "El campo Clave es obligatorio")]
    public string Clave { get; set; }
    [Required(ErrorMessage = "El campo Nombre es obligatorio")]
    public string Nombre { get; set; }
    [Required(ErrorMessage = "El campo Apellido es obligatorio")]
    public string Apellido { get; set; }
    public bool EstaActivo { get; set; }
}
