using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemToPay : MonoBehaviour {

    public string ItemName { get; set; }
    public decimal PriceInUSD { get; set; }
    public Expense OriginalExpense { get; set; }
    public Person WhoPaid { get; set; }
    public Person WhoConsumedItem { get; set; }

    public ItemToPay(string name, decimal price, Person whoPaid, Person whoConsumedItem, Currency currency)
    {
        ItemName = name;

        PriceInUSD = currency.GetConversionFrom("USD", price);

        whoPaid.UpdateOwesPerson(whoConsumedItem, -PriceInUSD);
        whoConsumedItem.UpdateOwesPerson(whoPaid, PriceInUSD);

        WhoPaid = whoPaid;
        WhoConsumedItem = whoConsumedItem;
    }



	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
