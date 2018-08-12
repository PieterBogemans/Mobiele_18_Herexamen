using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Transaction : MonoBehaviour {

    public int Payer { get; set; }
    public int Payee { get; set; }
    public decimal Amount { get; set; }

    public Transaction(Person payer, Person payee, decimal amount)
    {
        payer.UpdateOwesPerson(payee, -amount); 
        payee.UpdateOwesPerson(payer, amount);

        Payer = payer.Id;
        Payee = payee.Id;
    }


	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
