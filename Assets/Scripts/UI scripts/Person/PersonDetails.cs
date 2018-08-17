using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PersonDetails : MonoBehaviour {

    public Text PersonName;

    public Person Person;

    public void Setup(Person person)
    {
        Person = person;
        PersonName.text = Person.PersonName;
    }
}
