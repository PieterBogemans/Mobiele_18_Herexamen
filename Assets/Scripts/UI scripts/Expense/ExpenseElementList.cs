using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExpenseElementList : MonoBehaviour {

    public ExpenseElement prefab; 
    public Transform ExpenseList;

    // Use this for initialization
    void Start () {
        Prime();
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void Prime ()
    {
        TripDetails details = GetComponent<TripDetails>();

        foreach (Transform child in ExpenseList.transform)
        {
            GameObject.Destroy(child.gameObject);
        }
        if (details.Trip != null)
        {
            foreach (Expense expense in details.Trip.Expenses)
            {
                ExpenseElement element = (ExpenseElement)Instantiate(prefab);
                element.PrimeButton(expense);
                element.transform.SetParent(ExpenseList, false);
            }
        } 
    }
}
