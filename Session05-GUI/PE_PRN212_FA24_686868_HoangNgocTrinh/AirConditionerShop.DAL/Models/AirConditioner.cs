using System;
using System.Collections.Generic;

namespace AirConditionerShop.DAL.Models;

public partial class AirConditioner
{
    public int AirConditionerId { get; set; }

    public string AirConditionerName { get; set; } = null!;

    public string? Warranty { get; set; }

    public string? SoundPressureLevel { get; set; }

    public string? FeatureFunction { get; set; }

    public int? Quantity { get; set; }

    public double? DollarPrice { get; set; }

    public string? SupplierId { get; set; } //fk trỏ đến bảng supplier
    //cột này là của oop, object này có mqh với object kia
    //supplier là object cụ thể thuộc class supplier company
    public virtual SupplierCompany? Supplier { get; set; }
    //vietsub: 1 máy lạnh cụ thể thì có 1 nhà cung cấp cụ thể nào đó
    //supplier đc gọi là navigation path, con đường dẫn đến cha, object ở table cha
}
