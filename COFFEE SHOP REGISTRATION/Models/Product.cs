﻿using System;
using System.Collections.Generic;

namespace COFFEE_SHOP_REGISTRATION.Models;

public partial class Product
{
    public int Id { get; set; }

    public string? Name { get; set; }

    public string? Description { get; set; }

    public int? Price { get; set; }

    public string? Category { get; set; }
}
