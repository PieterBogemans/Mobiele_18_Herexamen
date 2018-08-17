using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CurrencyDropDown : MonoBehaviour {

    public Dropdown Dropdown;
    public Dropdown AddCurrencyToTrip;
    List<string> dropdownOptions = new List<string>();
    public string selectedCurrency;

    // Use this for initialization
    public void Dropdown_IndexChanged(int index)
    {
        selectedCurrency = dropdownOptions[index];
    }

    void Start ()
    {
        CurrencyRepository repo = GetComponent<CurrencyRepository>();
        foreach (Currency currency in repo.Currencies)
        {
            dropdownOptions.Add(currency.CurrencyCode);
        }
        Dropdown.AddOptions(dropdownOptions);
        AddCurrencyToTrip.AddOptions(dropdownOptions);
        selectedCurrency = dropdownOptions[0];
    }
}
