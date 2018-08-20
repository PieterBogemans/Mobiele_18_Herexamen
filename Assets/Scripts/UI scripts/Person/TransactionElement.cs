using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TransactionElement : MonoBehaviour {

    public Text PersonName;
    public Text PaidReceived;
    public Image prPanel;
    
    public void Prime(Person person, decimal paidReceived)
    {
        PersonDetails details = GameObject.Find("Scripts").GetComponent<PersonDetails>();
        PersonName.text = person.PersonName;
        if (paidReceived > 0)
        {
            PaidReceived.text = paidReceived.ToString();
            prPanel.GetComponent<Image>().color = Color.green;
        }
        else
        {

            PaidReceived.text = (-paidReceived).ToString();
            prPanel.GetComponent<Image>().color = Color.red;
        }
    }
}
