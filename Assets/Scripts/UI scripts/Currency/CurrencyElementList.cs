using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CurrencyElementList : MonoBehaviour {

    public CurrencyElement prefab; 
    public Transform CurrencyList;

    // Use this for initialization
    void Start () {
        Prime();
	}

    public void Prime ()
    {
        CurrencyRepository repo = GameObject.Find("Scripts").GetComponent<CurrencyRepository>();

        foreach (Transform child in CurrencyList)
        {
            GameObject.Destroy(child.gameObject);
        }

        foreach (Currency currency in repo.Currencies)
        {
            CurrencyElement element = (CurrencyElement)Instantiate(prefab);
            element.PrimeButton(currency);
            element.transform.SetParent(CurrencyList, false);
        }
    }
}
