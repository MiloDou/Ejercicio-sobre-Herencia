﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System;

public class Producto
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string Description { get; set; }

    public Producto(int id, string name, string description)
    {
        Id = id;
        Name = name;
        Description = description;
    }
}
