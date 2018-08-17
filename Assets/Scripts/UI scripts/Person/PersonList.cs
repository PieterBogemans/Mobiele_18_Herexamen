using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PersonList : MonoBehaviour {

    private PersonRepository repo;
    public PersonElement prefab; 
    public Transform personList;

    // Use this for initialization
    void Start () {
        Prime();
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void Prime ()
    {
        repo = GetComponent<PersonRepository>();
        foreach (Transform child in personList.transform)
        {
            GameObject.Destroy(child.gameObject);
        }

        foreach (KeyValuePair<int, Person> person in repo.People)
        {
            PersonElement element = (PersonElement)Instantiate(prefab);
            element.PrimeButton(person.Value);
            element.transform.SetParent(personList, false);
        }
    }
}
