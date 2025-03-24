using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace BETL20250324AppWebMVC.Models;

public partial class Warehouse
{
    public int Id { get; set; }

    [Required(ErrorMessage = "El nombre es obligatorio.")]
    [Display(Name = "nombre")]
    public string WarehouseName { get; set; } = null!;

    [Display(Name = "notas")]
    public string? Notes { get; set; }

    public virtual ICollection<Product> Products { get; set; } = new List<Product>();
}
