using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeCurrency : MonoBehaviour {


    public void ChangePersonDetailsCurrency()
    {
        CurrencyDropDown dropdown = GameObject.Find("Scripts").GetComponent<CurrencyDropDown>();
        GameObject personDetails = GameObject.Find("PersonDetailsPane");
        personDetails.transform.SetAsLastSibling();

        GameObject scripts = GameObject.Find("Scripts");
        OwesPersonList list = scripts.GetComponent<OwesPersonList>();
        Currency currency = scripts.GetComponent<CurrencyRepository>().GetCurrencyWithName(dropdown.selectedCurrency);
        scripts.GetComponent<PersonDetails>().Currency = currency;
        list.Prime();
    }
}
