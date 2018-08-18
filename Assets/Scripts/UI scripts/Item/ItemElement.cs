using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ItemElement : MonoBehaviour {

    public Button ItemButton;
    public ItemToPay Item;

	// Use this for initialization
	void Start () {
        if (Item != null) PrimeButton(Item);
	}

    public void PrimeButton(ItemToPay item)
    {
        this.Item = item;

        ItemButton.GetComponentInChildren<Text>().text = Item.ItemName;
        ItemButton.onClick.AddListener(AddButtonOnClick);
    }

    public void AddButtonOnClick()
    {
        GameObject itemDetailsPane = GameObject.Find("ItemDetails");
        itemDetailsPane.transform.SetAsLastSibling();
        GameObject scripts = GameObject.Find("Scripts");
        ItemDetails details = scripts.GetComponent<ItemDetails>();
        details.Setup(Item);
    }
}
