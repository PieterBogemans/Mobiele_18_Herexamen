using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Trip : MonoBehaviour {

    public int Id { get; set; }
    public string LocationName { get; set; }
    public Dictionary<int, Person> PeopleOnTrip { get; set; }
    public List<Expense> Expenses { get; set; }

    public Currency DefaultCurrency { get; set; }
    public List<Currency> Currencies { get; set; }

    public Trip(string  name, int id, Currency defaultCurrency)
    {
        Id = id;
        LocationName = name;
        PeopleOnTrip = new Dictionary<int, Person>();
        Expenses = new List<Expense>();
        DefaultCurrency = defaultCurrency;
        Currencies = new List<Currency>()
        {
            DefaultCurrency
        };
    }

    public void AddPersonToTrip(Person person)
    {
        person.AddTrip(this);
        PeopleOnTrip.Add(person.Id, person);
    }

    public void AddExpenseToTrip(Expense expense)
    {
        Expenses.Add(expense);
    }

    public void AddCurrencyToTrip(Currency currency)
    {
        Currencies.Add(currency);
    }


    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
