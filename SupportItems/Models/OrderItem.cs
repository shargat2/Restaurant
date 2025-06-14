using System;

namespace Restaurant.SupportItems.Models;

public class OrderItem
{
    public required OrderType Type { get; set; }
    public DateTime Time { get; set; }
}
