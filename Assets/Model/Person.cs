using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Person {

    public int Id { get; set; }
    public string PersonName { get; set; }
    public Dictionary<int, decimal> AmountPaid { get; set; }
    public Dictionary<int, decimal> AmountDue { get; set; }
    public List<int> Trips { get; set; }
    public List<Transaction> Transactions { get; set; }


    
    public Person(string Name, int id)
    {
        Id = id;
        PersonName = Name;
        AmountPaid = new Dictionary<int, decimal>();
        AmountDue = new Dictionary<int, decimal>();
        Trips = new List<int>();
        Transactions = new List<Transaction>();
    }

    public void AddTrip (Trip trip)
    {
        Trips.Add(trip.Id);
    }

    public void AddPaidBy(Person otherParty, decimal amount)
    {
        if (otherParty.Id == this.Id)
        {

        } else if (AmountPaid.ContainsKey(otherParty.Id)) {
            AmountPaid[otherParty.Id] += amount;
        } else
        {
            AmountPaid.Add(otherParty.Id, amount);
        }
    }

    public void AddDueFrom(Person otherParty, decimal amount)
    {
        if (otherParty.Id == this.Id)
        {
        }
        else if (AmountDue.ContainsKey(otherParty.Id))
        {
            AmountDue[otherParty.Id] += amount;
        }
        else
        {
            AmountDue.Add(otherParty.Id, amount);
        }
    }

    public void AddTransaction(Person paidTo, decimal amount, Currency currency)
    {
        decimal convertedAmount = currency.GetConversionFrom("USD", amount);
        Transaction transaction = new Transaction(this, paidTo, convertedAmount);

        paidTo.Transactions.Add(transaction);
        Transactions.Add(transaction);
    }

    public decimal GetAmountPaidInCurrency(Person person, Currency currency)
    {
        return currency.GetPriceFromUSD(GetPaidBy(person));
    }

    public decimal GetAmountDueInCurrency(Person person, Currency currency)
    {
        return currency.GetPriceFromUSD(GetDueFrom(person));
    }

    public decimal GetPaidBy(Person person)
    {
        decimal paid = 0;
        AmountPaid.TryGetValue(person.Id, out paid);
        return paid;
    }

    public decimal GetDueFrom(Person person)
    {
        decimal due = 0;
        AmountDue.TryGetValue(person.Id, out due);
        return due;
    }

    public bool IsOwedOrDue(Person person)
    {
        return GetDueFrom(person) - GetPaidBy(person) != 0;
        
    }
}
