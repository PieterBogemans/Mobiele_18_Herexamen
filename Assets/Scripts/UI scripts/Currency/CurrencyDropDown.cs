using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CurrencyDropDown : MonoBehaviour {

    List<string> dropdownOptions = new List<string>();
    public string selectedCurrency;

    public void Dropdown_IndexChanged(int index)
    {
        selectedCurrency = dropdownOptions[index];
    }

    public void Prime(Dropdown dropdown)
    {
        CurrencyRepository repo = GetComponent<CurrencyRepository>();
        ClearOptions(dropdown);
        foreach (Currency currency in repo.Currencies)
        {
            dropdownOptions.Add(currency.CurrencyCode);
        }
        dropdown.AddOptions(dropdownOptions);
        selectedCurrency = dropdownOptions[0];
    }

    public void PrimeAddCurrencyToTrip(Dropdown dropdown)
    {
        CurrencyRepository repo = GetComponent<CurrencyRepository>();
        TripDetails details = GetComponent<TripDetails>();
        ClearOptions(dropdown);

        foreach (Currency currency in repo.Currencies)
        {
            bool isCurrencyNotYetInTrip = true;
            foreach (Currency currencyInTrip in details.Trip.Currencies)
            {
                if (isCurrencyNotYetInTrip) { isCurrencyNotYetInTrip = currencyInTrip.CurrencyCode != currency.CurrencyCode; }
                else { break; }
            }
            if (isCurrencyNotYetInTrip) { dropdownOptions.Add(currency.CurrencyCode); }
        }
        dropdown.AddOptions(dropdownOptions);
        selectedCurrency = dropdownOptions[0];
    }

    public void PrimeAddCurrencyToExpense(Dropdown dropdown)
    {
        CurrencyRepository repo = GetComponent<CurrencyRepository>();
        TripDetails details = GetComponent<TripDetails>();
        ClearOptions(dropdown);
        foreach (Currency currency in repo.Currencies)
        {
            bool isCurrencyNotYetInTrip = true;
            foreach (Currency currencyInTrip in details.Trip.Currencies)
            {
                if (isCurrencyNotYetInTrip) { isCurrencyNotYetInTrip = currencyInTrip.CurrencyCode != currency.CurrencyCode; }
                else { break; }
            }
            if (!isCurrencyNotYetInTrip) { dropdownOptions.Add(currency.CurrencyCode); }
        }
        dropdown.AddOptions(dropdownOptions);
        if (dropdownOptions.Count != 0) selectedCurrency = dropdownOptions[0];
    }

    private void ClearOptions(Dropdown dropdown)
    {
        dropdownOptions = new List<string>();
        dropdown.options.Clear();
    }
}
