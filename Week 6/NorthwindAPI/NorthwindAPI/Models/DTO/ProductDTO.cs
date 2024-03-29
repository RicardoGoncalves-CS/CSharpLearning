﻿namespace NorthwindAPI.Models.DTO;

public class ProductDTO
{
    public int ProductId { get; set; }
    public string? ProductName { get; set; }
    public int? SupplierId { get; set; }
    public int? CategoryId { get; set; }
    public decimal? UnitPrice { get; set; }
}