using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace ProductAPI.Models;

[Table("products")]
public partial class Product
{
    [Key]
    [Column("id")]
    public int Id { get; set; }

    [Column("name")]
    [StringLength(255)]
    [Unicode(false)]
    public string Name { get; set; } = null!;

    [Column("description", TypeName = "text")]
    public string Description { get; set; } = null!;

    [Column("price", TypeName = "decimal(10, 2)")]
    public decimal Price { get; set; }

    [Column("image_name")]
    [StringLength(255)]
    [Unicode(false)]
    public string ImageName { get; set; } = null!;
}
