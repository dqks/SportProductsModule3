using System;
using System.Collections.Generic;

namespace SportProducts.Models;

public partial class Product
{
    public int Id { get; set; }

    public string Article { get; set; } = null!;

    public string Name { get; set; } = null!;

    public int IdCategory { get; set; }

    public int IdManufacturer { get; set; }

    public int IdSupplier { get; set; }

    public decimal Price { get; set; }

    public int IdUnitOfMeasurment { get; set; }

    public int Discount { get; set; }

    public int StorageAmount { get; set; }

    public string? Description { get; set; }

    public virtual ProductCategory IdCategoryNavigation { get; set; } = null!;

    public virtual Manufacturer IdManufacturerNavigation { get; set; } = null!;

    public virtual Supplier IdSupplierNavigation { get; set; } = null!;

    public virtual UnitOfMeasurment IdUnitOfMeasurmentNavigation { get; set; } = null!;

    public virtual ICollection<ProductOrder> ProductOrders { get; set; } = new List<ProductOrder>();
}
