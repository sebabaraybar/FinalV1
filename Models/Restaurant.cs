﻿using FinalV1.Models;

namespace FinalV1;

public class Restaurant
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string Address { get; set; }
    public string Phone { get; set; }

    public int MenuId { get; set; }
    public virtual Menu Menu { get; set; }
}
