﻿namespace AuctionService.DTOs;

public class AuctionDto
{
  public Guid Id { get; set; }

  public int ReservedPrice { get; set; }

  public string Seller { get; set; }

  public string Winner { get; set; }

  public int SoldAmound { get; set; }

  public int CurrentHighBid { get; set; }

  public DateTime CreateAt { get; set; }

  public DateTime UpdatedAt { get; set; }

  public DateTime AuctionEnd { get; set; }
  public string Status { get; set; }

  public string Make { get; set; }

  public string Model { get; set; }

  public int Year { get; set; }

  public string Color { get; set; }

  public int Mileage { get; set; }

  public string ImageUrl { get; set; }
}
