using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CurrencyDropDown : MonoBehaviour {

    public Dropdown Dropdown;

	// Use this for initialization
	void Start ()
    {
        List<string> dropdownOptions = new List<string>();
        CurrencyRepository repo = GetComponent<CurrencyRepository>();
        foreach (Currency currency in repo.Currencies)
        {
            dropdownOptions.Add(currency.CurrencyCode);
        }
        Dropdown.AddOptions(dropdownOptions);
    }
	
	// Update is called once per frame
	void Update () {
		
	}
}
