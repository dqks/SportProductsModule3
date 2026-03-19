using SportProducts.Models;
using System;
using System.Collections.Generic;

namespace SportProducts;

public partial class DeliveryPoint
{
    public int Id { get; set; }

    public string DeliveryName { get; set; } = null!;

    public string Phone { get; set; } = null!;

    public virtual ICollection<Order> Orders { get; set; } = new List<Order>();
}
