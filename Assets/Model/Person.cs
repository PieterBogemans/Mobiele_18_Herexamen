using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Person : MonoBehaviour {

    public int Id { get; set; }
    public string PersonName { get; set; }
    //Negative value == Person owes you
    public Dictionary<int, decimal> OwesPerson { get; set; }
    public List<int> Trips { get; set; }
    public List<Transaction> Transactions { get; set; }


    
    public Person(string Name, int id)
    {
        Id = id;
        OwesPerson = new Dictionary<int, decimal>();
        Trips = new List<int>();
        Transactions = new List<Transaction>();
    }

    public void AddTrip (Trip trip)
    {
        Trips.Add(trip.Id);
    }

    public void UpdateOwesPerson(Person otherParty, decimal amount)
    {
        if (otherParty.Id == this.Id)
        {

        } else if (OwesPerson.ContainsKey(otherParty.Id)) {
            OwesPerson[otherParty.Id] += amount;
        } else
        {
            OwesPerson.Add(otherParty.Id, amount);
        }
    }

    public void AddTransaction(Person paidTo, decimal amount)
    {
        Transaction transaction = new Transaction(this, paidTo, amount);
        Transactions.Add(transaction);
    }

    public Dictionary<int, decimal> GetOwesPersonInCurrency(Currency currency)
    {
        Dictionary<int, decimal> newOwesPerson = new Dictionary<int, decimal>();
        foreach (KeyValuePair<int, decimal> entry in OwesPerson)
        {
            decimal newAmount = currency.GetConversionFrom("USD", entry.Value);
            newOwesPerson.Add(entry.Key, newAmount);
        }
        return newOwesPerson;
    }



	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
