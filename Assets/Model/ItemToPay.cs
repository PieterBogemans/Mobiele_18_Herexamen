﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemToPay {

    public string ItemName { get; set; }
    public decimal Price { get; set; }
    public decimal PriceInUSD { get; set; }
    public Currency currency { get; set; }
    public Person WhoPaid { get; set; }
    public Person WhoConsumedItem { get; set; }

    public ItemToPay(string name, decimal price, Person whoPaid, Person whoConsumedItem, Currency currency, Expense expense)
    {
        ItemName = name;

        Price = price;
        expense.TotalPrice += Price;
        PriceInUSD = currency.GetConversionFrom("USD", price);

        whoConsumedItem.AddPaidBy(whoPaid, PriceInUSD);
        whoPaid.AddDueFrom(whoConsumedItem, PriceInUSD);

        WhoPaid = whoPaid;
        WhoConsumedItem = whoConsumedItem;
    }
}
