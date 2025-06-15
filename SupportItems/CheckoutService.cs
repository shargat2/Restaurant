using Restaurant.SupportItems.Models;
using System;

namespace Restaurant.SupportItems;

public class CheckoutService
{
    private readonly decimal StarterPrice = 4.00m;
    private readonly decimal MainPrice = 7.00m;
    private readonly decimal DrinkPrice = 2.50m;
    private readonly decimal DrinkDiscount = 0.30m;
    private readonly TimeSpan DiscountCutoff = new(19, 0, 0);

    public decimal CalculateBill(Order order)
    {
        decimal subtotal = 0;

        foreach (var item in order.GetItems())
        {
            switch (item.Type)
            {
                case OrderType.Starter:
                    subtotal += StarterPrice;
                    break;
                case OrderType.Main:
                    subtotal += MainPrice;
                    break;
                case OrderType.Drink:
                    bool discounted = item.Time.TimeOfDay < DiscountCutoff; //assume that at 19:00 or later, drinks are not discounted
                    subtotal += DrinkPrice * (discounted ? 1 - DrinkDiscount : 1);
                    break;
            }
        }

        decimal foodTotal = 0;
        foreach (var item in order.GetItems())// assuming food items are only starters and mains
        {
            if (item.Type == OrderType.Starter) foodTotal += StarterPrice;
            if (item.Type == OrderType.Main) foodTotal += MainPrice;
        }

        decimal serviceCharge = foodTotal * 0.10m;

        return Math.Round(subtotal + serviceCharge, 2);
    }
}
