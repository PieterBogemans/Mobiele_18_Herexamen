﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Expense {

    public int ExpenseId { get; set; }
    public string ExpenseName { get; set; }
    public int TripId { get; set; }
    public decimal TotalPrice { get; set; }
    public Person WhoPaid { get; set; }
    public List<ItemToPay> ItemsToPay { get; set; }
    public Currency Currency { get; set; }


    public Expense(string expenseName, Person whoPaid, Trip trip, Currency currency)
    {
        TripId = trip.Id;
        ExpenseName = expenseName;
        WhoPaid = whoPaid;
        ItemsToPay = new List<ItemToPay>();
        Currency = currency;
        TotalPrice = 0;
    }

    public void AddItem(string itemName, decimal price, Person whoConsumedItem)
    {
        ItemToPay item = new ItemToPay(itemName, price, WhoPaid, whoConsumedItem, Currency, this);
        ItemsToPay.Add(item);
    }

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
