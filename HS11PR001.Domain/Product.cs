using HS11PR001.Domain.Common;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HS11PR001.Domain;

public class Product : BaseEntity
{
    [Required, MaxLength(64)]
    public string Name { get; set; } = default!;
    public double Price { get; set; }
}
