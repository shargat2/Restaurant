using Restaurant.SupportItems.Models;
using System;

namespace Restaurant.SupportItems;

public class CheckoutService
{
    private readonly decimal StarterPrice = 4.00m;
    private readonly decimal MainPrice = 7.00m;
    private readonly decimal DrinkPrice = 2.50m;
    private readonly decimal DrinkDiscount = 0.30m;
    private readonly TimeSpan DiscountCutoff = new TimeSpan(19, 0, 0);

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
                    bool discounted = item.Time.TimeOfDay < DiscountCutoff;
                    subtotal += DrinkPrice * (discounted ? 1 - DrinkDiscount : 1);
                    break;
            }
        }

        decimal foodTotal = 0;
        foreach (var item in order.GetItems())
        {
            if (item.Type == OrderType.Starter) foodTotal += StarterPrice;
            if (item.Type == OrderType.Main) foodTotal += MainPrice;
        }

        decimal serviceCharge = foodTotal * 0.10m;

        return Math.Round(subtotal + serviceCharge, 2);
    }
}
