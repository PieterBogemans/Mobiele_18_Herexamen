using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AddItem : MonoBehaviour {

    public InputField ItemNameText;
    public InputField ItemPriceText;
    public Button submitButton;
    public Text invalidItemName;

    // Use this for initialization
    void Start () {
		
	}

    public void SubmitItem()
    {
        string itemName = ItemNameText.text;
        decimal itemPrice = decimal.Parse(ItemPriceText.text);
        ExpenseDetails details = GetComponent<ExpenseDetails>();

        PeopleDropdown dropdown = GetComponent<PeopleDropdown>();
        string personName = dropdown.selectedPerson;

        PersonRepository repo = GetComponent<PersonRepository>();
        Person person = repo.GetPerson(personName);


        details.AddItem(itemName, itemPrice, person);

        ExpenseElementList expenseList = GetComponent<ExpenseElementList>();
        expenseList.Prime();
    }

    public void ValidateItem()
    {

        Text invalidItemName = GameObject.Find("InvalidItemName").GetComponent<Text>();
        Text invalidItemPrice = GameObject.Find("InvalidItemPrice").GetComponent<Text>();

        InputField itemName = GameObject.Find("ItemNameAnswer").GetComponent<InputField>();
        InputField itemPrice = GameObject.Find("ItemPriceAnswer").GetComponent<InputField>();
        submitButton.interactable = !string.IsNullOrEmpty(itemName.text) && !string.IsNullOrEmpty(itemPrice.text);

        if (string.IsNullOrEmpty(itemName.text)) { invalidItemName.text = "Name cannot be empty"; }
        else { invalidItemName.text = ""; }
        if (string.IsNullOrEmpty(itemPrice.text)) { invalidItemPrice.text = "Price cannot be empty and has to be a decimal (for example: '2.05'"; }
        else { invalidItemPrice.text = ""; }
    }


}
