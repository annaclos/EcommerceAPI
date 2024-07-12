﻿namespace ecommerceApi.Model;

public class Produto : BaseEntity
{
    public string? Name { get; set; }
    public string? Model { get; set; }
    public string? Brand { get; set; }
    public string? Description { get; set; }
    public decimal? Price { get; set; }
    public string? Image { get; set; }
    public int Amount { get; set; }

}
