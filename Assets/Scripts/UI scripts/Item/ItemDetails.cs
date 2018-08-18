using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ItemDetails : MonoBehaviour {

    public ItemToPay Item;
    public Text ItemName;
    public Text Price;
    public Text PriceInUSD;
    public Text WhoPaid;
    public Text WhoConsumed;

    public void Setup(ItemToPay item)
    {
        Item = item;
        ItemName.text = item.ItemName;
        Price.text = item.Price.ToString();
        PriceInUSD.text = Math.Round(item.PriceInUSD, 3).ToString();
        WhoPaid.text = item.WhoPaid.PersonName;
        WhoConsumed.text = item.WhoConsumedItem.PersonName;
    }

    public void AddCopy()
    {
        GameObject addItemPanel = GameObject.Find("AddItemToExpensePanel");
        addItemPanel.transform.SetAsLastSibling();

        InputField ItemNameAnswer = GameObject.Find("ItemNameAnswer").GetComponent<InputField>();
        InputField ItemPriceAnswer = GameObject.Find("ItemPriceAnswer").GetComponent<InputField>();
        ItemNameAnswer.text = Item.ItemName;
        ItemPriceAnswer.text = Item.Price.ToString();

        Dropdown personDropdown = GameObject.Find("WhoConsumedAnswer").GetComponent<Dropdown>();
        GameObject.Find("Scripts").GetComponent<PeopleDropdown>().PrimeAddPersonToItem(personDropdown);
    }
}
