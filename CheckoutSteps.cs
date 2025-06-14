using Restaurant.SupportItems;
using Restaurant.SupportItems.Models;
using System;
using System.Collections.Generic;
using TechTalk.SpecFlow;
using Xunit;

namespace Restaurant;

[Binding]
public class CheckoutSteps
{
    private Order _order = new Order();
    private CheckoutService _checkoutService = new CheckoutService();
    private decimal _finalBill;
    private List<decimal> _intermediateBills = new List<decimal>();

    [Given(@"a group of (.*) orders (.*) starters, (.*) mains and (.*) drinks at (.*)")]
    public void GivenAGroupOfOrdersStarterMainsAndDrinksAt(int people, int starters, int mains, int drinks, string time)
    {
        var orderTime = DateTime.Parse(time);
        _order.AddItems(OrderType.Starter, starters, orderTime);
        _order.AddItems(OrderType.Main, mains, orderTime);
        _order.AddItems(OrderType.Drink, drinks, orderTime);
    }

    [Then(@"later at (.*) (.*) more join and order (.*) mains and (.*) drinks")]
    public void LaterJoinAndOrder(string time, int people, int mains, int drinks)
    {
        var orderTime = DateTime.Parse(time);
        _order.AddItems(OrderType.Main, mains, orderTime);
        _order.AddItems(OrderType.Drink, drinks, orderTime);
    }

    [Then(@"one member cancels their order")]
    public void GivenOneMemberCancelsTheirOrder()
    {
        _order.RemoveItems(OrderType.Starter, 1);
        _order.RemoveItems(OrderType.Main, 1);
        _order.RemoveItems(OrderType.Drink, 1);
    }

    [When(@"the intermediate bill is requested")]
    public void WhenTheIntermediateBillIsRequested()
    {
        var bill = _checkoutService.CalculateBill(_order);
        _intermediateBills.Add(bill);
    }

    [Then(@"the intermediate bill at step (.*) should be (.*)")]
    public void ThenTheIntermediateBillAtStepShouldBe(int step, decimal expectedBill)
    {
        Assert.True(step > 0 && step <= _intermediateBills.Count, $"Step {step} is out of range.");
        Assert.Equal(expectedBill, _intermediateBills[step - 1]);
    }

    [When(@"the bill is requested")]
    [When(@"the final bill is requested")]
    public void WhenTheBillIsRequested()
    {
        _finalBill = _checkoutService.CalculateBill(_order);
    }

    [Then(@"the total bill should be (.*)")]
    public void ThenTheTotalBillShouldBe(decimal expectedBill)
    {
        Assert.Equal(expectedBill, _finalBill);
    }
}
