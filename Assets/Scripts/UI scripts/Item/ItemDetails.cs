using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ItemDetails : MonoBehaviour {

    public Text ItemName;
    public Text Price;
    public Text PriceInUSD;
    public Text WhoPaid;
    public Text WhoConsumed;

    public void Setup(ItemToPay item)
    {
        ItemName.text = item.ItemName;
        Price.text = item.Price.ToString();
        PriceInUSD.text = Math.Round(item.PriceInUSD, 3).ToString();
        WhoPaid.text = item.WhoPaid.PersonName;
        WhoConsumed.text = item.WhoConsumedItem.PersonName;
    }
}
