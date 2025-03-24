using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace BETL20250324AppWebMVC.Models;

public partial class Product
{
    public int Id { get; set; }

    [Required(ErrorMessage = "El nombre es obligatorio.")]
    [Display(Name = "Nombre")]
    public string ProductName { get; set; } = null!;

    [Display(Name = "Descripcion")]
    public string? Description { get; set; }

    [Display(Name = "Precio")]
    [Required(ErrorMessage = "El precio es obligatorio.")]
    [Range(typeof(decimal), "0.01", "99999999.99", ErrorMessage = "El precio debe estar entre 0.01 y 99999999.99")]
    public decimal Price { get; set; }

    [Display(Name = "Precio compra")]
    [Required(ErrorMessage = "El precio es obligatorio.")]
    [Range(typeof(decimal), "0.01", "99999999.99", ErrorMessage = "El precio debe estar entre 0.01 y 99999999.99")]
    public decimal PurchasePrice { get; set; }

    public int? WarehouseId { get; set; }

    public int? BrandId { get; set; }

    [Display(Name = "notas")]
    public string? Notes { get; set; }

    [Display(Name = "marca")]
    public virtual Brand? Brand { get; set; }

    [Display(Name = "Bodega")]
    public virtual Warehouse? Warehouse { get; set; }
}
