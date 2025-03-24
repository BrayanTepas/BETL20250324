using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace BETL20250324AppWebMVC.Models;

public partial class User
{
    public int Id { get; set; }

    [Display(Name = "nombre")]
    [Required(ErrorMessage = "El nombre es obligatorio.")]
    public string Username { get; set; } = null!;

    [Display(Name = "email")]
    [Required(ErrorMessage = "El email es obligatorio.")]
    [EmailAddress(ErrorMessage = "El correo electrónico no tiene un formato válido.")]
    public string Email { get; set; } = null!;

    [Display(Name = "contraseña")]
    [Required(ErrorMessage = "El contraseña es obligatorio.")]
    [DataType(DataType.Password)]
    [StringLength(32, MinimumLength = 5, ErrorMessage = "El passowrd debe tener entre 5 y 32 caracteres.")]
    public string Password { get; set; } = null!;

    [Required(ErrorMessage = "El rol es obligatorio.")]
    [Display(Name = "rol")]
    public string Role { get; set; } = null!;

    [Display(Name = "notas")]
    public string? Notes { get; set; }
}
