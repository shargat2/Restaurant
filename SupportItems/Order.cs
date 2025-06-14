using Restaurant.SupportItems.Models;
using System;
using System.Collections.Generic;

namespace Restaurant.SupportItems;

public class Order
{
    private List<OrderItem> _items = new List<OrderItem>();

    public void AddItems(OrderType type, int quantity, DateTime time)
    {
        for (int i = 0; i < quantity; i++)
        {
            _items.Add(new OrderItem { Type = type, Time = time });
        }
    }

    public void RemoveItems(OrderType type, int quantity)
    {
        for (int i = 0; i < quantity; i++)
        {
            var item = _items.FindLast(x => x.Type == type);
            if (item != null)
                _items.Remove(item);
        }
    }

    public List<OrderItem> GetItems() => _items;
}
