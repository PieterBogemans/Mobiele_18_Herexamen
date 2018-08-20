using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PersonDetails : MonoBehaviour {


    public Person MainPerson;
    public Person ListPerson;
    private Currency currency;
    public Currency Currency {
        get { return currency; }
        set
        {
            GameObject.Find("CurrentCurrency").GetComponent<Text>().text = value.CurrencyCode;
            currency = value;
        }
    }
    
    public void Setup(Person person)
    {
        MainPerson = person;
        Currency = GameObject.Find("Scripts").GetComponent<CurrencyRepository>().GetCurrencyWithName("USD");
    }
}
