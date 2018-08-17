using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PersonElement : MonoBehaviour {

    public Button PersonButton;
    public Person Person;

	// Use this for initialization
	void Start () {
        if (Person != null) PrimeButton(Person);
	}

    public void PrimeButton(Person person)
    {
        this.Person = person;

        PersonButton.GetComponentInChildren<Text>().text = Person.PersonName;
        PersonButton.onClick.AddListener(AddButtonOnClick);
    }

    public void AddButtonOnClick()
    {
        //PeoplePane.transform.SetAsLastSibling();
        GameObject Scripts = GameObject.Find("Scripts");
        PersonDetails details = Scripts.GetComponent<PersonDetails>();
        details.Setup(Person);
    }
}
