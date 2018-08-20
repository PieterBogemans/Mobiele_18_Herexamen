using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AddTransaction : MonoBehaviour {

    public void AddTransactionToPerson()
    {
        InputField field = GameObject.Find("TransactionPriceAnswer").GetComponent<InputField>();
        OwesPersonList list = GameObject.Find("Scripts").GetComponent<OwesPersonList>();
        PersonDetails details = GameObject.Find("Scripts").GetComponent<PersonDetails>();

        details.MainPerson.AddTransaction(details.ListPerson, decimal.Parse(field.text), list.Currency);
        list.Prime();
    }

    public void AddTransactionValidation()
    {
        InputField field = GameObject.Find("TransactionPriceAnswer").GetComponent<InputField>();
        Button submitButton = GameObject.Find("SubmitTransactionButton").GetComponent<Button>();
        Text invalidAnswerText = GameObject.Find("InvalidTransactionAnswer").GetComponent<Text>();
        submitButton.interactable = !string.IsNullOrEmpty(field.text);
        if (string.IsNullOrEmpty(name))
        {
            invalidAnswerText.text = "Amount cannot be empty";
        }
        else
        {
            invalidAnswerText.text = "";
        }
    }
}
