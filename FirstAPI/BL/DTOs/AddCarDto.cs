﻿namespace FirstAPI.BL.DTOs;

public class AddCarDto
{
    public string Name { get; set; } = string.Empty;
    public string Model { get; set; } = string.Empty;
    public string Year { get; set; } = string.Empty;
    public string Color { get; set; } = string.Empty;
    public string Price { get; set; } = string.Empty;
    public string Image { get; set; } = string.Empty;
    public int BrandId { get; set; }
}
