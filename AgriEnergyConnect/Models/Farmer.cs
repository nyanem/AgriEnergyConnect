using System;
using System.Collections.Generic;

namespace AgriEnergyConnect.Models;

public partial class Farmer
{
    public int FarmerId { get; set; }

    public string FullName { get; set; } = null!;

    public string Email { get; set; } = null!;

    public virtual ICollection<Product> Products { get; set; } = new List<Product>();
}
