using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CurrencyElement : MonoBehaviour {

    public Button currencyButton;
    public Text Text;

    public Currency Currency;

    public void PrimeButton(Currency currency)
    {
        Currency = currency;
        Text.text = currency.CurrencyCode;
        currencyButton.onClick.AddListener(AddButtonOnClick);
    }

    public void PrimeButtonInTrip(Currency currency)
    {
        Currency = currency;
        currencyButton.GetComponentInChildren<Text>().text = currency.CurrencyCode;
        currencyButton.onClick.AddListener(AddButtonOnClick);
    }

    public void AddButtonOnClick()
    {
        GameObject currencies = GameObject.Find("Currencies");
        GameObject editCurrencies = GameObject.Find("EditCurrency");
        currencies.transform.SetAsLastSibling();
        editCurrencies.transform.SetAsLastSibling();

        GameObject scripts = GameObject.Find("Scripts");
        EditCurrency editCurrency = scripts.GetComponent<EditCurrency>();
        editCurrency.Prime(Currency);
    }
}
