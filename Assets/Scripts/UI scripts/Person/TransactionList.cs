using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TransactionList : MonoBehaviour {

    private Person Person;
    public TransactionElement prefab; 
    public Transform transactionList;
    public Currency Currency;

    public void Prime()
    {
        Person = GetComponent<PersonDetails>().MainPerson;
        Currency = GetComponent<PersonDetails>().Currency;
        PersonRepository repo = GetComponent<PersonRepository>();
        foreach (Transform child in transactionList.transform)
        {
            GameObject.Destroy(child.gameObject);
        }
        foreach (Transaction transaction in Person.Transactions)
        {
            TransactionElement element = (TransactionElement)Instantiate(prefab);
            if (Person.Id == transaction.Payer)
            {
                element.Prime(repo.GetPerson(transaction.Payee), -transaction.Amount);
            } else if (Person.Id == transaction.Payee)
            {
                element.Prime(repo.GetPerson(transaction.Payer), transaction.Amount);
            }
            element.transform.SetParent(transactionList, false);
        }
        
    }
}
