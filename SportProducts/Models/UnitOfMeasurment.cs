using System;
using System.Collections.Generic;

namespace SportProducts.Models;

public partial class UnitOfMeasurment
{
    public int Id { get; set; }

    public string UnitName { get; set; } = null!;

    public virtual ICollection<Product> Products { get; set; } = new List<Product>();
}
