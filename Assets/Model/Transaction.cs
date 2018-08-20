using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Transaction {

    public int Payer { get; set; }
    public int Payee { get; set; }
    public decimal Amount { get; set; }

    public Transaction(Person paidTo, Person payee, decimal amount)
    {
        paidTo.AddDueFrom(payee, amount); 
        payee.AddPaidBy(paidTo, amount);

        Payer = paidTo.Id;
        Payee = payee.Id;
        Amount = amount;
    }
}
