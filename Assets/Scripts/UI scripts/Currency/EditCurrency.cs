using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EditCurrency : MonoBehaviour {

    public Text CurrencyNameText;
    public Currency Currency;
    public InputField CurrencyInputField;
    public Button submitButton;

    public void Prime(Currency currency)
    {
        Currency = currency;
        Text code = GameObject.Find("CurrencyCodeTag").GetComponent<Text>();
        InputField rate = GameObject.Find("CurrencyInputField").GetComponent<InputField>();

        code.text = currency.CurrencyCode;
        rate.text = Currency.GetCustomRate(currency.CurrencyCode).ToString();
    }

    public void EditCurrencyRate()
    {

        double rate = 0;
        double.TryParse(CurrencyInputField.text, out rate);
        CurrencyNameText.text = Currency.CurrencyCode;

        Currency.ChangeRate(Currency.CurrencyCode, rate);
        GetComponent<CurrencyElementList>().Prime();
    }

    public void ValidateRate()
    {
        Text InvalidCurrencyRateAnswer = GameObject.Find("InvalidCurrencyRateAnswer").GetComponent<Text>();

        InputField CurrencyInputField = GameObject.Find("CurrencyInputField").GetComponent<InputField>();
        submitButton.interactable = !string.IsNullOrEmpty(CurrencyInputField.text);

        if (string.IsNullOrEmpty(CurrencyInputField.text)) { InvalidCurrencyRateAnswer.text = "Rate cannot be empty"; }
        else { InvalidCurrencyRateAnswer.text = ""; }
    }


}
