﻿namespace HISApp.DTOs;

public class CardsDto
{
    public string Id { set; get; }
    //public required byte[] Img { get; set; }
    public required string Name { get; set; }
    public required string Description { get; set; }
}